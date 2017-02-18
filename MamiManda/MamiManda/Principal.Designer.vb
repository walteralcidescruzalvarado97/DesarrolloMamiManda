<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnVenta
        '
        Me.BtnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVenta.Location = New System.Drawing.Point(128, 165)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(75, 23)
        Me.BtnVenta.TabIndex = 0
        Me.BtnVenta.Text = "Venta"
        Me.BtnVenta.UseVisualStyleBackColor = True
        '
        'BtnInventario
        '
        Me.BtnInventario.Location = New System.Drawing.Point(420, 223)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(75, 23)
        Me.BtnInventario.TabIndex = 1
        Me.BtnInventario.Text = "Inventario"
        Me.BtnInventario.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(209, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Btn
        '
        Me.Btn.Location = New System.Drawing.Point(289, 223)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(88, 23)
        Me.Btn.TabIndex = 0
        Me.Btn.Text = "Materia Prima"
        Me.Btn.UseVisualStyleBackColor = True
        '
        'BtnProveedor
        '
        Me.BtnProveedor.Location = New System.Drawing.Point(171, 223)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(75, 23)
        Me.BtnProveedor.TabIndex = 0
        Me.BtnProveedor.Text = "Proveedor"
        Me.BtnProveedor.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 335)
        Me.Controls.Add(Me.BtnInventario)
        Me.Controls.Add(Me.Btn)
        Me.Controls.Add(Me.BtnProveedor)
        Me.Controls.Add(Me.BtnVenta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmPrincipal"
        Me.Text = "MAMIMANDA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnVenta As Button
    Friend WithEvents BtnInventario As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn As Button
    Friend WithEvents BtnProveedor As Button
End Class
