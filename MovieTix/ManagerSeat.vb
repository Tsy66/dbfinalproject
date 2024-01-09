Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class ManagerSeat
    Private connectionString As String = "server=127.0.0.1;user=root;password=;database=movie"

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        ManagerMovie.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        ManagerTIX.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        ManagerMember.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        ManagerHome.Show()
    End Sub

    Private Sub LoadSeatData(cinemaFilter As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using command As New MySqlCommand()
                command.Connection = connection

                ' 查看所有座位資料，或者根據影城篩選座位資料
                If Not String.IsNullOrEmpty(cinemaFilter) Then
                    command.CommandText = "SELECT SNo, cinema, office, state, price FROM sit WHERE cinema = @cinemaFilter"
                    command.Parameters.AddWithValue("@cinemaFilter", cinemaFilter)
                Else
                    command.CommandText = "SELECT SNo, cinema, office, state, price FROM sit"
                End If

                Dim dataAdapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()

                dataAdapter.Fill(dataTable)

                DataGridView1.Rows.Clear()

                For Each row As DataRow In dataTable.Rows
                    ' 獲取資料行的值
                    Dim SNo As String = row("SNo").ToString()
                    Dim cinema As String = row("cinema").ToString()
                    Dim office As String = row("office").ToString()
                    Dim state As String = row("state").ToString()
                    Dim price As String = row("price").ToString()

                    ' 將資料添加到 DataGridView 的新行中
                    DataGridView1.Rows.Add(SNo, cinema, office, state, price)
                Next
            End Using
        End Using
    End Sub

    Private Sub ManagerSeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSeatData("")
    End Sub

#Region "新增"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim seatRange As String = TextBox1.Text.Trim()
            Dim cinema As String = TextBox2.Text.Trim()
            Dim office As String = TextBox3.Text.Trim()
            Dim state As String = TextBox4.Text.Trim()
            Dim price As Decimal = TextBox5.Text.Trim()

            Dim result As DialogResult = MessageBox.Show("是否確定新增座位", "確認新增", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' 驗證輸入的座位範圍格式
                Dim seatPattern As String = "^[A-Za-z]{1}\d{1,2}~[A-Za-z]{1}\d{1,2}$"
                If Regex.IsMatch(seatRange, seatPattern) Then
                    ' 處理新增有範圍的座位排號
                    ProcessSeatRange(seatRange, cinema, office, state, price)
                Else
                    ' 處理新增單個座位排號
                    ProcessSingleSeat(seatRange, cinema, office, state, price)
                End If

                MessageBox.Show("新增座位成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' 清空輸入框
                ClearForm()

                ' 刷新座位列表
                LoadSeatData("")
            End If
        Catch ex As Exception
            MessageBox.Show("新增座位錯誤: ", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ProcessSeatRange(seatRange As String, cinema As String, office As String, state As String, price As Decimal)
        ' 抓取起始座位號碼和結束座位號碼
        Dim seatStart As String = seatRange.Substring(0, seatRange.IndexOf("~")).Trim()
        Dim seatEnd As String = seatRange.Substring(seatRange.IndexOf("~") + 1).Trim()

        ' 根據起始座位號碼和結束座位號碼生成座位列表
        Dim seats As New List(Of String)()
        Dim seatPrefix As String = seatStart.Substring(0, 1) ' 座位前缀，如 A
        Dim seatStartNumber As Integer = Convert.ToInt32(seatStart.Substring(1)) ' 座位起始號碼
        Dim seatEndNumber As Integer = Convert.ToInt32(seatEnd.Substring(1)) ' 座位结束號碼

        For i As Integer = seatStartNumber To seatEndNumber
            Dim seatNumber As String = seatPrefix + i.ToString("D2")
            seats.Add(seatNumber)
        Next

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' 執行新增
            For Each seat As String In seats
                Dim insertSeatSql As String = "INSERT INTO sit (SNo, cinema, office, state, price) VALUES (@SNo, @cinema, @office, @state, @price);"
                Using insertSeatCommand As New MySqlCommand(insertSeatSql, connection)
                    insertSeatCommand.Parameters.AddWithValue("@SNo", seat)
                    insertSeatCommand.Parameters.AddWithValue("@cinema", cinema)
                    insertSeatCommand.Parameters.AddWithValue("@office", office)
                    insertSeatCommand.Parameters.AddWithValue("@state", state)
                    insertSeatCommand.Parameters.AddWithValue("@price", price)
                    insertSeatCommand.ExecuteNonQuery()
                End Using
            Next

            connection.Close()
        End Using
    End Sub

    Private Sub ProcessSingleSeat(seatNumber As String, cinema As String, office As String, state As String, price As Decimal)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' 執行新增
            Dim insertSeatSql As String = "INSERT INTO sit (SNo, cinema, office, state, price) VALUES (@SNo, @cinema, @office, @state, @price);"
            Using insertSeatCommand As New MySqlCommand(insertSeatSql, connection)
                insertSeatCommand.Parameters.AddWithValue("@SNo", seatNumber)
                insertSeatCommand.Parameters.AddWithValue("@cinema", cinema)
                insertSeatCommand.Parameters.AddWithValue("@office", office)
                insertSeatCommand.Parameters.AddWithValue("@state", state)
                insertSeatCommand.Parameters.AddWithValue("@price", price)
                insertSeatCommand.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub ClearForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
#End Region

#Region "刪除"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 確認至少選擇了一個座位資料
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim isCheckBoxChecked As Boolean = Convert.ToBoolean(row.Cells("Column6").Value)

            If isCheckBoxChecked = True Then
                Dim SNo As String = row.Cells("Column1").Value.ToString()

                Dim result As DialogResult = MessageBox.Show("是否確定刪除該筆座位資料", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' 建立連線
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()

                        ' 刪除座位資料
                        Dim deleteOrderSql As String = "DELETE FROM sit WHERE SNo = @SNo;"
                        Using deleteOrderCommand As New MySqlCommand(deleteOrderSql, connection)
                            deleteOrderCommand.Parameters.AddWithValue("@SNo", SNo)
                            deleteOrderCommand.ExecuteNonQuery()
                        End Using

                        connection.Close()
                    End Using
                End If
            End If
        Next

        ' 重新載入座位資料
        LoadSeatData("")
    End Sub
#End Region

#Region "查詢"
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ' 取得使用者輸入的影城
        Dim cinemaFilter As String = TextBox6.Text.Trim()

        ' 載入符合篩選條件的座位資料
        LoadSeatData(cinemaFilter)
    End Sub

#End Region
End Class