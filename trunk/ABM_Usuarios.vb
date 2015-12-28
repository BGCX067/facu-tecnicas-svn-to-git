Public Class ABM_Usuarios

    Dim sa As Boolean = False
    Dim modificar As Boolean

    Public sql As New MySQL

    Private Sub Cargar_combo(ByVal Combo As System.Object, ByVal Texto As String, ByVal Clave As String)
        Combo.Items.Add(New MiComboBox(Texto, Clave))
    End Sub

    Private Sub ABM_Usuarios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If sa = False Then
            sa = True
            empezar()
        End If
    End Sub


    'Private Sub ABM_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    empezar()
    'End Sub

    Private Sub empezar()
        Dim Dt, Dt1 As System.Data.DataTable
        cboxNivelAcceso.Items.Clear()
        btNuevo.Enabled = True
        btModificar.Enabled = True
        bteliminar.Enabled = True
        btAceptar.Enabled = False
        btCancelar.Enabled = False
        PEdicion.Visible = False
        DataGridView1.Enabled = True
        txtApellido.Clear()
        txtLogin.Clear()
        txtNombre.Clear()
        txtPass.Clear()
        cboxNivelAcceso.Text = ""





        Dt1 = sql.LEER("SELECT * FROM Usuarios u Inner Join niveles_acceso na on (u.id_nivel = na.id_nivel_acceso)")
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(Dt1.Rows.Count)
        For i As Integer = 0 To Dt1.Rows.Count - 1
            DataGridView1.Item(0, i).Value = Dt1.Rows(i).Item("apellido")
            DataGridView1.Item(1, i).Value = Dt1.Rows(i).Item("nombre")
            DataGridView1.Item(2, i).Value = Dt1.Rows(i).Item("login")
            DataGridView1.Item(3, i).Value = Dt1.Rows(i).Item("password")
            DataGridView1.Item(4, i).Value = Dt1.Rows(i).Item("nivel_acceso")
            DataGridView1.Item(5, i).Value = Dt1.Rows(i).Item("Id_nivel_acceso")
            DataGridView1.Item(6, i).Value = Dt1.Rows(i).Item("Id_Usuario")
        Next
        Dt = sql.LEER("SELECT * FROM niveles_acceso")
        For I As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count <> 0 Then
                Cargar_combo(cboxNivelAcceso, Dt.Rows(I).Item("Nivel_acceso").ToString(), Dt.Rows(I).Item("id_nivel_acceso").ToString())
                'cboxNivelAcceso.Items.Add(Dt.Rows(I).Item("nivel_acceso"))
                'cboxNivelAcceso.ValueMember = Dt.Rows(I).Item("id_nivel_acceso")
            End If
        Next I
        DataGridView1.Rows(0).Selected = True
        DataGridView1.Focus()
    End Sub

    Private Sub btAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAceptar.Click
        Dim nivel As Integer
        nivel = cboxNivelAcceso.Items(cboxNivelAcceso.SelectedIndex).ItemData()
        If modificar = True Then
            sql.INSERT_UPDATE_DELETE("Update usuarios SET apellido='" & (txtApellido.Text) & "', nombre='" & (txtNombre.Text) & "', login='" & (txtLogin.Text) & "', password ='" & (txtPass.Text) & "',id_nivel='" & (nivel) & "' WHERE Id_usuario = " & (DataGridView1.CurrentRow.Cells.Item(6).Value) & "")
            MsgBox("los datos se modificaron correctamente")
        Else
            PEdicion.Visible = True
            sql.INSERT_UPDATE_DELETE("Insert into usuarios(apellido,nombre,login,password,id_nivel) values('" & (txtApellido.Text) & "','" & (txtNombre.Text) & "','" & (txtLogin.Text) & "','" & (txtPass.Text) & "','" & (nivel) & "')")
            MsgBox("Los Datos se cargaron con exito")
        End If
        empezar()
        btSalir.Enabled = True
        modificar = False
    End Sub

    Private Sub btNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevo.Click
        btNuevo.Enabled = False
        btModificar.Enabled = False
        bteliminar.Enabled = False
        btSalir.Enabled = False
        btAceptar.Enabled = True
        btCancelar.Enabled = True
        DataGridView1.Enabled = False
        PEdicion.Visible = True
        txtApellido.Focus()



    End Sub

    Private Sub btbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt As System.Data.DataTable
        Dim y As Integer

        Dt = sql.LEER("SELECT u.*, na.nivel_acceso FROM usuarios u left join niveles_acceso na on (u.id_nivel = na.id_nivel_acceso) where apellido = '" & txtApellido.Text & "' ")

        For I As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count <> 0 Then
                DataGridView1.Rows.Add(1)
                y = DataGridView1.Rows.Count - 2
                DataGridView1.Item(0, y).Value = Dt.Rows(I).Item("apellido")
                DataGridView1.Item(1, y).Value = Dt.Rows(I).Item("nombre")
                DataGridView1.Item(2, y).Value = Dt.Rows(I).Item("login")
                DataGridView1.Item(3, y).Value = Dt.Rows(I).Item("password")
                DataGridView1.Item(4, y).Value = Dt.Rows(I).Item("nivel_acceso")
            End If
        Next I
    End Sub

    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btModificar.Click
        btNuevo.Enabled = False
        btModificar.Enabled = False
        bteliminar.Enabled = False
        btSalir.Enabled = False
        btAceptar.Enabled = True
        btCancelar.Enabled = True
        DataGridView1.Enabled = False
        PEdicion.Visible = True

        txtApellido.Text = DataGridView1.CurrentRow.Cells.Item(0).Value
        txtNombre.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
        txtLogin.Text = DataGridView1.CurrentRow.Cells.Item(2).Value
        txtPass.Text = DataGridView1.CurrentRow.Cells.Item(3).Value
        cboxNivelAcceso.SelectedIndex = DataGridView1.CurrentRow.Cells.Item(5).Value - 1
        modificar = True
    End Sub

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        DataGridView1.Enabled = True
        PEdicion.Visible = False
        btNuevo.Enabled = True
        btModificar.Enabled = True
        bteliminar.Enabled = True
        btAceptar.Enabled = False
        btCancelar.Enabled = False
        btSalir.Enabled = True
        empezar()

    End Sub

    Private Sub bteliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteliminar.Click
        Dim id As Integer
        Dim response As MsgBoxResult

        response = MsgBox("desea eliminar el registro seleccionado?", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then
            id = DataGridView1.CurrentRow.Cells.Item(6).Value
            sql.INSERT_UPDATE_DELETE("Delete From usuarios WHERE Id_usuario= " & id & "")
            empezar()
        End If

    End Sub
End Class