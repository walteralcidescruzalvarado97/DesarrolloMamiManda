<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedor))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
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
        Me.lsvMostrar = New System.Windows.Forms.ListView()
        Me.chRTN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbDatos.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(427, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Actualizar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(431, 285)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 64
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
        Me.btnActualizar.Location = New System.Drawing.Point(432, 107)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(47, 43)
        Me.btnActualizar.TabIndex = 61
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
        Me.btnCancelar.Location = New System.Drawing.Point(439, 249)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 33)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(433, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Insertar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(431, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 58
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
        Me.btnInsertar.Location = New System.Drawing.Point(433, 46)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(47, 43)
        Me.btnInsertar.TabIndex = 55
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
        Me.btnGuardar.Location = New System.Drawing.Point(435, 174)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(46, 42)
        Me.btnGuardar.TabIndex = 56
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 25)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Gestión Proveedor"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
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
        Me.gbDatos.Location = New System.Drawing.Point(49, 73)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(290, 264)
        Me.gbDatos.TabIndex = 66
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos de Proveedor"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(68, 206)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(177, 42)
        Me.txtDireccion.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Dirección"
        '
        'mtbTelefono
        '
        Me.mtbTelefono.Location = New System.Drawing.Point(68, 173)
        Me.mtbTelefono.Mask = "9999-9999"
        Me.mtbTelefono.Name = "mtbTelefono"
        Me.mtbTelefono.Size = New System.Drawing.Size(177, 20)
        Me.mtbTelefono.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Telefono"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(68, 137)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(177, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(70, 98)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(177, 20)
        Me.txtApellido.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(70, 63)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(177, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'txtRtn
        '
        Me.txtRtn.Location = New System.Drawing.Point(70, 28)
        Me.txtRtn.Name = "txtRtn"
        Me.txtRtn.Size = New System.Drawing.Size(177, 20)
        Me.txtRtn.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RTN"
        '
        'chkVer
        '
        Me.chkVer.AutoSize = True
        Me.chkVer.BackColor = System.Drawing.Color.Transparent
        Me.chkVer.Location = New System.Drawing.Point(357, 304)
        Me.chkVer.Name = "chkVer"
        Me.chkVer.Size = New System.Drawing.Size(66, 17)
        Me.chkVer.TabIndex = 67
        Me.chkVer.Text = "Ver todo"
        Me.chkVer.UseVisualStyleBackColor = False
        '
        'lsvMostrar
        '
        Me.lsvMostrar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRTN, Me.chNombre, Me.chApellido, Me.chEmail, Me.chTelefono, Me.chDireccion})
        Me.lsvMostrar.FullRowSelect = True
        Me.lsvMostrar.Location = New System.Drawing.Point(12, 381)
        Me.lsvMostrar.Name = "lsvMostrar"
        Me.lsvMostrar.Size = New System.Drawing.Size(517, 139)
        Me.lsvMostrar.TabIndex = 68
        Me.lsvMostrar.UseCompatibleStateImageBehavior = False
        Me.lsvMostrar.View = System.Windows.Forms.View.Details
        '
        'chRTN
        '
        Me.chRTN.Text = "RTN"
        Me.chRTN.Width = 120
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre"
        Me.chNombre.Width = 100
        '
        'chApellido
        '
        Me.chApellido.Text = "Apellido"
        Me.chApellido.Width = 100
        '
        'chEmail
        '
        Me.chEmail.Text = "Email"
        Me.chEmail.Width = 120
        '
        'chTelefono
        '
        Me.chTelefono.Text = "Telefono"
        Me.chTelefono.Width = 100
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Dirección"
        Me.chDireccion.Width = 120
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(541, 369)
        Me.Controls.Add(Me.lsvMostrar)
        Me.Controls.Add(Me.chkVer)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnGuardar)
        Me.DoubleBuffered = True
        Me.Name = "FrmProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRtn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mtbTelefono As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkVer As CheckBox
    Friend WithEvents lsvMostrar As ListView
    Friend WithEvents chRTN As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chApellido As ColumnHeader
    Friend WithEvents chEmail As ColumnHeader
    Friend WithEvents chTelefono As ColumnHeader
    Friend WithEvents chDireccion As ColumnHeader
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
