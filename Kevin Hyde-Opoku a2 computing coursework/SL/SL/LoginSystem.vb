Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxUsername.Text = "admin" And TextBoxPassword.Text = "qwerty" Then
            MsgBox("Logged in")
            Form1.Show()
            'the library system form will show after the user logs in.
        ElseIf TextBoxUsername.Text = "" And TextBoxPassword.Text = "" Then
            MsgBox("Nothing is being entered, try again")
            'user failing to enter anything to prevent him/her from being logged in
        Else
            MsgBox("Wrong username or password, TRY AGAIN!")
            'user failing to log in
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        'the form closes after the user finishes using it
        'the user can't go back to form 1 now
    End Sub
End Class