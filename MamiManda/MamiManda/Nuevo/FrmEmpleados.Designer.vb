<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleados))
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.GcEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTipoEmpleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl1.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 149
        Me.NavBarControl1.Size = New System.Drawing.Size(149, 471)
        Me.NavBarControl1.TabIndex = 3
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Opciones"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        Me.NavBarGroup1.SmallImage = CType(resources.GetObject("NavBarGroup1.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "Crear nuevo"
        Me.NavBarItem1.LargeImage = CType(resources.GetObject("NavBarItem1.LargeImage"), System.Drawing.Image)
        Me.NavBarItem1.Name = "NavBarItem1"
        Me.NavBarItem1.SmallImage = CType(resources.GetObject("NavBarItem1.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "Editar registro"
        Me.NavBarItem2.Name = "NavBarItem2"
        Me.NavBarItem2.SmallImage = CType(resources.GetObject("NavBarItem2.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "Actualizar datos"
        Me.NavBarItem3.Name = "NavBarItem3"
        Me.NavBarItem3.SmallImage = CType(resources.GetObject("NavBarItem3.SmallImage"), System.Drawing.Image)
        '
        'GcEmpleados
        '
        Me.GcEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GcEmpleados.Location = New System.Drawing.Point(165, 15)
        Me.GcEmpleados.MainView = Me.GridView1
        Me.GcEmpleados.Name = "GcEmpleados"
        Me.GcEmpleados.Size = New System.Drawing.Size(739, 444)
        Me.GcEmpleados.TabIndex = 2
        Me.GcEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GcEmpleados
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.TxtDireccion)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.TxtTipoEmpleado)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.TxtTelefono)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.TxtEmail)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TxtNombreCompleto)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.TxtIdEmpleado)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(922, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(255, 471)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Datos del Empleado"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(11, 289)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(232, 92)
        Me.TxtDireccion.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Dirección:"
        '
        'TxtTipoEmpleado
        '
        Me.TxtTipoEmpleado.Location = New System.Drawing.Point(12, 240)
        Me.TxtTipoEmpleado.Name = "TxtTipoEmpleado"
        Me.TxtTipoEmpleado.ReadOnly = True
        Me.TxtTipoEmpleado.Size = New System.Drawing.Size(110, 21)
        Me.TxtTipoEmpleado.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tipo de empleado:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(11, 188)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.ReadOnly = True
        Me.TxtTelefono.Size = New System.Drawing.Size(111, 21)
        Me.TxtTelefono.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Teléfono:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(9, 135)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(184, 21)
        Me.TxtEmail.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Email:"
        '
        'TxtNombreCompleto
        '
        Me.TxtNombreCompleto.Location = New System.Drawing.Point(9, 84)
        Me.TxtNombreCompleto.Name = "TxtNombreCompleto"
        Me.TxtNombreCompleto.ReadOnly = True
        Me.TxtNombreCompleto.Size = New System.Drawing.Size(184, 21)
        Me.TxtNombreCompleto.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre completo:"
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(79, 42)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.ReadOnly = True
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(43, 21)
        Me.TxtIdEmpleado.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Id Empleado:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(746, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Hacer doble click para editar"
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MamiManda.My.Resources.Resources.IMG_20180311_WA0027
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1177, 471)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.GcEmpleados)
        Me.Name = "FrmEmpleados"
        Me.Text = "Gestion Empleados"
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents GcEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTipoEmpleado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombreCompleto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
