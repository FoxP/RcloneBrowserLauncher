Public Class EndAction

    Public TimerEndAction As New Timer
    Public CountdownEndAction As Integer

    Private Sub EndAction_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerEndAction.Interval = 1000
        AddHandler TimerEndAction.Tick, AddressOf TimerHandler

        '60 seconds countdown
        CountdownEndAction = 60
        lbCountdown.Text = CountdownEndAction.ToString & " seconds"
        Select Case MainForm.cbEndAction.SelectedIndex
            Case 0
                lbDescription.Text = "System will happily hibernate in : "
            Case 1
                lbDescription.Text = "System will happily shut down in : "
            Case 2
                lbDescription.Text = "System will happily sleep in : "
        End Select

        'Flash Window and taskbar 3 times
        Dim res = NativeMethods.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 3)

        TimerEndAction.Start()
    End Sub

    Private Sub EndAction_Closed(sender As Object, e As EventArgs) Handles Me.Closed, cbCancel.Click
        TimerEndAction.Dispose()
        Me.Dispose()
    End Sub

    Sub TimerHandler()
        If CountdownEndAction = 0 Then
            Call cbOk_Click(Nothing, New EventArgs)
        Else
            CountdownEndAction = CountdownEndAction - 1
            lbCountdown.Text = CountdownEndAction.ToString & " seconds"
        End If
    End Sub

    Private Sub cbOk_Click(sender As Object, e As EventArgs) Handles cbOk.Click
        TimerEndAction.Dispose()
        Me.Dispose()
        Select Case MainForm.cbEndAction.SelectedIndex
            Case 0
                Call Hibernate()
            Case 1
                Call Shutdown()
            Case 2
                Call Sleep()
        End Select
    End Sub

End Class