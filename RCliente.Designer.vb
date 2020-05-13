<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRCliente))
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
        Me.dgvRCliente = New System.Windows.Forms.DataGridView()
        Me.gpbCliente = New System.Windows.Forms.GroupBox()
        Me.lblRTotal = New System.Windows.Forms.Label()
        Me.txtCCodigo = New System.Windows.Forms.TextBox()
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblCCodigo = New System.Windows.Forms.Label()
        Me.MnuMantenimiento.SuspendLayout()
        CType(Me.dgvRCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuMantenimiento
        '
        Me.MnuMantenimiento.BackColor = System.Drawing.Color.Transparent
        Me.MnuMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrarToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MnuMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.MnuMantenimiento.Name = "MnuMantenimiento"
        Me.MnuMantenimiento.Size = New System.Drawing.Size(800, 24)
        Me.MnuMantenimiento.TabIndex = 1
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
        'dgvRCliente
        '
        Me.dgvRCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRCliente.Location = New System.Drawing.Point(36, 79)
        Me.dgvRCliente.Name = "dgvRCliente"
        Me.dgvRCliente.Size = New System.Drawing.Size(720, 359)
        Me.dgvRCliente.TabIndex = 2
        '
        'gpbCliente
        '
        Me.gpbCliente.BackColor = System.Drawing.Color.Transparent
        Me.gpbCliente.Controls.Add(Me.lblRTotal)
        Me.gpbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbCliente.Location = New System.Drawing.Point(18, 25)
        Me.gpbCliente.Name = "gpbCliente"
        Me.gpbCliente.Size = New System.Drawing.Size(188, 36)
        Me.gpbCliente.TabIndex = 3
        Me.gpbCliente.TabStop = False
        Me.gpbCliente.Text = "Clientes"
        '
        'lblRTotal
        '
        Me.lblRTotal.AutoSize = True
        Me.lblRTotal.Location = New System.Drawing.Point(106, 12)
        Me.lblRTotal.Name = "lblRTotal"
        Me.lblRTotal.Size = New System.Drawing.Size(56, 24)
        Me.lblRTotal.TabIndex = 0
        Me.lblRTotal.Text = "Total"
        '
        'txtCCodigo
        '
        Me.txtCCodigo.Location = New System.Drawing.Point(277, 41)
        Me.txtCCodigo.Name = "txtCCodigo"
        Me.txtCCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCCodigo.TabIndex = 18
        '
        'btnTodos
        '
        Me.btnTodos.Location = New System.Drawing.Point(464, 39)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(75, 23)
        Me.btnTodos.TabIndex = 17
        Me.btnTodos.Text = "Ver Todos"
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(383, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCCodigo
        '
        Me.lblCCodigo.AutoSize = True
        Me.lblCCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblCCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCodigo.Location = New System.Drawing.Point(225, 48)
        Me.lblCCodigo.Name = "lblCCodigo"
        Me.lblCCodigo.Size = New System.Drawing.Size(46, 13)
        Me.lblCCodigo.TabIndex = 14
        Me.lblCCodigo.Text = "Código"
        '
        'FrmRCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtCCodigo)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblCCodigo)
        Me.Controls.Add(Me.gpbCliente)
        Me.Controls.Add(Me.dgvRCliente)
        Me.Controls.Add(Me.MnuMantenimiento)
        Me.Name = "FrmRCliente"
        Me.Text = "Cliente"
        Me.MnuMantenimiento.ResumeLayout(False)
        Me.MnuMantenimiento.PerformLayout()
        CType(Me.dgvRCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbCliente.ResumeLayout(False)
        Me.gpbCliente.PerformLayout()
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
    Friend WithEvents dgvRCliente As DataGridView
    Friend WithEvents gpbCliente As GroupBox
    Friend WithEvents lblRTotal As Label
    Friend WithEvents ApartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtCCodigo As TextBox
    Friend WithEvents btnTodos As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblCCodigo As Label
End Class
