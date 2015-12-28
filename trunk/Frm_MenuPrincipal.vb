Public Class Frm_MenuPrincipal
    Dim ingreso_sistema
    Dim nivel_usuario As Integer

    Dim menustrip As New MenuStrip
    Dim Item, InnerItem, subInnerItem As New ToolStripMenuItem

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Frm_MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ingreso_sistema = 0
    End Sub

    Private Sub ABMCuentasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ABMCuentas As New ABM_PlanCuentas
        ABMCuentas.MdiParent = Me
        ABMCuentas.Show()
    End Sub

    Private Sub Txt_Clave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Clave.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim sql As New MySQL
            Dim Dt As System.Data.DataTable
            Dt = sql.LEER("SELECT * FROM usuarios where login = '" & Txt_Usuario.Text & "' AND password = '" & Txt_Clave.Text & "'")

            nivel_usuario = Dt.Rows(0).Item("id_nivel")

            If Dt.Rows.Count = 0 Then
                MsgBox("El usuario y/o contraseña son incorrectos. VERIFIQUE")
                ingreso_sistema = ingreso_sistema + 1
                If ingreso_sistema > 3 Then
                    Me.Close()
                End If
            Else
                Grb_Login.Visible = False

                Dt = sql.LEER("SELECT * FROM MENUES m where m.id_nivel_acceso >= " & nivel_usuario & " order by  m.id_menu_padre, m.id_nivel_menu ")

                For I As Integer = 0 To Dt.Rows.Count - 1
                    If Dt.Rows.Count <> 0 Then
                        If Dt.Rows(I).Item("id_nivel_menu") = 0 Then
                            crear_menu_dinamico(1, Dt.Rows(I).Item("nombre_menu"), "")
                        End If

                        If Dt.Rows(I).Item("id_nivel_menu") = 1 Then
                            crear_menu_dinamico(2, Dt.Rows(I).Item("nombre_menu"), Dt.Rows(I).Item("form"))
                        End If

                        If Dt.Rows(I).Item("id_nivel_menu") = 2 Then
                            crear_menu_dinamico(3, Dt.Rows(I).Item("nombre_menu"), Dt.Rows(I).Item("form"))
                        End If
                    End If
                Next I

                Me.Controls.Add(menustrip)
                Me.MainMenuStrip = menustrip
            End If

        End If

    End Sub

    Private Sub crear_menu_dinamico(ByVal nivel As Integer, ByVal texto As String, ByVal referencia As String)
        Select Case nivel
            Case 1
                Item = New ToolStripMenuItem()
                Item.Text = texto
                Item.Tag = referencia
                menustrip.Items.Add(Item)
                AddHandler Item.Click, AddressOf nivel_click
            Case 2
                inneritem = New ToolStripMenuItem()
                inneritem.text = texto
                inneritem.tag = referencia
                Item.DropDownItems.Add(InnerItem)
                AddHandler InnerItem.Click, AddressOf nivel_click
            Case 3
                subInnerItem = New ToolStripMenuItem()
                subInnerItem.Text = texto
                subInnerItem.Tag = referencia
                InnerItem.DropDownItems.Add(subInnerItem)
                AddHandler subInnerItem.Click, AddressOf nivel_click
        End Select
    End Sub


    Private Sub nivel_click(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.tag <> "" Then
            Dim form As String = sender.tag
            Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
            Dim strformname = "tecnicas." & Form
            Dim frm As Form = CType(asm.CreateInstance(strformname), Form)
            frm.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Libro_Mayor.ShowDialog()
    End Sub
End Class
