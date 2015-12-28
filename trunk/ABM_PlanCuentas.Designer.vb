<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_PlanCuentas
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
        Me.P_Botones = New System.Windows.Forms.Panel
        Me.btcancelar = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.btagregar = New System.Windows.Forms.Button
        Me.btmodificar = New System.Windows.Forms.Button
        Me.btbaja = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbN1 = New System.Windows.Forms.ComboBox
        Me.CmbN2 = New System.Windows.Forms.ComboBox
        Me.CmbN3 = New System.Windows.Forms.ComboBox
        Me.CmbN4 = New System.Windows.Forms.ComboBox
        Me.CmbN5 = New System.Windows.Forms.ComboBox
        Me.CboxInflacion = New System.Windows.Forms.ComboBox
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.BtNuevoN1 = New System.Windows.Forms.Button
        Me.BtNuevoN2 = New System.Windows.Forms.Button
        Me.BtNuevoN3 = New System.Windows.Forms.Button
        Me.BtNuevoN4 = New System.Windows.Forms.Button
        Me.BtNuevoN5 = New System.Windows.Forms.Button
        Me.txtClaveContable = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtClaveContableNueva = New System.Windows.Forms.TextBox
        Me.CBoxImputable = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.P_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Botones
        '
        Me.P_Botones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_Botones.Controls.Add(Me.btcancelar)
        Me.P_Botones.Controls.Add(Me.Button9)
        Me.P_Botones.Controls.Add(Me.btagregar)
        Me.P_Botones.Controls.Add(Me.btmodificar)
        Me.P_Botones.Controls.Add(Me.btbaja)
        Me.P_Botones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.P_Botones.Location = New System.Drawing.Point(0, 331)
        Me.P_Botones.Name = "P_Botones"
        Me.P_Botones.Size = New System.Drawing.Size(535, 32)
        Me.P_Botones.TabIndex = 0
        '
        'btcancelar
        '
        Me.btcancelar.Enabled = False
        Me.btcancelar.Location = New System.Drawing.Point(301, 3)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(75, 23)
        Me.btcancelar.TabIndex = 28
        Me.btcancelar.Text = "Cancelar"
        Me.btcancelar.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(455, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 27
        Me.Button9.Text = "&Salir"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btagregar
        '
        Me.btagregar.Enabled = False
        Me.btagregar.Location = New System.Drawing.Point(211, 3)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(75, 23)
        Me.btagregar.TabIndex = 26
        Me.btagregar.Text = "&Guardar"
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'btmodificar
        '
        Me.btmodificar.Location = New System.Drawing.Point(95, 3)
        Me.btmodificar.Name = "btmodificar"
        Me.btmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btmodificar.TabIndex = 25
        Me.btmodificar.Text = "&Modificar"
        Me.btmodificar.UseVisualStyleBackColor = True
        '
        'btbaja
        '
        Me.btbaja.Location = New System.Drawing.Point(3, 3)
        Me.btbaja.Name = "btbaja"
        Me.btbaja.Size = New System.Drawing.Size(75, 23)
        Me.btbaja.TabIndex = 24
        Me.btbaja.Text = "&Baja"
        Me.btbaja.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave Contable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nivel 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nivel 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nivel 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nivel 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Descripcion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(93, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nivel 5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Ajuste por Inflacion"
        '
        'CmbN1
        '
        Me.CmbN1.FormattingEnabled = True
        Me.CmbN1.Location = New System.Drawing.Point(162, 50)
        Me.CmbN1.Name = "CmbN1"
        Me.CmbN1.Size = New System.Drawing.Size(254, 21)
        Me.CmbN1.TabIndex = 12
        '
        'CmbN2
        '
        Me.CmbN2.FormattingEnabled = True
        Me.CmbN2.Location = New System.Drawing.Point(162, 81)
        Me.CmbN2.Name = "CmbN2"
        Me.CmbN2.Size = New System.Drawing.Size(254, 21)
        Me.CmbN2.TabIndex = 13
        '
        'CmbN3
        '
        Me.CmbN3.FormattingEnabled = True
        Me.CmbN3.Items.AddRange(New Object() {"", "Prueba1", "Prueba2"})
        Me.CmbN3.Location = New System.Drawing.Point(162, 115)
        Me.CmbN3.Name = "CmbN3"
        Me.CmbN3.Size = New System.Drawing.Size(254, 21)
        Me.CmbN3.TabIndex = 14
        '
        'CmbN4
        '
        Me.CmbN4.FormattingEnabled = True
        Me.CmbN4.Items.AddRange(New Object() {"", "Prueba1", "Prueba2"})
        Me.CmbN4.Location = New System.Drawing.Point(162, 149)
        Me.CmbN4.Name = "CmbN4"
        Me.CmbN4.Size = New System.Drawing.Size(254, 21)
        Me.CmbN4.TabIndex = 15
        '
        'CmbN5
        '
        Me.CmbN5.FormattingEnabled = True
        Me.CmbN5.Items.AddRange(New Object() {"", "Prueba1", "Prueba2"})
        Me.CmbN5.Location = New System.Drawing.Point(162, 185)
        Me.CmbN5.Name = "CmbN5"
        Me.CmbN5.Size = New System.Drawing.Size(254, 21)
        Me.CmbN5.TabIndex = 16
        '
        'CboxInflacion
        '
        Me.CboxInflacion.Enabled = False
        Me.CboxInflacion.FormattingEnabled = True
        Me.CboxInflacion.Items.AddRange(New Object() {"Si", "No"})
        Me.CboxInflacion.Location = New System.Drawing.Point(164, 289)
        Me.CboxInflacion.Name = "CboxInflacion"
        Me.CboxInflacion.Size = New System.Drawing.Size(54, 21)
        Me.CboxInflacion.TabIndex = 17
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(164, 258)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(334, 20)
        Me.TxtDescripcion.TabIndex = 20
        '
        'BtNuevoN1
        '
        Me.BtNuevoN1.Location = New System.Drawing.Point(423, 50)
        Me.BtNuevoN1.Name = "BtNuevoN1"
        Me.BtNuevoN1.Size = New System.Drawing.Size(75, 23)
        Me.BtNuevoN1.TabIndex = 21
        Me.BtNuevoN1.Text = "Nueva"
        Me.BtNuevoN1.UseVisualStyleBackColor = True
        Me.BtNuevoN1.Visible = False
        '
        'BtNuevoN2
        '
        Me.BtNuevoN2.Location = New System.Drawing.Point(423, 81)
        Me.BtNuevoN2.Name = "BtNuevoN2"
        Me.BtNuevoN2.Size = New System.Drawing.Size(75, 23)
        Me.BtNuevoN2.TabIndex = 22
        Me.BtNuevoN2.Text = "Nueva"
        Me.BtNuevoN2.UseVisualStyleBackColor = True
        Me.BtNuevoN2.Visible = False
        '
        'BtNuevoN3
        '
        Me.BtNuevoN3.Location = New System.Drawing.Point(423, 115)
        Me.BtNuevoN3.Name = "BtNuevoN3"
        Me.BtNuevoN3.Size = New System.Drawing.Size(75, 23)
        Me.BtNuevoN3.TabIndex = 23
        Me.BtNuevoN3.Text = "Nueva"
        Me.BtNuevoN3.UseVisualStyleBackColor = True
        Me.BtNuevoN3.Visible = False
        '
        'BtNuevoN4
        '
        Me.BtNuevoN4.Location = New System.Drawing.Point(423, 149)
        Me.BtNuevoN4.Name = "BtNuevoN4"
        Me.BtNuevoN4.Size = New System.Drawing.Size(75, 23)
        Me.BtNuevoN4.TabIndex = 24
        Me.BtNuevoN4.Text = "Nueva"
        Me.BtNuevoN4.UseVisualStyleBackColor = True
        Me.BtNuevoN4.Visible = False
        '
        'BtNuevoN5
        '
        Me.BtNuevoN5.Location = New System.Drawing.Point(423, 182)
        Me.BtNuevoN5.Name = "BtNuevoN5"
        Me.BtNuevoN5.Size = New System.Drawing.Size(75, 23)
        Me.BtNuevoN5.TabIndex = 25
        Me.BtNuevoN5.Text = "Nueva"
        Me.BtNuevoN5.UseVisualStyleBackColor = True
        Me.BtNuevoN5.Visible = False
        '
        'txtClaveContable
        '
        Me.txtClaveContable.Enabled = False
        Me.txtClaveContable.Location = New System.Drawing.Point(162, 12)
        Me.txtClaveContable.Name = "txtClaveContable"
        Me.txtClaveContable.Size = New System.Drawing.Size(173, 20)
        Me.txtClaveContable.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(224, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Clave Contable Nueva"
        '
        'txtClaveContableNueva
        '
        Me.txtClaveContableNueva.Enabled = False
        Me.txtClaveContableNueva.Location = New System.Drawing.Point(344, 290)
        Me.txtClaveContableNueva.Name = "txtClaveContableNueva"
        Me.txtClaveContableNueva.Size = New System.Drawing.Size(154, 20)
        Me.txtClaveContableNueva.TabIndex = 28
        '
        'CBoxImputable
        '
        Me.CBoxImputable.Enabled = False
        Me.CBoxImputable.FormattingEnabled = True
        Me.CBoxImputable.Items.AddRange(New Object() {"Si", "No"})
        Me.CBoxImputable.Location = New System.Drawing.Point(164, 222)
        Me.CBoxImputable.Name = "CBoxImputable"
        Me.CBoxImputable.Size = New System.Drawing.Size(56, 21)
        Me.CBoxImputable.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Imputable"
        '
        'ABM_PlanCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 363)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBoxImputable)
        Me.Controls.Add(Me.txtClaveContableNueva)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtClaveContable)
        Me.Controls.Add(Me.BtNuevoN5)
        Me.Controls.Add(Me.BtNuevoN4)
        Me.Controls.Add(Me.BtNuevoN3)
        Me.Controls.Add(Me.BtNuevoN2)
        Me.Controls.Add(Me.BtNuevoN1)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.CboxInflacion)
        Me.Controls.Add(Me.CmbN5)
        Me.Controls.Add(Me.CmbN4)
        Me.Controls.Add(Me.CmbN3)
        Me.Controls.Add(Me.CmbN2)
        Me.Controls.Add(Me.CmbN1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.P_Botones)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABM_PlanCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Plan de Cuentas"
        Me.P_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P_Botones As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbN2 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbN3 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbN4 As System.Windows.Forms.ComboBox
    Friend WithEvents CmbN5 As System.Windows.Forms.ComboBox
    Friend WithEvents CboxInflacion As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btagregar As System.Windows.Forms.Button
    Friend WithEvents btmodificar As System.Windows.Forms.Button
    Friend WithEvents btbaja As System.Windows.Forms.Button
    Friend WithEvents BtNuevoN1 As System.Windows.Forms.Button
    Friend WithEvents BtNuevoN2 As System.Windows.Forms.Button
    Friend WithEvents BtNuevoN3 As System.Windows.Forms.Button
    Friend WithEvents BtNuevoN4 As System.Windows.Forms.Button
    Friend WithEvents BtNuevoN5 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents txtClaveContable As System.Windows.Forms.TextBox
    Protected Friend WithEvents CmbN1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtClaveContableNueva As System.Windows.Forms.TextBox
    Friend WithEvents btcancelar As System.Windows.Forms.Button
    Friend WithEvents CBoxImputable As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
