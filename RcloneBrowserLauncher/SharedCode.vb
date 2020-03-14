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

Module SharedCode

    Function GetFileFromDialog(Optional ByVal dialogTitle As String = "Select a file",
                           Optional ByVal initialDirectory As String = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}",
                           Optional ByVal extensionFilters As String = "All files (*.*)|*.*|All files (*.*)|*.*",
                           Optional ByVal restoreDirectory As Boolean = True
                          ) As String
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = dialogTitle
        fd.InitialDirectory = initialDirectory
        fd.Filter = extensionFilters
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Return fd.FileName
        Else
            Return String.Empty
        End If
    End Function

    Sub RunCmdCommand(ByVal command As String, Optional ByVal isVisible As Boolean = True, Optional ByVal workingDirectoryPath As String = "",
                  Optional ByVal environmentVareName As String = "", Optional ByVal environmenVarValue As String = "")
        Dim p = New Process()
        If Not isVisible Then
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            p.StartInfo.CreateNoWindow = True
        End If
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/K " & """" & command & " && EXIT" & """"
        p.StartInfo.UseShellExecute = False
        If environmentVareName <> String.Empty And environmenVarValue <> String.Empty Then
            p.StartInfo.EnvironmentVariables(environmentVareName) = environmenVarValue
        End If
        If Not workingDirectoryPath = String.Empty Then
            p.StartInfo.WorkingDirectory = workingDirectoryPath
        End If
        p.Start()
    End Sub

    'Hibernate computer
    Sub Hibernate(Optional ByVal timeInSeconds As Integer = 0)
        Call RunCmdCommand("Shutdown -h -f", False)
    End Sub

    'Sleep computer
    Sub Sleep()
        Application.SetSuspendState(PowerState.Suspend, True, True)
    End Sub

    'Shutdown computer
    Sub Shutdown(Optional ByVal timeInSeconds As Integer = 0)
        Call RunCmdCommand("Shutdown -s -f -t " & timeInSeconds, False)
    End Sub

End Module
