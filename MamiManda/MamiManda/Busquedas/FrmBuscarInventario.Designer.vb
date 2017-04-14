<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarInventario))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lsvMostrar = New System.Windows.Forms.ListView()
        Me.chCodInventario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExistenciaMaxima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExistenciaMinima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExistencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(105, 48)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(380, 26)
        Me.txtBuscar.TabIndex = 84
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(201, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 25)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Buscar Producto"
        '
        'lsvMostrar
        '
        Me.lsvMostrar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCodInventario, Me.chNombre, Me.chExistenciaMaxima, Me.chExistenciaMinima, Me.chExistencia})
        Me.lsvMostrar.FullRowSelect = True
        Me.lsvMostrar.GridLines = True
        Me.lsvMostrar.Location = New System.Drawing.Point(-2, 110)
        Me.lsvMostrar.Name = "lsvMostrar"
        Me.lsvMostrar.Size = New System.Drawing.Size(589, 270)
        Me.lsvMostrar.TabIndex = 82
        Me.lsvMostrar.UseCompatibleStateImageBehavior = False
        Me.lsvMostrar.View = System.Windows.Forms.View.Details
        '
        'chCodInventario
        '
        Me.chCodInventario.Text = "Código Inventario"
        Me.chCodInventario.Width = 95
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre Producto"
        Me.chNombre.Width = 125
        '
        'chExistenciaMaxima
        '
        Me.chExistenciaMaxima.Text = "Existencia Máxima"
        Me.chExistenciaMaxima.Width = 120
        '
        'chExistenciaMinima
        '
        Me.chExistenciaMinima.Text = "Existencia Mínima"
        Me.chExistenciaMinima.Width = 120
        '
        'chExistencia
        '
        Me.chExistencia.Text = "Existencia"
        Me.chExistencia.Width = 120
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
        Me.btnAgregar.Location = New System.Drawing.Point(544, 60)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 33)
        Me.btnAgregar.TabIndex = 90
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'FrmBuscarInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(586, 380)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lsvMostrar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lsvMostrar As ListView
    Friend WithEvents chCodInventario As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chExistenciaMaxima As ColumnHeader
    Friend WithEvents chExistenciaMinima As ColumnHeader
    Friend WithEvents chExistencia As ColumnHeader
    Friend WithEvents btnAgregar As Button
End Class
