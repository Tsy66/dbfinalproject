<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieIntro
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
        Me.log_btn = New System.Windows.Forms.PictureBox()
        Me.home_btn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mov_txt = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.member_btn = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.log_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.home_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.member_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'log_btn
        '
        Me.log_btn.BackColor = System.Drawing.Color.Transparent
        Me.log_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.LOGIN_button
        Me.log_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.log_btn.Location = New System.Drawing.Point(1047, 57)
        Me.log_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.log_btn.Name = "log_btn"
        Me.log_btn.Size = New System.Drawing.Size(81, 38)
        Me.log_btn.TabIndex = 2
        Me.log_btn.TabStop = False
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.Transparent
        Me.home_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.MovieTIX_button
        Me.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.home_btn.Location = New System.Drawing.Point(76, 48)
        Me.home_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(226, 40)
        Me.home_btn.TabIndex = 4
        Me.home_btn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(97, 164)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 390)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'mov_txt
        '
        Me.mov_txt.AutoSize = True
        Me.mov_txt.BackColor = System.Drawing.Color.Transparent
        Me.mov_txt.Font = New System.Drawing.Font("新細明體-ExtB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mov_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mov_txt.Location = New System.Drawing.Point(446, 166)
        Me.mov_txt.Name = "mov_txt"
        Me.mov_txt.Size = New System.Drawing.Size(137, 30)
        Me.mov_txt.TabIndex = 12
        Me.mov_txt.Text = "電影名稱"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.我要訂票
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(938, 504)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 52)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(450, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "導演"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(450, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "演員"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(450, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "分級"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(450, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "片長"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(450, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(668, 121)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "劇情簡介"
        '
        'member_btn
        '
        Me.member_btn.BackColor = System.Drawing.Color.Transparent
        Me.member_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.會員
        Me.member_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.member_btn.Location = New System.Drawing.Point(985, 53)
        Me.member_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.member_btn.Name = "member_btn"
        Me.member_btn.Size = New System.Drawing.Size(43, 48)
        Me.member_btn.TabIndex = 19
        Me.member_btn.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體-ExtB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(450, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "上映日期"
        '
        'MovieIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.電影簡介
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1182, 623)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.member_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.mov_txt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.home_btn)
        Me.Controls.Add(Me.log_btn)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "MovieIntro"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovieTIX"
        CType(Me.log_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.home_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.member_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents log_btn As PictureBox
    Friend WithEvents home_btn As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mov_txt As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents member_btn As PictureBox
    Friend WithEvents Label5 As Label
End Class
