<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificar))
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
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.gpbModificarApto = New System.Windows.Forms.GroupBox()
        Me.cmbCod_Apto = New System.Windows.Forms.ComboBox()
        Me.lblCod_Apto = New System.Windows.Forms.Label()
        Me.txtCosto_Alq = New System.Windows.Forms.TextBox()
        Me.lblCostoAlq = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtRecamaras = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCod_Pro = New System.Windows.Forms.TextBox()
        Me.BtnModificar_Apto = New System.Windows.Forms.Button()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.lblRecamaras = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCod_Pro = New System.Windows.Forms.Label()
        Me.gpbModificarM = New System.Windows.Forms.GroupBox()
        Me.cmbCodigo = New System.Windows.Forms.ComboBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCod_AptoM = New System.Windows.Forms.TextBox()
        Me.lblCod_AptoM = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnModificar_Mant = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.MnuMantenimiento.SuspendLayout()
        Me.gpbModificarApto.SuspendLayout()
        Me.gpbModificarM.SuspendLayout()
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
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruccion.Location = New System.Drawing.Point(51, 34)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(668, 29)
        Me.lblInstruccion.TabIndex = 9
        Me.lblInstruccion.Text = "Escoja una de las dos tablas en las que desea Modificar"
        '
        'gpbModificarApto
        '
        Me.gpbModificarApto.BackColor = System.Drawing.Color.Transparent
        Me.gpbModificarApto.Controls.Add(Me.cmbCod_Apto)
        Me.gpbModificarApto.Controls.Add(Me.lblCod_Apto)
        Me.gpbModificarApto.Controls.Add(Me.txtCosto_Alq)
        Me.gpbModificarApto.Controls.Add(Me.lblCostoAlq)
        Me.gpbModificarApto.Controls.Add(Me.txtAño)
        Me.gpbModificarApto.Controls.Add(Me.txtValor)
        Me.gpbModificarApto.Controls.Add(Me.lblValor)
        Me.gpbModificarApto.Controls.Add(Me.txtRecamaras)
        Me.gpbModificarApto.Controls.Add(Me.txtNombre)
        Me.gpbModificarApto.Controls.Add(Me.txtCod_Pro)
        Me.gpbModificarApto.Controls.Add(Me.BtnModificar_Apto)
        Me.gpbModificarApto.Controls.Add(Me.lblAño)
        Me.gpbModificarApto.Controls.Add(Me.lblRecamaras)
        Me.gpbModificarApto.Controls.Add(Me.lblNombre)
        Me.gpbModificarApto.Controls.Add(Me.lblCod_Pro)
        Me.gpbModificarApto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbModificarApto.Location = New System.Drawing.Point(388, 72)
        Me.gpbModificarApto.Name = "gpbModificarApto"
        Me.gpbModificarApto.Size = New System.Drawing.Size(321, 437)
        Me.gpbModificarApto.TabIndex = 11
        Me.gpbModificarApto.TabStop = False
        Me.gpbModificarApto.Text = "Modificar Apartamento"
        '
        'cmbCod_Apto
        '
        Me.cmbCod_Apto.FormattingEnabled = True
        Me.cmbCod_Apto.Location = New System.Drawing.Point(129, 46)
        Me.cmbCod_Apto.Name = "cmbCod_Apto"
        Me.cmbCod_Apto.Size = New System.Drawing.Size(121, 24)
        Me.cmbCod_Apto.TabIndex = 19
        '
        'lblCod_Apto
        '
        Me.lblCod_Apto.AutoSize = True
        Me.lblCod_Apto.Location = New System.Drawing.Point(8, 27)
        Me.lblCod_Apto.Name = "lblCod_Apto"
        Me.lblCod_Apto.Size = New System.Drawing.Size(307, 16)
        Me.lblCod_Apto.TabIndex = 18
        Me.lblCod_Apto.Text = "Cod de Apto donde se hará la modificación"
        '
        'txtCosto_Alq
        '
        Me.txtCosto_Alq.Location = New System.Drawing.Point(108, 344)
        Me.txtCosto_Alq.Name = "txtCosto_Alq"
        Me.txtCosto_Alq.Size = New System.Drawing.Size(169, 22)
        Me.txtCosto_Alq.TabIndex = 17
        '
        'lblCostoAlq
        '
        Me.lblCostoAlq.AutoSize = True
        Me.lblCostoAlq.BackColor = System.Drawing.Color.White
        Me.lblCostoAlq.Location = New System.Drawing.Point(83, 325)
        Me.lblCostoAlq.Name = "lblCostoAlq"
        Me.lblCostoAlq.Size = New System.Drawing.Size(127, 16)
        Me.lblCostoAlq.TabIndex = 16
        Me.lblCostoAlq.Text = "Costo de Alquiler"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(109, 290)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(169, 22)
        Me.txtAño.TabIndex = 15
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(109, 247)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(168, 22)
        Me.txtValor.TabIndex = 14
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.BackColor = System.Drawing.Color.White
        Me.lblValor.Location = New System.Drawing.Point(87, 228)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(45, 16)
        Me.lblValor.TabIndex = 13
        Me.lblValor.Text = "Valor"
        '
        'txtRecamaras
        '
        Me.txtRecamaras.Location = New System.Drawing.Point(108, 194)
        Me.txtRecamaras.Multiline = True
        Me.txtRecamaras.Name = "txtRecamaras"
        Me.txtRecamaras.Size = New System.Drawing.Size(169, 24)
        Me.txtRecamaras.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(108, 151)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(169, 22)
        Me.txtNombre.TabIndex = 8
        '
        'txtCod_Pro
        '
        Me.txtCod_Pro.Location = New System.Drawing.Point(106, 101)
        Me.txtCod_Pro.Name = "txtCod_Pro"
        Me.txtCod_Pro.Size = New System.Drawing.Size(171, 22)
        Me.txtCod_Pro.TabIndex = 6
        '
        'BtnModificar_Apto
        '
        Me.BtnModificar_Apto.Location = New System.Drawing.Point(86, 391)
        Me.BtnModificar_Apto.Name = "BtnModificar_Apto"
        Me.BtnModificar_Apto.Size = New System.Drawing.Size(191, 40)
        Me.BtnModificar_Apto.TabIndex = 5
        Me.BtnModificar_Apto.Text = "Modificar Apartamento"
        Me.BtnModificar_Apto.UseVisualStyleBackColor = True
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.BackColor = System.Drawing.Color.White
        Me.lblAño.Location = New System.Drawing.Point(87, 271)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(35, 16)
        Me.lblAño.TabIndex = 4
        Me.lblAño.Text = "Año"
        '
        'lblRecamaras
        '
        Me.lblRecamaras.AutoSize = True
        Me.lblRecamaras.BackColor = System.Drawing.Color.White
        Me.lblRecamaras.Location = New System.Drawing.Point(85, 177)
        Me.lblRecamaras.Name = "lblRecamaras"
        Me.lblRecamaras.Size = New System.Drawing.Size(88, 16)
        Me.lblRecamaras.TabIndex = 3
        Me.lblRecamaras.Text = "Recámaras"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(87, 129)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 16)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblCod_Pro
        '
        Me.lblCod_Pro.AutoSize = True
        Me.lblCod_Pro.Location = New System.Drawing.Point(64, 74)
        Me.lblCod_Pro.Name = "lblCod_Pro"
        Me.lblCod_Pro.Size = New System.Drawing.Size(161, 16)
        Me.lblCod_Pro.TabIndex = 0
        Me.lblCod_Pro.Text = "Código de Propietario"
        '
        'gpbModificarM
        '
        Me.gpbModificarM.BackColor = System.Drawing.Color.Transparent
        Me.gpbModificarM.Controls.Add(Me.cmbCodigo)
        Me.gpbModificarM.Controls.Add(Me.lblCodigo)
        Me.gpbModificarM.Controls.Add(Me.txtCod_AptoM)
        Me.gpbModificarM.Controls.Add(Me.lblCod_AptoM)
        Me.gpbModificarM.Controls.Add(Me.cmbEstado)
        Me.gpbModificarM.Controls.Add(Me.txtDescripcion)
        Me.gpbModificarM.Controls.Add(Me.txtCosto)
        Me.gpbModificarM.Controls.Add(Me.dtpFecha)
        Me.gpbModificarM.Controls.Add(Me.btnModificar_Mant)
        Me.gpbModificarM.Controls.Add(Me.lblEstado)
        Me.gpbModificarM.Controls.Add(Me.lblDescripcion)
        Me.gpbModificarM.Controls.Add(Me.lblCosto)
        Me.gpbModificarM.Controls.Add(Me.lblFecha)
        Me.gpbModificarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbModificarM.Location = New System.Drawing.Point(47, 72)
        Me.gpbModificarM.Name = "gpbModificarM"
        Me.gpbModificarM.Size = New System.Drawing.Size(320, 437)
        Me.gpbModificarM.TabIndex = 10
        Me.gpbModificarM.TabStop = False
        Me.gpbModificarM.Text = "Modificar Mantenimiento"
        '
        'cmbCodigo
        '
        Me.cmbCodigo.FormattingEnabled = True
        Me.cmbCodigo.Location = New System.Drawing.Point(124, 46)
        Me.cmbCodigo.Name = "cmbCodigo"
        Me.cmbCodigo.Size = New System.Drawing.Size(121, 24)
        Me.cmbCodigo.TabIndex = 14
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.BackColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(53, 27)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(251, 16)
        Me.lblCodigo.TabIndex = 13
        Me.lblCodigo.Text = "Cod_Mantenimiento que modificará"
        '
        'txtCod_AptoM
        '
        Me.txtCod_AptoM.Location = New System.Drawing.Point(106, 101)
        Me.txtCod_AptoM.Name = "txtCod_AptoM"
        Me.txtCod_AptoM.Size = New System.Drawing.Size(171, 22)
        Me.txtCod_AptoM.TabIndex = 12
        '
        'lblCod_AptoM
        '
        Me.lblCod_AptoM.AutoSize = True
        Me.lblCod_AptoM.BackColor = System.Drawing.Color.White
        Me.lblCod_AptoM.Location = New System.Drawing.Point(73, 82)
        Me.lblCod_AptoM.Name = "lblCod_AptoM"
        Me.lblCod_AptoM.Size = New System.Drawing.Size(172, 16)
        Me.lblCod_AptoM.TabIndex = 11
        Me.lblCod_AptoM.Text = "Código de Apartamento"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"P", "R", "C"})
        Me.cmbEstado.Location = New System.Drawing.Point(106, 364)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(169, 24)
        Me.cmbEstado.TabIndex = 10
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(106, 267)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(169, 74)
        Me.txtDescripcion.TabIndex = 9
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(108, 225)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(169, 22)
        Me.txtCosto.TabIndex = 8
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(104, 171)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(171, 22)
        Me.dtpFecha.TabIndex = 7
        '
        'btnModificar_Mant
        '
        Me.btnModificar_Mant.Location = New System.Drawing.Point(80, 391)
        Me.btnModificar_Mant.Name = "btnModificar_Mant"
        Me.btnModificar_Mant.Size = New System.Drawing.Size(191, 40)
        Me.btnModificar_Mant.TabIndex = 5
        Me.btnModificar_Mant.Text = "Modificar Mantenimiento"
        Me.btnModificar_Mant.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(73, 344)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(57, 16)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "Estado"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.White
        Me.lblDescripcion.Location = New System.Drawing.Point(73, 248)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(91, 16)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.BackColor = System.Drawing.Color.White
        Me.lblCosto.Location = New System.Drawing.Point(80, 202)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(48, 16)
        Me.lblCosto.TabIndex = 2
        Me.lblCosto.Text = "Costo"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(77, 140)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(51, 16)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'FrmModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(756, 534)
        Me.Controls.Add(Me.gpbModificarApto)
        Me.Controls.Add(Me.gpbModificarM)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Controls.Add(Me.MnuMantenimiento)
        Me.Name = "FrmModificar"
        Me.Text = "Modificar"
        Me.MnuMantenimiento.ResumeLayout(False)
        Me.MnuMantenimiento.PerformLayout()
        Me.gpbModificarApto.ResumeLayout(False)
        Me.gpbModificarApto.PerformLayout()
        Me.gpbModificarM.ResumeLayout(False)
        Me.gpbModificarM.PerformLayout()
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
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents gpbModificarApto As GroupBox
    Friend WithEvents txtCosto_Alq As TextBox
    Friend WithEvents lblCostoAlq As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents txtRecamaras As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCod_Pro As TextBox
    Friend WithEvents BtnModificar_Apto As Button
    Friend WithEvents lblAño As Label
    Friend WithEvents lblRecamaras As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCod_Pro As Label
    Friend WithEvents gpbModificarM As GroupBox
    Friend WithEvents txtCod_AptoM As TextBox
    Friend WithEvents lblCod_AptoM As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnModificar_Mant As Button
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCosto As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents ApartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCod_Apto As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents cmbCod_Apto As ComboBox
    Friend WithEvents cmbCodigo As ComboBox
End Class
