<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdicionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdicionar))
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
        Me.gpbAdicionar = New System.Windows.Forms.GroupBox()
        Me.txtCod_AptoM = New System.Windows.Forms.TextBox()
        Me.lblCod_AptoM = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.gpbAdicionarApto = New System.Windows.Forms.GroupBox()
        Me.txtCosto_Alquiler = New System.Windows.Forms.TextBox()
        Me.lblCostoAl = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtCod_Pro = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtRecamaras = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.BtnAgregarApto = New System.Windows.Forms.Button()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.lblRecamaras = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCod_Pro = New System.Windows.Forms.Label()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.MnuMantenimiento.SuspendLayout()
        Me.gpbAdicionar.SuspendLayout()
        Me.gpbAdicionarApto.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuMantenimiento
        '
        Me.MnuMantenimiento.BackColor = System.Drawing.Color.Transparent
        Me.MnuMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrarToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MnuMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.MnuMantenimiento.Name = "MnuMantenimiento"
        Me.MnuMantenimiento.Size = New System.Drawing.Size(756, 24)
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
        'gpbAdicionar
        '
        Me.gpbAdicionar.BackColor = System.Drawing.Color.Transparent
        Me.gpbAdicionar.Controls.Add(Me.txtCod_AptoM)
        Me.gpbAdicionar.Controls.Add(Me.lblCod_AptoM)
        Me.gpbAdicionar.Controls.Add(Me.cmbEstado)
        Me.gpbAdicionar.Controls.Add(Me.txtDescripcion)
        Me.gpbAdicionar.Controls.Add(Me.txtCosto)
        Me.gpbAdicionar.Controls.Add(Me.dtpFecha)
        Me.gpbAdicionar.Controls.Add(Me.btnAgregar)
        Me.gpbAdicionar.Controls.Add(Me.lblEstado)
        Me.gpbAdicionar.Controls.Add(Me.lblDescripcion)
        Me.gpbAdicionar.Controls.Add(Me.lblCosto)
        Me.gpbAdicionar.Controls.Add(Me.lblFecha)
        Me.gpbAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAdicionar.Location = New System.Drawing.Point(41, 76)
        Me.gpbAdicionar.Name = "gpbAdicionar"
        Me.gpbAdicionar.Size = New System.Drawing.Size(320, 437)
        Me.gpbAdicionar.TabIndex = 5
        Me.gpbAdicionar.TabStop = False
        Me.gpbAdicionar.Text = "Adicionar Mantenimiento"
        '
        'txtCod_AptoM
        '
        Me.txtCod_AptoM.Location = New System.Drawing.Point(93, 77)
        Me.txtCod_AptoM.Name = "txtCod_AptoM"
        Me.txtCod_AptoM.Size = New System.Drawing.Size(171, 22)
        Me.txtCod_AptoM.TabIndex = 12
        '
        'lblCod_AptoM
        '
        Me.lblCod_AptoM.AutoSize = True
        Me.lblCod_AptoM.BackColor = System.Drawing.Color.White
        Me.lblCod_AptoM.Location = New System.Drawing.Point(66, 58)
        Me.lblCod_AptoM.Name = "lblCod_AptoM"
        Me.lblCod_AptoM.Size = New System.Drawing.Size(172, 16)
        Me.lblCod_AptoM.TabIndex = 11
        Me.lblCod_AptoM.Text = "Código de Apartamento"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"P", "R", "C"})
        Me.cmbEstado.Location = New System.Drawing.Point(91, 330)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(169, 24)
        Me.cmbEstado.TabIndex = 10
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(91, 233)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(169, 74)
        Me.txtDescripcion.TabIndex = 9
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(93, 191)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(169, 22)
        Me.txtCosto.TabIndex = 8
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(89, 138)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(171, 22)
        Me.dtpFecha.TabIndex = 7
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(69, 369)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(191, 40)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar Mantenimiento"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(58, 310)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(57, 16)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "Estado"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.White
        Me.lblDescripcion.Location = New System.Drawing.Point(58, 214)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(91, 16)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.BackColor = System.Drawing.Color.White
        Me.lblCosto.Location = New System.Drawing.Point(66, 172)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(48, 16)
        Me.lblCosto.TabIndex = 2
        Me.lblCosto.Text = "Costo"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(63, 117)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(51, 16)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'gpbAdicionarApto
        '
        Me.gpbAdicionarApto.BackColor = System.Drawing.Color.Transparent
        Me.gpbAdicionarApto.Controls.Add(Me.txtCosto_Alquiler)
        Me.gpbAdicionarApto.Controls.Add(Me.lblCostoAl)
        Me.gpbAdicionarApto.Controls.Add(Me.txtAño)
        Me.gpbAdicionarApto.Controls.Add(Me.txtValor)
        Me.gpbAdicionarApto.Controls.Add(Me.txtCod_Pro)
        Me.gpbAdicionarApto.Controls.Add(Me.lblValor)
        Me.gpbAdicionarApto.Controls.Add(Me.txtRecamaras)
        Me.gpbAdicionarApto.Controls.Add(Me.txtNombre)
        Me.gpbAdicionarApto.Controls.Add(Me.BtnAgregarApto)
        Me.gpbAdicionarApto.Controls.Add(Me.lblAño)
        Me.gpbAdicionarApto.Controls.Add(Me.lblRecamaras)
        Me.gpbAdicionarApto.Controls.Add(Me.lblNombre)
        Me.gpbAdicionarApto.Controls.Add(Me.lblCod_Pro)
        Me.gpbAdicionarApto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAdicionarApto.Location = New System.Drawing.Point(382, 76)
        Me.gpbAdicionarApto.Name = "gpbAdicionarApto"
        Me.gpbAdicionarApto.Size = New System.Drawing.Size(321, 437)
        Me.gpbAdicionarApto.TabIndex = 6
        Me.gpbAdicionarApto.TabStop = False
        Me.gpbAdicionarApto.Text = "Adicionar Apartamento"
        '
        'txtCosto_Alquiler
        '
        Me.txtCosto_Alquiler.Location = New System.Drawing.Point(88, 322)
        Me.txtCosto_Alquiler.Name = "txtCosto_Alquiler"
        Me.txtCosto_Alquiler.Size = New System.Drawing.Size(169, 22)
        Me.txtCosto_Alquiler.TabIndex = 17
        '
        'lblCostoAl
        '
        Me.lblCostoAl.AutoSize = True
        Me.lblCostoAl.BackColor = System.Drawing.Color.White
        Me.lblCostoAl.Location = New System.Drawing.Point(63, 303)
        Me.lblCostoAl.Name = "lblCostoAl"
        Me.lblCostoAl.Size = New System.Drawing.Size(127, 16)
        Me.lblCostoAl.TabIndex = 16
        Me.lblCostoAl.Text = "Costo de Alquiler"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(89, 268)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(169, 22)
        Me.txtAño.TabIndex = 15
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(89, 225)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(168, 22)
        Me.txtValor.TabIndex = 14
        '
        'txtCod_Pro
        '
        Me.txtCod_Pro.Location = New System.Drawing.Point(89, 70)
        Me.txtCod_Pro.Name = "txtCod_Pro"
        Me.txtCod_Pro.Size = New System.Drawing.Size(171, 22)
        Me.txtCod_Pro.TabIndex = 6
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.BackColor = System.Drawing.Color.White
        Me.lblValor.Location = New System.Drawing.Point(67, 206)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(45, 16)
        Me.lblValor.TabIndex = 13
        Me.lblValor.Text = "Valor"
        '
        'txtRecamaras
        '
        Me.txtRecamaras.Location = New System.Drawing.Point(88, 172)
        Me.txtRecamaras.Multiline = True
        Me.txtRecamaras.Name = "txtRecamaras"
        Me.txtRecamaras.Size = New System.Drawing.Size(169, 24)
        Me.txtRecamaras.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(88, 129)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(169, 22)
        Me.txtNombre.TabIndex = 8
        '
        'BtnAgregarApto
        '
        Me.BtnAgregarApto.Location = New System.Drawing.Point(66, 369)
        Me.BtnAgregarApto.Name = "BtnAgregarApto"
        Me.BtnAgregarApto.Size = New System.Drawing.Size(191, 40)
        Me.BtnAgregarApto.TabIndex = 5
        Me.BtnAgregarApto.Text = "Agregar Apartamento"
        Me.BtnAgregarApto.UseVisualStyleBackColor = True
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.BackColor = System.Drawing.Color.White
        Me.lblAño.Location = New System.Drawing.Point(67, 249)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(35, 16)
        Me.lblAño.TabIndex = 4
        Me.lblAño.Text = "Año"
        '
        'lblRecamaras
        '
        Me.lblRecamaras.AutoSize = True
        Me.lblRecamaras.BackColor = System.Drawing.Color.White
        Me.lblRecamaras.Location = New System.Drawing.Point(65, 155)
        Me.lblRecamaras.Name = "lblRecamaras"
        Me.lblRecamaras.Size = New System.Drawing.Size(88, 16)
        Me.lblRecamaras.TabIndex = 3
        Me.lblRecamaras.Text = "Recámaras"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(67, 107)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 16)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblCod_Pro
        '
        Me.lblCod_Pro.AutoSize = True
        Me.lblCod_Pro.BackColor = System.Drawing.Color.White
        Me.lblCod_Pro.Location = New System.Drawing.Point(38, 49)
        Me.lblCod_Pro.Name = "lblCod_Pro"
        Me.lblCod_Pro.Size = New System.Drawing.Size(161, 16)
        Me.lblCod_Pro.TabIndex = 0
        Me.lblCod_Pro.Text = "Código de Propietario"
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruccion.Location = New System.Drawing.Point(48, 33)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(670, 29)
        Me.lblInstruccion.TabIndex = 7
        Me.lblInstruccion.Text = "Escoja una de las dos tablas en las que desea Adicionar"
        '
        'FrmAdicionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(756, 525)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Controls.Add(Me.gpbAdicionarApto)
        Me.Controls.Add(Me.gpbAdicionar)
        Me.Controls.Add(Me.MnuMantenimiento)
        Me.Name = "FrmAdicionar"
        Me.Text = "Adicionar"
        Me.MnuMantenimiento.ResumeLayout(False)
        Me.MnuMantenimiento.PerformLayout()
        Me.gpbAdicionar.ResumeLayout(False)
        Me.gpbAdicionar.PerformLayout()
        Me.gpbAdicionarApto.ResumeLayout(False)
        Me.gpbAdicionarApto.PerformLayout()
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
    Friend WithEvents gpbAdicionar As GroupBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCosto As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents gpbAdicionarApto As GroupBox
    Friend WithEvents txtCosto_Alquiler As TextBox
    Friend WithEvents lblCostoAl As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents txtRecamaras As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCod_Pro As TextBox
    Friend WithEvents BtnAgregarApto As Button
    Friend WithEvents lblAño As Label
    Friend WithEvents lblRecamaras As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCod_Pro As Label
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents txtCod_AptoM As TextBox
    Friend WithEvents lblCod_AptoM As Label
    Friend WithEvents ApartamentoToolStripMenuItem As ToolStripMenuItem
End Class
