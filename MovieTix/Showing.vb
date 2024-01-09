Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Showing
    Public Shared ticketCount As Integer
    Public Shared CinemaValue As String
    Public Shared playtimeValue As String
    Public Shared WatchDate As String

    Dim Home As New Home()
    Dim MovieName As String = Home.movieName



    Private Sub member_btn_Click(sender As Object, e As EventArgs) Handles member_btn.Click
        Me.Hide()
        Record.Show()
    End Sub


    Friend Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click


        ' 檢查是否選擇了影城
        If ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("請選擇時間！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            playtimeValue = ComboBox2.SelectedItem.ToString()
            If ComboBox2.SelectedValue IsNot Nothing Then
                Showing.playtimeValue = playtimeValue
            End If

        End If

        ' 檢查是否選擇了影城
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("請選擇影城！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            CinemaValue = ComboBox1.SelectedItem.ToString()
            If ComboBox1.SelectedValue IsNot Nothing Then
                Showing.CinemaValue = CinemaValue
            End If
        End If


        ' 獲取輸入的票數
        Integer.TryParse(txtTicketCount.Text, ticketCount)
        Showing.ticketCount = ticketCount



        ' 驗證票數是否有效
        If ticketCount <= 0 Or ticketCount > 25 Then

            MessageBox.Show("請輸入有效的票數！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim selectedDate As DateTime = DateTimePicker1.Value.Date
        Dim selectedTime As TimeSpan = TimeSpan.Parse(ComboBox2.SelectedItem.ToString())
        Dim selectedDateTime As DateTime = selectedDate.Add(selectedTime)

        ' 獲取當前日期和時間
        Dim currentDate As DateTime = DateTime.Now

        ' 檢查選擇的日期和時間是否早于當前日期和時間
        If selectedDateTime < currentDate Then
            MessageBox.Show("該電影已結束", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        SelectSeats.Show()
        Me.Hide()

    End Sub

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Showing_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateComboBoxValues()
    End Sub

    Private Sub UpdateComboBoxValues()
        ' 清空 ComboBox1 的内容
        ComboBox1.Items.Clear()
        Dim Movietitle As String = MovieName
        Select Case Movietitle
            Case "小美人魚"
                ComboBox1.Items.Add("A影城")
                ComboBox1.Items.Add("B影城")
            Case "星際異攻隊3"
                ComboBox1.Items.Add("C影城")
            Case "超級瑪利歐兄弟電影版"
                ComboBox1.Items.Add("D影城")
            Case "金之國水之國"
                ComboBox1.Items.Add("E影城")
        End Select
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim selectedDate As DateTime = DateTimePicker1.Value
        Dim maxDate As DateTime = DateTime.Today.AddDays(15)

        If selectedDate < DateTime.Today Then
            MessageBox.Show("選擇的日期不能早於今天！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' 將日期重置為今天
            DateTimePicker1.Value = DateTime.Today
        End If

        ' 檢查選擇的日期是否超過最大日期
        If selectedDate > maxDate Then
            MessageBox.Show("只能選擇未來 15 天内的日期！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' 將日期重置為最大日期
            DateTimePicker1.Value = DateTime.Today
        End If
        WatchDate = DateTimePicker1.Value.ToString()
        Showing.WatchDate = WatchDate

        UpdateComboBox2Values()

    End Sub

    Private Sub UpdateComboBox2Values()
        ' 清空 ComboBox2 的内容
        ComboBox2.Items.Clear()

        ' 獲取 DateTimePicker1 的值
        Dim selectedDate As DateTime = DateTimePicker1.Value


        ' 根據選擇的日期，加入不同的内容到 ComboBox2
        If selectedDate.DayOfWeek = DayOfWeek.Monday Then
            ComboBox2.Items.Add("14:05")
            ComboBox2.Items.Add("16:40")
            ComboBox2.Items.Add("19:15")
            ComboBox2.Items.Add("00:00")
        ElseIf selectedDate.DayOfWeek = DayOfWeek.Tuesday Then
            ComboBox2.Items.Add("13:40")
            ComboBox2.Items.Add("16:30")
            ComboBox2.Items.Add("22:30")
        ElseIf selectedDate.DayOfWeek = DayOfWeek.Wednesday Then
            ComboBox2.Items.Add("15:20")
            ComboBox2.Items.Add("20:10")
            ComboBox2.Items.Add("23:15")
        ElseIf selectedDate.DayOfWeek = DayOfWeek.Thursday Then
            ComboBox2.Items.Add("10:20")
            ComboBox2.Items.Add("16:20")
            ComboBox2.Items.Add("21:25")
            ComboBox2.Items.Add("00:00")
        ElseIf selectedDate.DayOfWeek = DayOfWeek.Friday Then
            ComboBox2.Items.Add("14:20")
            ComboBox2.Items.Add("17:10")
            ComboBox2.Items.Add("22:45")
        ElseIf selectedDate.DayOfWeek = DayOfWeek.Saturday Then
            ComboBox2.Items.Add("13:40")
            ComboBox2.Items.Add("17:45")
            ComboBox2.Items.Add("22:15")
        ElseIf selectedDate.DayOfWeek = DayOfWeek.Sunday Then
            ComboBox2.Items.Add("12:20")
            ComboBox2.Items.Add("16:20")
            ComboBox2.Items.Add("21:30")
            ComboBox2.Items.Add("00:00")
        End If

        ' 默認選擇第一項
        ComboBox2.SelectedIndex = 0
    End Sub



End Class