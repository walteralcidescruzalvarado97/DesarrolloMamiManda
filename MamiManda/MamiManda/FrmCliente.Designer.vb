<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.LsvMostrarCliente = New System.Windows.Forms.ListView()
        Me.chRtn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMunicipio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.cboMunicipio = New System.Windows.Forms.ComboBox()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRtn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkVer = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbDatos.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LsvMostrarCliente
        '
        Me.LsvMostrarCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRtn, Me.chNombre, Me.chApellido, Me.chEmail, Me.chTelefono, Me.chDireccion, Me.chFecha, Me.chSexo, Me.chMunicipio})
        Me.LsvMostrarCliente.FullRowSelect = True
        Me.LsvMostrarCliente.Location = New System.Drawing.Point(82, 583)
        Me.LsvMostrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.LsvMostrarCliente.Name = "LsvMostrarCliente"
        Me.LsvMostrarCliente.Size = New System.Drawing.Size(720, 170)
        Me.LsvMostrarCliente.TabIndex = 109
        Me.LsvMostrarCliente.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarCliente.View = System.Windows.Forms.View.Details
        '
        'chRtn
        '
        Me.chRtn.Text = "RtnCLiente"
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre"
        '
        'chApellido
        '
        Me.chApellido.Text = "Apellido"
        '
        'chEmail
        '
        Me.chEmail.Text = "Email"
        '
        'chTelefono
        '
        Me.chTelefono.Text = "Teléfono"
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Dirección"
        '
        'chFecha
        '
        Me.chFecha.Text = "Fecha"
        '
        'chSexo
        '
        Me.chSexo.Text = "Sexo"
        '
        'chMunicipio
        '
        Me.chMunicipio.Text = "Municipio"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(352, 5)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(200, 31)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "Gestión Cliente"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.txtFecha)
        Me.gbDatos.Controls.Add(Me.cboMunicipio)
        Me.gbDatos.Controls.Add(Me.cboSexo)
        Me.gbDatos.Controls.Add(Me.Label12)
        Me.gbDatos.Controls.Add(Me.Label11)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.txtDireccion)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.mtbTelefono)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.txtEmail)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.txtApellido)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.txtRtn)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Location = New System.Drawing.Point(130, 53)
        Me.gbDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDatos.Size = New System.Drawing.Size(500, 438)
        Me.gbDatos.TabIndex = 107
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos de Proveedor"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(171, 327)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(160, 22)
        Me.txtFecha.TabIndex = 20
        '
        'cboMunicipio
        '
        Me.cboMunicipio.FormattingEnabled = True
        Me.cboMunicipio.Location = New System.Drawing.Point(171, 395)
        Me.cboMunicipio.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Size = New System.Drawing.Size(160, 24)
        Me.cboMunicipio.TabIndex = 19
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Location = New System.Drawing.Point(171, 359)
        Me.cboSexo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(160, 24)
        Me.cboSexo.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(93, 399)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Municipio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(116, 363)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 17)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Sexo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 331)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha de Nacimiento"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(171, 254)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(235, 51)
        Me.txtDireccion.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 257)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Dirección"
        '
        'mtbTelefono
        '
        Me.mtbTelefono.Location = New System.Drawing.Point(171, 213)
        Me.mtbTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.mtbTelefono.Mask = "9999-9999"
        Me.mtbTelefono.Name = "mtbTelefono"
        Me.mtbTelefono.Size = New System.Drawing.Size(235, 22)
        Me.mtbTelefono.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 217)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Telefono"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(171, 169)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(235, 22)
        Me.txtEmail.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 177)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(173, 121)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(235, 22)
        Me.txtApellido.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(173, 78)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 22)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'txtRtn
        '
        Me.txtRtn.Location = New System.Drawing.Point(173, 34)
        Me.txtRtn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRtn.Name = "txtRtn"
        Me.txtRtn.Size = New System.Drawing.Size(235, 22)
        Me.txtRtn.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RTN"
        '
        'chkVer
        '
        Me.chkVer.AutoSize = True
        Me.chkVer.BackColor = System.Drawing.Color.Transparent
        Me.chkVer.Location = New System.Drawing.Point(644, 477)
        Me.chkVer.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVer.Name = "chkVer"
        Me.chkVer.Size = New System.Drawing.Size(84, 21)
        Me.chkVer.TabIndex = 106
        Me.chkVer.Text = "Ver todo"
        Me.chkVer.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(731, 208)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 20)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Actualizar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(731, 342)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 20)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Cancelar"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.BackgroundImage = CType(resources.GetObject("btnActualizar.BackgroundImage"), System.Drawing.Image)
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Location = New System.Drawing.Point(735, 178)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(56, 27)
        Me.btnActualizar.TabIndex = 102
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(742, 298)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(53, 41)
        Me.btnCancelar.TabIndex = 103
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(743, 415)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 20)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Atras"
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(748, 377)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(47, 34)
        Me.btnAtras.TabIndex = 100
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(732, 144)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Insertar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(732, 267)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Guardar"
        '
        'btnInsertar
        '
        Me.btnInsertar.BackColor = System.Drawing.Color.Transparent
        Me.btnInsertar.BackgroundImage = CType(resources.GetObject("btnInsertar.BackgroundImage"), System.Drawing.Image)
        Me.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInsertar.FlatAppearance.BorderSize = 0
        Me.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertar.Location = New System.Drawing.Point(742, 104)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(41, 57)
        Me.btnInsertar.TabIndex = 96
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(742, 233)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(49, 31)
        Me.btnGuardar.TabIndex = 97
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(907, 522)
        Me.Controls.Add(Me.LsvMostrarCliente)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.chkVer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "FrmCliente"
        Me.Text = "Cliente"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LsvMostrarCliente As ListView
    Friend WithEvents chRtn As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chApellido As ColumnHeader
    Friend WithEvents chEmail As ColumnHeader
    Friend WithEvents chTelefono As ColumnHeader
    Friend WithEvents chDireccion As ColumnHeader
    Friend WithEvents chFecha As ColumnHeader
    Friend WithEvents chSexo As ColumnHeader
    Friend WithEvents chMunicipio As ColumnHeader
    Friend WithEvents Label15 As Label
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents cboMunicipio As ComboBox
    Friend WithEvents cboSexo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mtbTelefono As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRtn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkVer As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
