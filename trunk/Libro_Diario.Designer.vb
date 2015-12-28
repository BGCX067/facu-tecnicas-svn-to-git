<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libro_Diario
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
        Me.PDatos = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtfechaHasta = New System.Windows.Forms.MaskedTextBox
        Me.txtfechaDesde = New System.Windows.Forms.MaskedTextBox
        Me.btBuscar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtMotivo = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btImprimir = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LFechaAsiento = New System.Windows.Forms.Label
        Me.lblDatos = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.id_plan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Clave_contable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Debe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Haber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MOTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PDatos
        '
        Me.PDatos.Controls.Add(Me.Label2)
        Me.PDatos.Controls.Add(Me.Label1)
        Me.PDatos.Controls.Add(Me.txtfechaHasta)
        Me.PDatos.Controls.Add(Me.txtfechaDesde)
        Me.PDatos.Controls.Add(Me.btBuscar)
        Me.PDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PDatos.Location = New System.Drawing.Point(0, 0)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(857, 42)
        Me.PDatos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Desde"
        '
        'txtfechaHasta
        '
        Me.txtfechaHasta.Location = New System.Drawing.Point(306, 12)
        Me.txtfechaHasta.Mask = "0000/00/00"
        Me.txtfechaHasta.Name = "txtfechaHasta"
        Me.txtfechaHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtfechaHasta.TabIndex = 2
        '
        'txtfechaDesde
        '
        Me.txtfechaDesde.Location = New System.Drawing.Point(111, 13)
        Me.txtfechaDesde.Mask = "0000/00/00"
        Me.txtfechaDesde.Name = "txtfechaDesde"
        Me.txtfechaDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtfechaDesde.TabIndex = 1
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(456, 9)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 0
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtMotivo)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 469)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 160)
        Me.Panel1.TabIndex = 2
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtMotivo.Location = New System.Drawing.Point(0, 40)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(857, 91)
        Me.TxtMotivo.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btImprimir)
        Me.Panel3.Controls.Add(Me.BtnSalir)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(857, 29)
        Me.Panel3.TabIndex = 1
        '
        'btImprimir
        '
        Me.btImprimir.Location = New System.Drawing.Point(12, 3)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(115, 23)
        Me.btImprimir.TabIndex = 5
        Me.btImprimir.Text = "Imprimir Borrador"
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Location = New System.Drawing.Point(770, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LFechaAsiento)
        Me.Panel2.Controls.Add(Me.lblDatos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(857, 40)
        Me.Panel2.TabIndex = 0
        '
        'LFechaAsiento
        '
        Me.LFechaAsiento.AutoSize = True
        Me.LFechaAsiento.Location = New System.Drawing.Point(18, 6)
        Me.LFechaAsiento.Name = "LFechaAsiento"
        Me.LFechaAsiento.Size = New System.Drawing.Size(94, 13)
        Me.LFechaAsiento.TabIndex = 1
        Me.LFechaAsiento.Text = "                             "
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(18, 22)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(85, 13)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "                          "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_plan, Me.Clave_contable, Me.Descripcion, Me.Debe, Me.Haber, Me.MOTIVO, Me.FECHA})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 42)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(857, 427)
        Me.DataGridView1.TabIndex = 7
        '
        'id_plan
        '
        Me.id_plan.HeaderText = "Nro Asiento"
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
        'MOTIVO
        '
        Me.MOTIVO.HeaderText = "MOTIVO"
        Me.MOTIVO.Name = "MOTIVO"
        Me.MOTIVO.ReadOnly = True
        Me.MOTIVO.Visible = False
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Imprimir Definitivo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(254, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Imprimir Titulos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Libro_Diario
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 629)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PDatos)
        Me.Name = "Libro_Diario"
        Me.Text = "Libro Diario"
        Me.PDatos.ResumeLayout(False)
        Me.PDatos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PDatos As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtfechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents id_plan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clave_contable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents LFechaAsiento As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
