<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPresentacion))
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gpbIntegrantes = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MnuPresentacion = New System.Windows.Forms.MenuStrip()
        Me.IniciarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gpbIntegrantes.SuspendLayout()
        Me.MnuPresentacion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.Location = New System.Drawing.Point(53, 0)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(236, 42)
        Me.lblBienvenido.TabIndex = 0
        Me.lblBienvenido.Text = "¡Bienvenidos!"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(3, 38)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(323, 42)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Buena Vista Resort"
        '
        'gpbIntegrantes
        '
        Me.gpbIntegrantes.BackColor = System.Drawing.Color.Snow
        Me.gpbIntegrantes.Controls.Add(Me.Label5)
        Me.gpbIntegrantes.Controls.Add(Me.Label3)
        Me.gpbIntegrantes.Controls.Add(Me.Label4)
        Me.gpbIntegrantes.Controls.Add(Me.Label2)
        Me.gpbIntegrantes.Controls.Add(Me.Label1)
        Me.gpbIntegrantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbIntegrantes.Location = New System.Drawing.Point(304, 205)
        Me.gpbIntegrantes.Name = "gpbIntegrantes"
        Me.gpbIntegrantes.Size = New System.Drawing.Size(210, 137)
        Me.gpbIntegrantes.TabIndex = 2
        Me.gpbIntegrantes.TabStop = False
        Me.gpbIntegrantes.Text = "Elaborado por:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ruiz, Corina     8-913-1440"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Espino, Alejandro     8-936-448"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pico, James     8-924-154"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diaz, Nancy     8-934-2228"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Arias, Jeshua     E-8-145485"
        '
        'MnuPresentacion
        '
        Me.MnuPresentacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MnuPresentacion.Location = New System.Drawing.Point(0, 0)
        Me.MnuPresentacion.Name = "MnuPresentacion"
        Me.MnuPresentacion.Size = New System.Drawing.Size(800, 24)
        Me.MnuPresentacion.TabIndex = 4
        Me.MnuPresentacion.Text = "MenuStrip1"
        '
        'IniciarSesiónToolStripMenuItem
        '
        Me.IniciarSesiónToolStripMenuItem.Name = "IniciarSesiónToolStripMenuItem"
        Me.IniciarSesiónToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.IniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(243, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 80)
        Me.Panel1.TabIndex = 5
        '
        'FrmPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gpbIntegrantes)
        Me.Controls.Add(Me.MnuPresentacion)
        Me.MainMenuStrip = Me.MnuPresentacion
        Me.Name = "FrmPresentacion"
        Me.Text = "Presentacion"
        Me.gpbIntegrantes.ResumeLayout(False)
        Me.gpbIntegrantes.PerformLayout()
        Me.MnuPresentacion.ResumeLayout(False)
        Me.MnuPresentacion.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBienvenido As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gpbIntegrantes As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MnuPresentacion As MenuStrip
    Friend WithEvents IniciarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
