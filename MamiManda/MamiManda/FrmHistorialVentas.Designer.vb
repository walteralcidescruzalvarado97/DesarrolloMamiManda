<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistorialVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistorialVentas))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.LsvMostrarVentas = New System.Windows.Forms.ListView()
        Me.chCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSubtotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chIsv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(114, 101)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(403, 26)
        Me.txtBuscar.TabIndex = 113
        '
        'LsvMostrarVentas
        '
        Me.LsvMostrarVentas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCodigo, Me.chCliente, Me.chFecha, Me.chSubtotal, Me.chIsv, Me.chTotal, Me.chUsuario})
        Me.LsvMostrarVentas.FullRowSelect = True
        Me.LsvMostrarVentas.GridLines = True
        Me.LsvMostrarVentas.Location = New System.Drawing.Point(12, 147)
        Me.LsvMostrarVentas.Name = "LsvMostrarVentas"
        Me.LsvMostrarVentas.Size = New System.Drawing.Size(637, 302)
        Me.LsvMostrarVentas.TabIndex = 112
        Me.LsvMostrarVentas.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarVentas.View = System.Windows.Forms.View.Details
        '
        'chCodigo
        '
        Me.chCodigo.Text = "Código Factura"
        Me.chCodigo.Width = 85
        '
        'chCliente
        '
        Me.chCliente.Text = "Cliente"
        Me.chCliente.Width = 110
        '
        'chFecha
        '
        Me.chFecha.Text = "Fecha"
        Me.chFecha.Width = 120
        '
        'chSubtotal
        '
        Me.chSubtotal.Text = "Subtotal"
        Me.chSubtotal.Width = 75
        '
        'chIsv
        '
        Me.chIsv.Text = "ISV"
        Me.chIsv.Width = 75
        '
        'chTotal
        '
        Me.chTotal.Text = "Total"
        Me.chTotal.Width = 75
        '
        'chUsuario
        '
        Me.chUsuario.Text = "Usuario"
        Me.chUsuario.Width = 90
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(90, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 25)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "Historial Ventas"
        '
        'FrmHistorialVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(659, 468)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.LsvMostrarVentas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmHistorialVentas"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents LsvMostrarVentas As ListView
    Friend WithEvents Label15 As Label
    Friend WithEvents chCodigo As ColumnHeader
    Friend WithEvents chCliente As ColumnHeader
    Friend WithEvents chFecha As ColumnHeader
    Friend WithEvents chUsuario As ColumnHeader
    Friend WithEvents chSubtotal As ColumnHeader
    Friend WithEvents chIsv As ColumnHeader
    Friend WithEvents chTotal As ColumnHeader
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
