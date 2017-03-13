<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarProveedor
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
        Me.lsvMostrarProveedor = New System.Windows.Forms.ListView()
        Me.chRTN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        'lsvMostrarProveedor
        '
        Me.lsvMostrarProveedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRTN, Me.chNombre, Me.chEmail, Me.chTelefono, Me.chDireccion})
        Me.lsvMostrarProveedor.FullRowSelect = True
        Me.lsvMostrarProveedor.Location = New System.Drawing.Point(26, 168)
        Me.lsvMostrarProveedor.Name = "lsvMostrarProveedor"
        Me.lsvMostrarProveedor.Size = New System.Drawing.Size(517, 139)
        Me.lsvMostrarProveedor.TabIndex = 75
        Me.lsvMostrarProveedor.UseCompatibleStateImageBehavior = False
        Me.lsvMostrarProveedor.View = System.Windows.Forms.View.Details
        '
        'chRTN
        '
        Me.chRTN.Text = "RTN"
        Me.chRTN.Width = 120
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre Completo"
        Me.chNombre.Width = 100
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
        'txtBuscarRtn
        '
        Me.txtBuscarRtn.BackColor = System.Drawing.SystemColors.Window
        Me.txtBuscarRtn.Location = New System.Drawing.Point(89, 113)
        Me.txtBuscarRtn.Multiline = True
        Me.txtBuscarRtn.Name = "txtBuscarRtn"
        Me.txtBuscarRtn.Size = New System.Drawing.Size(314, 37)
        Me.txtBuscarRtn.TabIndex = 74
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(409, 113)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 36)
        Me.btnBuscar.TabIndex = 73
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(89, 113)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(314, 37)
        Me.txtBuscar.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbNombre)
        Me.GroupBox1.Controls.Add(Me.rbRtn)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 50)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de búsqueda"
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(221, 20)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(114, 17)
        Me.rbNombre.TabIndex = 1
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Nombre Proveedor"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'rbRtn
        '
        Me.rbRtn.AutoSize = True
        Me.rbRtn.Location = New System.Drawing.Point(42, 19)
        Me.rbRtn.Name = "rbRtn"
        Me.rbRtn.Size = New System.Drawing.Size(100, 17)
        Me.rbRtn.TabIndex = 0
        Me.rbRtn.TabStop = True
        Me.rbRtn.Text = "RTN Proveedor"
        Me.rbRtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Buscar Proveedor"
        '
        'FrmBuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 327)
        Me.Controls.Add(Me.lsvMostrarProveedor)
        Me.Controls.Add(Me.txtBuscarRtn)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBuscarProveedor"
        Me.Text = "FrmBuscarProveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvMostrarProveedor As ListView
    Friend WithEvents chRTN As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chEmail As ColumnHeader
    Friend WithEvents chTelefono As ColumnHeader
    Friend WithEvents chDireccion As ColumnHeader
    Friend WithEvents txtBuscarRtn As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbRtn As RadioButton
    Friend WithEvents Label1 As Label
End Class
