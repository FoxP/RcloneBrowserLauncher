<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndAction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndAction))
        Me.cbCancel = New System.Windows.Forms.Button()
        Me.cbOk = New System.Windows.Forms.Button()
        Me.lbCountdown = New System.Windows.Forms.Label()
        Me.lbDescription = New System.Windows.Forms.Label()
        Me.lbCancel = New System.Windows.Forms.Label()
        Me.lbJobsCompleted = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbCancel
        '
        Me.cbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cbCancel.Location = New System.Drawing.Point(175, 76)
        Me.cbCancel.Name = "cbCancel"
        Me.cbCancel.Size = New System.Drawing.Size(75, 23)
        Me.cbCancel.TabIndex = 2
        Me.cbCancel.Text = "Cancel"
        Me.cbCancel.UseVisualStyleBackColor = True
        '
        'cbOk
        '
        Me.cbOk.Location = New System.Drawing.Point(89, 76)
        Me.cbOk.Name = "cbOk"
        Me.cbOk.Size = New System.Drawing.Size(75, 23)
        Me.cbOk.TabIndex = 1
        Me.cbOk.Text = "Ok"
        Me.cbOk.UseVisualStyleBackColor = True
        '
        'lbCountdown
        '
        Me.lbCountdown.Location = New System.Drawing.Point(168, 32)
        Me.lbCountdown.Name = "lbCountdown"
        Me.lbCountdown.Size = New System.Drawing.Size(85, 13)
        Me.lbCountdown.TabIndex = 3
        Me.lbCountdown.Text = "{COUNT}"
        Me.lbCountdown.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDescription
        '
        Me.lbDescription.AutoSize = True
        Me.lbDescription.Location = New System.Drawing.Point(9, 32)
        Me.lbDescription.Name = "lbDescription"
        Me.lbDescription.Size = New System.Drawing.Size(88, 13)
        Me.lbDescription.TabIndex = 4
        Me.lbDescription.Text = "{DESCRIPTION}"
        '
        'lbCancel
        '
        Me.lbCancel.AutoSize = True
        Me.lbCancel.Location = New System.Drawing.Point(9, 54)
        Me.lbCancel.Name = "lbCancel"
        Me.lbCancel.Size = New System.Drawing.Size(183, 13)
        Me.lbCancel.TabIndex = 6
        Me.lbCancel.Text = "Click ""Cancel"" to abort the operation."
        '
        'lbJobsCompleted
        '
        Me.lbJobsCompleted.AutoSize = True
        Me.lbJobsCompleted.Location = New System.Drawing.Point(9, 11)
        Me.lbJobsCompleted.Name = "lbJobsCompleted"
        Me.lbJobsCompleted.Size = New System.Drawing.Size(87, 13)
        Me.lbJobsCompleted.TabIndex = 7
        Me.lbJobsCompleted.Text = "Jobs completed !"
        '
        'EndAction
        '
        Me.AcceptButton = Me.cbOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cbCancel
        Me.ClientSize = New System.Drawing.Size(262, 111)
        Me.Controls.Add(Me.lbJobsCompleted)
        Me.Controls.Add(Me.lbCancel)
        Me.Controls.Add(Me.lbDescription)
        Me.Controls.Add(Me.lbCountdown)
        Me.Controls.Add(Me.cbCancel)
        Me.Controls.Add(Me.cbOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EndAction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RcloneBrowserLauncher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCancel As Button
    Friend WithEvents cbOk As Button
    Friend WithEvents lbCountdown As Label
    Friend WithEvents lbDescription As Label
    Friend WithEvents lbCancel As Label
    Friend WithEvents lbJobsCompleted As Label
End Class
