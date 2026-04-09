Public Class Form1
    Private Sub loginbtt_Click(sender As Object, e As EventArgs) Handles loginbtt.Click
        Dim username As String
        Dim password As String
        username = user.Text
        password = pass.Text
        If (username.Equals("1") And password.Equals("1")) Then
            MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form2 As New Form2()
            form2.Show()
        Else
            MessageBox.Show("user/password is Incorrect", "IROR101", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class