<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.MnuLogin = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MnuLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Controls.Add(Me.lblContraseña)
        Me.Panel1.Controls.Add(Me.lblUsuario)
        Me.Panel1.Controls.Add(Me.btnIniciarSesion)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Location = New System.Drawing.Point(228, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 206)
        Me.Panel1.TabIndex = 0
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblContraseña.Location = New System.Drawing.Point(51, 108)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(73, 15)
        Me.lblContraseña.TabIndex = 4
        Me.lblContraseña.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsuario.Location = New System.Drawing.Point(51, 66)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(51, 15)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.DarkGreen
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.Window
        Me.btnIniciarSesion.Location = New System.Drawing.Point(54, 162)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(251, 34)
        Me.btnIniciarSesion.TabIndex = 2
        Me.btnIniciarSesion.Text = "Iniciar Sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(137, 108)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(167, 20)
        Me.txtContraseña.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(137, 65)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(167, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'MnuLogin
        '
        Me.MnuLogin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MnuLogin.Location = New System.Drawing.Point(0, 0)
        Me.MnuLogin.Name = "MnuLogin"
        Me.MnuLogin.Size = New System.Drawing.Size(800, 24)
        Me.MnuLogin.TabIndex = 1
        Me.MnuLogin.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLogin.Location = New System.Drawing.Point(143, 14)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(80, 29)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MnuLogin)
        Me.MainMenuStrip = Me.MnuLogin
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MnuLogin.ResumeLayout(False)
        Me.MnuLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents MnuLogin As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblLogin As Label
End Class
