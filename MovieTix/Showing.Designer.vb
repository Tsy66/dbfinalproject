<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Showing
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.member_btn = New System.Windows.Forms.PictureBox()
        Me.next_btn = New System.Windows.Forms.PictureBox()
        Me.home_btn = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtTicketCount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.member_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.next_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.home_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'member_btn
        '
        Me.member_btn.BackColor = System.Drawing.Color.Transparent
        Me.member_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.會員
        Me.member_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.member_btn.Location = New System.Drawing.Point(1069, 47)
        Me.member_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.member_btn.Name = "member_btn"
        Me.member_btn.Size = New System.Drawing.Size(43, 48)
        Me.member_btn.TabIndex = 5
        Me.member_btn.TabStop = False
        '
        'next_btn
        '
        Me.next_btn.BackColor = System.Drawing.Color.Transparent
        Me.next_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.next_button
        Me.next_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.next_btn.Location = New System.Drawing.Point(1010, 475)
        Me.next_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(55, 54)
        Me.next_btn.TabIndex = 6
        Me.next_btn.TabStop = False
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.Transparent
        Me.home_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.MovieTIX_button
        Me.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.home_btn.Location = New System.Drawing.Point(78, 49)
        Me.home_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(226, 40)
        Me.home_btn.TabIndex = 7
        Me.home_btn.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(536, 311)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(159, 25)
        Me.DateTimePicker1.TabIndex = 50
        '
        'txtTicketCount
        '
        Me.txtTicketCount.Location = New System.Drawing.Point(536, 443)
        Me.txtTicketCount.Name = "txtTicketCount"
        Me.txtTicketCount.Size = New System.Drawing.Size(100, 25)
        Me.txtTicketCount.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(463, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "票數"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(536, 377)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox2.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(536, 247)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(463, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "時間"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(463, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "日期"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(463, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "影城"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(425, 192)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 324)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(639, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 15)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "張"
        '
        'Showing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.選擇場次
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1182, 623)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtTicketCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.home_btn)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.member_btn)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Showing"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovieTIX"
        CType(Me.member_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.next_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.home_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents member_btn As PictureBox
    Friend WithEvents next_btn As PictureBox
    Friend WithEvents home_btn As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtTicketCount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
