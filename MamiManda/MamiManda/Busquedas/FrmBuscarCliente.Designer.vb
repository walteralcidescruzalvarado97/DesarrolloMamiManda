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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarCliente))
        Me.LsvMostrarCliente = New System.Windows.Forms.ListView()
        Me.chRtn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMunicipio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDiasPlazo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'LsvMostrarCliente
        '
        Me.LsvMostrarCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRtn, Me.chNombre, Me.chEmail, Me.chTelefono, Me.chDireccion, Me.chFecha, Me.chSexo, Me.chMunicipio, Me.ChDiasPlazo})
        Me.LsvMostrarCliente.FullRowSelect = True
        Me.LsvMostrarCliente.GridLines = True
        Me.LsvMostrarCliente.Location = New System.Drawing.Point(0, 84)
        Me.LsvMostrarCliente.Name = "LsvMostrarCliente"
        Me.LsvMostrarCliente.Size = New System.Drawing.Size(821, 254)
        Me.LsvMostrarCliente.TabIndex = 88
        Me.LsvMostrarCliente.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarCliente.View = System.Windows.Forms.View.Details
        '
        'chRtn
        '
        Me.chRtn.Text = "RTN CLiente"
        Me.chRtn.Width = 100
        '
        'chNombre
        '
        Me.chNombre.Text = "NombreCompleto"
        Me.chNombre.Width = 105
        '
        'chEmail
        '
        Me.chEmail.Text = "Email"
        Me.chEmail.Width = 100
        '
        'chTelefono
        '
        Me.chTelefono.Text = "Teléfono"
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Dirección"
        Me.chDireccion.Width = 120
        '
        'chFecha
        '
        Me.chFecha.Text = "Fecha"
        Me.chFecha.Width = 110
        '
        'chSexo
        '
        Me.chSexo.Text = "Sexo"
        Me.chSexo.Width = 70
        '
        'chMunicipio
        '
        Me.chMunicipio.Text = "Municipio"
        Me.chMunicipio.Width = 90
        '
        'ChDiasPlazo
        '
        Me.ChDiasPlazo.Text = "DiasPlazo"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(179, 37)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(416, 29)
        Me.txtBuscar.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Buscar Cliente"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(778, 45)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 33)
        Me.btnAgregar.TabIndex = 89
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'FrmBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MamiManda.My.Resources.Resources.FondoNew
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(820, 339)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.LsvMostrarCliente)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarCliente"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
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
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ChDiasPlazo As ColumnHeader
End Class
