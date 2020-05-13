<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRMantenimiento))
        Me.MnuMantenimiento = New System.Windows.Forms.MenuStrip()
        Me.EntrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropietarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpbPendiente = New System.Windows.Forms.GroupBox()
        Me.lblTPendiente = New System.Windows.Forms.Label()
        Me.gpbConcluida = New System.Windows.Forms.GroupBox()
        Me.lblTConcluida = New System.Windows.Forms.Label()
        Me.gpbReparacion = New System.Windows.Forms.GroupBox()
        Me.lblTReparacion = New System.Windows.Forms.Label()
        Me.dgvMantenimiento = New System.Windows.Forms.DataGridView()
        Me.lblMantenimiento = New System.Windows.Forms.Label()
        Me.MnuMantenimiento.SuspendLayout()
        Me.gpbPendiente.SuspendLayout()
        Me.gpbConcluida.SuspendLayout()
        Me.gpbReparacion.SuspendLayout()
        CType(Me.dgvMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MnuMantenimiento
        '
        Me.MnuMantenimiento.BackColor = System.Drawing.Color.Transparent
        Me.MnuMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrarToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MnuMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.MnuMantenimiento.Name = "MnuMantenimiento"
        Me.MnuMantenimiento.Size = New System.Drawing.Size(800, 24)
        Me.MnuMantenimiento.TabIndex = 2
        Me.MnuMantenimiento.Text = "MenuStrip1"
        '
        'EntrarToolStripMenuItem
        '
        Me.EntrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.EntrarToolStripMenuItem.Name = "EntrarToolStripMenuItem"
        Me.EntrarToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.EntrarToolStripMenuItem.Text = "Entrar"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        Me.AdicionarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AdicionarToolStripMenuItem.Text = "Adicionar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem, Me.MantenimientoToolStripMenuItem1, Me.ClienteToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.IngresosToolStripMenuItem.Text = "Ingresos"
        '
        'MantenimientoToolStripMenuItem1
        '
        Me.MantenimientoToolStripMenuItem1.Name = "MantenimientoToolStripMenuItem1"
        Me.MantenimientoToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.MantenimientoToolStripMenuItem1.Text = "Mantenimiento"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PropietarioToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ApartamentoToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'PropietarioToolStripMenuItem
        '
        Me.PropietarioToolStripMenuItem.Name = "PropietarioToolStripMenuItem"
        Me.PropietarioToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PropietarioToolStripMenuItem.Text = "Propietario"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ApartamentoToolStripMenuItem
        '
        Me.ApartamentoToolStripMenuItem.Name = "ApartamentoToolStripMenuItem"
        Me.ApartamentoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ApartamentoToolStripMenuItem.Text = "Apartamento"
        '
        'gpbPendiente
        '
        Me.gpbPendiente.BackColor = System.Drawing.Color.Transparent
        Me.gpbPendiente.Controls.Add(Me.lblTPendiente)
        Me.gpbPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPendiente.Location = New System.Drawing.Point(21, 381)
        Me.gpbPendiente.Name = "gpbPendiente"
        Me.gpbPendiente.Size = New System.Drawing.Size(134, 57)
        Me.gpbPendiente.TabIndex = 4
        Me.gpbPendiente.TabStop = False
        Me.gpbPendiente.Text = "Pendientes"
        '
        'lblTPendiente
        '
        Me.lblTPendiente.AutoSize = True
        Me.lblTPendiente.Location = New System.Drawing.Point(37, 29)
        Me.lblTPendiente.Name = "lblTPendiente"
        Me.lblTPendiente.Size = New System.Drawing.Size(56, 24)
        Me.lblTPendiente.TabIndex = 0
        Me.lblTPendiente.Text = "Total"
        '
        'gpbConcluida
        '
        Me.gpbConcluida.BackColor = System.Drawing.Color.Transparent
        Me.gpbConcluida.Controls.Add(Me.lblTConcluida)
        Me.gpbConcluida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbConcluida.Location = New System.Drawing.Point(342, 381)
        Me.gpbConcluida.Name = "gpbConcluida"
        Me.gpbConcluida.Size = New System.Drawing.Size(134, 57)
        Me.gpbConcluida.TabIndex = 5
        Me.gpbConcluida.TabStop = False
        Me.gpbConcluida.Text = "Concluidas"
        '
        'lblTConcluida
        '
        Me.lblTConcluida.AutoSize = True
        Me.lblTConcluida.Location = New System.Drawing.Point(37, 29)
        Me.lblTConcluida.Name = "lblTConcluida"
        Me.lblTConcluida.Size = New System.Drawing.Size(56, 24)
        Me.lblTConcluida.TabIndex = 0
        Me.lblTConcluida.Text = "Total"
        '
        'gpbReparacion
        '
        Me.gpbReparacion.BackColor = System.Drawing.Color.Transparent
        Me.gpbReparacion.Controls.Add(Me.lblTReparacion)
        Me.gpbReparacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbReparacion.Location = New System.Drawing.Point(180, 381)
        Me.gpbReparacion.Name = "gpbReparacion"
        Me.gpbReparacion.Size = New System.Drawing.Size(134, 57)
        Me.gpbReparacion.TabIndex = 5
        Me.gpbReparacion.TabStop = False
        Me.gpbReparacion.Text = "Reparación"
        '
        'lblTReparacion
        '
        Me.lblTReparacion.AutoSize = True
        Me.lblTReparacion.Location = New System.Drawing.Point(37, 29)
        Me.lblTReparacion.Name = "lblTReparacion"
        Me.lblTReparacion.Size = New System.Drawing.Size(56, 24)
        Me.lblTReparacion.TabIndex = 0
        Me.lblTReparacion.Text = "Total"
        '
        'dgvMantenimiento
        '
        Me.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMantenimiento.Location = New System.Drawing.Point(78, 61)
        Me.dgvMantenimiento.Name = "dgvMantenimiento"
        Me.dgvMantenimiento.Size = New System.Drawing.Size(647, 314)
        Me.dgvMantenimiento.TabIndex = 6
        '
        'lblMantenimiento
        '
        Me.lblMantenimiento.AutoSize = True
        Me.lblMantenimiento.BackColor = System.Drawing.Color.Transparent
        Me.lblMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMantenimiento.Location = New System.Drawing.Point(17, 38)
        Me.lblMantenimiento.Name = "lblMantenimiento"
        Me.lblMantenimiento.Size = New System.Drawing.Size(303, 20)
        Me.lblMantenimiento.TabIndex = 7
        Me.lblMantenimiento.Text = "Mantenimiento en los Apartamentos "
        '
        'FrmRMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMantenimiento)
        Me.Controls.Add(Me.dgvMantenimiento)
        Me.Controls.Add(Me.gpbReparacion)
        Me.Controls.Add(Me.gpbConcluida)
        Me.Controls.Add(Me.gpbPendiente)
        Me.Controls.Add(Me.MnuMantenimiento)
        Me.Name = "FrmRMantenimiento"
        Me.Text = "Mantenimiento"
        Me.MnuMantenimiento.ResumeLayout(False)
        Me.MnuMantenimiento.PerformLayout()
        Me.gpbPendiente.ResumeLayout(False)
        Me.gpbPendiente.PerformLayout()
        Me.gpbConcluida.ResumeLayout(False)
        Me.gpbConcluida.PerformLayout()
        Me.gpbReparacion.ResumeLayout(False)
        Me.gpbReparacion.PerformLayout()
        CType(Me.dgvMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuMantenimiento As MenuStrip
    Friend WithEvents EntrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropietarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gpbPendiente As GroupBox
    Friend WithEvents lblTPendiente As Label
    Friend WithEvents gpbConcluida As GroupBox
    Friend WithEvents lblTConcluida As Label
    Friend WithEvents gpbReparacion As GroupBox
    Friend WithEvents lblTReparacion As Label
    Friend WithEvents dgvMantenimiento As DataGridView
    Friend WithEvents ApartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblMantenimiento As Label
End Class
