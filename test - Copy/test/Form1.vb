Public Class Form1

    Private Sub loginbtt_Click(sender As Object, e As EventArgs) Handles loginbtt.Click
        Dim username As String
        Dim password As String
        username = user.Text
        password = pass.Text

        If (username.Equals("Student") And password.Equals("1")) Then
            MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Form2 As New Form2()
            Form2.Show()
            Me.Hide()

        ElseIf (username.Equals("Admin") And password.Equals("1")) Then
            MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Form3 As New Form3()
            Form3.Show()
            Me.Hide()

        Else
            MessageBox.Show("user/password is Incorrect", "IROR101", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class