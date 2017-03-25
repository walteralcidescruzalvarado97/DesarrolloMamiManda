<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarMateriaPrima
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
        Me.LsvMostrarMateriaPrima = New System.Windows.Forms.ListView()
        Me.ChIdMateriaPrima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreMateriaPrima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChExistenciaMinima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChExistencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChMedida = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChRTNProveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LsvMostrarMateriaPrima
        '
        Me.LsvMostrarMateriaPrima.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdMateriaPrima, Me.ChNombreMateriaPrima, Me.ChExistenciaMinima, Me.ChExistencia, Me.ChCantidad, Me.ChPrecio, Me.ChFecha, Me.ChMedida, Me.ChRTNProveedor})
        Me.LsvMostrarMateriaPrima.FullRowSelect = True
        Me.LsvMostrarMateriaPrima.GridLines = True
        Me.LsvMostrarMateriaPrima.Location = New System.Drawing.Point(1, 91)
        Me.LsvMostrarMateriaPrima.Name = "LsvMostrarMateriaPrima"
        Me.LsvMostrarMateriaPrima.Size = New System.Drawing.Size(692, 284)
        Me.LsvMostrarMateriaPrima.TabIndex = 97
        Me.LsvMostrarMateriaPrima.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarMateriaPrima.View = System.Windows.Forms.View.Details
        '
        'ChIdMateriaPrima
        '
        Me.ChIdMateriaPrima.Text = "IdMateriaPrima"
        Me.ChIdMateriaPrima.Width = 84
        '
        'ChNombreMateriaPrima
        '
        Me.ChNombreMateriaPrima.Text = "Nombre Materia Prima"
        Me.ChNombreMateriaPrima.Width = 120
        '
        'ChExistenciaMinima
        '
        Me.ChExistenciaMinima.Text = "ExistenciaMinima"
        Me.ChExistenciaMinima.Width = 92
        '
        'ChExistencia
        '
        Me.ChExistencia.Text = "Existencia"
        Me.ChExistencia.Width = 72
        '
        'ChCantidad
        '
        Me.ChCantidad.Text = "Cantidad"
        '
        'ChPrecio
        '
        Me.ChPrecio.Text = "PrecioCostoM"
        '
        'ChFecha
        '
        Me.ChFecha.Text = "Fecha"
        '
        'ChMedida
        '
        Me.ChMedida.Text = "Medida"
        '
        'ChRTNProveedor
        '
        Me.ChRTNProveedor.Text = "RtnProveedor"
        Me.ChRTNProveedor.Width = 78
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(258, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(204, 25)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "Listar Materia Prima"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(199, 42)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(314, 27)
        Me.txtBuscar.TabIndex = 94
        '
        'FrmBuscarMateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(693, 372)
        Me.Controls.Add(Me.LsvMostrarMateriaPrima)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "FrmBuscarMateriaPrima"
        Me.Text = "FrmBuscarMateriaPrima"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LsvMostrarMateriaPrima As ListView
    Friend WithEvents ChIdMateriaPrima As ColumnHeader
    Friend WithEvents ChNombreMateriaPrima As ColumnHeader
    Friend WithEvents ChExistenciaMinima As ColumnHeader
    Friend WithEvents ChExistencia As ColumnHeader
    Friend WithEvents ChCantidad As ColumnHeader
    Friend WithEvents ChPrecio As ColumnHeader
    Friend WithEvents ChFecha As ColumnHeader
    Friend WithEvents ChMedida As ColumnHeader
    Friend WithEvents ChRTNProveedor As ColumnHeader
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBuscar As TextBox
End Class
