Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' // declare variable username, yang ada didalam "" adalah nama username yg harus diisi agar dapat masuk ke form1(aplikasi)
        Dim username As String = "user"
        '// declare variable password, yang ada didalam "" adalah password yg harus diisikan.
        Dim pw As String = "pw"
        If TextBox1.Text = username And TextBox2.Text = pw Then
            Form1.ShowDialog()
        Else
            MessageBox.Show("passwordmu salah njing")
        End If
    End Sub

End Class