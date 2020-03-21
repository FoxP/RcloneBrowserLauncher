'-----------------------------------------------------------------------------------------------------------------------------------------------
'
'	This program is free software; you can redistribute it and/or
'	modify it under the terms of the GNU General Public License
'	as published by the Free Software Foundation; either version 2
'	of the License, or (at your option) any later version.
'
'	This program is distributed in the hope that it will be useful,
'	but WITHOUT ANY WARRANTY; without even the implied warranty of
'	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'	GNU General Public License for more details.
'
'	You should have received a copy of the GNU General Public License
'	along with this program; if not, write to the Free Software Foundation,
'	Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.
'
'	Name :
'				RcloneBrowserLauncher
'	Author :
'				Paul RENARD
'
'-----------------------------------------------------------------------------------------------------------------------------------------------

Imports System.IO
Imports System.Threading
Imports System.Configuration

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = My.Application.Info.AssemblyName & " - v" & My.Application.Info.Version.ToString

        'Delete / check for corrupted "user.config" file

        Try
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
        Catch exception As ConfigurationErrorsException
            File.Delete(exception.Filename)
        End Try

        'Restore user settings

        If My.Settings.sRcloneBrowserPath <> String.Empty Then
            tbRcloneBrowserPath.Text = My.Settings.sRcloneBrowserPath
        End If

        If My.Settings.sRclonePwd <> String.Empty Then
            tbRclonePwd.Text = My.Settings.sRclonePwd
        End If
        AddHandler tbRclonePwd.TextChanged, AddressOf tbRclonePwd_TextChanged

        If My.Settings.bActivatePwd Then
            cbActivatePwd.Checked = True
            tbRclonePwd.Enabled = True
        End If
        AddHandler cbActivatePwd.CheckedChanged, AddressOf cbActivatePwd_CheckedChanged

        If My.Settings.bActivateEndAction Then
            cbActivateEndAction.Checked = True
            cbEndAction.Enabled = True
        End If
        AddHandler cbActivateEndAction.CheckedChanged, AddressOf cbActivateEndAction_CheckedChanged

        cbEndAction.Items.Add("Hibernate computer")
        cbEndAction.Items.Add("Shutdown computer")
        cbEndAction.Items.Add("Sleep computer")
        cbEndAction.SelectedIndex = My.Settings.iEndAction
        AddHandler cbEndAction.SelectedIndexChanged, AddressOf cbEndAction_SelectedIndexChanged

        'Set focus on "run" button

        cbRunRcloneBrowser.Select()

        'If started from RcloneExplorer...

        If Path.GetDirectoryName(My.Settings.sRcloneBrowserPath).ToLower = Environment.CurrentDirectory.ToLower Then
            'If no end action, keep Form hidden and exit
            If Not cbActivateEndAction.Checked Then
                Visible = False
                ShowInTaskbar = False
            End If
        End If

    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'If started from RcloneExplorer...

        If Path.GetDirectoryName(My.Settings.sRcloneBrowserPath).ToLower = Environment.CurrentDirectory.ToLower Then
            'Run chosen action
            If cbActivateEndAction.Checked Then
                'Fix for EndAction.StartPosition = CenterParent
                Me.Activate()
                'Countdown before end action
                EndAction.ShowDialog()
            End If
            Application.Exit()
        End If

    End Sub

    Private Sub cbRclonePath_Click(sender As Object, e As EventArgs) Handles cbRclonePath.Click

        Dim sFilePath As String
        sFilePath = GetFileFromDialog("Select RcloneBrowser.exe", String.Empty, "EXE file|*.exe", True)
        If (sFilePath <> String.Empty) Then
            tbRcloneBrowserPath.Text = sFilePath
            My.Settings.sRcloneBrowserPath = sFilePath
        End If

    End Sub

    Private Sub tbRclonePwd_TextChanged(sender As Object, e As EventArgs)

        My.Settings.sRclonePwd = tbRclonePwd.Text

    End Sub

    Private Sub cbActivatePwd_CheckedChanged(sender As Object, e As EventArgs)

        If sender.checked Then
            tbRclonePwd.Enabled = True
        Else
            tbRclonePwd.Enabled = False
        End If
        My.Settings.bActivatePwd = cbActivatePwd.Checked

    End Sub

    Private Sub cbEndAction_SelectedIndexChanged(sender As Object, e As EventArgs)

        My.Settings.iEndAction = cbEndAction.SelectedIndex

    End Sub

    Private Sub cbActivateEndAction_CheckedChanged(sender As Object, e As EventArgs)

        If sender.checked Then
            cbEndAction.Enabled = True
        Else
            cbEndAction.Enabled = False
        End If
        My.Settings.bActivateEndAction = cbActivateEndAction.Checked

    End Sub

    Private Sub cbRunRcloneBrowser_Click(sender As Object, e As EventArgs) Handles cbRunRcloneBrowser.Click

        If tbRcloneBrowserPath.Text.Trim <> String.Empty Then
            If File.Exists(tbRcloneBrowserPath.Text) Then
                If cbActivatePwd.Checked Then
                    If tbRclonePwd.Text.Trim <> String.Empty Then
                        If Process.GetProcessesByName("RcloneBrowser").Count = 0 Then
                            Dim t = New Thread(Sub()
                                                   Call RunCmdCommand(Path.GetFileName(tbRcloneBrowserPath.Text), False, Path.GetDirectoryName(tbRcloneBrowserPath.Text), "RCLONE_CONFIG_PASS", tbRclonePwd.Text)
                                                   Application.Exit()
                                               End Sub)
                            t.IsBackground = True
                            t.Start()
                        Else
                            MessageBox.Show(Me, "Oops, Rclone Browser is already running.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show(Me, "Oops, empty rclone.conf password.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If Process.GetProcessesByName("RcloneBrowser").Count = 0 Then
                        Dim t = New Thread(Sub()
                                               Call RunCmdCommand(Path.GetFileName(tbRcloneBrowserPath.Text), False, Path.GetDirectoryName(tbRcloneBrowserPath.Text))
                                               Application.Exit()
                                           End Sub)
                        t.IsBackground = True
                        t.Start()
                    Else
                        MessageBox.Show(Me, "Oops, Rclone Browser is already running.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                MessageBox.Show(Me, "Oops, can't find RcloneBrowser.exe location :" & vbNewLine & vbNewLine & tbRcloneBrowserPath.Text, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show(Me, "Oops, empty RcloneBrowser.exe location.", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cbAbout_Click(sender As Object, e As EventArgs) Handles cbAbout.Click
        ABOUT.StartPosition = FormStartPosition.CenterParent
        ABOUT.ShowDialog()
    End Sub

End Class
