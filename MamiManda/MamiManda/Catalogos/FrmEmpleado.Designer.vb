<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.mtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.lblapellidos = New System.Windows.Forms.Label()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.CboTipoEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TPGestionEmpleado = New System.Windows.Forms.TabPage()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.TPListarEmpleado = New System.Windows.Forms.TabPage()
        Me.LsvMostrarEmpleado = New System.Windows.Forms.ListView()
        Me.ChCodEMpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GbDatos.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TPGestionEmpleado.SuspendLayout()
        Me.TPListarEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 25)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Gestión Empleado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(460, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Actualizar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(467, 306)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 83
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
        Me.btnActualizar.Location = New System.Drawing.Point(466, 125)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(47, 43)
        Me.btnActualizar.TabIndex = 73
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
        Me.btnCancelar.Location = New System.Drawing.Point(475, 270)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 33)
        Me.btnCancelar.TabIndex = 75
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(466, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Insertar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(467, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Guardar"
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
        Me.btnGuardar.Location = New System.Drawing.Point(470, 195)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(46, 42)
        Me.btnGuardar.TabIndex = 74
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GbDatos
        '
        Me.GbDatos.BackColor = System.Drawing.Color.Transparent
        Me.GbDatos.Controls.Add(Me.mtbTelefono)
        Me.GbDatos.Controls.Add(Me.lblapellidos)
        Me.GbDatos.Controls.Add(Me.CboSexo)
        Me.GbDatos.Controls.Add(Me.TxtApellido)
        Me.GbDatos.Controls.Add(Me.CboTipoEmpleado)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.TxtCodEmpleado)
        Me.GbDatos.Controls.Add(Me.Label7)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.TxtNombre)
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.TxtDireccion)
        Me.GbDatos.Controls.Add(Me.TxtEmail)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Location = New System.Drawing.Point(39, 70)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(348, 293)
        Me.GbDatos.TabIndex = 78
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos del Empleado"
        '
        'mtbTelefono
        '
        Me.mtbTelefono.Location = New System.Drawing.Point(130, 145)
        Me.mtbTelefono.Mask = "9999-9999"
        Me.mtbTelefono.Name = "mtbTelefono"
        Me.mtbTelefono.Size = New System.Drawing.Size(157, 20)
        Me.mtbTelefono.TabIndex = 18
        '
        'lblapellidos
        '
        Me.lblapellidos.AutoSize = True
        Me.lblapellidos.Location = New System.Drawing.Point(78, 98)
        Me.lblapellidos.Name = "lblapellidos"
        Me.lblapellidos.Size = New System.Drawing.Size(49, 13)
        Me.lblapellidos.TabIndex = 17
        Me.lblapellidos.Text = "Apellidos"
        '
        'CboSexo
        '
        Me.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(129, 259)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(126, 21)
        Me.CboSexo.TabIndex = 16
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(129, 95)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(158, 20)
        Me.TxtApellido.TabIndex = 3
        '
        'CboTipoEmpleado
        '
        Me.CboTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoEmpleado.FormattingEnabled = True
        Me.CboTipoEmpleado.Location = New System.Drawing.Point(130, 232)
        Me.CboTipoEmpleado.Name = "CboTipoEmpleado"
        Me.CboTipoEmpleado.Size = New System.Drawing.Size(125, 21)
        Me.CboTipoEmpleado.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod Empleado"
        '
        'TxtCodEmpleado
        '
        Me.TxtCodEmpleado.Enabled = False
        Me.TxtCodEmpleado.Location = New System.Drawing.Point(129, 37)
        Me.TxtCodEmpleado.Name = "TxtCodEmpleado"
        Me.TxtCodEmpleado.Size = New System.Drawing.Size(158, 20)
        Me.TxtCodEmpleado.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sexo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(129, 67)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(158, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "TipoEmpleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(129, 174)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(158, 49)
        Me.TxtDireccion.TabIndex = 6
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(129, 119)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(158, 20)
        Me.TxtEmail.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Teléfono"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPGestionEmpleado)
        Me.TabControl1.Controls.Add(Me.TPListarEmpleado)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(603, 395)
        Me.TabControl1.TabIndex = 86
        '
        'TPGestionEmpleado
        '
        Me.TPGestionEmpleado.BackgroundImage = CType(resources.GetObject("TPGestionEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.TPGestionEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TPGestionEmpleado.Controls.Add(Me.btnInsertar)
        Me.TPGestionEmpleado.Controls.Add(Me.GbDatos)
        Me.TPGestionEmpleado.Controls.Add(Me.Label8)
        Me.TPGestionEmpleado.Controls.Add(Me.btnGuardar)
        Me.TPGestionEmpleado.Controls.Add(Me.Label10)
        Me.TPGestionEmpleado.Controls.Add(Me.Label11)
        Me.TPGestionEmpleado.Controls.Add(Me.Label13)
        Me.TPGestionEmpleado.Controls.Add(Me.Label9)
        Me.TPGestionEmpleado.Controls.Add(Me.btnActualizar)
        Me.TPGestionEmpleado.Controls.Add(Me.btnCancelar)
        Me.TPGestionEmpleado.Location = New System.Drawing.Point(4, 22)
        Me.TPGestionEmpleado.Name = "TPGestionEmpleado"
        Me.TPGestionEmpleado.Padding = New System.Windows.Forms.Padding(3)
        Me.TPGestionEmpleado.Size = New System.Drawing.Size(595, 369)
        Me.TPGestionEmpleado.TabIndex = 0
        Me.TPGestionEmpleado.Text = "Gestión Empleado"
        Me.TPGestionEmpleado.UseVisualStyleBackColor = True
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
        Me.btnInsertar.Location = New System.Drawing.Point(468, 61)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(47, 43)
        Me.btnInsertar.TabIndex = 72
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'TPListarEmpleado
        '
        Me.TPListarEmpleado.BackgroundImage = CType(resources.GetObject("TPListarEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.TPListarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TPListarEmpleado.Controls.Add(Me.LsvMostrarEmpleado)
        Me.TPListarEmpleado.Controls.Add(Me.btnEditar)
        Me.TPListarEmpleado.Controls.Add(Me.Label12)
        Me.TPListarEmpleado.Controls.Add(Me.txtBuscar)
        Me.TPListarEmpleado.Location = New System.Drawing.Point(4, 22)
        Me.TPListarEmpleado.Name = "TPListarEmpleado"
        Me.TPListarEmpleado.Padding = New System.Windows.Forms.Padding(3)
        Me.TPListarEmpleado.Size = New System.Drawing.Size(595, 369)
        Me.TPListarEmpleado.TabIndex = 1
        Me.TPListarEmpleado.Text = "Listar Empleado"
        Me.TPListarEmpleado.UseVisualStyleBackColor = True
        '
        'LsvMostrarEmpleado
        '
        Me.LsvMostrarEmpleado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodEMpleado, Me.ChNombre, Me.ChApellido, Me.ChEmail, Me.ChTelefono, Me.ChTipoEmpleado, Me.ChSexo})
        Me.LsvMostrarEmpleado.FullRowSelect = True
        Me.LsvMostrarEmpleado.GridLines = True
        Me.LsvMostrarEmpleado.Location = New System.Drawing.Point(-3, 121)
        Me.LsvMostrarEmpleado.Name = "LsvMostrarEmpleado"
        Me.LsvMostrarEmpleado.Size = New System.Drawing.Size(600, 252)
        Me.LsvMostrarEmpleado.TabIndex = 90
        Me.LsvMostrarEmpleado.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarEmpleado.View = System.Windows.Forms.View.Details
        '
        'ChCodEMpleado
        '
        Me.ChCodEMpleado.Text = "Código"
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre "
        Me.ChNombre.Width = 80
        '
        'ChApellido
        '
        Me.ChApellido.Text = "Apellido"
        Me.ChApellido.Width = 80
        '
        'ChEmail
        '
        Me.ChEmail.Text = "Email"
        Me.ChEmail.Width = 120
        '
        'ChTelefono
        '
        Me.ChTelefono.Text = "Teléfono"
        Me.ChTelefono.Width = 75
        '
        'ChTipoEmpleado
        '
        Me.ChTipoEmpleado.Text = "Tipo Empleado"
        Me.ChTipoEmpleado.Width = 100
        '
        'ChSexo
        '
        Me.ChSexo.Text = "Sexo"
        Me.ChSexo.Width = 80
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.Location = New System.Drawing.Point(463, 78)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 88
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(49, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 25)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Listar Empleado"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(134, 75)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(314, 27)
        Me.txtBuscar.TabIndex = 86
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 392)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado"
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TPGestionEmpleado.ResumeLayout(False)
        Me.TPGestionEmpleado.PerformLayout()
        Me.TPListarEmpleado.ResumeLayout(False)
        Me.TPListarEmpleado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents lblapellidos As Label
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents CboTipoEmpleado As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodEmpleado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPGestionEmpleado As TabPage
    Friend WithEvents TPListarEmpleado As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents mtbTelefono As MaskedTextBox
    Friend WithEvents LsvMostrarEmpleado As ListView
    Friend WithEvents ChCodEMpleado As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellido As ColumnHeader
    Friend WithEvents ChEmail As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChTipoEmpleado As ColumnHeader
    Friend WithEvents ChSexo As ColumnHeader
    Friend WithEvents btnInsertar As Button
End Class
