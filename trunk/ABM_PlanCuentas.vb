Public Class ABM_PlanCuentas
    Dim codigo1
    Dim codigo2
    Dim codigo3
    Dim codigo4
    Dim codigo5

    Dim Dt As System.Data.DataTable
    Dim sql As New MySQL

    Dim Modificando As Integer


    'COMO CARGAR EL COMBO
    Private Sub Cargar_combo(ByVal Combo As System.Object, ByVal Texto As String, ByVal Clave As String)
        Combo.Items.Add(New MiComboBox(Texto, Clave))
    End Sub

    Private Sub AltaCuenta(ByVal clave_contable As String, ByVal tipo_clave As Integer)
        btagregar.Enabled = True
        btcancelar.Enabled = True
        btbaja.Enabled = False
        btmodificar.Enabled = False


        TxtDescripcion.Enabled = True
        txtClaveContable.Enabled = True
        CboxInflacion.Enabled = True

        TxtDescripcion.Focus()

        If tipo_clave = 1 Then
            clave_contable = Format(Val(clave_contable) + 1, "0")

            txtClaveContableNueva.Text = clave_contable + "-00-000-000-000"
        End If

        If tipo_clave = 2 Then
            clave_contable = Format(Val(clave_contable) + 1, "00")

            txtClaveContableNueva.Text = txtClaveContable.Text + "-" + clave_contable + "-000-000-000"
        End If

        If tipo_clave = 3 Then
            clave_contable = Format(Val(clave_contable) + 1, "000")

            txtClaveContableNueva.Text = txtClaveContable.Text + "-" + clave_contable + "-000-000"
        End If

        If tipo_clave = 4 Then
            clave_contable = Format(Val(clave_contable) + 1, "000")

            txtClaveContableNueva.Text = txtClaveContable.Text + "-" + clave_contable + "-000"
        End If

        If tipo_clave = 5 Then
            clave_contable = Format(Val(clave_contable) + 1, "000")

            txtClaveContableNueva.Text = txtClaveContable.Text + "-" + clave_contable
        End If

    End Sub

    Private Sub ABM_Cuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Modificando = 0
        codigo1 = "0"

        Dt = sql.LEER("SELECT left(pc.clave_contable, 1) AS Clave, Descripcion FROM plan_cuentas AS pc WHERE (pc.baja <> 'S') AND left(pc.clave_contable, 1) > '0' AND mid(pc.clave_contable, 2,15) = '-00-000-000-000'")
        CmbN1.Items.Clear()
        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CmbN1, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Clave").ToString())

                If Dt.Rows(i).Item("Clave").ToString() > codigo1 Then
                    codigo1 = Dt.Rows(i).Item("Clave").ToString()
                End If
            End If
        Next i
        CmbN1.Text = "Elija un item"
        BtNuevoN1.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbaja.Click

        If CmbN1.Text = "Elija un item" Then
            Exit Sub
        End If

        If CmbN2.Text = "Elija un item" Then
            txtClaveContable.Text = txtClaveContable.Text + "-00-000-000-000"
        End If

        If CmbN3.Text = "Elija un item" Then
            txtClaveContable.Text = txtClaveContable.Text + "-000-000-000"
        End If

        If CmbN4.Text = "Elija un item" Then
            txtClaveContable.Text = txtClaveContable.Text + "-000-000"
        End If

        If CmbN5.Text = "Elija un item" Then
            txtClaveContable.Text = txtClaveContable.Text + "-000"
        End If


        sql.INSERT_UPDATE_DELETE("UPDATE plan_cuentas pc set pc.baja = 'S'where pc.clave_contable = '" & txtClaveContable.Text & "'")

        MsgBox("La Cuenta ha sido dada de baja")

        CmbN1.Items.Clear()
        CmbN2.Items.Clear()
        CmbN2.Text = ""
        CmbN3.Items.Clear()
        CmbN3.Text = ""
        CmbN4.Items.Clear()
        CmbN4.Text = ""
        CmbN5.Items.Clear()
        CmbN5.Text = ""

        BtNuevoN1.Visible = False
        BtNuevoN2.Visible = False
        BtNuevoN3.Visible = False
        BtNuevoN4.Visible = False
        BtNuevoN5.Visible = False
        CmbN1.Focus()

        codigo1 = "0"

        Dt = sql.LEER("SELECT left(pc.clave_contable, 1) AS Clave, Descripcion FROM plan_cuentas AS pc WHERE left(pc.clave_contable, 1) > '0' AND mid(pc.clave_contable, 2,15) = '-00-000-000-000'")
        CmbN1.Items.Clear()
        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CmbN1, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Clave").ToString())

                If Dt.Rows(i).Item("Clave").ToString() > codigo1 Then
                    codigo1 = Dt.Rows(i).Item("Clave").ToString()
                End If
            End If
        Next i
        CmbN1.Text = "Elija un item"
        BtNuevoN1.Visible = True
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmodificar.Click
        If CmbN1.Text = "Elija un item" Then
            Exit Sub
        End If

        If CmbN2.Text = "Elija un item" Then
            txtClaveContable.Text = txtClaveContable.Text + "-00-000-000-000"
        End If

        If CmbN3.Text = "Elija un item" Then
            txtClaveContable.Text = txtClaveContable.Text + "-000-000-000"
        End If

        If CmbN4.Text = "Elija un item" Then
            txtClaveContable.Text = txtClaveContable.Text + "-000-000"
        End If

        If CmbN5.Text = "Elija un item" Then
            txtClaveContable.Text = txtClaveContable.Text + "-000"
        End If

        TxtDescripcion.Enabled = True
        txtClaveContable.Enabled = True
        CboxInflacion.Enabled = True
        CBoxImputable.Enabled = True

        TxtDescripcion.Focus()

        Dt = sql.LEER("SELECT pc.Descripcion, pc.Ajuste_Inflacion, pc.clave_contable FROM plan_cuentas AS pc where pc.clave_contable = '" & txtClaveContable.Text & "'")


        If Dt.Rows(0).Item("Ajuste_Inflacion").ToString() = "S" Then
            CboxInflacion.Text = "Si"
        Else
            CboxInflacion.Text = "No"
        End If

        TxtDescripcion.Text = Dt.Rows(0).Item("Descripcion").ToString()


        Modificando = 1
        btagregar.Enabled = True
        btcancelar.Enabled = True
        btbaja.Enabled = False
        btmodificar.Enabled = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub CmbN1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbN1.SelectedIndexChanged
        Dt = sql.LEER("SELECT mid(pc.clave_contable, 3,2) AS Clave, Descripcion FROM plan_cuentas AS pc WHERE (pc.baja <> 'S') AND left(pc.clave_contable, 1) = '" & CmbN1.Items(CmbN1.SelectedIndex).ItemData() & "' AND mid(pc.clave_contable, 3,2) <> '00' AND mid(pc.clave_contable, 5, 12) = '-000-000-000'")
        CmbN2.Items.Clear()
        CmbN3.Items.Clear()
        CmbN3.Text = ""
        CmbN4.Items.Clear()
        CmbN4.Text = ""
        CmbN5.Items.Clear()
        CmbN5.Text = ""

        codigo2 = "00"

        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CmbN2, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Clave").ToString())

                If Dt.Rows(i).Item("Clave").ToString() > codigo2 Then
                    codigo2 = Dt.Rows(i).Item("Clave").ToString()
                End If
            End If
        Next i
        CmbN2.Text = "Elija un item"

        txtClaveContable.Text = CmbN1.Items(CmbN1.SelectedIndex).ItemData()
        BtNuevoN2.Visible = True

    End Sub

    Private Sub CmbN1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN1.SelectedValueChanged
        If (CmbN1.Text = "Elija un item") Then
            BtNuevoN1.Visible = True
        Else
            BtNuevoN1.Visible = False
        End If
    End Sub

    Private Sub CmbN1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN1.TabIndexChanged

    End Sub

    Private Sub CmbN1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN1.TextChanged

    End Sub

    Private Sub CmbN2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbN2.SelectedIndexChanged
        Dt = sql.LEER("SELECT mid(pc.clave_contable, 6,3) AS Clave, Descripcion FROM plan_cuentas AS pc WHERE (pc.baja <> 'S') AND mid(pc.clave_contable, 3, 2) = '" & CmbN2.Items(CmbN2.SelectedIndex).ItemData() & "' AND mid(pc.clave_contable, 6,3) <> '000' AND mid(pc.clave_contable, 9, 8) = '-000-000'")
        CmbN3.Items.Clear()
        CmbN3.Text = ""
        CmbN4.Items.Clear()
        CmbN4.Text = ""
        CmbN5.Items.Clear()
        CmbN5.Text = ""

        codigo3 = "000"

        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CmbN3, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Clave").ToString())

                If Dt.Rows(i).Item("Clave").ToString() > codigo3 Then
                    codigo3 = Dt.Rows(i).Item("Clave").ToString()
                End If

            End If
        Next i
        CmbN3.Text = "Elija un item"

        txtClaveContable.Clear()
        txtClaveContable.Text = CmbN1.Items(CmbN1.SelectedIndex).ItemData() + "-" + CmbN2.Items(CmbN2.SelectedIndex).ItemData()
        BtNuevoN3.Visible = True
    End Sub

    Private Sub CmbN2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN2.SelectedValueChanged
        If (CmbN2.Text = "Elija un item") Then
            BtNuevoN2.Visible = True
        Else
            BtNuevoN2.Visible = False
        End If
    End Sub

    Private Sub CmbN2_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN2.TabIndexChanged

    End Sub

    Private Sub CmbN3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbN3.SelectedIndexChanged
        Dt = sql.LEER("SELECT mid(pc.clave_contable, 10,3) AS Clave, Descripcion FROM plan_cuentas AS pc WHERE (pc.baja <> 'S') AND mid(pc.clave_contable, 6, 3) = '" & CmbN3.Items(CmbN3.SelectedIndex).ItemData() & "' AND mid(pc.clave_contable, 10,3) <> '000' AND mid(pc.clave_contable, 13, 4) = '-000'")
        CmbN4.Items.Clear()
        CmbN4.Text = ""
        CmbN5.Items.Clear()
        CmbN5.Text = ""


        codigo4 = "000"

        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CmbN4, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Clave").ToString())

                If Dt.Rows(i).Item("Clave").ToString() > codigo4 Then
                    codigo4 = Dt.Rows(i).Item("Clave").ToString()
                End If

            End If
        Next i
        CmbN4.Text = "Elija un item"

        txtClaveContable.Clear()
        txtClaveContable.Text = CmbN1.Items(CmbN1.SelectedIndex).ItemData() + "-" + CmbN2.Items(CmbN2.SelectedIndex).ItemData() + "-" + CmbN3.Items(CmbN3.SelectedIndex).ItemData()
        BtNuevoN4.Visible = True
    End Sub

    Private Sub CmbN3_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN3.SelectedValueChanged
        If (CmbN3.Text = "Elija un item") Then
            BtNuevoN3.Visible = True
        Else
            BtNuevoN3.Visible = False
        End If
    End Sub

    Private Sub CmbN3_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN3.TabIndexChanged

    End Sub

    Private Sub CmbN4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbN4.SelectedIndexChanged
        codigo5 = "000"

        Dt = sql.LEER("SELECT mid(pc.clave_contable, 14,3) AS Clave, Descripcion FROM plan_cuentas AS pc WHERE (pc.baja <> 'S') AND mid(pc.clave_contable, 10, 3) = '" & CmbN4.Items(CmbN4.SelectedIndex).ItemData() & "' AND mid(pc.clave_contable, 14,3) <> '000'")
        CmbN5.Items.Clear()
        CmbN5.Text = ""
        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CmbN5, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Clave").ToString())

                If Dt.Rows(i).Item("Clave").ToString() > codigo5 Then
                    codigo5 = Dt.Rows(i).Item("Clave").ToString()
                End If
            End If
        Next i
        CmbN5.Text = "Elija un item"

        txtClaveContable.Clear()
        txtClaveContable.Text = CmbN1.Items(CmbN1.SelectedIndex).ItemData() + "-" + CmbN2.Items(CmbN2.SelectedIndex).ItemData() + "-" + CmbN3.Items(CmbN3.SelectedIndex).ItemData() + "-" + CmbN4.Items(CmbN4.SelectedIndex).ItemData()
        BtNuevoN5.Visible = True
    End Sub

    Private Sub CmbN4_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN4.SelectedValueChanged
        If (CmbN4.Text = "Elija un item") Then
            BtNuevoN4.Visible = True
        Else
            BtNuevoN4.Visible = False
        End If
    End Sub

    Private Sub CmbN4_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN4.TabIndexChanged

    End Sub

    Private Sub CmbN5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbN5.SelectedIndexChanged
        txtClaveContable.Clear()
        txtClaveContable.Text = CmbN1.Items(CmbN1.SelectedIndex).ItemData() + "-" + CmbN2.Items(CmbN2.SelectedIndex).ItemData() + "-" + CmbN3.Items(CmbN3.SelectedIndex).ItemData() + "-" + CmbN4.Items(CmbN4.SelectedIndex).ItemData() + "-" + CmbN5.Items(CmbN5.SelectedIndex).ItemData()
    End Sub

    Private Sub CmbN5_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN5.SelectedValueChanged
        If (CmbN5.Text = "Elija un item") Then
            BtNuevoN5.Visible = True
        Else
            BtNuevoN5.Visible = False
        End If
    End Sub

    Private Sub CmbN5_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbN5.TabIndexChanged
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub BtNuevoN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevoN1.Click
        AltaCuenta(codigo1, 1)
    End Sub

    Private Sub Button2_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btmodificar.TabIndexChanged

    End Sub

    Private Sub BtNuevoN3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevoN3.Click
        AltaCuenta(codigo3, 3)
    End Sub

    Private Sub BtNuevoN2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevoN2.Click
        AltaCuenta(codigo2, 2)
    End Sub

    Private Sub BtNuevoN4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevoN4.Click
        AltaCuenta(codigo4, 4)
    End Sub

    Private Sub BtNuevoN5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevoN5.Click
        AltaCuenta(codigo5, 5)
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btagregar.Click
        Dim Inflacion As String
        Dim imputable As String

        If CBoxImputable.Text = "Si" Then
            imputable = "S"
        Else
            imputable = "N"
        End If

        If CboxInflacion.Text = "Si" Then
            Inflacion = "S"
        Else
            Inflacion = "N"
        End If

        If Modificando = 0 Then
            sql.INSERT_UPDATE_DELETE("Insert into plan_cuentas(Clave_Contable, Descripcion, Ajuste_Inflacion, Baja, Imputable) values('" & txtClaveContableNueva.Text & "','" & TxtDescripcion.Text & "', '" & Inflacion & "','N', '" & imputable & "')")
        Else
            sql.INSERT_UPDATE_DELETE("UPDATE plan_cuentas pc set pc.Descripcion ='" & TxtDescripcion.Text & "', pc.ajuste_inflacion = '" & Inflacion & "' where pc.clave_contable = '" & txtClaveContable.Text & "'")
        End If

        Modificando = 0
        MsgBox("Los Datos se Guardaron con exito")

        TxtDescripcion.Clear()
        txtClaveContable.Clear()
        txtClaveContableNueva.Clear()

        TxtDescripcion.Enabled = False
        txtClaveContable.Enabled = False
        txtClaveContableNueva.Enabled = False
        CboxInflacion.Enabled = False
        CBoxImputable.Enabled = False


        CmbN1.Items.Clear()
        CmbN2.Items.Clear()
        CmbN2.Text = ""
        CmbN3.Items.Clear()
        CmbN3.Text = ""
        CmbN4.Items.Clear()
        CmbN4.Text = ""
        CmbN5.Items.Clear()
        CmbN5.Text = ""

        BtNuevoN1.Visible = False
        BtNuevoN2.Visible = False
        BtNuevoN3.Visible = False
        BtNuevoN4.Visible = False
        BtNuevoN5.Visible = False
        CmbN1.Focus()

        codigo1 = "0"

        Dt = sql.LEER("SELECT left(pc.clave_contable, 1) AS Clave, Descripcion FROM plan_cuentas AS pc WHERE left(pc.clave_contable, 1) > '0' AND mid(pc.clave_contable, 2,15) = '-00-000-000-000'")
        CmbN1.Items.Clear()
        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CmbN1, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Clave").ToString())

                If Dt.Rows(i).Item("Clave").ToString() > codigo1 Then
                    codigo1 = Dt.Rows(i).Item("Clave").ToString()
                End If
            End If
        Next i
        CmbN1.Text = "Elija un item"
        BtNuevoN1.Visible = True


        btagregar.Enabled = False
        btcancelar.Enabled = False
        btbaja.Enabled = True
        btmodificar.Enabled = True
    End Sub

    Private Sub btcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancelar.Click
        Modificando = 0

        TxtDescripcion.Clear()
        txtClaveContable.Clear()
        txtClaveContableNueva.Clear()

        TxtDescripcion.Enabled = False
        txtClaveContable.Enabled = False
        txtClaveContableNueva.Enabled = False
        CboxInflacion.Enabled = False
        CBoxImputable.Enabled = False


        CmbN1.Items.Clear()
        CmbN2.Items.Clear()
        CmbN2.Text = ""
        CmbN3.Items.Clear()
        CmbN3.Text = ""
        CmbN4.Items.Clear()
        CmbN4.Text = ""
        CmbN5.Items.Clear()
        CmbN5.Text = ""

        BtNuevoN1.Visible = False
        BtNuevoN2.Visible = False
        BtNuevoN3.Visible = False
        BtNuevoN4.Visible = False
        BtNuevoN5.Visible = False

        CmbN1.Focus()

        codigo1 = "0"

        Dt = sql.LEER("SELECT left(pc.clave_contable, 1) AS Clave, Descripcion FROM plan_cuentas AS pc WHERE left(pc.clave_contable, 1) > '0' AND mid(pc.clave_contable, 2,15) = '-00-000-000-000'")
        CmbN1.Items.Clear()
        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CmbN1, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Clave").ToString())

                If Dt.Rows(i).Item("Clave").ToString() > codigo1 Then
                    codigo1 = Dt.Rows(i).Item("Clave").ToString()
                End If
            End If
        Next i
        CmbN1.Text = "Elija un item"
        BtNuevoN1.Visible = True

        btagregar.Enabled = False
        btcancelar.Enabled = False
        btbaja.Enabled = True
        btmodificar.Enabled = True

    End Sub
End Class