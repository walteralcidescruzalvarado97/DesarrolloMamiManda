<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarPermisos))
        Me.GcModulosDisponibles = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GcModulosAsignados = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GcUsuario = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnRemover = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GcModulosDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcModulosAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GcModulosDisponibles
        '
        Me.GcModulosDisponibles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GcModulosDisponibles.Location = New System.Drawing.Point(39, 204)
        Me.GcModulosDisponibles.MainView = Me.GridView2
        Me.GcModulosDisponibles.Name = "GcModulosDisponibles"
        Me.GcModulosDisponibles.Size = New System.Drawing.Size(266, 235)
        Me.GcModulosDisponibles.TabIndex = 5
        Me.GcModulosDisponibles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GcModulosDisponibles
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GcModulosAsignados
        '
        Me.GcModulosAsignados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GcModulosAsignados.Location = New System.Drawing.Point(628, 204)
        Me.GcModulosAsignados.MainView = Me.GridView3
        Me.GcModulosAsignados.Name = "GcModulosAsignados"
        Me.GcModulosAsignados.Size = New System.Drawing.Size(261, 235)
        Me.GcModulosAsignados.TabIndex = 6
        Me.GcModulosAsignados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GcModulosAsignados
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GcUsuario
        '
        Me.GcUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GcUsuario.Location = New System.Drawing.Point(39, 12)
        Me.GcUsuario.MainView = Me.GridView1
        Me.GcUsuario.Name = "GcUsuario"
        Me.GcUsuario.Size = New System.Drawing.Size(850, 176)
        Me.GcUsuario.TabIndex = 7
        Me.GcUsuario.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GcUsuario
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(432, 268)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(84, 57)
        Me.BtnAgregar.TabIndex = 8
        '
        'BtnRemover
        '
        Me.BtnRemover.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRemover.Image = CType(resources.GetObject("BtnRemover.Image"), System.Drawing.Image)
        Me.BtnRemover.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnRemover.Location = New System.Drawing.Point(432, 331)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Size = New System.Drawing.Size(84, 57)
        Me.BtnRemover.TabIndex = 9
        '
        'FrmAsignarPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 451)
        Me.Controls.Add(Me.BtnRemover)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.GcUsuario)
        Me.Controls.Add(Me.GcModulosAsignados)
        Me.Controls.Add(Me.GcModulosDisponibles)
        Me.Name = "FrmAsignarPermisos"
        Me.Text = "FrmAsignarPermisos"
        CType(Me.GcModulosDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcModulosAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GcModulosDisponibles As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GcModulosAsignados As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GcUsuario As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnRemover As DevExpress.XtraEditors.SimpleButton
End Class
