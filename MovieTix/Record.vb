Imports MySql.Data.MySqlClient
Public Class Record
    Dim login As New Login()
    Dim ID As String = Login.ID

    Dim MySqlcon As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click '回首頁
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click '登出 回登出的首頁
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load '連接資料庫(訂票紀錄)
        MySqlcon = New MySqlConnection
        MySqlcon.ConnectionString = "server=127.0.0.1;userid=root;password=;database=movie"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Using connection As New MySqlConnection(MySqlcon.ConnectionString)
            connection.Open()

            ' 建立新的 MySqlCommand 物件
            Using command As New MySqlCommand()
                command.Connection = connection

                command.CommandText = "select OID, ID, paytime, Ptotal from record WHERE ID = '" + ID + "'"
                SDA.SelectCommand = command
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet)

                command.CommandText = "Select Name FROM `member` WHERE ID = '" + ID + "'"
                TextBox1.Text = command.ExecuteScalar()

                command.CommandText = "Select PNumber FROM `member` WHERE ID = '" + ID + "'"
                TextBox2.Text = command.ExecuteScalar()

                command.CommandText = "Select email FROM `member` WHERE ID = '" + ID + "'"
                TextBox3.Text = command.ExecuteScalar()

                command.CommandText = "Select BDAY FROM `member` WHERE ID = '" + ID + "'"
                Dim dateValue As String = command.ExecuteScalar()
                Dim parsedDate As DateTime
                If DateTime.TryParse(dateValue, parsedDate) Then
                    DateTimePicker1.Value = parsedDate
                Else
                    MessageBox.Show("無效的日期！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
            connection.Close()
        End Using

        With ComboBox1.Items
            .Add("男")
            .Add("女")
            .Add("其他")
        End With

        Dim gender As String = "Select Gender FROM `member` WHERE ID = '" + ID + "'"

        Using connection As New MySqlConnection(MySqlcon.ConnectionString)
            connection.Open()
            Using command As New MySqlCommand(gender, connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    Dim memberGender As String = result.ToString()

                    Select Case memberGender
                        Case "男性"
                            ComboBox1.SelectedItem = "男"
                        Case "女性"
                            ComboBox1.SelectedItem = "女"
                        Case "其他"
                            ComboBox1.SelectedItem = "其他"
                    End Select
                End If
            End Using
            connection.Close()
        End Using

        DataGridView1.AutoResizeColumns()
        DataGridView1.Refresh()
    End Sub

End Class