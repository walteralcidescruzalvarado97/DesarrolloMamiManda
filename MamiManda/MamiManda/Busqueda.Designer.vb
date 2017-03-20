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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelControl3)
        Me.Panel1.Controls.Add(Me.LabelControl4)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.BtnEmpleados)
        Me.Panel1.Controls.Add(Me.BtnUsuarios)
        Me.Panel1.Controls.Add(Me.BtnClientes)
        Me.Panel1.Controls.Add(Me.BtnProveedor)
        Me.Panel1.Location = New System.Drawing.Point(62, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(869, 320)
        Me.Panel1.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(681, 191)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(129, 33)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Empleados"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(497, 257)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(102, 33)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Usuarios"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(287, 261)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 33)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Clientes"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(73, 183)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 29)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Proveedor"
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.BackgroundImage = CType(resources.GetObject("BtnEmpleados.BackgroundImage"), System.Drawing.Image)
        Me.BtnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmpleados.FlatAppearance.BorderSize = 0
        Me.BtnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleados.Location = New System.Drawing.Point(655, 27)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(173, 158)
        Me.BtnEmpleados.TabIndex = 3
        Me.BtnEmpleados.UseVisualStyleBackColor = True
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.BackgroundImage = CType(resources.GetObject("BtnUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.BtnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.Location = New System.Drawing.Point(460, 97)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(173, 158)
        Me.BtnUsuarios.TabIndex = 4
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.BackgroundImage = CType(resources.GetObject("BtnClientes.BackgroundImage"), System.Drawing.Image)
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Location = New System.Drawing.Point(244, 97)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(174, 158)
        Me.BtnClientes.TabIndex = 5
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnProveedor
        '
        Me.BtnProveedor.BackgroundImage = CType(resources.GetObject("BtnProveedor.BackgroundImage"), System.Drawing.Image)
        Me.BtnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProveedor.FlatAppearance.BorderSize = 0
        Me.BtnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedor.Location = New System.Drawing.Point(40, 27)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(171, 156)
        Me.BtnProveedor.TabIndex = 6
        Me.BtnProveedor.UseVisualStyleBackColor = True
        '
        'FrmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(991, 396)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FrmBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnProveedor As Button
End Class
