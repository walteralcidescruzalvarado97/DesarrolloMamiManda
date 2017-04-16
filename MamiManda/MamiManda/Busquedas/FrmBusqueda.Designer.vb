<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBusqueda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusqueda))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(550, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 31)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Usuarios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(731, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 31)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Empleados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(335, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 31)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 31)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Proveedor"
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.BtnEmpleados.BackgroundImage = CType(resources.GetObject("BtnEmpleados.BackgroundImage"), System.Drawing.Image)
        Me.BtnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmpleados.FlatAppearance.BorderSize = 0
        Me.BtnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleados.Location = New System.Drawing.Point(716, 67)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(173, 158)
        Me.BtnEmpleados.TabIndex = 19
        Me.BtnEmpleados.UseVisualStyleBackColor = False
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarios.BackgroundImage = CType(resources.GetObject("BtnUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.BtnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.Location = New System.Drawing.Point(521, 137)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(173, 158)
        Me.BtnUsuarios.TabIndex = 20
        Me.BtnUsuarios.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.BackgroundImage = CType(resources.GetObject("BtnClientes.BackgroundImage"), System.Drawing.Image)
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Location = New System.Drawing.Point(305, 137)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(174, 158)
        Me.BtnClientes.TabIndex = 21
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'BtnProveedor
        '
        Me.BtnProveedor.BackColor = System.Drawing.Color.Transparent
        Me.BtnProveedor.BackgroundImage = CType(resources.GetObject("BtnProveedor.BackgroundImage"), System.Drawing.Image)
        Me.BtnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProveedor.FlatAppearance.BorderSize = 0
        Me.BtnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedor.Location = New System.Drawing.Point(101, 67)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(171, 156)
        Me.BtnProveedor.TabIndex = 22
        Me.BtnProveedor.UseVisualStyleBackColor = False
        '
        'FrmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(991, 396)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEmpleados)
        Me.Controls.Add(Me.BtnUsuarios)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.BtnProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnProveedor As Button
End Class
