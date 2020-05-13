<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEliminar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminar))
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
        Me.gpbEliminar = New System.Windows.Forms.GroupBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.BtnEliminarEstado_Mant = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.gpbEliminarApto = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCod_Apto = New System.Windows.Forms.Label()
        Me.BtnEliminar_Apto = New System.Windows.Forms.Button()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.cmbMCodigo = New System.Windows.Forms.ComboBox()
        Me.cmbMCod_Apto = New System.Windows.Forms.ComboBox()
        Me.cmbMNombre = New System.Windows.Forms.ComboBox()
        Me.MnuMantenimiento.SuspendLayout()
        Me.gpbEliminar.SuspendLayout()
        Me.gpbEliminarApto.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuMantenimiento
        '
        Me.MnuMantenimiento.BackColor = System.Drawing.Color.Transparent
        Me.MnuMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrarToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MnuMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.MnuMantenimiento.Name = "MnuMantenimiento"
        Me.MnuMantenimiento.Size = New System.Drawing.Size(756, 24)
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
        'gpbEliminar
        '
        Me.gpbEliminar.BackColor = System.Drawing.Color.Transparent
        Me.gpbEliminar.Controls.Add(Me.cmbMCodigo)
        Me.gpbEliminar.Controls.Add(Me.cmbEstado)
        Me.gpbEliminar.Controls.Add(Me.lblEstado)
        Me.gpbEliminar.Controls.Add(Me.BtnEliminarEstado_Mant)
        Me.gpbEliminar.Controls.Add(Me.lblCodigo)
        Me.gpbEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbEliminar.Location = New System.Drawing.Point(74, 80)
        Me.gpbEliminar.Name = "gpbEliminar"
        Me.gpbEliminar.Size = New System.Drawing.Size(288, 320)
        Me.gpbEliminar.TabIndex = 6
        Me.gpbEliminar.TabStop = False
        Me.gpbEliminar.Text = "Eliminar Mantenimiento"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"P", "R", "C"})
        Me.cmbEstado.Location = New System.Drawing.Point(59, 158)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(169, 24)
        Me.cmbEstado.TabIndex = 12
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(23, 118)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(247, 24)
        Me.lblEstado.TabIndex = 11
        Me.lblEstado.Text = "Estado de Mantenimiento"
        '
        'BtnEliminarEstado_Mant
        '
        Me.BtnEliminarEstado_Mant.BackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarEstado_Mant.Location = New System.Drawing.Point(29, 224)
        Me.BtnEliminarEstado_Mant.Name = "BtnEliminarEstado_Mant"
        Me.BtnEliminarEstado_Mant.Size = New System.Drawing.Size(226, 52)
        Me.BtnEliminarEstado_Mant.TabIndex = 7
        Me.BtnEliminarEstado_Mant.Text = "Eliminar Mantenimiento"
        Me.BtnEliminarEstado_Mant.UseVisualStyleBackColor = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.BackColor = System.Drawing.Color.White
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(23, 36)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(250, 24)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código de Mantenimiento"
        '
        'gpbEliminarApto
        '
        Me.gpbEliminarApto.BackColor = System.Drawing.Color.Transparent
        Me.gpbEliminarApto.Controls.Add(Me.cmbMNombre)
        Me.gpbEliminarApto.Controls.Add(Me.cmbMCod_Apto)
        Me.gpbEliminarApto.Controls.Add(Me.lblNombre)
        Me.gpbEliminarApto.Controls.Add(Me.lblCod_Apto)
        Me.gpbEliminarApto.Controls.Add(Me.BtnEliminar_Apto)
        Me.gpbEliminarApto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbEliminarApto.Location = New System.Drawing.Point(401, 80)
        Me.gpbEliminarApto.Name = "gpbEliminarApto"
        Me.gpbEliminarApto.Size = New System.Drawing.Size(321, 320)
        Me.gpbEliminarApto.TabIndex = 7
        Me.gpbEliminarApto.TabStop = False
        Me.gpbEliminarApto.Text = "Eliminar Apartamento"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(46, 115)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(239, 24)
        Me.lblNombre.TabIndex = 14
        Me.lblNombre.Text = "Nombre de Apartamento"
        '
        'lblCod_Apto
        '
        Me.lblCod_Apto.AutoSize = True
        Me.lblCod_Apto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod_Apto.Location = New System.Drawing.Point(49, 36)
        Me.lblCod_Apto.Name = "lblCod_Apto"
        Me.lblCod_Apto.Size = New System.Drawing.Size(231, 24)
        Me.lblCod_Apto.TabIndex = 11
        Me.lblCod_Apto.Text = "Código de Apartamento"
        '
        'BtnEliminar_Apto
        '
        Me.BtnEliminar_Apto.Location = New System.Drawing.Point(57, 224)
        Me.BtnEliminar_Apto.Name = "BtnEliminar_Apto"
        Me.BtnEliminar_Apto.Size = New System.Drawing.Size(216, 52)
        Me.BtnEliminar_Apto.TabIndex = 5
        Me.BtnEliminar_Apto.Text = "Eliminar Apartamento"
        Me.BtnEliminar_Apto.UseVisualStyleBackColor = True
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruccion.Location = New System.Drawing.Point(49, 35)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(656, 29)
        Me.lblInstruccion.TabIndex = 8
        Me.lblInstruccion.Text = "Escoja una de las dos tablas en las que desea Eliminar"
        '
        'cmbMCodigo
        '
        Me.cmbMCodigo.FormattingEnabled = True
        Me.cmbMCodigo.Location = New System.Drawing.Point(79, 75)
        Me.cmbMCodigo.Name = "cmbMCodigo"
        Me.cmbMCodigo.Size = New System.Drawing.Size(121, 24)
        Me.cmbMCodigo.TabIndex = 13
        '
        'cmbMCod_Apto
        '
        Me.cmbMCod_Apto.FormattingEnabled = True
        Me.cmbMCod_Apto.Location = New System.Drawing.Point(101, 75)
        Me.cmbMCod_Apto.Name = "cmbMCod_Apto"
        Me.cmbMCod_Apto.Size = New System.Drawing.Size(121, 24)
        Me.cmbMCod_Apto.TabIndex = 15
        '
        'cmbMNombre
        '
        Me.cmbMNombre.FormattingEnabled = True
        Me.cmbMNombre.Location = New System.Drawing.Point(85, 158)
        Me.cmbMNombre.Name = "cmbMNombre"
        Me.cmbMNombre.Size = New System.Drawing.Size(168, 24)
        Me.cmbMNombre.TabIndex = 16
        '
        'FrmEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(756, 493)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Controls.Add(Me.gpbEliminarApto)
        Me.Controls.Add(Me.gpbEliminar)
        Me.Controls.Add(Me.MnuMantenimiento)
        Me.Name = "FrmEliminar"
        Me.Text = "Eliminar"
        Me.MnuMantenimiento.ResumeLayout(False)
        Me.MnuMantenimiento.PerformLayout()
        Me.gpbEliminar.ResumeLayout(False)
        Me.gpbEliminar.PerformLayout()
        Me.gpbEliminarApto.ResumeLayout(False)
        Me.gpbEliminarApto.PerformLayout()
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
    Friend WithEvents gpbEliminar As GroupBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents gpbEliminarApto As GroupBox
    Friend WithEvents lblCod_Apto As Label
    Friend WithEvents BtnEliminar_Apto As Button
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents ApartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNombre As Label
    Friend WithEvents BtnEliminarEstado_Mant As Button
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents cmbMCodigo As ComboBox
    Friend WithEvents cmbMCod_Apto As ComboBox
    Friend WithEvents cmbMNombre As ComboBox
End Class
