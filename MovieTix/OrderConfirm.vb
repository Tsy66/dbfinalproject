Imports MySql.Data.MySqlClient

Public Class OrderConfirm
    Public Shared OID As String

    Dim payway As String

    Dim login As New Login()
    Dim ID As String = login.ID

    Dim Showing As New Showing()
    Dim ticketC As Integer = Showing.ticketCount
    Dim CinemaValue As String = Showing.CinemaValue
    Dim WatchDate As String = Showing.WatchDate

    Dim Home As New Home()
    Dim MovieName As String = Home.movieName

    Dim SelectSeats As New SelectSeats()


    Private connString As String = "server=127.0.0.1;user=root;password=;database=movie"

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click '回首頁
        Me.Hide()
        Home.Show()
    End Sub
    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click '前往下頁


        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("請選擇付款方式", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim currentTime As DateTime = DateTime.Now

        Using connection As New MySqlConnection(connString)
            connection.Open()


            ' 建立新的 MySqlCommand 物件
            Using command As New MySqlCommand()
                command.Connection = connection

                command.CommandText = "SELECT COUNT(DISTINCT OID) FROM record"
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                OID = "A" & (count + 1).ToString("D9")


                Dim Ptotol As Integer = ticketC * 200

                payway = ComboBox1.SelectedItem.ToString()

                ' 設置插入語句
                command.CommandText = "INSERT INTO `record`(`OID`, `Ptotal`, `payway`, `paytime`, `title`, `ID`, `Tnum`) VALUES (@oid, @ptotal, @payway, @paytime, @title, @id, @tnum)"

                ' 添加參數並設置參數值
                command.Parameters.AddWithValue("@oid", OID)
                command.Parameters.AddWithValue("@ptotal", Ptotol)
                command.Parameters.AddWithValue("@payway", payway)
                command.Parameters.AddWithValue("@paytime", currentTime)
                command.Parameters.AddWithValue("@title", MovieName)
                command.Parameters.AddWithValue("@id", ID)
                command.Parameters.AddWithValue("@tnum", ticketC)
                command.ExecuteNonQuery()

                For Each seats As String In SelectSeats.selectedSeats
                    command.CommandText = "UPDATE `sit` SET `state`='已選擇',`OID`='" + OID + "' WHERE `SNo`='" + seats + "' AND `cinema`='" + CinemaValue + "' AND `office`='A廳'"

                    command.ExecuteNonQuery()
                Next

            End Using
            connection.Close()
        End Using


        OrderSus.Show()
        Me.Hide()

    End Sub

    Private Sub step1_btn_Click(sender As Object, e As EventArgs) Handles step1_btn.Click '返回step1
        Me.Hide()
        Showing.Show()
    End Sub

    Private Sub step2_btn_Click(sender As Object, e As EventArgs) Handles step2_btn.Click '返回step2
        Me.Hide()
        SelectSeats.Show()
    End Sub

    Private Sub member_btn_Click(sender As Object, e As EventArgs) Handles member_btn.Click '檢視會員資訊與歷史訂單
        Me.Hide()
        Record.Show()
    End Sub

    Private Sub OrderConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dateTime As DateTime = DateTime.Parse(WatchDate)
        Dim dateOnly As DateTime = dateTime.Date


        seat_id.Text = ""
        For Each seats As String In SelectSeats.selectedSeats
            seat_id.Text += seats + " "
        Next

        mov_txt.Text = MovieName
        theater_txt.Text = CinemaValue
        time_txt.Text = dateOnly
        TotalPrice.Text = (ticketC * 200).ToString

        With ComboBox1.Items
            .Add("現金")
            .Add("信用卡")
        End With
    End Sub

End Class