<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDetalleFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalleFactura))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LsvMostrarVentas = New System.Windows.Forms.ListView()
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPresentacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCAntidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(70, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 25)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Detalle Factura"
        '
        'LsvMostrarVentas
        '
        Me.LsvMostrarVentas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNombre, Me.chPresentacion, Me.chCAntidad, Me.chPrecio})
        Me.LsvMostrarVentas.FullRowSelect = True
        Me.LsvMostrarVentas.GridLines = True
        Me.LsvMostrarVentas.Location = New System.Drawing.Point(13, 80)
        Me.LsvMostrarVentas.Name = "LsvMostrarVentas"
        Me.LsvMostrarVentas.Size = New System.Drawing.Size(576, 221)
        Me.LsvMostrarVentas.TabIndex = 115
        Me.LsvMostrarVentas.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarVentas.View = System.Windows.Forms.View.Details
        '
        'chNombre
        '
        Me.chNombre.Text = "Producto"
        Me.chNombre.Width = 170
        '
        'chPresentacion
        '
        Me.chPresentacion.Text = "Presentación"
        Me.chPresentacion.Width = 160
        '
        'chCAntidad
        '
        Me.chCAntidad.Text = "Cantidad"
        Me.chCAntidad.Width = 120
        '
        'chPrecio
        '
        Me.chPrecio.Text = "Precio"
        Me.chPrecio.Width = 120
        '
        'FrmDetalleFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(593, 305)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LsvMostrarVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDetalleFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDetalleFactura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents LsvMostrarVentas As ListView
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chPresentacion As ColumnHeader
    Friend WithEvents chCAntidad As ColumnHeader
    Friend WithEvents chPrecio As ColumnHeader
End Class
