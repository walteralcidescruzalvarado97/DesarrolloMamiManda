<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarPresentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarPresentacion))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lsvMostrar = New System.Windows.Forms.ListView()
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUnidades = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecioMAyorista = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecioDEtalle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecioCOsto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(113, 44)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(380, 26)
        Me.txtBuscar.TabIndex = 85
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(202, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 25)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Listar Presentación"
        '
        'lsvMostrar
        '
        Me.lsvMostrar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNombre, Me.chTipo, Me.chUnidades, Me.chPrecioMAyorista, Me.chPrecioDEtalle, Me.chPrecioCOsto})
        Me.lsvMostrar.FullRowSelect = True
        Me.lsvMostrar.GridLines = True
        Me.lsvMostrar.Location = New System.Drawing.Point(12, 87)
        Me.lsvMostrar.Name = "lsvMostrar"
        Me.lsvMostrar.Size = New System.Drawing.Size(588, 241)
        Me.lsvMostrar.TabIndex = 86
        Me.lsvMostrar.UseCompatibleStateImageBehavior = False
        Me.lsvMostrar.View = System.Windows.Forms.View.Details
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre Producto"
        Me.chNombre.Width = 135
        '
        'chTipo
        '
        Me.chTipo.Text = "Tipo Presentación"
        Me.chTipo.Width = 115
        '
        'chUnidades
        '
        Me.chUnidades.Text = "Unidades"
        Me.chUnidades.Width = 80
        '
        'chPrecioMAyorista
        '
        Me.chPrecioMAyorista.Text = "Precio Mayorista"
        Me.chPrecioMAyorista.Width = 90
        '
        'chPrecioDEtalle
        '
        Me.chPrecioDEtalle.Text = "Precio Detalle"
        Me.chPrecioDEtalle.Width = 80
        '
        'chPrecioCOsto
        '
        Me.chPrecioCOsto.Text = "Precio Costo"
        Me.chPrecioCOsto.Width = 80
        '
        'FrmBuscarPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 340)
        Me.Controls.Add(Me.lsvMostrar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label11)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBuscarPresentacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lsvMostrar As ListView
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chTipo As ColumnHeader
    Friend WithEvents chUnidades As ColumnHeader
    Friend WithEvents chPrecioMAyorista As ColumnHeader
    Friend WithEvents chPrecioDEtalle As ColumnHeader
    Friend WithEvents chPrecioCOsto As ColumnHeader
End Class
