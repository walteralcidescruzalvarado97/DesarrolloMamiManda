<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodUsuario = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.GrupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarFoto = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.FotoAgregar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lsvMostrar = New System.Windows.Forms.ListView()
        Me.chCodUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUserName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPassword = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.AbrirFoto = New System.Windows.Forms.OpenFileDialog()
        Me.GrupBox1.SuspendLayout()
        CType(Me.FotoAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(166, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Usuario"
        '
        'txtCodUsuario
        '
        Me.txtCodUsuario.Enabled = False
        Me.txtCodUsuario.Location = New System.Drawing.Point(251, 27)
        Me.txtCodUsuario.Name = "txtCodUsuario"
        Me.txtCodUsuario.Size = New System.Drawing.Size(121, 20)
        Me.txtCodUsuario.TabIndex = 1
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(251, 60)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(121, 20)
        Me.txtUserName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(146, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de usuario"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(251, 93)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(121, 20)
        Me.txtContrasena.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(181, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(205, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(251, 125)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(191, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Empleado"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(251, 156)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(121, 20)
        Me.txtEmpleado.TabIndex = 9
        '
        'btnEmpleado
        '
        Me.btnEmpleado.BackgroundImage = CType(resources.GetObject("btnEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleado.FlatAppearance.BorderSize = 0
        Me.btnEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleado.Location = New System.Drawing.Point(378, 154)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(26, 23)
        Me.btnEmpleado.TabIndex = 10
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(165, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo de usuario"
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUsuario.FormattingEnabled = True
        Me.cboTipoUsuario.Location = New System.Drawing.Point(251, 187)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoUsuario.TabIndex = 12
        '
        'GrupBox1
        '
        Me.GrupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GrupBox1.Controls.Add(Me.txtEmpleado)
        Me.GrupBox1.Controls.Add(Me.btnEmpleado)
        Me.GrupBox1.Controls.Add(Me.btnEliminarFoto)
        Me.GrupBox1.Controls.Add(Me.btnAbrir)
        Me.GrupBox1.Controls.Add(Me.FotoAgregar)
        Me.GrupBox1.Controls.Add(Me.Label1)
        Me.GrupBox1.Controls.Add(Me.cboTipoUsuario)
        Me.GrupBox1.Controls.Add(Me.txtCodUsuario)
        Me.GrupBox1.Controls.Add(Me.Label6)
        Me.GrupBox1.Controls.Add(Me.Label2)
        Me.GrupBox1.Controls.Add(Me.txtUserName)
        Me.GrupBox1.Controls.Add(Me.Label3)
        Me.GrupBox1.Controls.Add(Me.Label5)
        Me.GrupBox1.Controls.Add(Me.txtContrasena)
        Me.GrupBox1.Controls.Add(Me.cboEstado)
        Me.GrupBox1.Controls.Add(Me.Label4)
        Me.GrupBox1.Location = New System.Drawing.Point(24, 57)
        Me.GrupBox1.Name = "GrupBox1"
        Me.GrupBox1.Size = New System.Drawing.Size(442, 226)
        Me.GrupBox1.TabIndex = 13
        Me.GrupBox1.TabStop = False
        Me.GrupBox1.Text = "Datos de Usuario"
        '
        'btnEliminarFoto
        '
        Me.btnEliminarFoto.BackgroundImage = CType(resources.GetObject("btnEliminarFoto.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarFoto.FlatAppearance.BorderSize = 0
        Me.btnEliminarFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEliminarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEliminarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarFoto.Location = New System.Drawing.Point(79, 150)
        Me.btnEliminarFoto.Name = "btnEliminarFoto"
        Me.btnEliminarFoto.Size = New System.Drawing.Size(33, 30)
        Me.btnEliminarFoto.TabIndex = 50
        Me.btnEliminarFoto.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.BackgroundImage = CType(resources.GetObject("btnAbrir.BackgroundImage"), System.Drawing.Image)
        Me.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbrir.FlatAppearance.BorderSize = 0
        Me.btnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrir.Location = New System.Drawing.Point(29, 150)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(33, 30)
        Me.btnAbrir.TabIndex = 49
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'FotoAgregar
        '
        Me.FotoAgregar.BackColor = System.Drawing.Color.Transparent
        Me.FotoAgregar.InitialImage = Nothing
        Me.FotoAgregar.Location = New System.Drawing.Point(13, 27)
        Me.FotoAgregar.Name = "FotoAgregar"
        Me.FotoAgregar.Size = New System.Drawing.Size(120, 115)
        Me.FotoAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoAgregar.TabIndex = 48
        Me.FotoAgregar.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(520, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Insertar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(517, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Guardar"
        '
        'btnInsertar
        '
        Me.btnInsertar.BackColor = System.Drawing.Color.Transparent
        Me.btnInsertar.BackgroundImage = CType(resources.GetObject("btnInsertar.BackgroundImage"), System.Drawing.Image)
        Me.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsertar.FlatAppearance.BorderSize = 0
        Me.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertar.Location = New System.Drawing.Point(520, 31)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(47, 43)
        Me.btnInsertar.TabIndex = 43
        Me.btnInsertar.UseVisualStyleBackColor = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(521, 155)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(46, 42)
        Me.btnGuardar.TabIndex = 44
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(514, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Actualizar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(515, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Cancelar"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.BackgroundImage = CType(resources.GetObject("btnActualizar.BackgroundImage"), System.Drawing.Image)
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Location = New System.Drawing.Point(520, 93)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(47, 43)
        Me.btnActualizar.TabIndex = 51
        Me.btnActualizar.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(523, 220)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 33)
        Me.btnCancelar.TabIndex = 52
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lsvMostrar
        '
        Me.lsvMostrar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCodUsuario, Me.chUserName, Me.chPassword, Me.chEstado, Me.chNombre, Me.chTipo})
        Me.lsvMostrar.FullRowSelect = True
        Me.lsvMostrar.GridLines = True
        Me.lsvMostrar.Location = New System.Drawing.Point(0, 112)
        Me.lsvMostrar.Name = "lsvMostrar"
        Me.lsvMostrar.Size = New System.Drawing.Size(596, 187)
        Me.lsvMostrar.TabIndex = 57
        Me.lsvMostrar.UseCompatibleStateImageBehavior = False
        Me.lsvMostrar.View = System.Windows.Forms.View.Details
        '
        'chCodUsuario
        '
        Me.chCodUsuario.Text = "Código Usuario"
        Me.chCodUsuario.Width = 90
        '
        'chUserName
        '
        Me.chUserName.Text = "Nombre Usuario"
        Me.chUserName.Width = 120
        '
        'chPassword
        '
        Me.chPassword.Text = "Password"
        Me.chPassword.Width = 70
        '
        'chEstado
        '
        Me.chEstado.Text = "Estado"
        Me.chEstado.Width = 80
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre Completo"
        Me.chNombre.Width = 130
        '
        'chTipo
        '
        Me.chTipo.Text = "Tipo Usuario"
        Me.chTipo.Width = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 25)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Gestión Usuario"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(611, 328)
        Me.TabControl1.TabIndex = 59
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.btnInsertar)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.GrupBox1)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.btnActualizar)
        Me.TabPage1.Controls.Add(Me.btnCancelar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(603, 302)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gestión Usuario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.btnEditar)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtBuscar)
        Me.TabPage2.Controls.Add(Me.lsvMostrar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(595, 299)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listar Usuario"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.Location = New System.Drawing.Point(517, 55)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 88
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 25)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Listar Usuario"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(83, 69)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(416, 29)
        Me.txtBuscar.TabIndex = 86
        '
        'AbrirFoto
        '
        Me.AbrirFoto.FileName = "OpenFileDialog1"
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(599, 323)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Usuario"
        Me.GrupBox1.ResumeLayout(False)
        Me.GrupBox1.PerformLayout()
        CType(Me.FotoAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodUsuario As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents btnEmpleado As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cboTipoUsuario As ComboBox
    Friend WithEvents GrupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lsvMostrar As ListView
    Friend WithEvents chCodUsuario As ColumnHeader
    Friend WithEvents chUserName As ColumnHeader
    Friend WithEvents chPassword As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chTipo As ColumnHeader
    Friend WithEvents chEstado As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnEliminarFoto As Button
    Friend WithEvents btnAbrir As Button
    Friend WithEvents FotoAgregar As PictureBox
    Friend WithEvents AbrirFoto As OpenFileDialog
End Class
