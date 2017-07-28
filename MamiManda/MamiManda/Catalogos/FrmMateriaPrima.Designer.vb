<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMateriaPrima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMateriaPrima))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtRtnProveedor = New System.Windows.Forms.TextBox()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.CboUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtExistenciaMinima = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombreMateriaPrima = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdMateriaPrima = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LsvMostrarMateriaPrima = New System.Windows.Forms.ListView()
        Me.ChIdMateriaPrima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreMateriaPrima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChExistenciaMinima = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChExistencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChMedida = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChProveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-5, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(741, 389)
        Me.TabControl1.TabIndex = 42
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.btnInsertar)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.btnActualizar)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.btnCancelar)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(733, 363)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gestión Materia Prima"
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
        Me.btnInsertar.Location = New System.Drawing.Point(485, 66)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(47, 43)
        Me.btnInsertar.TabIndex = 84
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gestión Materia Prima"
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
        Me.btnGuardar.Location = New System.Drawing.Point(487, 200)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(46, 42)
        Me.btnGuardar.TabIndex = 86
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtRtnProveedor)
        Me.GroupBox1.Controls.Add(Me.btnProveedor)
        Me.GroupBox1.Controls.Add(Me.CboUnidadMedida)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtFecha)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtExistenciaMinima)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtNombreMateriaPrima)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtIdMateriaPrima)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 271)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos materia prima"
        '
        'TxtRtnProveedor
        '
        Me.TxtRtnProveedor.Enabled = False
        Me.TxtRtnProveedor.Location = New System.Drawing.Point(172, 200)
        Me.TxtRtnProveedor.Name = "TxtRtnProveedor"
        Me.TxtRtnProveedor.Size = New System.Drawing.Size(146, 20)
        Me.TxtRtnProveedor.TabIndex = 17
        '
        'btnProveedor
        '
        Me.btnProveedor.BackgroundImage = CType(resources.GetObject("btnProveedor.BackgroundImage"), System.Drawing.Image)
        Me.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedor.FlatAppearance.BorderSize = 0
        Me.btnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedor.Location = New System.Drawing.Point(324, 198)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(26, 23)
        Me.btnProveedor.TabIndex = 18
        Me.btnProveedor.UseVisualStyleBackColor = True
        '
        'CboUnidadMedida
        '
        Me.CboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUnidadMedida.FormattingEnabled = True
        Me.CboUnidadMedida.Location = New System.Drawing.Point(172, 172)
        Me.CboUnidadMedida.Name = "CboUnidadMedida"
        Me.CboUnidadMedida.Size = New System.Drawing.Size(146, 21)
        Me.CboUnidadMedida.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(90, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Rtn Proveedor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Unidad de medida"
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(172, 145)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(146, 20)
        Me.TxtFecha.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Fecha"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(172, 119)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(146, 20)
        Me.TxtPrecio.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Precio costo"
        '
        'TxtExistenciaMinima
        '
        Me.TxtExistenciaMinima.Location = New System.Drawing.Point(172, 93)
        Me.TxtExistenciaMinima.Name = "TxtExistenciaMinima"
        Me.TxtExistenciaMinima.Size = New System.Drawing.Size(146, 20)
        Me.TxtExistenciaMinima.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Existencia mínima"
        '
        'TxtNombreMateriaPrima
        '
        Me.TxtNombreMateriaPrima.Location = New System.Drawing.Point(172, 67)
        Me.TxtNombreMateriaPrima.Name = "TxtNombreMateriaPrima"
        Me.TxtNombreMateriaPrima.Size = New System.Drawing.Size(146, 20)
        Me.TxtNombreMateriaPrima.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre materia prima"
        '
        'TxtIdMateriaPrima
        '
        Me.TxtIdMateriaPrima.Enabled = False
        Me.TxtIdMateriaPrima.Location = New System.Drawing.Point(172, 41)
        Me.TxtIdMateriaPrima.Name = "TxtIdMateriaPrima"
        Me.TxtIdMateriaPrima.Size = New System.Drawing.Size(146, 20)
        Me.TxtIdMateriaPrima.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id Materia Prima"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(477, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Actualizar"
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
        Me.btnActualizar.Location = New System.Drawing.Point(483, 130)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(47, 43)
        Me.btnActualizar.TabIndex = 85
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(484, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Guardar"
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
        Me.btnCancelar.Location = New System.Drawing.Point(492, 275)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 33)
        Me.btnCancelar.TabIndex = 87
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(484, 311)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Cancelar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(483, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Insertar"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.LsvMostrarMateriaPrima)
        Me.TabPage2.Controls.Add(Me.btnEditar)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtBuscar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(733, 363)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listar Materia Prima"
        '
        'LsvMostrarMateriaPrima
        '
        Me.LsvMostrarMateriaPrima.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdMateriaPrima, Me.ChNombreMateriaPrima, Me.ChExistenciaMinima, Me.ChExistencia, Me.ChFecha, Me.ChMedida, Me.ChProveedor})
        Me.LsvMostrarMateriaPrima.FullRowSelect = True
        Me.LsvMostrarMateriaPrima.GridLines = True
        Me.LsvMostrarMateriaPrima.Location = New System.Drawing.Point(0, 114)
        Me.LsvMostrarMateriaPrima.Name = "LsvMostrarMateriaPrima"
        Me.LsvMostrarMateriaPrima.Size = New System.Drawing.Size(727, 249)
        Me.LsvMostrarMateriaPrima.TabIndex = 93
        Me.LsvMostrarMateriaPrima.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarMateriaPrima.View = System.Windows.Forms.View.Details
        '
        'ChIdMateriaPrima
        '
        Me.ChIdMateriaPrima.Text = "Código"
        Me.ChIdMateriaPrima.Width = 84
        '
        'ChNombreMateriaPrima
        '
        Me.ChNombreMateriaPrima.Text = "Materia Prima"
        Me.ChNombreMateriaPrima.Width = 120
        '
        'ChExistenciaMinima
        '
        Me.ChExistenciaMinima.Text = "Existencia Minima"
        Me.ChExistenciaMinima.Width = 100
        '
        'ChExistencia
        '
        Me.ChExistencia.Text = "Existencia"
        '
        'ChFecha
        '
        Me.ChFecha.Text = "Fecha"
        Me.ChFecha.Width = 131
        '
        'ChMedida
        '
        Me.ChMedida.Text = "Medida"
        Me.ChMedida.Width = 100
        '
        'ChProveedor
        '
        Me.ChProveedor.Text = "Proveedor"
        Me.ChProveedor.Width = 120
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.Location = New System.Drawing.Point(526, 73)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 92
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(58, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(204, 25)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Listar Materia Prima"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(198, 71)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(314, 27)
        Me.txtBuscar.TabIndex = 90
        '
        'FrmMateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 384)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMateriaPrima"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MateriaPrima"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnInsertar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtRtnProveedor As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtExistenciaMinima As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombreMateriaPrima As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdMateriaPrima As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CboUnidadMedida As ComboBox
    Friend WithEvents btnProveedor As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents LsvMostrarMateriaPrima As ListView
    Friend WithEvents ChIdMateriaPrima As ColumnHeader
    Friend WithEvents ChNombreMateriaPrima As ColumnHeader
    Friend WithEvents ChExistenciaMinima As ColumnHeader
    Friend WithEvents ChExistencia As ColumnHeader
    Friend WithEvents ChProveedor As ColumnHeader
    Friend WithEvents ChFecha As ColumnHeader
    Friend WithEvents ChMedida As ColumnHeader
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
