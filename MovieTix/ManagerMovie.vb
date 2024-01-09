Imports MySql.Data.MySqlClient
Public Class ManagerMovie
    Private connectionString As String = "server=127.0.0.1;user=root;password=;database=movie"
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        ManagerSeat.Show()
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

    Private Sub ManagerMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMovieData()
    End Sub

    Private Sub LoadMovieData()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using command As New MySqlCommand()
                command.Connection = connection

                ' 查看所有會員資料
                command.CommandText = "SELECT title, classification, DATE_FORMAT(release_date, '%Y/%m/%d') AS release_date, duration, plot_summary FROM movies"

                Dim dataAdapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()

                dataAdapter.Fill(dataTable)

                DataGridView1.Rows.Clear()

                For Each row As DataRow In dataTable.Rows
                    ' 獲取資料行的值
                    Dim title As String = row("title").ToString()
                    Dim classification As String = row("classification").ToString()
                    Dim release_date As String = row("release_date").ToString()
                    Dim duration As String = row("duration").ToString()
                    Dim plot_summary As String = row("plot_summary").ToString()

                    ' 將資料添加到 DataGridView 的新行中
                    DataGridView1.Rows.Add(title, classification, release_date, duration, plot_summary)
                Next
            End Using
        End Using
    End Sub

#Region "新增"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 新增電影資料
        Dim title As String = TextBox1.Text.Trim()
        Dim classification As String = TextBox2.Text.Trim()
        Dim release_date As Date = DateTimePicker1.Value
        Dim duration As String = TextBox3.Text.Trim()
        Dim plot_summary As String = TextBox4.Text.Trim()

        ' 檢查是否所有控制項都有輸入值
        If String.IsNullOrEmpty(title) OrElse String.IsNullOrEmpty(classification) OrElse release_date = DateTime.MinValue OrElse String.IsNullOrEmpty(duration) OrElse String.IsNullOrEmpty(plot_summary) Then
            MessageBox.Show("請為每個屬性輸入值", "輸入框不可為空", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' 建立連線
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' 檢查是否存在相同名稱的電影
                Dim checkDuplicateSql As String = "SELECT COUNT(*) FROM movies WHERE title = @title;"
                Using checkDuplicateCommand As New MySqlCommand(checkDuplicateSql, connection)
                    checkDuplicateCommand.Parameters.AddWithValue("@title", title)
                    Dim count As Integer = Convert.ToInt32(checkDuplicateCommand.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("已存在相同名稱的電影", "重複的電影名稱", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' 插入新的電影資料
                Dim insertMovieSql As String = "INSERT INTO movies (title, classification, release_date, duration, plot_summary) VALUES (@title, @classification, @release_date, @duration, @plot_summary);"
                Using insertMovieCommand As New MySqlCommand(insertMovieSql, connection)
                    insertMovieCommand.Parameters.AddWithValue("@title", title)
                    insertMovieCommand.Parameters.AddWithValue("@classification", classification)
                    insertMovieCommand.Parameters.AddWithValue("@release_date", release_date)
                    insertMovieCommand.Parameters.AddWithValue("@duration", duration)
                    insertMovieCommand.Parameters.AddWithValue("@plot_Summary", plot_summary)
                    insertMovieCommand.ExecuteNonQuery()
                End Using

                connection.Close()
            End Using

            ' 重新載入電影資料
            LoadMovieData()
        Catch ex As Exception
            MessageBox.Show("發生錯誤：" & ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "刪除"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 確認至少選擇了一個電影資料
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim isCheckBoxChecked As Boolean = Convert.ToBoolean(row.Cells("Column6").Value)

            If isCheckBoxChecked = True Then
                ' 取得電影資料的 title
                Dim title As String = row.Cells("Column1").Value.ToString()

                Dim result As DialogResult = MessageBox.Show("是否確定刪除該電影", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' 建立連線
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()

                        ' 刪除電影資料
                        Dim deleteOrderSql As String = "DELETE FROM movies WHERE title = @title;"
                        Using deleteOrderCommand As New MySqlCommand(deleteOrderSql, connection)
                            deleteOrderCommand.Parameters.AddWithValue("@title", title)
                            deleteOrderCommand.ExecuteNonQuery()
                        End Using

                        connection.Close()
                    End Using
                End If
            End If
        Next

        ' 重新載入電影資料
        LoadMovieData()
    End Sub
#End Region

#Region "修改"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 確認選中了一個電影資料
        'If DataGridView1.SelectedRows.Count > 0 Then
        'Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim title As String = TextBox1.Text
        Dim classification As String = TextBox2.Text
        Dim release_date As Date = DateTimePicker1.Value
        Dim duration As String = TextBox3.Text
        Dim plot_summary As String = TextBox4.Text

        ' 檢查是否所有屬性都有輸入值
        If String.IsNullOrEmpty(title) OrElse String.IsNullOrEmpty(classification) OrElse release_date = DateTime.MinValue OrElse String.IsNullOrEmpty(duration) OrElse String.IsNullOrEmpty(plot_summary) Then
            MessageBox.Show("請為每個屬性輸入值", "輸入不可為空", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("是否確定修改該電影", "確認修改", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' 建立連線
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' 更新電影資料
                Dim updateMovieSql As String = "UPDATE movies SET classification = @classification, release_date = @release_date, duration = @duration, plot_summary = @plot_summary WHERE title = @title;"
                Using updateMovieCommand As New MySqlCommand(updateMovieSql, connection)
                    updateMovieCommand.Parameters.AddWithValue("@classification", classification)
                    updateMovieCommand.Parameters.AddWithValue("@release_date", release_date)
                    updateMovieCommand.Parameters.AddWithValue("@duration", duration)
                    updateMovieCommand.Parameters.AddWithValue("@plot_summary", plot_summary)
                    updateMovieCommand.Parameters.AddWithValue("@title", title)
                    updateMovieCommand.ExecuteNonQuery()
                End Using

                connection.Close()
            End Using

            ' 重新載入電影資料
            LoadMovieData()
            'End If
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' 清空輸入框的值
        TextBox1.Clear()
        TextBox2.Clear()
        DateTimePicker1.Value = DateTime.Now
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' 檢查是否為修改按鈕的點擊事件
        If e.RowIndex >= 0 AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "Column6" Then
            ' 取得選中的電影資料
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim title As String = selectedRow.Cells("Column1").Value.ToString()
            Dim classification As String = selectedRow.Cells("Column2").Value.ToString()
            Dim release_date As Date = Convert.ToDateTime(selectedRow.Cells("Column3").Value)
            Dim duration As String = selectedRow.Cells("Column4").Value.ToString()
            Dim plot_summary As String = selectedRow.Cells("Column5").Value.ToString()

            ' 將選中的電影資料放入輸入框
            TextBox1.Text = title
            TextBox2.Text = classification
            DateTimePicker1.Value = release_date
            TextBox3.Text = duration
            TextBox4.Text = plot_summary
        End If
    End Sub
#End Region
End Class