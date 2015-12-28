<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas_PlanCuentas
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
        Me.TxtReferencia = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DGView_Consulta = New System.Windows.Forms.DataGridView
        Me.id_plan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Clave_Contable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LblReferencia = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGView_Consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblReferencia)
        Me.Panel1.Controls.Add(Me.TxtReferencia)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 22)
        Me.Panel1.TabIndex = 2
        '
        'TxtReferencia
        '
        Me.TxtReferencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TxtReferencia.Enabled = False
        Me.TxtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencia.Location = New System.Drawing.Point(638, 6)
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(17, 12)
        Me.TxtReferencia.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGView_Consulta)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(712, 286)
        Me.Panel2.TabIndex = 3
        '
        'DGView_Consulta
        '
        Me.DGView_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView_Consulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_plan, Me.Clave_Contable, Me.Descripcion})
        Me.DGView_Consulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGView_Consulta.Location = New System.Drawing.Point(0, 0)
        Me.DGView_Consulta.Name = "DGView_Consulta"
        Me.DGView_Consulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGView_Consulta.Size = New System.Drawing.Size(712, 286)
        Me.DGView_Consulta.TabIndex = 1
        '
        'id_plan
        '
        Me.id_plan.HeaderText = "ID Plan"
        Me.id_plan.Name = "id_plan"
        '
        'Clave_Contable
        '
        Me.Clave_Contable.HeaderText = "Clave Contable"
        Me.Clave_Contable.Name = "Clave_Contable"
        Me.Clave_Contable.Width = 180
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 300
        '
        'LblReferencia
        '
        Me.LblReferencia.AutoSize = True
        Me.LblReferencia.Location = New System.Drawing.Point(515, 5)
        Me.LblReferencia.Name = "LblReferencia"
        Me.LblReferencia.Size = New System.Drawing.Size(117, 13)
        Me.LblReferencia.TabIndex = 3
        Me.LblReferencia.Text = "Cuentas No Imputables"
        '
        'Consultas_PlanCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 308)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Consultas_PlanCuentas"
        Me.Text = "Consulta Plan Cuentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGView_Consulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DGView_Consulta As System.Windows.Forms.DataGridView
    Friend WithEvents id_plan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clave_Contable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblReferencia As System.Windows.Forms.Label
End Class
