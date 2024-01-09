Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class SignUp
    Private connectionString As String = "server=127.0.0.1;user=root;password=;database=movie"
    Public userIDcounter As Integer '起始編號

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True

        With ComboBox1.Items
            .Add("男性")
            .Add("女性")
            .Add("其他")
        End With


        ' 從資料庫獲取最大的顧客編號並設定為 userIDcounter 的初始值
        userIDcounter = GetMaxCustomerIDFromDatabase() + 1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim pNumber As String = TextBox1.Text
        Dim passwd As String = TextBox2.Text
        Dim email As String = TextBox3.Text
        Dim name As String = TextBox4.Text
        Dim gender As String = If(ComboBox1.SelectedItem IsNot Nothing, ComboBox1.SelectedItem.ToString(), "")
        Dim BDAY As Date = DateTimePicker1.Value

        ' 檢查電話號碼是否已經存在
        If IsPhoneNumberExists(pNumber) Then
            MessageBox.Show("該電話號碼已經被註冊", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        '檢查電子信箱是否已經存在
        If IsEmailExists(email) Then
            MessageBox.Show("該電子信箱已經被註冊", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        '防呆&檢查格式
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("請輸入手機號碼", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return '中止後續操作
        ElseIf Not IsValidPhoneNumber(pNumber) Then
            MessageBox.Show("請輸入有效的電話號碼（10位數字）", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("請輸入密碼", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("請輸入電子信箱", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf Not IsValidEmail(email) Then
            MessageBox.Show("請輸入有效電子信箱", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("請輸入姓名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrEmpty(ComboBox1.Text) Then
            MessageBox.Show("請選擇性別", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrEmpty(DateTimePicker1.Text) Then
            MessageBox.Show("請選擇生日", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 生成格式化的使用者ID
        Dim ID As String = GenerateFormattedUserID()

        ' 將資料儲存至資料庫
        Dim query As String = "INSERT INTO member (ID, email, PNumber, passwd, Name, Gender, BDAY) VALUES (@ID, @email, @PNumber, @passwd, @Name, @Gender, @BDAY)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand()
                command.Connection = connection
                command.CommandText = query

                command.Parameters.AddWithValue("@ID", ID)
                command.Parameters.AddWithValue("@PNumber", pNumber)
                command.Parameters.AddWithValue("@passwd", passwd)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@Gender", gender)
                command.Parameters.AddWithValue("@BDAY", BDAY)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using

        MessageBox.Show("註冊成功! 您的使用者ID為：" & ID)
        ClearForm()
        Login.Show()
    End Sub

    Private Function IsValidPhoneNumber(pNumber As String) As Boolean
        ' 使用正則表達式進行匹配
        Dim pattern As String = "^\d{10}$" ' 電話號碼必須是10位數字
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(pNumber)
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[A-Za-z0-9]+@[A-Za-z0-9]+\.[A-Za-z]+$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    Private Function GenerateFormattedUserID() As String
        ' 生成格式化的使用者ID
        Dim formattedID As String = userIDcounter.ToString("D8") ' 使用零填充的8位數字格式
        userIDcounter += 1 ' 遞增顧客編號計數器
        Return formattedID
    End Function

    Private Sub ClearForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Function GetMaxCustomerIDFromDatabase() As Integer
        ' 從資料庫獲取最大的顧客編號
        Dim maxID As Integer = 0
        Dim query As String = "SELECT MAX(ID) FROM member"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    maxID = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return maxID
    End Function

    Private Function IsEmailExists(email As String) As Boolean
        ' 檢查電子信箱是否已經存在
        Dim query As String = "SELECT COUNT(*) FROM member WHERE email = @Email"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)
                connection.Open()
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return result > 0
            End Using
        End Using
    End Function

    Private Function IsPhoneNumberExists(pNumber As String) As Boolean
        ' 檢查電話號碼是否已經存在
        Dim query As String = "SELECT COUNT(*) FROM member WHERE PNumber = @PNumber"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@PNumber", pNumber)
                connection.Open()
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return result > 0
            End Using
        End Using
    End Function

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged '選擇密碼可視性
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class