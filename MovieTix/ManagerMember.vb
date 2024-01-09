Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class ManagerMember
    Private connectionString As String = "server=127.0.0.1;user=root;password=;database=movie"

    Private Sub ManagerMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMemberData()
    End Sub

    Private Sub LoadMemberData()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using command As New MySqlCommand()
                command.Connection = connection

                ' 查看所有會員資料
                command.CommandText = "SELECT ID, Name, PNumber, email, gender, DATE_FORMAT(BDAY, '%Y/%m/%d') AS BDAY FROM member"

                Dim dataAdapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()

                dataAdapter.Fill(dataTable)

                DataGridView1.Rows.Clear()

                For Each row As DataRow In dataTable.Rows
                    ' 獲取資料行的值
                    Dim ID As String = row("ID").ToString()
                    Dim Name As String = row("Name").ToString()
                    Dim Phone As String = row("PNumber").ToString()
                    Dim Email As String = row("email").ToString()
                    Dim sex As String = row("gender").ToString()
                    Dim bday As String = row("BDAY").ToString()

                    ' 將資料添加到 DataGridView 的新行中
                    DataGridView1.Rows.Add(ID, Name, Phone, Email, sex, bday)
                Next
            End Using
        End Using
    End Sub

#Region "刪除"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 確認至少選擇了一個會員資料
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim ID As String = selectedRow.Cells("Column1").Value.ToString()
            Dim isCheckBoxChecked As Boolean = Convert.ToBoolean(selectedRow.Cells("Column7").Value)

            If isCheckBoxChecked = True Then

                Dim result As DialogResult = MessageBox.Show("是否確定刪除該會員資料", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' 建立連線
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()

                        Dim removeForeignKeySql As String = "SET FOREIGN_KEY_CHECKS = 0;"
                        Using removeForeignKeyCommand As New MySqlCommand(removeForeignKeySql, connection)
                            removeForeignKeyCommand.ExecuteNonQuery()
                        End Using

                        ' 刪除會員資料
                        Dim deleteMemberSql As String = "DELETE FROM member WHERE ID = @ID;"
                        Using deleteMemberCommand As New MySqlCommand(deleteMemberSql, connection)
                            deleteMemberCommand.Parameters.AddWithValue("@ID", ID)
                            deleteMemberCommand.ExecuteNonQuery()
                        End Using

                        Dim restoreForeignKeySql As String = "SET FOREIGN_KEY_CHECKS = 1;"
                        Using restoreForeignKeyCommand As New MySqlCommand(restoreForeignKeySql, connection)
                            restoreForeignKeyCommand.ExecuteNonQuery()
                        End Using

                        connection.Close()
                    End Using

                    ' 重新載入會員資料
                    LoadMemberData()
                End If
            End If
        End If
    End Sub
#End Region


    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        ManagerHome.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        ManagerSeat.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        ManagerTIX.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        ManagerMovie.Show()
    End Sub
End Class