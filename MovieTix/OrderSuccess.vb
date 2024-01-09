
Public Class OrderSus
    Dim OrderConfirm As New OrderConfirm()
    Dim OID As String = OrderConfirm.OID

    Dim Showing As New Showing()
    Dim ticketC As Integer = Showing.ticketCount
    Dim CinemaValue As String = Showing.CinemaValue
    Dim WatchDate As String = Showing.WatchDate
    Dim playtime As String = Showing.playtimeValue

    Dim Home As New Home()
    Dim MovieName As String = Home.movieName

    Dim SelectSeats As New SelectSeats()

    Private Sub step1_btn_Click(sender As Object, e As EventArgs) Handles step1_btn.Click '返回step1
        Me.Hide()
        Showing.Show()
    End Sub

    Private Sub step2_btn_Click(sender As Object, e As EventArgs) Handles step2_btn.Click '返回step2
        Me.Hide()
        SelectSeats.Show()
    End Sub

    Private Sub member_btn_Click(sender As Object, e As EventArgs) Handles member_btn.Click '檢視會員資料與歷史訂單
        Me.Hide()
        Record.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load '連接資料庫(訂單資訊)
        Dim dateTime As DateTime = DateTime.Parse(WatchDate)
        Dim dateOnly As DateTime = dateTime.Date

        Label1.Text = OID
        Label2.Text = MovieName
        Label3.Text = CinemaValue
        Label4.Text = dateOnly + "  " + playtime
        Label5.Text = ""
        For Each seats As String In SelectSeats.selectedSeats
            Label5.Text += seats + " "
        Next
        Label6.Text = ticketC * 200
    End Sub

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        Me.Hide()
        Home.Show()
    End Sub


End Class