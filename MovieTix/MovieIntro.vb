Imports MySql.Data.MySqlClient

Module MyFunctions
    Public Function change(Ctime As String)
        Dim time As String = Ctime
        Dim parts() As String = time.Split(":")
        Dim hours As Integer = Convert.ToInt32(parts(0))
        Dim minutes As Integer = Convert.ToInt32(parts(1))
        Dim displayTime As String = ""

        ' 处理小时
        If hours > 0 Then
            displayTime = hours & "小時"
        End If

        ' 处理分钟
        If minutes > 0 Then
            displayTime &= minutes & "分"
        End If

        ' 如果时间是零，则显示 "零分"
        If hours = 0 AndAlso minutes = 0 Then
            displayTime = "零分"
        End If

        ' 输出结果
        Return displayTime

    End Function

End Module

Public Class MovieIntro
    Private connString As String = "server=127.0.0.1;user=root;password=;database=movie"

    Public Property MovieName As String
    Public Property MoviePic As Image

    Dim MovieDirectorName As New List(Of String)()
    Dim MovieActorName As New List(Of String)()

    Dim login As New Login()
    Dim ID As String = Login.ID

    Dim MovieDirector As String = ""
    Dim MovieActor As String = ""
    Dim MovieRated As String = ""
    Dim MovieLength As String = ""
    Dim MovieDate As String = ""
    Dim MovieDescription As String = ""

    Private Sub MovieDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (ID = "") Then
            log_btn.BackgroundImage = My.Resources.LOGIN_button
        Else
            log_btn.BackgroundImage = My.Resources.logout_button
        End If

        Using connection As New MySqlConnection(connString)
            connection.Open()

            ' 建立新的 MySqlCommand 物件
            Using command As New MySqlCommand()
                command.Connection = connection

                ' 查詢已選座位的座位編號
                command.CommandText = "SELECT movies.classification FROM movies WHERE movies.title='" + MovieName + "'"
                MovieRated = command.ExecuteScalar()

                command.CommandText = "Select  movies.duration FROM movies WHERE movies.title='" + MovieName + "'"
                MovieLength = command.ExecuteScalar().ToString

                command.CommandText = "Select  movies.release_date FROM movies WHERE movies.title='" + MovieName + "'"
                MovieDate = command.ExecuteScalar().ToString

                command.CommandText = "Select  movies.plot_summary FROM movies WHERE movies.title='" + MovieName + "'"
                MovieDescription = command.ExecuteScalar().ToString

                Dim reader As MySqlDataReader

                command.CommandText = "Select  movies_director.director_name FROM movies_director WHERE movies_director.title='" + MovieName + "'"
                reader = command.ExecuteReader()
                While reader.Read()
                    Dim director As String = reader("director_name").ToString
                    MovieDirectorName.Add(director)
                End While
                reader.Close()

                command.CommandText = "Select  movies_actor.actor_name FROM movies_actor WHERE movies_actor.title='" + MovieName + "'"
                reader = command.ExecuteReader()

                While reader.Read()
                    Dim actor As String = reader("actor_name").ToString
                    MovieActorName.Add(actor)
                End While
                reader.Close()

            End Using
            connection.Close()
        End Using

        Dim dateTime As DateTime = DateTime.Parse(MovieDate)
        Dim dateOnly As DateTime = dateTime.Date

        Dim counter As Integer = 0

        Label1.Text = "導演："
        For Each MovieDirector As String In MovieDirectorName
            Label1.Text += MovieDirector + " "
        Next

        Label2.Text = "演員："
        For Each MovieActor As String In MovieActorName
            Label2.Text += MovieActor + " "
            counter += 1

            ' 在添加四个名字後進行換行
            If counter Mod 4 = 0 Then
                Label2.Text += Environment.NewLine + "            "
            End If
        Next

        PictureBox1.Image = MoviePic
        mov_txt.Text = MovieName

        Label3.Text = "分級：" + MovieRated
        Label4.Text = "片長：" + change(MovieLength)
        Label5.Text = "上映日期：" + dateOnly
        Label6.Text = MovieDescription

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

    Private Sub member_btn_Click(sender As Object, e As EventArgs) Handles member_btn.Click
        If (ID = "") Then
            MessageBox.Show("請先登入！")
            login.Show()
            Me.Hide()
        Else
            Record.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (ID = "") Then
            MessageBox.Show("請先登入再來購票！")
        Else
            Showing.Show()
            Me.Close()
            SignUp.Hide()
            Home.Hide()
        End If

    End Sub
End Class