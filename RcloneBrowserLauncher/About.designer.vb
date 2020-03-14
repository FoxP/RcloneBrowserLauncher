<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABOUT
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
        Me.labelImg = New System.Windows.Forms.Label()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.panelTitle = New System.Windows.Forms.Panel()
        Me.labelIcone = New System.Windows.Forms.Label()
        Me.labelExeInfo = New System.Windows.Forms.Label()
        Me.labelGitHub = New System.Windows.Forms.Label()
        Me.panelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelImg
        '
        Me.labelImg.BackColor = System.Drawing.Color.Transparent
        Me.labelImg.Image = Global.RcloneBrowserLauncher.My.Resources.Resources.coded_by
        Me.labelImg.Location = New System.Drawing.Point(36, 53)
        Me.labelImg.Name = "labelImg"
        Me.labelImg.Size = New System.Drawing.Size(183, 184)
        Me.labelImg.TabIndex = 1
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.White
        Me.labelTitle.Location = New System.Drawing.Point(78, 12)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(172, 27)
        Me.labelTitle.TabIndex = 2
        Me.labelTitle.Text = "RBLauncher"
        '
        'panelTitle
        '
        Me.panelTitle.BackColor = System.Drawing.Color.Black
        Me.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelTitle.Controls.Add(Me.labelIcone)
        Me.panelTitle.Controls.Add(Me.labelTitle)
        Me.panelTitle.Location = New System.Drawing.Point(-22, 0)
        Me.panelTitle.Name = "panelTitle"
        Me.panelTitle.Size = New System.Drawing.Size(396, 50)
        Me.panelTitle.TabIndex = 3
        '
        'labelIcone
        '
        Me.labelIcone.BackColor = System.Drawing.Color.Transparent
        Me.labelIcone.Image = Global.RcloneBrowserLauncher.My.Resources.Resources.information_small_white
        Me.labelIcone.Location = New System.Drawing.Point(27, 9)
        Me.labelIcone.Name = "labelIcone"
        Me.labelIcone.Size = New System.Drawing.Size(50, 31)
        Me.labelIcone.TabIndex = 4
        '
        'labelExeInfo
        '
        Me.labelExeInfo.AutoSize = True
        Me.labelExeInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelExeInfo.Location = New System.Drawing.Point(38, 237)
        Me.labelExeInfo.Name = "labelExeInfo"
        Me.labelExeInfo.Size = New System.Drawing.Size(82, 16)
        Me.labelExeInfo.TabIndex = 4
        Me.labelExeInfo.Text = "Version : {...}"
        '
        'labelGitHub
        '
        Me.labelGitHub.AutoSize = True
        Me.labelGitHub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelGitHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGitHub.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.labelGitHub.Location = New System.Drawing.Point(88, 269)
        Me.labelGitHub.Name = "labelGitHub"
        Me.labelGitHub.Size = New System.Drawing.Size(77, 16)
        Me.labelGitHub.TabIndex = 5
        Me.labelGitHub.Text = "GitHub : {...}"
        '
        'ABOUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(254, 292)
        Me.Controls.Add(Me.labelGitHub)
        Me.Controls.Add(Me.labelExeInfo)
        Me.Controls.Add(Me.panelTitle)
        Me.Controls.Add(Me.labelImg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABOUT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.panelTitle.ResumeLayout(False)
        Me.panelTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelImg As System.Windows.Forms.Label
    Friend WithEvents labelTitle As System.Windows.Forms.Label
    Friend WithEvents panelTitle As System.Windows.Forms.Panel
    Friend WithEvents labelIcone As System.Windows.Forms.Label
    Friend WithEvents labelExeInfo As System.Windows.Forms.Label
    Friend WithEvents labelGitHub As System.Windows.Forms.Label
End Class
