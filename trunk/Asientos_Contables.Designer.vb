<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asientos_Contables
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
        Me.PDetalle = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtHaber = New System.Windows.Forms.TextBox
        Me.txtDebe = New System.Windows.Forms.TextBox
        Me.CBoxCuentas = New System.Windows.Forms.ComboBox
        Me.DTPFechaAsiento = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.PBotones = New System.Windows.Forms.Panel
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtGuardar = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.PContenedor = New System.Windows.Forms.Panel
        Me.PDatos = New System.Windows.Forms.Panel
        Me.lblDatos = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.id_plan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Clave_contable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Debe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Haber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GboxMotivo = New System.Windows.Forms.GroupBox
        Me.TxtMotivo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnQuitar = New System.Windows.Forms.Button
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.PDetalle.SuspendLayout()
        Me.PBotones.SuspendLayout()
        Me.PContenedor.SuspendLayout()
        Me.PDatos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxMotivo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PDetalle
        '
        Me.PDetalle.Controls.Add(Me.GroupBox1)
        Me.PDetalle.Controls.Add(Me.Label4)
        Me.PDetalle.Controls.Add(Me.Label3)
        Me.PDetalle.Controls.Add(Me.Label2)
        Me.PDetalle.Controls.Add(Me.txtHaber)
        Me.PDetalle.Controls.Add(Me.txtDebe)
        Me.PDetalle.Controls.Add(Me.CBoxCuentas)
        Me.PDetalle.Controls.Add(Me.DTPFechaAsiento)
        Me.PDetalle.Controls.Add(Me.Label1)
        Me.PDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PDetalle.Enabled = False
        Me.PDetalle.Location = New System.Drawing.Point(0, 0)
        Me.PDetalle.Name = "PDetalle"
        Me.PDetalle.Size = New System.Drawing.Size(596, 128)
        Me.PDetalle.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Haber"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Debe"
        '
        'txtHaber
        '
        Me.txtHaber.Location = New System.Drawing.Point(436, 58)
        Me.txtHaber.Name = "txtHaber"
        Me.txtHaber.Size = New System.Drawing.Size(100, 20)
        Me.txtHaber.TabIndex = 5
        '
        'txtDebe
        '
        Me.txtDebe.Location = New System.Drawing.Point(261, 58)
        Me.txtDebe.Name = "txtDebe"
        Me.txtDebe.Size = New System.Drawing.Size(100, 20)
        Me.txtDebe.TabIndex = 4
        '
        'CBoxCuentas
        '
        Me.CBoxCuentas.FormattingEnabled = True
        Me.CBoxCuentas.Location = New System.Drawing.Point(261, 24)
        Me.CBoxCuentas.Name = "CBoxCuentas"
        Me.CBoxCuentas.Size = New System.Drawing.Size(275, 21)
        Me.CBoxCuentas.TabIndex = 3
        '
        'DTPFechaAsiento
        '
        Me.DTPFechaAsiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaAsiento.Location = New System.Drawing.Point(15, 25)
        Me.DTPFechaAsiento.Name = "DTPFechaAsiento"
        Me.DTPFechaAsiento.Size = New System.Drawing.Size(85, 20)
        Me.DTPFechaAsiento.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'PBotones
        '
        Me.PBotones.Controls.Add(Me.BtnSalir)
        Me.PBotones.Controls.Add(Me.BtnCancelar)
        Me.PBotones.Controls.Add(Me.BtGuardar)
        Me.PBotones.Controls.Add(Me.BtnNuevo)
        Me.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PBotones.Location = New System.Drawing.Point(0, 481)
        Me.PBotones.Name = "PBotones"
        Me.PBotones.Size = New System.Drawing.Size(596, 36)
        Me.PBotones.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(518, 10)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Location = New System.Drawing.Point(335, 9)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtGuardar
        '
        Me.BtGuardar.Enabled = False
        Me.BtGuardar.Location = New System.Drawing.Point(244, 9)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtGuardar.TabIndex = 1
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 9)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'PContenedor
        '
        Me.PContenedor.Controls.Add(Me.PDatos)
        Me.PContenedor.Controls.Add(Me.DataGridView1)
        Me.PContenedor.Controls.Add(Me.GboxMotivo)
        Me.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PContenedor.Location = New System.Drawing.Point(0, 128)
        Me.PContenedor.Name = "PContenedor"
        Me.PContenedor.Size = New System.Drawing.Size(596, 353)
        Me.PContenedor.TabIndex = 2
        '
        'PDatos
        '
        Me.PDatos.Controls.Add(Me.lblDatos)
        Me.PDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PDatos.Location = New System.Drawing.Point(0, 237)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(596, 19)
        Me.PDatos.TabIndex = 3
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.Location = New System.Drawing.Point(0, 3)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(48, 13)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "Datos:"
        Me.lblDatos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_plan, Me.Clave_contable, Me.Descripcion, Me.Debe, Me.Haber})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(596, 256)
        Me.DataGridView1.TabIndex = 2
        '
        'id_plan
        '
        Me.id_plan.HeaderText = "ID PLAN"
        Me.id_plan.Name = "id_plan"
        Me.id_plan.ReadOnly = True
        Me.id_plan.Width = 50
        '
        'Clave_contable
        '
        Me.Clave_contable.HeaderText = "CLAVE CONTABLE"
        Me.Clave_contable.Name = "Clave_contable"
        Me.Clave_contable.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "NOMBRE CUENTA"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
        '
        'Debe
        '
        Me.Debe.HeaderText = "DEBE"
        Me.Debe.Name = "Debe"
        Me.Debe.ReadOnly = True
        '
        'Haber
        '
        Me.Haber.HeaderText = "HABER"
        Me.Haber.Name = "Haber"
        Me.Haber.ReadOnly = True
        '
        'GboxMotivo
        '
        Me.GboxMotivo.Controls.Add(Me.TxtMotivo)
        Me.GboxMotivo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GboxMotivo.Location = New System.Drawing.Point(0, 256)
        Me.GboxMotivo.Name = "GboxMotivo"
        Me.GboxMotivo.Size = New System.Drawing.Size(596, 97)
        Me.GboxMotivo.TabIndex = 1
        Me.GboxMotivo.TabStop = False
        Me.GboxMotivo.Text = "Motivo del Asiento contable"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtMotivo.Enabled = False
        Me.TxtMotivo.Location = New System.Drawing.Point(3, 16)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(590, 78)
        Me.TxtMotivo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Seleccione una cuenta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnQuitar)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 46)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar o Quitar Cuenta"
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Location = New System.Drawing.Point(509, 17)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuitar.TabIndex = 10
        Me.BtnQuitar.Text = "Quitar"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(428, 17)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 9
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Asientos_Contables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 517)
        Me.Controls.Add(Me.PContenedor)
        Me.Controls.Add(Me.PBotones)
        Me.Controls.Add(Me.PDetalle)
        Me.Name = "Asientos_Contables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asientos Contables"
        Me.PDetalle.ResumeLayout(False)
        Me.PDetalle.PerformLayout()
        Me.PBotones.ResumeLayout(False)
        Me.PContenedor.ResumeLayout(False)
        Me.PDatos.ResumeLayout(False)
        Me.PDatos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxMotivo.ResumeLayout(False)
        Me.GboxMotivo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PDetalle As System.Windows.Forms.Panel
    Friend WithEvents PBotones As System.Windows.Forms.Panel
    Friend WithEvents PContenedor As System.Windows.Forms.Panel
    Friend WithEvents GboxMotivo As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents DTPFechaAsiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBoxCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHaber As System.Windows.Forms.TextBox
    Friend WithEvents txtDebe As System.Windows.Forms.TextBox
    Friend WithEvents id_plan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clave_contable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDatos As System.Windows.Forms.Panel
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
End Class
