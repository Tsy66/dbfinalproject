Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Login
    Public Shared phoneNum As String
    Public Shared ID As String = ""

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private ConString As String = "server=127.0.0.1;user=root;password=;database=movie"

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim phoneNumber As String = TextBox1.Text
        Dim passwd As String = TextBox2.Text

        ''防呆
        'If String.IsNullOrEmpty(TextBox1.Text) Then
        '    MessageBox.Show("請輸入手機號碼", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return
        'ElseIf Not IsValidPhoneNumber(TextBox1.Text) Then
        '    MessageBox.Show("請輸入有效的電話號碼（10位數字）", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return '中止後續操作
        'ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
        '    MessageBox.Show("請輸入密碼", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return
        'End If

        ' 建立連線
        Using connection As New MySqlConnection(ConString)
            connection.Open()

            ' 建立 MySqlCommand 物件
            Using command As New MySqlCommand()
                command.Connection = connection

                ' 檢查手機號碼和密碼是否匹配資料庫中的記錄

                command.CommandText = "SELECT COUNT(*) FROM member WHERE PNumber = @PNumber AND passwd = @passwd;"
                command.Parameters.AddWithValue("@PNumber", phoneNumber)
                command.Parameters.AddWithValue("@passwd", passwd)

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then
                    ' 獲取輸入的電話
                    phoneNum = TextBox1.Text
                    Login.phoneNum = phoneNum
                    ' 登入成功，進入主頁
                    command.CommandText = "SELECT `ID`FROM `member` WHERE PNumber='" + phoneNum + "'"
                    ID = command.ExecuteScalar().ToString

                    Dim Home As New Home()
                    Home.Show()
                    Me.Hide()
                    ClearForm()
                ElseIf TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
                    ManagerHome.Show()
                    Me.Hide()
                    ClearForm()
                Else
                    ' 登入失敗，顯示錯誤訊息
                    MessageBox.Show("手機號碼或密碼不正確，請重新輸入。")
                    ' 清空輸入框
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If






            End Using

            connection.Close()
        End Using
    End Sub

    Private Function IsValidPhoneNumber(pNumber As String) As Boolean
        ' 使用正則表達式進行匹配
        Dim pattern As String = "^\d{10}$" ' 電話號碼必須是10位數字
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(pNumber)
    End Function

    Private Sub ClearForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub
End Class