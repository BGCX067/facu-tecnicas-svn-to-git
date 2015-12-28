<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btSalir = New System.Windows.Forms.Button
        Me.bteliminar = New System.Windows.Forms.Button
        Me.btModificar = New System.Windows.Forms.Button
        Me.btNuevo = New System.Windows.Forms.Button
        Me.btCancelar = New System.Windows.Forms.Button
        Me.btAceptar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PEdicion = New System.Windows.Forms.Panel
        Me.cboxNivelAcceso = New System.Windows.Forms.ComboBox
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pass = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nivel_acceso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_nivel_accesso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PEdicion.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btSalir)
        Me.Panel2.Controls.Add(Me.bteliminar)
        Me.Panel2.Controls.Add(Me.btModificar)
        Me.Panel2.Controls.Add(Me.btNuevo)
        Me.Panel2.Controls.Add(Me.btCancelar)
        Me.Panel2.Controls.Add(Me.btAceptar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(765, 53)
        Me.Panel2.TabIndex = 34
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(684, 18)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(75, 23)
        Me.btSalir.TabIndex = 8
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'bteliminar
        '
        Me.bteliminar.Location = New System.Drawing.Point(182, 18)
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.Size = New System.Drawing.Size(75, 23)
        Me.bteliminar.TabIndex = 7
        Me.bteliminar.Text = "Eliminar"
        Me.bteliminar.UseVisualStyleBackColor = True
        '
        'btModificar
        '
        Me.btModificar.Location = New System.Drawing.Point(101, 18)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(75, 23)
        Me.btModificar.TabIndex = 6
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btNuevo
        '
        Me.btNuevo.Location = New System.Drawing.Point(20, 18)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btNuevo.TabIndex = 5
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.Location = New System.Drawing.Point(603, 18)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 3
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(522, 18)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 2
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PEdicion)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 298)
        Me.Panel1.TabIndex = 35
        '
        'PEdicion
        '
        Me.PEdicion.Controls.Add(Me.cboxNivelAcceso)
        Me.PEdicion.Controls.Add(Me.txtPass)
        Me.PEdicion.Controls.Add(Me.txtLogin)
        Me.PEdicion.Controls.Add(Me.txtNombre)
        Me.PEdicion.Controls.Add(Me.txtApellido)
        Me.PEdicion.Controls.Add(Me.Label5)
        Me.PEdicion.Controls.Add(Me.Label4)
        Me.PEdicion.Controls.Add(Me.Label3)
        Me.PEdicion.Controls.Add(Me.Label2)
        Me.PEdicion.Controls.Add(Me.Label1)
        Me.PEdicion.Location = New System.Drawing.Point(3, 208)
        Me.PEdicion.Name = "PEdicion"
        Me.PEdicion.Size = New System.Drawing.Size(756, 72)
        Me.PEdicion.TabIndex = 35
        Me.PEdicion.Visible = False
        '
        'cboxNivelAcceso
        '
        Me.cboxNivelAcceso.FormattingEnabled = True
        Me.cboxNivelAcceso.Location = New System.Drawing.Point(590, 8)
        Me.cboxNivelAcceso.Name = "cboxNivelAcceso"
        Me.cboxNivelAcceso.Size = New System.Drawing.Size(152, 21)
        Me.cboxNivelAcceso.TabIndex = 21
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(311, 35)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(182, 20)
        Me.txtPass.TabIndex = 20
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(64, 35)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(182, 20)
        Me.txtLogin.TabIndex = 19
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(311, 9)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 20)
        Me.txtNombre.TabIndex = 18
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(64, 9)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(182, 20)
        Me.txtApellido.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(499, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nivel de Acceso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Pass"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Apellido"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.Login, Me.Pass, Me.nivel_acceso, Me.id_nivel_accesso, Me.Id_usuario})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(762, 202)
        Me.DataGridView1.TabIndex = 34
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Login
        '
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.ReadOnly = True
        '
        'Pass
        '
        Me.Pass.HeaderText = "Pass"
        Me.Pass.Name = "Pass"
        Me.Pass.ReadOnly = True
        '
        'nivel_acceso
        '
        Me.nivel_acceso.HeaderText = "Nivel Acceso"
        Me.nivel_acceso.Name = "nivel_acceso"
        Me.nivel_acceso.ReadOnly = True
        '
        'id_nivel_accesso
        '
        Me.id_nivel_accesso.HeaderText = "id_nivel"
        Me.id_nivel_accesso.Name = "id_nivel_accesso"
        Me.id_nivel_accesso.ReadOnly = True
        Me.id_nivel_accesso.Visible = False
        '
        'Id_usuario
        '
        Me.Id_usuario.HeaderText = "Id_Usuario"
        Me.Id_usuario.Name = "Id_usuario"
        Me.Id_usuario.ReadOnly = True
        Me.Id_usuario.Visible = False
        '
        'ABM_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btCancelar
        Me.ClientSize = New System.Drawing.Size(765, 351)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ABM_Usuarios"
        Me.Text = "ABM Usuarios"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PEdicion.ResumeLayout(False)
        Me.PEdicion.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PEdicion As System.Windows.Forms.Panel
    Friend WithEvents cboxNivelAcceso As System.Windows.Forms.ComboBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bteliminar As System.Windows.Forms.Button
    Friend WithEvents btModificar As System.Windows.Forms.Button
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nivel_acceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_nivel_accesso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
