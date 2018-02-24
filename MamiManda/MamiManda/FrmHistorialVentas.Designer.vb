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
        Me.LsvMostrarVentas = New System.Windows.Forms.ListView()
        Me.chCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoFactura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'LsvMostrarVentas
        '
        Me.LsvMostrarVentas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCodigo, Me.chCliente, Me.chFecha, Me.ChTipoFactura, Me.ChEstado})
        Me.LsvMostrarVentas.FullRowSelect = True
        Me.LsvMostrarVentas.GridLines = True
        Me.LsvMostrarVentas.Location = New System.Drawing.Point(12, 147)
        Me.LsvMostrarVentas.Name = "LsvMostrarVentas"
        Me.LsvMostrarVentas.Size = New System.Drawing.Size(594, 302)
        Me.LsvMostrarVentas.TabIndex = 112
        Me.LsvMostrarVentas.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarVentas.View = System.Windows.Forms.View.Details
        '
        'chCodigo
        '
        Me.chCodigo.Text = "Código Factura"
        Me.chCodigo.Width = 120
        '
        'chCliente
        '
        Me.chCliente.Text = "Cliente"
        Me.chCliente.Width = 141
        '
        'chFecha
        '
        Me.chFecha.Text = "Fecha"
        Me.chFecha.Width = 107
        '
        'ChTipoFactura
        '
        Me.ChTipoFactura.Text = "TipoFactura"
        Me.ChTipoFactura.Width = 141
        '
        'ChEstado
        '
        Me.ChEstado.Text = "Estado"
        Me.ChEstado.Width = 81
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(62, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Fecha Desde:"
        '
        'DtpFechaDesde
        '
        Me.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDesde.Location = New System.Drawing.Point(137, 105)
        Me.DtpFechaDesde.Name = "DtpFechaDesde"
        Me.DtpFechaDesde.Size = New System.Drawing.Size(96, 20)
        Me.DtpFechaDesde.TabIndex = 116
        '
        'DtpFechaHasta
        '
        Me.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaHasta.Location = New System.Drawing.Point(353, 103)
        Me.DtpFechaHasta.Name = "DtpFechaHasta"
        Me.DtpFechaHasta.Size = New System.Drawing.Size(96, 20)
        Me.DtpFechaHasta.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(278, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Fecha Hasta:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(477, 98)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(101, 27)
        Me.SimpleButton1.TabIndex = 119
        Me.SimpleButton1.Text = "Mostrar"
        '
        'FrmHistorialVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 468)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.DtpFechaHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpFechaDesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
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
    Friend WithEvents LsvMostrarVentas As ListView
    Friend WithEvents Label15 As Label
    Friend WithEvents chCodigo As ColumnHeader
    Friend WithEvents chCliente As ColumnHeader
    Friend WithEvents chFecha As ColumnHeader
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ChTipoFactura As ColumnHeader
    Friend WithEvents ChEstado As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpFechaDesde As DateTimePicker
    Friend WithEvents DtpFechaHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
