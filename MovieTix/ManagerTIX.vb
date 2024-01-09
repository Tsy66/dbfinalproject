Imports MySql.Data.MySqlClient
Public Class ManagerTIX
    Private connectionString As String = "server=127.0.0.1;user=root;password=;database=movie"

    Private Sub ManagerTIX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 確認至少選擇了一個訂單資料
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim isCheckBoxChecked As Boolean = Convert.ToBoolean(row.Cells("Column8").Value)

            If isCheckBoxChecked = True Then
                ' 取得訂單資料的 OID
                Dim OID As String = row.Cells("Column1").Value.ToString()

                Dim result As DialogResult = MessageBox.Show("是否確定刪除該筆票證交易資料", "刪除交易", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' 建立連線
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()

                        ' 刪除訂單資料
                        Dim deleteOrderSql As String = "DELETE FROM record WHERE OID = @OID;"
                        Using deleteOrderCommand As New MySqlCommand(deleteOrderSql, connection)
                            deleteOrderCommand.Parameters.AddWithValue("@OID", OID)
                            deleteOrderCommand.ExecuteNonQuery()
                        End Using

                        connection.Close()
                    End Using
                End If
            End If
        Next

        ' 重新載入訂單資料
        LoadOrderData()
    End Sub


    Private Sub LoadOrderData()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using command As New MySqlCommand()
                command.Connection = connection

                ' 查詢訂單資料
                command.CommandText = "SELECT OID, ID, title, Ptotal, payway, paytime, Tnum FROM record"

                Dim dataAdapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()

                dataAdapter.Fill(dataTable)

                ' 清空原有的 DataGridView 資料
                DataGridView1.Rows.Clear()

                ' 將 DataTable 資料填充到 DataGridView
                For Each row As DataRow In dataTable.Rows
                    ' 獲取資料行的值
                    Dim OID As String = row("OID").ToString()
                    Dim ID As String = row("ID").ToString()
                    Dim title As String = row("title").ToString()
                    Dim Ptotal As String = row("Ptotal").ToString()
                    Dim payway As String = row("payway").ToString()
                    Dim paytime As String = row("paytime").ToString()
                    Dim Tnum As String = row("Tnum").ToString()

                    ' 將資料添加到 DataGridView 的新行中
                    DataGridView1.Rows.Add(OID, ID, title, Ptotal, payway, paytime, Tnum)
                Next
            End Using
        End Using
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        ManagerMember.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        ManagerMovie.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        ManagerSeat.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        ManagerHome.Show()
    End Sub
End Class