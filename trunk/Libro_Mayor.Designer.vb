<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libro_Mayor
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.CBoxCuentas = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtfechaHasta = New System.Windows.Forms.MaskedTextBox
        Me.txtfechaDesde = New System.Windows.Forms.MaskedTextBox
        Me.btBuscar = New System.Windows.Forms.Button
        Me.PGrilla = New System.Windows.Forms.Panel
        Me.GrillaLibroMayor = New System.Windows.Forms.DataGridView
        Me.PBotones = New System.Windows.Forms.Panel
        Me.btsalir = New System.Windows.Forms.Button
        Me.nro_interno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.asiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.saldo_anterior = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.debitado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acreditado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.saldo_final = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PDatos.SuspendLayout()
        Me.PGrilla.SuspendLayout()
        CType(Me.GrillaLibroMayor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PDatos
        '
        Me.PDatos.Controls.Add(Me.Label3)
        Me.PDatos.Controls.Add(Me.CBoxCuentas)
        Me.PDatos.Controls.Add(Me.Label2)
        Me.PDatos.Controls.Add(Me.Label1)
        Me.PDatos.Controls.Add(Me.txtfechaHasta)
        Me.PDatos.Controls.Add(Me.txtfechaDesde)
        Me.PDatos.Controls.Add(Me.btBuscar)
        Me.PDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PDatos.Location = New System.Drawing.Point(0, 0)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(857, 70)
        Me.PDatos.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cuenta"
        '
        'CBoxCuentas
        '
        Me.CBoxCuentas.FormattingEnabled = True
        Me.CBoxCuentas.Location = New System.Drawing.Point(111, 39)
        Me.CBoxCuentas.Name = "CBoxCuentas"
        Me.CBoxCuentas.Size = New System.Drawing.Size(295, 21)
        Me.CBoxCuentas.TabIndex = 5
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
        'PGrilla
        '
        Me.PGrilla.Controls.Add(Me.GrillaLibroMayor)
        Me.PGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PGrilla.Location = New System.Drawing.Point(0, 70)
        Me.PGrilla.Name = "PGrilla"
        Me.PGrilla.Size = New System.Drawing.Size(857, 559)
        Me.PGrilla.TabIndex = 1
        '
        'GrillaLibroMayor
        '
        Me.GrillaLibroMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaLibroMayor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nro_interno, Me.cuenta, Me.asiento, Me.fecha, Me.saldo_anterior, Me.debitado, Me.acreditado, Me.saldo_final})
        Me.GrillaLibroMayor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaLibroMayor.Location = New System.Drawing.Point(0, 0)
        Me.GrillaLibroMayor.Name = "GrillaLibroMayor"
        Me.GrillaLibroMayor.Size = New System.Drawing.Size(857, 559)
        Me.GrillaLibroMayor.TabIndex = 0
        '
        'PBotones
        '
        Me.PBotones.Controls.Add(Me.btsalir)
        Me.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PBotones.Location = New System.Drawing.Point(0, 598)
        Me.PBotones.Name = "PBotones"
        Me.PBotones.Size = New System.Drawing.Size(857, 31)
        Me.PBotones.TabIndex = 2
        '
        'btsalir
        '
        Me.btsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btsalir.Location = New System.Drawing.Point(770, 3)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(75, 23)
        Me.btsalir.TabIndex = 0
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = True
        '
        'nro_interno
        '
        Me.nro_interno.HeaderText = "Nro Interno"
        Me.nro_interno.Name = "nro_interno"
        '
        'cuenta
        '
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.Name = "cuenta"
        '
        'asiento
        '
        Me.asiento.HeaderText = "Asiento"
        Me.asiento.Name = "asiento"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'saldo_anterior
        '
        Me.saldo_anterior.HeaderText = "Saldo Anterior"
        Me.saldo_anterior.Name = "saldo_anterior"
        '
        'debitado
        '
        Me.debitado.HeaderText = "Debitado"
        Me.debitado.Name = "debitado"
        '
        'acreditado
        '
        Me.acreditado.HeaderText = "Acreditado"
        Me.acreditado.Name = "acreditado"
        '
        'saldo_final
        '
        Me.saldo_final.HeaderText = "Saldo Actual"
        Me.saldo_final.Name = "saldo_final"
        '
        'Libro_Mayor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 629)
        Me.Controls.Add(Me.PBotones)
        Me.Controls.Add(Me.PGrilla)
        Me.Controls.Add(Me.PDatos)
        Me.Name = "Libro_Mayor"
        Me.Text = "Libro Mayor"
        Me.PDatos.ResumeLayout(False)
        Me.PDatos.PerformLayout()
        Me.PGrilla.ResumeLayout(False)
        CType(Me.GrillaLibroMayor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PDatos As System.Windows.Forms.Panel
    Friend WithEvents PGrilla As System.Windows.Forms.Panel
    Friend WithEvents PBotones As System.Windows.Forms.Panel
    Friend WithEvents GrillaLibroMayor As System.Windows.Forms.DataGridView
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtfechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btsalir As System.Windows.Forms.Button
    Friend WithEvents CBoxCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nro_interno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo_anterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acreditado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo_final As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
