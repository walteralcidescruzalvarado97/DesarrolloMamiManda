﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteVenta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 59)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar reporte por:"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(180, 27)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Fecha"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(98, 27)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Mes"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(18, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Año"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(420, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateEdit1.EditValue = New Date(2018, 4, 17, 19, 35, 58, 263)
        Me.DateEdit1.Location = New System.Drawing.Point(420, 12)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(153, 20)
        Me.DateEdit1.TabIndex = 24
        '
        'FrmReporteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MamiManda.My.Resources.Resources.FondoNew
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(603, 258)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmReporteVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
End Class
