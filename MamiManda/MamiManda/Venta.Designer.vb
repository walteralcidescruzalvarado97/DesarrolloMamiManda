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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtCodFactura = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lsvMostrar = New System.Windows.Forms.ListView()
        Me.ChCod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.gbArticulos.SuspendLayout()
        Me.gbDatos.SuspendLayout()
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
        Me.btnNuevo.Location = New System.Drawing.Point(204, 558)
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
        Me.btnGuardar.Location = New System.Drawing.Point(360, 558)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(46, 42)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(356, 601)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Guardar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(204, 600)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Nuevo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(514, 599)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Cancelar"
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
        Me.btnCancelar.Location = New System.Drawing.Point(522, 563)
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
        Me.gbArticulos.Location = New System.Drawing.Point(24, 176)
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
        Me.btnBuscarProducto.TabIndex = 2
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(843, 27)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 4
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
        Me.txtCantidad.TabIndex = 3
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
        Me.gbDatos.Controls.Add(Me.btnBuscarCliente)
        Me.gbDatos.Controls.Add(Me.txtCliente)
        Me.gbDatos.Controls.Add(Me.label3)
        Me.gbDatos.Controls.Add(Me.txtCodFactura)
        Me.gbDatos.Controls.Add(Me.Label11)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(24, 113)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(599, 57)
        Me.gbDatos.TabIndex = 1
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos de Factura"
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
        Me.btnBuscarCliente.Location = New System.Drawing.Point(442, 23)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(26, 23)
        Me.btnBuscarCliente.TabIndex = 1
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(265, 25)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(171, 20)
        Me.txtCliente.TabIndex = 10
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(220, 28)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Cliente"
        '
        'txtCodFactura
        '
        Me.txtCodFactura.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodFactura.Enabled = False
        Me.txtCodFactura.Location = New System.Drawing.Point(102, 25)
        Me.txtCodFactura.Name = "txtCodFactura"
        Me.txtCodFactura.Size = New System.Drawing.Size(100, 20)
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
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(758, 27)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(196, 20)
        Me.dtpFecha.TabIndex = 15
        Me.dtpFecha.Visible = False
        '
        'lsvMostrar
        '
        Me.lsvMostrar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCod, Me.chNombre, Me.chTipo, Me.chPrecio, Me.chCantidad, Me.chTotal})
        Me.lsvMostrar.FullRowSelect = True
        Me.lsvMostrar.GridLines = True
        Me.lsvMostrar.Location = New System.Drawing.Point(24, 254)
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
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(834, 544)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(126, 20)
        Me.txtSubTotal.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(782, 547)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Subtotal"
        '
        'txtIsv
        '
        Me.txtIsv.BackColor = System.Drawing.SystemColors.Window
        Me.txtIsv.Enabled = False
        Me.txtIsv.Location = New System.Drawing.Point(834, 570)
        Me.txtIsv.Name = "txtIsv"
        Me.txtIsv.Size = New System.Drawing.Size(126, 20)
        Me.txtIsv.TabIndex = 81
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(782, 573)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Impuesto"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(834, 596)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(126, 20)
        Me.txtTotal.TabIndex = 83
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(797, 599)
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
        Me.lblNombreProducto.Location = New System.Drawing.Point(67, 504)
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
        Me.PictureBox1.Size = New System.Drawing.Size(483, 111)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(979, 631)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpFecha)
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
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCancelar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Venta"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        Me.gbArticulos.ResumeLayout(False)
        Me.gbArticulos.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
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
End Class
