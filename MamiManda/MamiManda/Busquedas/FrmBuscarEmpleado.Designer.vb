<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarEmpleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lsvMostrar = New System.Windows.Forms.ListView()
        Me.chIdEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipoEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Empleado"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbNombre)
        Me.GroupBox1.Controls.Add(Me.rbCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 50)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de búsqueda"
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(221, 20)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(111, 17)
        Me.rbNombre.TabIndex = 1
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Nombre empleado"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(42, 19)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(107, 17)
        Me.rbCodigo.TabIndex = 0
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Código empleado"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(44, 92)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(314, 37)
        Me.txtBuscar.TabIndex = 2
        '
        'lsvMostrar
        '
        Me.lsvMostrar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chIdEmpleado, Me.chNombre, Me.chEmail, Me.chTelefono, Me.chDireccion, Me.chTipoEmpleado, Me.chSexo})
        Me.lsvMostrar.FullRowSelect = True
        Me.lsvMostrar.Location = New System.Drawing.Point(29, 150)
        Me.lsvMostrar.Name = "lsvMostrar"
        Me.lsvMostrar.Size = New System.Drawing.Size(418, 208)
        Me.lsvMostrar.TabIndex = 3
        Me.lsvMostrar.UseCompatibleStateImageBehavior = False
        Me.lsvMostrar.View = System.Windows.Forms.View.Details
        '
        'chIdEmpleado
        '
        Me.chIdEmpleado.Text = "Código Empleado"
        Me.chIdEmpleado.Width = 95
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre Completo"
        Me.chNombre.Width = 120
        '
        'chEmail
        '
        Me.chEmail.Text = "Email"
        Me.chEmail.Width = 100
        '
        'chTelefono
        '
        Me.chTelefono.Text = "Telefono"
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Dirección"
        '
        'chTipoEmpleado
        '
        Me.chTipoEmpleado.Text = "Tipo Empleado"
        Me.chTipoEmpleado.Width = 80
        '
        'chSexo
        '
        Me.chSexo.Text = "Sexo"
        Me.chSexo.Width = 70
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(364, 93)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 36)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarCodigo
        '
        Me.txtBuscarCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtBuscarCodigo.Location = New System.Drawing.Point(44, 92)
        Me.txtBuscarCodigo.Multiline = True
        Me.txtBuscarCodigo.Name = "txtBuscarCodigo"
        Me.txtBuscarCodigo.Size = New System.Drawing.Size(314, 37)
        Me.txtBuscarCodigo.TabIndex = 5
        '
        'FrmBuscarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(475, 370)
        Me.Controls.Add(Me.txtBuscarCodigo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lsvMostrar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "FrmBuscarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents chIdEmpleado As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chEmail As ColumnHeader
    Friend WithEvents chTelefono As ColumnHeader
    Friend WithEvents chDireccion As ColumnHeader
    Friend WithEvents chTipoEmpleado As ColumnHeader
    Friend WithEvents chSexo As ColumnHeader
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarCodigo As TextBox
    Public WithEvents lsvMostrar As ListView
End Class
