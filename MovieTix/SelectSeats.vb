Imports MySql.Data.MySqlClient
Public Class SelectSeats

    Public userIDcounter As Integer '起始編號

    Private connString As String = "server=127.0.0.1;user=root;password=;database=movie"
    Public Shared selectedSeats As New List(Of String)()

    Dim Showing As New Showing()
    Dim ticketC As Integer = Showing.ticketCount
    Dim CinemaValue As String = Showing.CinemaValue

    Dim selectedSeatsCount As Integer = 0

    Private Sub step1_btn_Click(sender As Object, e As EventArgs) Handles step1_btn.Click
        Me.Hide()
        Showing.Show()
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click

        ' 檢查是否有選擇座位
        If selectedSeatsCount <> ticketC Then
            MessageBox.Show("請選擇座位", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        SelectSeats.selectedSeats = selectedSeats

        For i As Integer = 1 To 25
            Dim buttonName As String = "Button" & i.ToString()
            Dim button As Button = DirectCast(Me.Controls.Find(buttonName, True).FirstOrDefault(), Button)

            If button IsNot Nothing AndAlso button.Tag = 1 Then
                button.Tag = 2
            End If
        Next


        selectedSeatsCount = 0
        'recordOrder()
        'recordseat()

        OrderConfirm.Show()
        Me.Hide()

    End Sub

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub member_btn_Click(sender As Object, e As EventArgs) Handles member_btn.Click
        Me.Hide()
        Record.Show()
    End Sub

    Sub Button_Click(sender As Object, e As EventArgs)  '選擇座位
        Dim B = CType(sender, Button)
        Dim seatNo As String = B.Text.ToString() ' 獲取按鈕的座位號

        If B.Tag = 0 Then
            B.BackColor = Color.LimeGreen
            B.Tag = 1
            selectedSeats.Add(seatNo) ' 將選中的座位添加到列表
            selectedSeatsCount += 1
        ElseIf B.Tag = 1 Then
            B.BackColor = Color.White
            B.Tag = 0
            selectedSeats.Remove(seatNo) ' 從列表移除取消的座位
            selectedSeatsCount -= 1
        End If

        DisableButtonsIfLimitReached()

    End Sub

    Private Sub DisableButtonsIfLimitReached()

        For i As Integer = 1 To 25
            Dim buttonName As String = "Button" & i.ToString()
            Dim button As Button = DirectCast(Me.Controls.Find(buttonName, True).FirstOrDefault(), Button)

            If button IsNot Nothing Then
                If selectedSeatsCount >= ticketC AndAlso button.Tag = 0 Then
                    button.Enabled = False
                Else
                    button.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub Forml_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 1 To 25  '使按鈕觸發統一
            Dim buttonName As String = "Button" & i.ToString()
            Dim button As Button = DirectCast(Me.Controls.Find(buttonName, True).FirstOrDefault(), Button)

            If button IsNot Nothing Then
                AddHandler button.Click, AddressOf Button_Click
            End If
        Next

        CheckSeatStatus()
        DisableButtonsIfLimitReached()
    End Sub


    Private Sub CheckSeatStatus()

        Using connection As New MySqlConnection(connString)
            connection.Open()

            ' 建立新的 MySqlCommand 物件
            Using command As New MySqlCommand()
                command.Connection = connection

                ' 查詢已選座位的座位編號
                command.CommandText = "SELECT SNo FROM sit WHERE state = '已選擇' AND cinema = '" + CinemaValue + "'"
                'command.Parameters.AddWithValue("@cinema", CinemaValue)

                ' 執行查詢並獲取結果
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' 儲存已選座位的座位編號
                Dim selectedSeats As New List(Of String)()

                While reader.Read()
                    Dim seatNo As String = reader("SNo").ToString()
                    selectedSeats.Add(seatNo)
                End While

                ' 關閉讀取器
                reader.Close()

                ' 檢查座位狀態並更新按鈕
                For i As Integer = 1 To 25
                    Dim buttonName As String = "Button" & i.ToString()
                    Dim button As Button = DirectCast(Me.Controls.Find(buttonName, True).FirstOrDefault(), Button)

                    If button IsNot Nothing AndAlso selectedSeats.Contains(button.Text) Then
                        button.Enabled = False
                        button.BackColor = Color.LimeGreen
                        button.Tag = 2
                    End If
                Next

                ' 關閉連接
            End Using
            connection.Close()
        End Using
    End Sub

End Class