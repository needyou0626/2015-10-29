Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged, txtUserName.TextChanged
        If txtUserName.Text = "" And txtPassword.Text = "" Then
            txtUserName.BackColor = Color.MistyRose
            txtPassword.BackColor = Color.MistyRose
        End If
    End Sub

    Private Sub Sigin_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtUserName.Text = "login" And txtPassword.Text = "abc123" Then
            MessageBox.Show("帳戶密碼正確")
            Application.Exit()
        Else
            txtPassword.BackColor = Color.MistyRose
        End If
        If txtUserName.Text = "login" And txtPassword.Text = "abc123" Then
            MessageBox.Show("帳戶密碼正確")
            Application.Exit()
        Else
            txtUserName.BackColor = Color.MistyRose
        End If
    End Sub

    Private Sub Leave_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class