<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.LblGuardar = New System.Windows.Forms.Label()
        Me.LblNuevo = New System.Windows.Forms.Label()
        Me.LblCancelar = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbArticulos = New System.Windows.Forms.GroupBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPresentacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtCodProducto = New System.Windows.Forms.TextBox()
        Me.lblCodPresentacion = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.TxtFechaVence = New System.Windows.Forms.TextBox()
        Me.LblFechaVence = New System.Windows.Forms.Label()
        Me.NuDiasPlazo = New System.Windows.Forms.NumericUpDown()
        Me.LblDias = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtCodFactura = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lsvMostrar = New System.Windows.Forms.ListView()
        Me.ChCod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpcion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIsv = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.BtnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.gbArticulos.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        CType(Me.NuDiasPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsOpcion.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(204, 624)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(47, 43)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(360, 624)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(46, 42)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'LblGuardar
        '
        Me.LblGuardar.AutoSize = True
        Me.LblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.LblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardar.Location = New System.Drawing.Point(356, 667)
        Me.LblGuardar.Name = "LblGuardar"
        Me.LblGuardar.Size = New System.Drawing.Size(57, 16)
        Me.LblGuardar.TabIndex = 68
        Me.LblGuardar.Text = "Guardar"
        '
        'LblNuevo
        '
        Me.LblNuevo.AutoSize = True
        Me.LblNuevo.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevo.Location = New System.Drawing.Point(204, 666)
        Me.LblNuevo.Name = "LblNuevo"
        Me.LblNuevo.Size = New System.Drawing.Size(48, 16)
        Me.LblNuevo.TabIndex = 67
        Me.LblNuevo.Text = "Nuevo"
        '
        'LblCancelar
        '
        Me.LblCancelar.AutoSize = True
        Me.LblCancelar.BackColor = System.Drawing.Color.Transparent
        Me.LblCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancelar.Location = New System.Drawing.Point(514, 665)
        Me.LblCancelar.Name = "LblCancelar"
        Me.LblCancelar.Size = New System.Drawing.Size(62, 16)
        Me.LblCancelar.TabIndex = 72
        Me.LblCancelar.Text = "Cancelar"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(522, 629)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 33)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gbArticulos
        '
        Me.gbArticulos.BackColor = System.Drawing.Color.Transparent
        Me.gbArticulos.Controls.Add(Me.txtUnidad)
        Me.gbArticulos.Controls.Add(Me.Label5)
        Me.gbArticulos.Controls.Add(Me.txtPresentacion)
        Me.gbArticulos.Controls.Add(Me.Label14)
        Me.gbArticulos.Controls.Add(Me.btnBuscarProducto)
        Me.gbArticulos.Controls.Add(Me.btnAgregar)
        Me.gbArticulos.Controls.Add(Me.txtPrecio)
        Me.gbArticulos.Controls.Add(Me.Label1)
        Me.gbArticulos.Controls.Add(Me.txtCantidad)
        Me.gbArticulos.Controls.Add(Me.label6)
        Me.gbArticulos.Controls.Add(Me.txtCodProducto)
        Me.gbArticulos.Controls.Add(Me.lblCodPresentacion)
        Me.gbArticulos.Controls.Add(Me.label7)
        Me.gbArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbArticulos.Location = New System.Drawing.Point(24, 226)
        Me.gbArticulos.Name = "gbArticulos"
        Me.gbArticulos.Size = New System.Drawing.Size(936, 72)
        Me.gbArticulos.TabIndex = 2
        Me.gbArticulos.TabStop = False
        Me.gbArticulos.Text = "Articulos"
        '
        'txtUnidad
        '
        Me.txtUnidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtUnidad.Enabled = False
        Me.txtUnidad.Location = New System.Drawing.Point(467, 28)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(81, 20)
        Me.txtUnidad.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(409, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Unidades"
        '
        'txtPresentacion
        '
        Me.txtPresentacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtPresentacion.Enabled = False
        Me.txtPresentacion.Location = New System.Drawing.Point(305, 28)
        Me.txtPresentacion.Name = "txtPresentacion"
        Me.txtPresentacion.Size = New System.Drawing.Size(100, 20)
        Me.txtPresentacion.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(230, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Presentación"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.BackgroundImage = CType(resources.GetObject("btnBuscarProducto.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarProducto.FlatAppearance.BorderSize = 0
        Me.btnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Location = New System.Drawing.Point(189, 25)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(26, 23)
        Me.btnBuscarProducto.TabIndex = 6
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(843, 27)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrecio.Location = New System.Drawing.Point(601, 29)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(81, 20)
        Me.txtPrecio.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Precio"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.Location = New System.Drawing.Point(748, 29)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(81, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(693, 32)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(49, 13)
        Me.label6.TabIndex = 14
        Me.label6.Text = "Cantidad"
        '
        'txtCodProducto
        '
        Me.txtCodProducto.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodProducto.Enabled = False
        Me.txtCodProducto.Location = New System.Drawing.Point(102, 27)
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.Size = New System.Drawing.Size(81, 20)
        Me.txtCodProducto.TabIndex = 13
        '
        'lblCodPresentacion
        '
        Me.lblCodPresentacion.AutoSize = True
        Me.lblCodPresentacion.BackColor = System.Drawing.Color.Transparent
        Me.lblCodPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPresentacion.Location = New System.Drawing.Point(227, 11)
        Me.lblCodPresentacion.Name = "lblCodPresentacion"
        Me.lblCodPresentacion.Size = New System.Drawing.Size(0, 37)
        Me.lblCodPresentacion.TabIndex = 14
        Me.lblCodPresentacion.Visible = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(10, 31)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(86, 13)
        Me.label7.TabIndex = 12
        Me.label7.Text = "Código Producto"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.TxtFechaVence)
        Me.gbDatos.Controls.Add(Me.LblFechaVence)
        Me.gbDatos.Controls.Add(Me.NuDiasPlazo)
        Me.gbDatos.Controls.Add(Me.LblDias)
        Me.gbDatos.Controls.Add(Me.Label10)
        Me.gbDatos.Controls.Add(Me.TxtNombreCliente)
        Me.gbDatos.Controls.Add(Me.dtpFecha)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.CboTipoPago)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.btnBuscarCliente)
        Me.gbDatos.Controls.Add(Me.txtCliente)
        Me.gbDatos.Controls.Add(Me.label3)
        Me.gbDatos.Controls.Add(Me.txtCodFactura)
        Me.gbDatos.Controls.Add(Me.Label11)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(24, 113)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(936, 107)
        Me.gbDatos.TabIndex = 1
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos de Factura"
        '
        'TxtFechaVence
        '
        Me.TxtFechaVence.Location = New System.Drawing.Point(776, 61)
        Me.TxtFechaVence.Name = "TxtFechaVence"
        Me.TxtFechaVence.ReadOnly = True
        Me.TxtFechaVence.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaVence.TabIndex = 19
        '
        'LblFechaVence
        '
        Me.LblFechaVence.AutoSize = True
        Me.LblFechaVence.Location = New System.Drawing.Point(699, 64)
        Me.LblFechaVence.Name = "LblFechaVence"
        Me.LblFechaVence.Size = New System.Drawing.Size(71, 13)
        Me.LblFechaVence.TabIndex = 18
        Me.LblFechaVence.Text = "Fecha Vence"
        '
        'NuDiasPlazo
        '
        Me.NuDiasPlazo.Location = New System.Drawing.Point(630, 61)
        Me.NuDiasPlazo.Name = "NuDiasPlazo"
        Me.NuDiasPlazo.Size = New System.Drawing.Size(51, 20)
        Me.NuDiasPlazo.TabIndex = 5
        '
        'LblDias
        '
        Me.LblDias.AutoSize = True
        Me.LblDias.Location = New System.Drawing.Point(565, 65)
        Me.LblDias.Name = "LblDias"
        Me.LblDias.Size = New System.Drawing.Size(59, 13)
        Me.LblDias.TabIndex = 16
        Me.LblDias.Text = "Días Plazo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(262, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Fecha"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Location = New System.Drawing.Point(376, 60)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.ReadOnly = True
        Me.TxtNombreCliente.Size = New System.Drawing.Size(183, 20)
        Me.TxtNombreCliente.TabIndex = 14
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(305, 25)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(196, 20)
        Me.dtpFecha.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Rtn Cliente"
        '
        'CboTipoPago
        '
        Me.CboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPago.FormattingEnabled = True
        Me.CboTipoPago.Location = New System.Drawing.Point(621, 24)
        Me.CboTipoPago.Name = "CboTipoPago"
        Me.CboTipoPago.Size = New System.Drawing.Size(121, 21)
        Me.CboTipoPago.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(548, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tipo Venta"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackgroundImage = CType(resources.GetObject("btnBuscarCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCliente.Location = New System.Drawing.Point(259, 60)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(26, 23)
        Me.btnBuscarCliente.TabIndex = 4
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(85, 60)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(171, 20)
        Me.txtCliente.TabIndex = 10
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(291, 63)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(79, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Nombre Cliente"
        '
        'txtCodFactura
        '
        Me.txtCodFactura.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodFactura.Enabled = False
        Me.txtCodFactura.Location = New System.Drawing.Point(102, 25)
        Me.txtCodFactura.Name = "txtCodFactura"
        Me.txtCodFactura.Size = New System.Drawing.Size(154, 20)
        Me.txtCodFactura.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Código Factura"
        '
        'lsvMostrar
        '
        Me.lsvMostrar.AllowColumnReorder = True
        Me.lsvMostrar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCod, Me.chNombre, Me.chTipo, Me.chPrecio, Me.chCantidad, Me.chTotal})
        Me.lsvMostrar.ContextMenuStrip = Me.CmsOpcion
        Me.lsvMostrar.FullRowSelect = True
        Me.lsvMostrar.Location = New System.Drawing.Point(24, 314)
        Me.lsvMostrar.Name = "lsvMostrar"
        Me.lsvMostrar.Size = New System.Drawing.Size(936, 284)
        Me.lsvMostrar.TabIndex = 79
        Me.lsvMostrar.UseCompatibleStateImageBehavior = False
        Me.lsvMostrar.View = System.Windows.Forms.View.Details
        '
        'ChCod
        '
        Me.ChCod.Text = "Código Producto"
        Me.ChCod.Width = 130
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre Producto"
        Me.chNombre.Width = 200
        '
        'chTipo
        '
        Me.chTipo.Text = "Presentación"
        Me.chTipo.Width = 200
        '
        'chPrecio
        '
        Me.chPrecio.Text = "Precio"
        Me.chPrecio.Width = 130
        '
        'chCantidad
        '
        Me.chCantidad.Text = "Cantidad"
        Me.chCantidad.Width = 130
        '
        'chTotal
        '
        Me.chTotal.Text = "Total"
        Me.chTotal.Width = 141
        '
        'CmsOpcion
        '
        Me.CmsOpcion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarItemToolStripMenuItem})
        Me.CmsOpcion.Name = "CmsOpcion"
        Me.CmsOpcion.Size = New System.Drawing.Size(135, 26)
        '
        'QuitarItemToolStripMenuItem
        '
        Me.QuitarItemToolStripMenuItem.Name = "QuitarItemToolStripMenuItem"
        Me.QuitarItemToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.QuitarItemToolStripMenuItem.Text = "Quitar Item"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(834, 610)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(126, 20)
        Me.txtSubTotal.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(782, 613)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Subtotal"
        '
        'txtIsv
        '
        Me.txtIsv.BackColor = System.Drawing.SystemColors.Window
        Me.txtIsv.Enabled = False
        Me.txtIsv.Location = New System.Drawing.Point(834, 636)
        Me.txtIsv.Name = "txtIsv"
        Me.txtIsv.Size = New System.Drawing.Size(126, 20)
        Me.txtIsv.TabIndex = 81
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(782, 639)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Impuesto"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(834, 662)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(126, 20)
        Me.txtTotal.TabIndex = 83
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(797, 665)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Total"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(67, 611)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreProducto.TabIndex = 84
        Me.lblNombreProducto.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(504, 111)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.Location = New System.Drawing.Point(24, 632)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(96, 49)
        Me.BtnImprimir.TabIndex = 86
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.Visible = False
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(979, 703)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtIsv)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lsvMostrar)
        Me.Controls.Add(Me.gbArticulos)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.LblGuardar)
        Me.Controls.Add(Me.LblNuevo)
        Me.Controls.Add(Me.LblCancelar)
        Me.Controls.Add(Me.btnCancelar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Venta"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.gbArticulos.ResumeLayout(False)
        Me.gbArticulos.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.NuDiasPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsOpcion.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents LblGuardar As Label
    Friend WithEvents LblNuevo As Label
    Friend WithEvents LblCancelar As Label
    Friend WithEvents btnCancelar As Button
    Private WithEvents gbArticulos As GroupBox
    Private WithEvents btnBuscarProducto As Button
    Private WithEvents btnAgregar As Button
    Public WithEvents txtPrecio As TextBox
    Private WithEvents Label1 As Label
    Public WithEvents txtCantidad As TextBox
    Private WithEvents label6 As Label
    Public WithEvents txtCodProducto As TextBox
    Private WithEvents label7 As Label
    Private WithEvents gbDatos As GroupBox
    Private WithEvents btnBuscarCliente As Button
    Public WithEvents txtCliente As TextBox
    Private WithEvents dtpFecha As DateTimePicker
    Private WithEvents label3 As Label
    Private WithEvents txtCodFactura As TextBox
    Private WithEvents lblCodPresentacion As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label14 As Label
    Private WithEvents txtPresentacion As TextBox
    Friend WithEvents lsvMostrar As ListView
    Friend WithEvents ChCod As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chTipo As ColumnHeader
    Friend WithEvents chPrecio As ColumnHeader
    Friend WithEvents chCantidad As ColumnHeader
    Friend WithEvents chTotal As ColumnHeader
    Private WithEvents txtSubTotal As TextBox
    Private WithEvents Label15 As Label
    Private WithEvents txtIsv As TextBox
    Private WithEvents Label16 As Label
    Private WithEvents txtTotal As TextBox
    Private WithEvents Label17 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Public WithEvents txtUnidad As TextBox
    Private WithEvents Label5 As Label
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents CboTipoPago As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFechaVence As TextBox
    Friend WithEvents LblFechaVence As Label
    Friend WithEvents NuDiasPlazo As NumericUpDown
    Friend WithEvents LblDias As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CmsOpcion As ContextMenuStrip
    Friend WithEvents QuitarItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnImprimir As DevExpress.XtraEditors.SimpleButton
End Class
