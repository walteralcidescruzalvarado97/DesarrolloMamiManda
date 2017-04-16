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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(116, 101)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(380, 26)
        Me.txtBuscar.TabIndex = 113
        '
        'LsvMostrarVentas
        '
        Me.LsvMostrarVentas.FullRowSelect = True
        Me.LsvMostrarVentas.GridLines = True
        Me.LsvMostrarVentas.Location = New System.Drawing.Point(12, 147)
        Me.LsvMostrarVentas.Name = "LsvMostrarVentas"
        Me.LsvMostrarVentas.Size = New System.Drawing.Size(610, 302)
        Me.LsvMostrarVentas.TabIndex = 112
        Me.LsvMostrarVentas.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarVentas.View = System.Windows.Forms.View.Details
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(63, 39)
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
        Me.ClientSize = New System.Drawing.Size(644, 468)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.LsvMostrarVentas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmHistorialVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents LsvMostrarVentas As ListView
    Friend WithEvents Label15 As Label
End Class
