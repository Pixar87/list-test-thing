Public Class Form1
    Const frameRate As Short = 17 'frame delay, in ms, since 1000/60 ~ 17 (actually 16.(6))
    Dim i As Integer
    Dim toggle As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = frameRate
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1

        Try
            ListBox1.Items.Add($"String number {i}") 'try to increment "i" by 1
        Catch 'if we get an exception...
            Timer1.Stop() '..stop the timer, ...
            MsgBox($"Something went wrong while the timer was ticking...{vbCrLf}The timer has been stopped.{vbCrLf}We are sorry for the inconvenience.{vbCrLf}The application will close now.") '...show the MsgBox...
            Application.Exit() '... and exit the application.
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'handles when Button1 is clicked
        If toggle = False Then ' check if boolean "toggle" is False.
            Timer1.Start() 'Start timer
        Else
            Timer1.Stop() 'Stop timer
        End If
        toggle = Not toggle 'invert "toggle"
        'MsgBox($"e = {e}")
    End Sub
End Class
