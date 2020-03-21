<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gbEndAction = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelEndAction = New System.Windows.Forms.TableLayoutPanel()
        Me.cbActivateEndAction = New System.Windows.Forms.CheckBox()
        Me.cbEndAction = New System.Windows.Forms.ComboBox()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanelSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.cbActivatePwd = New System.Windows.Forms.CheckBox()
        Me.lbRcloneBrowserPath = New System.Windows.Forms.Label()
        Me.lbRclonePwd = New System.Windows.Forms.Label()
        Me.cbRclonePath = New System.Windows.Forms.Button()
        Me.tbRclonePwd = New System.Windows.Forms.TextBox()
        Me.tbRcloneBrowserPath = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanelRun = New System.Windows.Forms.TableLayoutPanel()
        Me.cbAbout = New System.Windows.Forms.Button()
        Me.cbRunRcloneBrowser = New System.Windows.Forms.Button()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.gbEndAction.SuspendLayout()
        Me.TableLayoutPanelEndAction.SuspendLayout()
        Me.gbSettings.SuspendLayout()
        Me.TableLayoutPanelSettings.SuspendLayout()
        Me.TableLayoutPanelRun.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.ColumnCount = 1
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.gbEndAction, 0, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.gbSettings, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanelRun, 0, 2)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 3
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(704, 216)
        Me.TableLayoutPanelMain.TabIndex = 0
        '
        'gbEndAction
        '
        Me.gbEndAction.Controls.Add(Me.TableLayoutPanelEndAction)
        Me.gbEndAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbEndAction.Location = New System.Drawing.Point(10, 105)
        Me.gbEndAction.Margin = New System.Windows.Forms.Padding(10, 3, 10, 0)
        Me.gbEndAction.Name = "gbEndAction"
        Me.gbEndAction.Size = New System.Drawing.Size(684, 65)
        Me.gbEndAction.TabIndex = 8
        Me.gbEndAction.TabStop = False
        Me.gbEndAction.Text = " Finished queue action : "
        '
        'TableLayoutPanelEndAction
        '
        Me.TableLayoutPanelEndAction.ColumnCount = 2
        Me.TableLayoutPanelEndAction.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndAction.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanelEndAction.Controls.Add(Me.cbActivateEndAction, 0, 0)
        Me.TableLayoutPanelEndAction.Controls.Add(Me.cbEndAction, 0, 0)
        Me.TableLayoutPanelEndAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelEndAction.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelEndAction.Name = "TableLayoutPanelEndAction"
        Me.TableLayoutPanelEndAction.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TableLayoutPanelEndAction.RowCount = 1
        Me.TableLayoutPanelEndAction.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEndAction.Size = New System.Drawing.Size(678, 46)
        Me.TableLayoutPanelEndAction.TabIndex = 8
        '
        'cbActivateEndAction
        '
        Me.cbActivateEndAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbActivateEndAction.AutoSize = True
        Me.cbActivateEndAction.Location = New System.Drawing.Point(603, 13)
        Me.cbActivateEndAction.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.cbActivateEndAction.Name = "cbActivateEndAction"
        Me.cbActivateEndAction.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.cbActivateEndAction.Size = New System.Drawing.Size(67, 19)
        Me.cbActivateEndAction.TabIndex = 10
        Me.cbActivateEndAction.Text = "Enabled"
        Me.cbActivateEndAction.UseVisualStyleBackColor = True
        '
        'cbEndAction
        '
        Me.cbEndAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEndAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEndAction.Enabled = False
        Me.cbEndAction.FormattingEnabled = True
        Me.cbEndAction.Location = New System.Drawing.Point(8, 12)
        Me.cbEndAction.Name = "cbEndAction"
        Me.cbEndAction.Size = New System.Drawing.Size(587, 21)
        Me.cbEndAction.TabIndex = 9
        '
        'gbSettings
        '
        Me.gbSettings.Controls.Add(Me.TableLayoutPanelSettings)
        Me.gbSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSettings.Location = New System.Drawing.Point(10, 5)
        Me.gbSettings.Margin = New System.Windows.Forms.Padding(10, 5, 10, 3)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(684, 94)
        Me.gbSettings.TabIndex = 2
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = " Settings : "
        '
        'TableLayoutPanelSettings
        '
        Me.TableLayoutPanelSettings.ColumnCount = 3
        Me.TableLayoutPanelSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TableLayoutPanelSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanelSettings.Controls.Add(Me.cbActivatePwd, 2, 1)
        Me.TableLayoutPanelSettings.Controls.Add(Me.lbRcloneBrowserPath, 0, 0)
        Me.TableLayoutPanelSettings.Controls.Add(Me.lbRclonePwd, 0, 1)
        Me.TableLayoutPanelSettings.Controls.Add(Me.cbRclonePath, 2, 0)
        Me.TableLayoutPanelSettings.Controls.Add(Me.tbRclonePwd, 1, 1)
        Me.TableLayoutPanelSettings.Controls.Add(Me.tbRcloneBrowserPath, 1, 0)
        Me.TableLayoutPanelSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelSettings.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanelSettings.Name = "TableLayoutPanelSettings"
        Me.TableLayoutPanelSettings.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TableLayoutPanelSettings.RowCount = 2
        Me.TableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelSettings.Size = New System.Drawing.Size(678, 75)
        Me.TableLayoutPanelSettings.TabIndex = 3
        '
        'cbActivatePwd
        '
        Me.cbActivatePwd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbActivatePwd.AutoSize = True
        Me.cbActivatePwd.Location = New System.Drawing.Point(603, 46)
        Me.cbActivatePwd.Margin = New System.Windows.Forms.Padding(4, 3, 3, 3)
        Me.cbActivatePwd.Name = "cbActivatePwd"
        Me.cbActivatePwd.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.cbActivatePwd.Size = New System.Drawing.Size(68, 19)
        Me.cbActivatePwd.TabIndex = 7
        Me.cbActivatePwd.Text = "Enabled"
        Me.cbActivatePwd.UseVisualStyleBackColor = True
        '
        'lbRcloneBrowserPath
        '
        Me.lbRcloneBrowserPath.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbRcloneBrowserPath.AutoSize = True
        Me.lbRcloneBrowserPath.Location = New System.Drawing.Point(7, 12)
        Me.lbRcloneBrowserPath.Name = "lbRcloneBrowserPath"
        Me.lbRcloneBrowserPath.Size = New System.Drawing.Size(148, 13)
        Me.lbRcloneBrowserPath.TabIndex = 8
        Me.lbRcloneBrowserPath.Text = "RcloneBrowser.exe location : "
        '
        'lbRclonePwd
        '
        Me.lbRclonePwd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbRclonePwd.AutoSize = True
        Me.lbRclonePwd.Location = New System.Drawing.Point(7, 49)
        Me.lbRclonePwd.Name = "lbRclonePwd"
        Me.lbRclonePwd.Size = New System.Drawing.Size(122, 13)
        Me.lbRclonePwd.TabIndex = 9
        Me.lbRclonePwd.Text = "Rclone.conf password : "
        '
        'cbRclonePath
        '
        Me.cbRclonePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRclonePath.Location = New System.Drawing.Point(602, 7)
        Me.cbRclonePath.Name = "cbRclonePath"
        Me.cbRclonePath.Size = New System.Drawing.Size(69, 22)
        Me.cbRclonePath.TabIndex = 5
        Me.cbRclonePath.Text = "..."
        Me.cbRclonePath.UseVisualStyleBackColor = True
        '
        'tbRclonePwd
        '
        Me.tbRclonePwd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRclonePwd.Enabled = False
        Me.tbRclonePwd.Location = New System.Drawing.Point(162, 46)
        Me.tbRclonePwd.Margin = New System.Windows.Forms.Padding(3, 3, 4, 3)
        Me.tbRclonePwd.Name = "tbRclonePwd"
        Me.tbRclonePwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tbRclonePwd.Size = New System.Drawing.Size(433, 20)
        Me.tbRclonePwd.TabIndex = 6
        '
        'tbRcloneBrowserPath
        '
        Me.tbRcloneBrowserPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRcloneBrowserPath.Enabled = False
        Me.tbRcloneBrowserPath.Location = New System.Drawing.Point(162, 8)
        Me.tbRcloneBrowserPath.Margin = New System.Windows.Forms.Padding(3, 3, 4, 3)
        Me.tbRcloneBrowserPath.Name = "tbRcloneBrowserPath"
        Me.tbRcloneBrowserPath.Size = New System.Drawing.Size(433, 20)
        Me.tbRcloneBrowserPath.TabIndex = 4
        '
        'TableLayoutPanelRun
        '
        Me.TableLayoutPanelRun.ColumnCount = 2
        Me.TableLayoutPanelRun.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRun.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanelRun.Controls.Add(Me.cbAbout, 0, 0)
        Me.TableLayoutPanelRun.Controls.Add(Me.cbRunRcloneBrowser, 0, 0)
        Me.TableLayoutPanelRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelRun.Location = New System.Drawing.Point(6, 173)
        Me.TableLayoutPanelRun.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TableLayoutPanelRun.Name = "TableLayoutPanelRun"
        Me.TableLayoutPanelRun.RowCount = 1
        Me.TableLayoutPanelRun.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRun.Size = New System.Drawing.Size(692, 40)
        Me.TableLayoutPanelRun.TabIndex = 11
        '
        'cbAbout
        '
        Me.cbAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAbout.Location = New System.Drawing.Point(609, 8)
        Me.cbAbout.Margin = New System.Windows.Forms.Padding(4, 3, 3, 3)
        Me.cbAbout.Name = "cbAbout"
        Me.cbAbout.Size = New System.Drawing.Size(80, 23)
        Me.cbAbout.TabIndex = 12
        Me.cbAbout.Text = "?"
        Me.cbAbout.UseVisualStyleBackColor = True
        '
        'cbRunRcloneBrowser
        '
        Me.cbRunRcloneBrowser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRunRcloneBrowser.Location = New System.Drawing.Point(3, 8)
        Me.cbRunRcloneBrowser.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
        Me.cbRunRcloneBrowser.Name = "cbRunRcloneBrowser"
        Me.cbRunRcloneBrowser.Size = New System.Drawing.Size(600, 23)
        Me.cbRunRcloneBrowser.TabIndex = 11
        Me.cbRunRcloneBrowser.Text = "Run Rclone Browser"
        Me.cbRunRcloneBrowser.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 216)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(4320, 255)
        Me.MinimumSize = New System.Drawing.Size(720, 255)
        Me.Name = "MainForm"
        Me.Text = "RcloneBrowserLauncher"
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.gbEndAction.ResumeLayout(False)
        Me.TableLayoutPanelEndAction.ResumeLayout(False)
        Me.TableLayoutPanelEndAction.PerformLayout()
        Me.gbSettings.ResumeLayout(False)
        Me.TableLayoutPanelSettings.ResumeLayout(False)
        Me.TableLayoutPanelSettings.PerformLayout()
        Me.TableLayoutPanelRun.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents gbSettings As GroupBox
    Friend WithEvents lbRclonePwd As Label
    Friend WithEvents lbRcloneBrowserPath As Label
    Friend WithEvents cbActivatePwd As CheckBox
    Friend WithEvents tbRclonePwd As TextBox
    Friend WithEvents cbRclonePath As Button
    Friend WithEvents tbRcloneBrowserPath As TextBox
    Friend WithEvents gbEndAction As GroupBox
    Friend WithEvents TableLayoutPanelSettings As TableLayoutPanel
    Friend WithEvents TableLayoutPanelEndAction As TableLayoutPanel
    Friend WithEvents cbEndAction As ComboBox
    Friend WithEvents cbActivateEndAction As CheckBox
    Friend WithEvents TableLayoutPanelRun As TableLayoutPanel
    Friend WithEvents cbRunRcloneBrowser As Button
    Friend WithEvents cbAbout As Button
End Class
