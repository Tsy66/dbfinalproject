Public Class ManagerHome
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click '電影資訊
        Me.Hide()
        ManagerMovie.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click '場次資訊
        Me.Hide()
        ManagerSeat.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click '票證交易資訊
        Me.Hide()
        ManagerTIX.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click '會員資訊
        Me.Hide()
        ManagerMember.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class