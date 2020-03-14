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

Public Class ABOUT

    Private Const sGithubRepositoryURL = "https://github.com/FoxP/RcloneBrowserLauncher"

    Private Sub ABOUT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        labelExeInfo.Text = "Build version : " & My.Application.Info.Version.ToString & vbNewLine &
                            "Compilation date : " & getCreationDate(Application.ExecutablePath).ToString("yyyy-MM-dd") & vbNewLine &
                            "GitHub : "
        labelGitHub.Text = My.Application.Info.AssemblyName
    End Sub

    Private Sub labelGitHub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelGitHub.Click
        Process.Start(sGithubRepositoryURL)
    End Sub

    Function getCreationDate(ByVal sFilePath As String) As DateTime
        Dim dt As New DateTime
        Try
            dt = File.GetCreationTime(sFilePath)
        Catch ex As Exception
            'Oops
        End Try
        Return dt
    End Function

End Class