<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Asientos_Contables
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblDatos = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.id_plan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Clave_contable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Debe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Haber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MOTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PBuscar = New System.Windows.Forms.Panel
        Me.btborrarFiltros = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboxTipoBuscar = New System.Windows.Forms.ComboBox
        Me.txtnroAsiento = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LFechaAsiento = New System.Windows.Forms.Label
        Me.btBuscar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtfechahasta = New System.Windows.Forms.MaskedTextBox
        Me.txtFechadesde = New System.Windows.Forms.MaskedTextBox
        Me.GboxMotivo = New System.Windows.Forms.GroupBox
        Me.PBotones = New System.Windows.Forms.Panel
        Me.btContra_asiento = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.TxtMotivo = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PBuscar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GboxMotivo.SuspendLayout()
        Me.PBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PBuscar)
        Me.Panel1.Controls.Add(Me.GboxMotivo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 551)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(613, 339)
        Me.Panel2.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblDatos)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 312)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(613, 27)
        Me.Panel4.TabIndex = 7
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(11, 10)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(35, 13)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "Datos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_plan, Me.Clave_contable, Me.Descripcion, Me.Debe, Me.Haber, Me.MOTIVO, Me.FECHA})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(613, 339)
        Me.DataGridView1.TabIndex = 6
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
        'PBuscar
        '
        Me.PBuscar.Controls.Add(Me.btborrarFiltros)
        Me.PBuscar.Controls.Add(Me.Label4)
        Me.PBuscar.Controls.Add(Me.CboxTipoBuscar)
        Me.PBuscar.Controls.Add(Me.txtnroAsiento)
        Me.PBuscar.Controls.Add(Me.Label3)
        Me.PBuscar.Controls.Add(Me.Panel3)
        Me.PBuscar.Controls.Add(Me.btBuscar)
        Me.PBuscar.Controls.Add(Me.Label2)
        Me.PBuscar.Controls.Add(Me.Label1)
        Me.PBuscar.Controls.Add(Me.txtfechahasta)
        Me.PBuscar.Controls.Add(Me.txtFechadesde)
        Me.PBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PBuscar.Location = New System.Drawing.Point(0, 0)
        Me.PBuscar.Name = "PBuscar"
        Me.PBuscar.Size = New System.Drawing.Size(613, 111)
        Me.PBuscar.TabIndex = 7
        '
        'btborrarFiltros
        '
        Me.btborrarFiltros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btborrarFiltros.Location = New System.Drawing.Point(422, 62)
        Me.btborrarFiltros.Name = "btborrarFiltros"
        Me.btborrarFiltros.Size = New System.Drawing.Size(75, 23)
        Me.btborrarFiltros.TabIndex = 10
        Me.btborrarFiltros.Text = "Borrar Filtros"
        Me.btborrarFiltros.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Buscar Por:"
        '
        'CboxTipoBuscar
        '
        Me.CboxTipoBuscar.FormattingEnabled = True
        Me.CboxTipoBuscar.Items.AddRange(New Object() {"Fecha de Asiento", "Nro. de Asiento"})
        Me.CboxTipoBuscar.Location = New System.Drawing.Point(88, 64)
        Me.CboxTipoBuscar.Name = "CboxTipoBuscar"
        Me.CboxTipoBuscar.Size = New System.Drawing.Size(189, 21)
        Me.CboxTipoBuscar.TabIndex = 8
        '
        'txtnroAsiento
        '
        Me.txtnroAsiento.Location = New System.Drawing.Point(88, 38)
        Me.txtnroAsiento.Name = "txtnroAsiento"
        Me.txtnroAsiento.Size = New System.Drawing.Size(100, 20)
        Me.txtnroAsiento.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nro Asiento:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LFechaAsiento)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(613, 18)
        Me.Panel3.TabIndex = 5
        '
        'LFechaAsiento
        '
        Me.LFechaAsiento.AutoSize = True
        Me.LFechaAsiento.Location = New System.Drawing.Point(11, 0)
        Me.LFechaAsiento.Name = "LFechaAsiento"
        Me.LFechaAsiento.Size = New System.Drawing.Size(37, 13)
        Me.LFechaAsiento.TabIndex = 0
        Me.LFechaAsiento.Text = "Fecha"
        '
        'btBuscar
        '
        Me.btBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btBuscar.Location = New System.Drawing.Point(286, 62)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btBuscar.TabIndex = 4
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Desde"
        '
        'txtfechahasta
        '
        Me.txtfechahasta.Location = New System.Drawing.Point(286, 12)
        Me.txtfechahasta.Mask = "0000/00/00"
        Me.txtfechahasta.Name = "txtfechahasta"
        Me.txtfechahasta.Size = New System.Drawing.Size(100, 20)
        Me.txtfechahasta.TabIndex = 1
        '
        'txtFechadesde
        '
        Me.txtFechadesde.Location = New System.Drawing.Point(88, 12)
        Me.txtFechadesde.Mask = "00/00/0000"
        Me.txtFechadesde.Name = "txtFechadesde"
        Me.txtFechadesde.Size = New System.Drawing.Size(100, 20)
        Me.txtFechadesde.TabIndex = 0
        Me.txtFechadesde.ValidatingType = GetType(Date)
        '
        'GboxMotivo
        '
        Me.GboxMotivo.Controls.Add(Me.PBotones)
        Me.GboxMotivo.Controls.Add(Me.TxtMotivo)
        Me.GboxMotivo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GboxMotivo.Location = New System.Drawing.Point(0, 450)
        Me.GboxMotivo.Name = "GboxMotivo"
        Me.GboxMotivo.Size = New System.Drawing.Size(613, 101)
        Me.GboxMotivo.TabIndex = 6
        Me.GboxMotivo.TabStop = False
        Me.GboxMotivo.Text = "Motivo del Asiento contable"
        '
        'PBotones
        '
        Me.PBotones.Controls.Add(Me.btContra_asiento)
        Me.PBotones.Controls.Add(Me.BtnSalir)
        Me.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PBotones.Location = New System.Drawing.Point(3, 62)
        Me.PBotones.Name = "PBotones"
        Me.PBotones.Size = New System.Drawing.Size(607, 36)
        Me.PBotones.TabIndex = 6
        '
        'btContra_asiento
        '
        Me.btContra_asiento.Location = New System.Drawing.Point(30, 5)
        Me.btContra_asiento.Name = "btContra_asiento"
        Me.btContra_asiento.Size = New System.Drawing.Size(129, 22)
        Me.btContra_asiento.TabIndex = 4
        Me.btContra_asiento.Text = "Contra Asiento"
        Me.btContra_asiento.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Location = New System.Drawing.Point(518, 6)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtMotivo.Location = New System.Drawing.Point(3, 16)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(607, 82)
        Me.TxtMotivo.TabIndex = 0
        '
        'Consulta_Asientos_Contables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 551)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Consulta_Asientos_Contables"
        Me.Text = "Consulta Asientos Contables"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PBuscar.ResumeLayout(False)
        Me.PBuscar.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GboxMotivo.ResumeLayout(False)
        Me.GboxMotivo.PerformLayout()
        Me.PBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PBuscar As System.Windows.Forms.Panel
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfechahasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFechadesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GboxMotivo As System.Windows.Forms.GroupBox
    Friend WithEvents PBotones As System.Windows.Forms.Panel
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents TxtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LFechaAsiento As System.Windows.Forms.Label
    Friend WithEvents id_plan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clave_contable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btContra_asiento As System.Windows.Forms.Button
    Friend WithEvents CboxTipoBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents txtnroAsiento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btborrarFiltros As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblDatos As System.Windows.Forms.Label
End Class
