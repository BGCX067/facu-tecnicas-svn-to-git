<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MenuPrincipal
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
        Me.Grb_Login = New System.Windows.Forms.GroupBox
        Me.Txt_Clave = New System.Windows.Forms.TextBox
        Me.Txt_Usuario = New System.Windows.Forms.TextBox
        Me.Lbl_Clave = New System.Windows.Forms.Label
        Me.Lbl_Usuario = New System.Windows.Forms.Label
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Grb_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb_Login
        '
        Me.Grb_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grb_Login.Controls.Add(Me.Txt_Clave)
        Me.Grb_Login.Controls.Add(Me.Txt_Usuario)
        Me.Grb_Login.Controls.Add(Me.Lbl_Clave)
        Me.Grb_Login.Controls.Add(Me.Lbl_Usuario)
        Me.Grb_Login.Location = New System.Drawing.Point(286, 52)
        Me.Grb_Login.Name = "Grb_Login"
        Me.Grb_Login.Size = New System.Drawing.Size(200, 100)
        Me.Grb_Login.TabIndex = 3
        Me.Grb_Login.TabStop = False
        Me.Grb_Login.Text = "Login"
        '
        'Txt_Clave
        '
        Me.Txt_Clave.Location = New System.Drawing.Point(82, 60)
        Me.Txt_Clave.Name = "Txt_Clave"
        Me.Txt_Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Clave.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Clave.TabIndex = 5
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Location = New System.Drawing.Point(82, 17)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Usuario.TabIndex = 4
        '
        'Lbl_Clave
        '
        Me.Lbl_Clave.AutoSize = True
        Me.Lbl_Clave.Location = New System.Drawing.Point(23, 67)
        Me.Lbl_Clave.Name = "Lbl_Clave"
        Me.Lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_Clave.TabIndex = 3
        Me.Lbl_Clave.Text = "Clave"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Location = New System.Drawing.Point(23, 20)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Usuario.TabIndex = 2
        Me.Lbl_Usuario.Text = "Usuario"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        'Frm_MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 273)
        Me.Controls.Add(Me.Grb_Login)
        Me.IsMdiContainer = True
        Me.Name = "Frm_MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Grb_Login.ResumeLayout(False)
        Me.Grb_Login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grb_Login As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Clave As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents Lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem

End Class
