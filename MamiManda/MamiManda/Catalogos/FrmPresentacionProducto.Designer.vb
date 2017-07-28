<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresentacionProducto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPresentacionProducto))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TPGestionPresentacion = New System.Windows.Forms.TabPage()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.txtPreCosto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPreDetalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPreMayorista = New System.Windows.Forms.TextBox()
        Me.cboPresentacion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodInventario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.TPListarPresentacion = New System.Windows.Forms.TabPage()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lsvMostrar = New System.Windows.Forms.ListView()
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUnidades = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecioMAyorista = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecioDEtalle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecioCOsto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TabControl1.SuspendLayout()
        Me.TPGestionPresentacion.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.TPListarPresentacion.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPGestionPresentacion)
        Me.TabControl1.Controls.Add(Me.TPListarPresentacion)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(607, 381)
        Me.TabControl1.TabIndex = 71
        '
        'TPGestionPresentacion
        '
        Me.TPGestionPresentacion.BackColor = System.Drawing.Color.Transparent
        Me.TPGestionPresentacion.BackgroundImage = CType(resources.GetObject("TPGestionPresentacion.BackgroundImage"), System.Drawing.Image)
        Me.TPGestionPresentacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TPGestionPresentacion.Controls.Add(Me.gbDatos)
        Me.TPGestionPresentacion.Controls.Add(Me.Label1)
        Me.TPGestionPresentacion.Controls.Add(Me.btnInsertar)
        Me.TPGestionPresentacion.Controls.Add(Me.btnGuardar)
        Me.TPGestionPresentacion.Controls.Add(Me.Label9)
        Me.TPGestionPresentacion.Controls.Add(Me.Label10)
        Me.TPGestionPresentacion.Controls.Add(Me.Label8)
        Me.TPGestionPresentacion.Controls.Add(Me.Label13)
        Me.TPGestionPresentacion.Controls.Add(Me.btnCancelar)
        Me.TPGestionPresentacion.Controls.Add(Me.btnActualizar)
        Me.TPGestionPresentacion.Location = New System.Drawing.Point(4, 22)
        Me.TPGestionPresentacion.Name = "TPGestionPresentacion"
        Me.TPGestionPresentacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TPGestionPresentacion.Size = New System.Drawing.Size(599, 355)
        Me.TPGestionPresentacion.TabIndex = 0
        Me.TPGestionPresentacion.Text = "Presentacion Producto"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.btnInventario)
        Me.gbDatos.Controls.Add(Me.txtPreCosto)
        Me.gbDatos.Controls.Add(Me.Label12)
        Me.gbDatos.Controls.Add(Me.txtPreDetalle)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.txtPreMayorista)
        Me.gbDatos.Controls.Add(Me.cboPresentacion)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtCodInventario)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Location = New System.Drawing.Point(55, 75)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(358, 223)
        Me.gbDatos.TabIndex = 66
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos "
        '
        'btnInventario
        '
        Me.btnInventario.BackgroundImage = CType(resources.GetObject("btnInventario.BackgroundImage"), System.Drawing.Image)
        Me.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Location = New System.Drawing.Point(293, 49)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(26, 23)
        Me.btnInventario.TabIndex = 16
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'txtPreCosto
        '
        Me.txtPreCosto.Location = New System.Drawing.Point(135, 182)
        Me.txtPreCosto.Name = "txtPreCosto"
        Me.txtPreCosto.Size = New System.Drawing.Size(177, 20)
        Me.txtPreCosto.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Precio Costo"
        '
        'txtPreDetalle
        '
        Me.txtPreDetalle.Location = New System.Drawing.Point(135, 156)
        Me.txtPreDetalle.Name = "txtPreDetalle"
        Me.txtPreDetalle.Size = New System.Drawing.Size(177, 20)
        Me.txtPreDetalle.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Precio Detalle"
        '
        'txtPreMayorista
        '
        Me.txtPreMayorista.Location = New System.Drawing.Point(135, 130)
        Me.txtPreMayorista.Name = "txtPreMayorista"
        Me.txtPreMayorista.Size = New System.Drawing.Size(177, 20)
        Me.txtPreMayorista.TabIndex = 11
        '
        'cboPresentacion
        '
        Me.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPresentacion.FormattingEnabled = True
        Me.cboPresentacion.Location = New System.Drawing.Point(135, 103)
        Me.cboPresentacion.Name = "cboPresentacion"
        Me.cboPresentacion.Size = New System.Drawing.Size(177, 21)
        Me.cboPresentacion.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio Mayorista"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tipo Presentación"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(135, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(177, 20)
        Me.txtNombre.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre Producto"
        '
        'txtCodInventario
        '
        Me.txtCodInventario.Enabled = False
        Me.txtCodInventario.Location = New System.Drawing.Point(135, 51)
        Me.txtCodInventario.Name = "txtCodInventario"
        Me.txtCodInventario.Size = New System.Drawing.Size(152, 20)
        Me.txtCodInventario.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código Inventario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Presentación Producto"
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
        'TPListarPresentacion
        '
        Me.TPListarPresentacion.BackgroundImage = CType(resources.GetObject("TPListarPresentacion.BackgroundImage"), System.Drawing.Image)
        Me.TPListarPresentacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TPListarPresentacion.Controls.Add(Me.btnEditar)
        Me.TPListarPresentacion.Controls.Add(Me.txtBuscar)
        Me.TPListarPresentacion.Controls.Add(Me.Label11)
        Me.TPListarPresentacion.Controls.Add(Me.lsvMostrar)
        Me.TPListarPresentacion.Location = New System.Drawing.Point(4, 22)
        Me.TPListarPresentacion.Name = "TPListarPresentacion"
        Me.TPListarPresentacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TPListarPresentacion.Size = New System.Drawing.Size(599, 355)
        Me.TPListarPresentacion.TabIndex = 1
        Me.TPListarPresentacion.Text = "Listar Presentación"
        Me.TPListarPresentacion.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.Location = New System.Drawing.Point(471, 75)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 82
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(73, 73)
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
        Me.Label11.Location = New System.Drawing.Point(31, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 25)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Listar Presentación"
        '
        'lsvMostrar
        '
        Me.lsvMostrar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNombre, Me.chTipo, Me.chUnidades, Me.chPrecioMAyorista, Me.chPrecioDEtalle, Me.chPrecioCOsto})
        Me.lsvMostrar.FullRowSelect = True
        Me.lsvMostrar.GridLines = True
        Me.lsvMostrar.Location = New System.Drawing.Point(0, 111)
        Me.lsvMostrar.Name = "lsvMostrar"
        Me.lsvMostrar.Size = New System.Drawing.Size(599, 248)
        Me.lsvMostrar.TabIndex = 78
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
        Me.chPrecioDEtalle.Width = 84
        '
        'chPrecioCOsto
        '
        Me.chPrecioCOsto.Text = "Precio Costo"
        Me.chPrecioCOsto.Width = 88
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmPresentacionProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MamiManda.My.Resources.Resources.Imagen1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 378)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPresentacionProducto"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentacion Producto"
        Me.TabControl1.ResumeLayout(False)
        Me.TPGestionPresentacion.ResumeLayout(False)
        Me.TPGestionPresentacion.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.TPListarPresentacion.ResumeLayout(False)
        Me.TPListarPresentacion.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPGestionPresentacion As TabPage
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodInventario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents TPListarPresentacion As TabPage
    Friend WithEvents btnEditar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lsvMostrar As ListView
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents chTipo As ColumnHeader
    Friend WithEvents chPrecioMAyorista As ColumnHeader
    Friend WithEvents chPrecioDEtalle As ColumnHeader
    Friend WithEvents chPrecioCOsto As ColumnHeader
    Friend WithEvents btnInventario As Button
    Friend WithEvents txtPreCosto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPreDetalle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPreMayorista As TextBox
    Friend WithEvents cboPresentacion As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents chUnidades As ColumnHeader
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
