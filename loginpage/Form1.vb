Public Class Form1
    Dim Username As String = "admin"
    Dim Password As String = "password"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text.Trim) Or String.IsNullOrEmpty(TextBox2.Text.Trim) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If TextBox1.Text.Trim = Username And TextBox2.Text.Trim = Password Then
            MessageBox.Show("welcome " + Username, "Success", MessageBoxButtons.OK)
            Return
        ElseIf Not TextBox1.Text.Trim = Username Or Not TextBox2.Text.Trim = Password Then
            MessageBox.Show("Invalid User name or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TextBox1.Text.Trim) Or String.IsNullOrEmpty(TextBox2.Text.Trim) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Username = TextBox1.Text.Trim
            Password = TextBox2.Text.Trim
            MessageBox.Show("Regestered Successfully", "Success", MessageBoxButtons.OK)

        End If
    End Sub
End Class
