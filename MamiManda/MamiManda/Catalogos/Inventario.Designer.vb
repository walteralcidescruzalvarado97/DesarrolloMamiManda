<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventario))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TPGestionInventario = New System.Windows.Forms.TabPage()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtExistenciaMinima = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtExistenciaMaxima = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodInventario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.TPListarInventario = New System.Windows.Forms.TabPage()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lsvMostrar = New System.Windows.Forms.ListView()
        Me.chCodInventario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExistenciaMaxima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExistenciaMinima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExistencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TPGestionInventario.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.TPListarInventario.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPGestionInventario)
        Me.TabControl1.Controls.Add(Me.TPListarInventario)
        Me.TabControl1.Location = New System.Drawing.Point(-5, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(596, 381)
        Me.TabControl1.TabIndex = 70
        '
        'TPGestionInventario
        '
        Me.TPGestionInventario.BackColor = System.Drawing.Color.Transparent
        Me.TPGestionInventario.BackgroundImage = CType(resources.GetObject("TPGestionInventario.BackgroundImage"), System.Drawing.Image)
        Me.TPGestionInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TPGestionInventario.Controls.Add(Me.gbDatos)
        Me.TPGestionInventario.Controls.Add(Me.Label1)
        Me.TPGestionInventario.Controls.Add(Me.btnInsertar)
        Me.TPGestionInventario.Controls.Add(Me.btnGuardar)
        Me.TPGestionInventario.Controls.Add(Me.Label9)
        Me.TPGestionInventario.Controls.Add(Me.Label10)
        Me.TPGestionInventario.Controls.Add(Me.Label8)
        Me.TPGestionInventario.Controls.Add(Me.Label13)
        Me.TPGestionInventario.Controls.Add(Me.btnCancelar)
        Me.TPGestionInventario.Controls.Add(Me.btnActualizar)
        Me.TPGestionInventario.Location = New System.Drawing.Point(4, 22)
        Me.TPGestionInventario.Name = "TPGestionInventario"
        Me.TPGestionInventario.Padding = New System.Windows.Forms.Padding(3)
        Me.TPGestionInventario.Size = New System.Drawing.Size(588, 355)
        Me.TPGestionInventario.TabIndex = 0
        Me.TPGestionInventario.Text = "Gestión Inventario"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.txtExistenciaMinima)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.txtExistenciaMaxima)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.txtCodInventario)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Location = New System.Drawing.Point(55, 75)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(339, 223)
        Me.gbDatos.TabIndex = 66
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos "
        '
        'txtExistenciaMinima
        '
        Me.txtExistenciaMinima.Location = New System.Drawing.Point(118, 138)
        Me.txtExistenciaMinima.Name = "txtExistenciaMinima"
        Me.txtExistenciaMinima.Size = New System.Drawing.Size(177, 20)
        Me.txtExistenciaMinima.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Existencia Mínima"
        '
        'txtExistenciaMaxima
        '
        Me.txtExistenciaMaxima.Location = New System.Drawing.Point(118, 99)
        Me.txtExistenciaMaxima.Name = "txtExistenciaMaxima"
        Me.txtExistenciaMaxima.Size = New System.Drawing.Size(177, 20)
        Me.txtExistenciaMaxima.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Existencia Máxima"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(118, 61)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(177, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Producto"
        '
        'txtCodInventario
        '
        Me.txtCodInventario.Location = New System.Drawing.Point(118, 25)
        Me.txtCodInventario.MaxLength = 4
        Me.txtCodInventario.Name = "txtCodInventario"
        Me.txtCodInventario.Size = New System.Drawing.Size(177, 20)
        Me.txtCodInventario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código Inventario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 25)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Gestión Inventario"
        '
        'btnInsertar
        '
        Me.btnInsertar.BackColor = System.Drawing.Color.Transparent
        Me.btnInsertar.BackgroundImage = CType(resources.GetObject("btnInsertar.BackgroundImage"), System.Drawing.Image)
        Me.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsertar.FlatAppearance.BorderSize = 0
        Me.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertar.Location = New System.Drawing.Point(453, 53)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(47, 43)
        Me.btnInsertar.TabIndex = 55
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(455, 181)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(46, 42)
        Me.btnGuardar.TabIndex = 56
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(451, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Guardar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(447, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Actualizar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(453, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Insertar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(451, 292)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Cancelar"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(459, 256)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 33)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.BackgroundImage = CType(resources.GetObject("btnActualizar.BackgroundImage"), System.Drawing.Image)
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Location = New System.Drawing.Point(452, 114)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(47, 43)
        Me.btnActualizar.TabIndex = 61
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'TPListarInventario
        '
        Me.TPListarInventario.BackgroundImage = CType(resources.GetObject("TPListarInventario.BackgroundImage"), System.Drawing.Image)
        Me.TPListarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TPListarInventario.Controls.Add(Me.btnEditar)
        Me.TPListarInventario.Controls.Add(Me.txtBuscar)
        Me.TPListarInventario.Controls.Add(Me.Label11)
        Me.TPListarInventario.Controls.Add(Me.lsvMostrar)
        Me.TPListarInventario.Location = New System.Drawing.Point(4, 22)
        Me.TPListarInventario.Name = "TPListarInventario"
        Me.TPListarInventario.Padding = New System.Windows.Forms.Padding(3)
        Me.TPListarInventario.Size = New System.Drawing.Size(588, 355)
        Me.TPListarInventario.TabIndex = 1
        Me.TPListarInventario.Text = "Listar Inventario"
        Me.TPListarInventario.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.Location = New System.Drawing.Point(467, 75)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 82
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(73, 74)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(380, 26)
        Me.txtBuscar.TabIndex = 81
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 25)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Listar Inventario"
        '
        'lsvMostrar
        '
        Me.lsvMostrar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCodInventario, Me.chNombre, Me.chExistenciaMaxima, Me.chExistenciaMinima, Me.chExistencia})
        Me.lsvMostrar.FullRowSelect = True
        Me.lsvMostrar.GridLines = True
        Me.lsvMostrar.Location = New System.Drawing.Point(0, 114)
        Me.lsvMostrar.Name = "lsvMostrar"
        Me.lsvMostrar.Size = New System.Drawing.Size(588, 239)
        Me.lsvMostrar.TabIndex = 78
        Me.lsvMostrar.UseCompatibleStateImageBehavior = False
        Me.lsvMostrar.View = System.Windows.Forms.View.Details
        '
        'chCodInventario
        '
        Me.chCodInventario.Text = "Código Inventario"
        Me.chCodInventario.Width = 110
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre Producto"
        Me.chNombre.Width = 120
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(586, 376)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "FrmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.TabControl1.ResumeLayout(False)
        Me.TPGestionInventario.ResumeLayout(False)
        Me.TPGestionInventario.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.TPListarInventario.ResumeLayout(False)
        Me.TPListarInventario.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPGestionInventario As TabPage
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents txtExistenciaMinima As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtExistenciaMaxima As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodInventario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents TPListarInventario As TabPage
    Friend WithEvents btnEditar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lsvMostrar As ListView
    Friend WithEvents chCodInventario As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chExistenciaMaxima As ColumnHeader
    Friend WithEvents chExistenciaMinima As ColumnHeader
    Friend WithEvents chExistencia As ColumnHeader
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
