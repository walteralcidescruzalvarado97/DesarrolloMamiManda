<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarCliente
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
        Me.LsvMostrarCliente = New System.Windows.Forms.ListView()
        Me.chRtn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMunicipio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBuscarRtn = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbRtn = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvMostrarCliente
        '
        Me.LsvMostrarCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRtn, Me.chNombre, Me.chEmail, Me.chTelefono, Me.chDireccion, Me.chFecha, Me.chSexo, Me.chMunicipio})
        Me.LsvMostrarCliente.FullRowSelect = True
        Me.LsvMostrarCliente.Location = New System.Drawing.Point(23, 178)
        Me.LsvMostrarCliente.Name = "LsvMostrarCliente"
        Me.LsvMostrarCliente.Size = New System.Drawing.Size(524, 139)
        Me.LsvMostrarCliente.TabIndex = 88
        Me.LsvMostrarCliente.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarCliente.View = System.Windows.Forms.View.Details
        '
        'chRtn
        '
        Me.chRtn.Text = "RtnCLiente"
        Me.chRtn.Width = 80
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre Completo"
        Me.chNombre.Width = 80
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
        'txtBuscarRtn
        '
        Me.txtBuscarRtn.BackColor = System.Drawing.SystemColors.Window
        Me.txtBuscarRtn.Location = New System.Drawing.Point(95, 114)
        Me.txtBuscarRtn.Multiline = True
        Me.txtBuscarRtn.Name = "txtBuscarRtn"
        Me.txtBuscarRtn.Size = New System.Drawing.Size(314, 37)
        Me.txtBuscarRtn.TabIndex = 87
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(415, 114)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 36)
        Me.btnBuscar.TabIndex = 86
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(95, 114)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(314, 37)
        Me.txtBuscar.TabIndex = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbNombre)
        Me.GroupBox1.Controls.Add(Me.rbRtn)
        Me.GroupBox1.Location = New System.Drawing.Point(95, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 50)
        Me.GroupBox1.TabIndex = 84
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
        'rbRtn
        '
        Me.rbRtn.AutoSize = True
        Me.rbRtn.Location = New System.Drawing.Point(42, 19)
        Me.rbRtn.Name = "rbRtn"
        Me.rbRtn.Size = New System.Drawing.Size(91, 17)
        Me.rbRtn.TabIndex = 0
        Me.rbRtn.TabStop = True
        Me.rbRtn.Text = "Rtn empleado"
        Me.rbRtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Buscar Cliente"
        '
        'FrmBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 339)
        Me.Controls.Add(Me.LsvMostrarCliente)
        Me.Controls.Add(Me.txtBuscarRtn)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBuscarCliente"
        Me.Text = "FrmBuscarCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LsvMostrarCliente As ListView
    Friend WithEvents chRtn As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chEmail As ColumnHeader
    Friend WithEvents chTelefono As ColumnHeader
    Friend WithEvents chDireccion As ColumnHeader
    Friend WithEvents chFecha As ColumnHeader
    Friend WithEvents chSexo As ColumnHeader
    Friend WithEvents chMunicipio As ColumnHeader
    Friend WithEvents txtBuscarRtn As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbRtn As RadioButton
    Friend WithEvents Label1 As Label
End Class
