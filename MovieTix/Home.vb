Public Class Home
    Public Shared movieName As String

    Dim login As New Login()
    Dim ID As String = Login.ID

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (ID = "") Then
            log_btn.BackgroundImage = My.Resources.LOGIN_button
        Else
            log_btn.BackgroundImage = My.Resources.logout_button
        End If

        AddHandler PictureBox1.Click, AddressOf PictureBox_Click
        AddHandler PictureBox2.Click, AddressOf PictureBox_Click
        AddHandler PictureBox3.Click, AddressOf PictureBox_Click
        AddHandler PictureBox4.Click, AddressOf PictureBox_Click
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Dim pictureBox As PictureBox = DirectCast(sender, PictureBox)

        movieName = ""
        Dim movieImage As Image = Nothing

        Select Case pictureBox.Name
            Case "PictureBox1"
                movieImage = My.Resources.小美人魚
                movieName = "小美人魚"
            Case "PictureBox2"
                movieImage = My.Resources.星際異功隊3
                movieName = "星際異攻隊3"
            Case "PictureBox3"
                movieImage = My.Resources.超級瑪利歐兄弟電影版
                movieName = "超級瑪利歐兄弟電影版"
            Case "PictureBox4"
                movieImage = My.Resources.金之國水之國
                movieName = "金之國水之國"
        End Select


        Home.movieName = movieName
        Dim MovieIntro As New MovieIntro()

        MovieIntro.MovieName = movieName
        MovieIntro.MoviePic = movieImage
        Me.Hide()
        MovieIntro.ShowDialog()

    End Sub

    Private Sub member_btn_Click(sender As Object, e As EventArgs) Handles member_btn.Click
        If (ID = "") Then
            MessageBox.Show("請先登入！")
            Login.Show()
            Me.Hide()
        Else
            Record.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub log_btn_Click(sender As Object, e As EventArgs) Handles log_btn.Click
        If (ID = "") Then
            login.Show()
            Me.Hide()
        Else
            ID = ""
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class
