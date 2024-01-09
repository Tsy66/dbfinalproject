<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderConfirm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.next_btn = New System.Windows.Forms.PictureBox()
        Me.step1_btn = New System.Windows.Forms.PictureBox()
        Me.step2_btn = New System.Windows.Forms.PictureBox()
        Me.home_btn = New System.Windows.Forms.PictureBox()
        Me.member_btn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mov_txt = New System.Windows.Forms.Label()
        Me.theater_txt = New System.Windows.Forms.Label()
        Me.seat_id = New System.Windows.Forms.Label()
        Me.TotalPrice = New System.Windows.Forms.Label()
        Me.time_txt = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.next_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.step1_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.step2_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.home_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.member_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'next_btn
        '
        Me.next_btn.BackColor = System.Drawing.Color.Transparent
        Me.next_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.next_button
        Me.next_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.next_btn.Location = New System.Drawing.Point(976, 478)
        Me.next_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(55, 54)
        Me.next_btn.TabIndex = 0
        Me.next_btn.TabStop = False
        '
        'step1_btn
        '
        Me.step1_btn.BackColor = System.Drawing.Color.Transparent
        Me.step1_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.step1_button
        Me.step1_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.step1_btn.Location = New System.Drawing.Point(523, 52)
        Me.step1_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.step1_btn.Name = "step1_btn"
        Me.step1_btn.Size = New System.Drawing.Size(44, 47)
        Me.step1_btn.TabIndex = 1
        Me.step1_btn.TabStop = False
        '
        'step2_btn
        '
        Me.step2_btn.BackColor = System.Drawing.Color.Transparent
        Me.step2_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.step2_button
        Me.step2_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.step2_btn.Location = New System.Drawing.Point(587, 52)
        Me.step2_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.step2_btn.Name = "step2_btn"
        Me.step2_btn.Size = New System.Drawing.Size(44, 47)
        Me.step2_btn.TabIndex = 2
        Me.step2_btn.TabStop = False
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.Transparent
        Me.home_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.MovieTIX_button
        Me.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.home_btn.Location = New System.Drawing.Point(74, 52)
        Me.home_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(226, 40)
        Me.home_btn.TabIndex = 3
        Me.home_btn.TabStop = False
        '
        'member_btn
        '
        Me.member_btn.BackColor = System.Drawing.Color.Transparent
        Me.member_btn.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.會員
        Me.member_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.member_btn.Location = New System.Drawing.Point(1068, 51)
        Me.member_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.member_btn.Name = "member_btn"
        Me.member_btn.Size = New System.Drawing.Size(43, 48)
        Me.member_btn.TabIndex = 4
        Me.member_btn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(338, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "選擇付款方式"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(338, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(547, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "___________________________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(338, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "票價總計"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(339, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "座位"
        '
        'mov_txt
        '
        Me.mov_txt.AutoSize = True
        Me.mov_txt.BackColor = System.Drawing.Color.Transparent
        Me.mov_txt.Font = New System.Drawing.Font("微軟正黑體", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mov_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mov_txt.Location = New System.Drawing.Point(332, 175)
        Me.mov_txt.Name = "mov_txt"
        Me.mov_txt.Size = New System.Drawing.Size(172, 48)
        Me.mov_txt.TabIndex = 11
        Me.mov_txt.Text = "電影名稱"
        '
        'theater_txt
        '
        Me.theater_txt.AutoSize = True
        Me.theater_txt.BackColor = System.Drawing.Color.Transparent
        Me.theater_txt.Font = New System.Drawing.Font("新細明體", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.theater_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.theater_txt.Location = New System.Drawing.Point(760, 186)
        Me.theater_txt.Name = "theater_txt"
        Me.theater_txt.Size = New System.Drawing.Size(157, 28)
        Me.theater_txt.TabIndex = 12
        Me.theater_txt.Text = "電影院名稱"
        Me.theater_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'seat_id
        '
        Me.seat_id.AutoEllipsis = True
        Me.seat_id.BackColor = System.Drawing.Color.Transparent
        Me.seat_id.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.seat_id.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.seat_id.Location = New System.Drawing.Point(403, 299)
        Me.seat_id.Name = "seat_id"
        Me.seat_id.Size = New System.Drawing.Size(370, 24)
        Me.seat_id.TabIndex = 13
        Me.seat_id.Text = "座位排號"
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSize = True
        Me.TotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.TotalPrice.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TotalPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotalPrice.Location = New System.Drawing.Point(807, 427)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(54, 24)
        Me.TotalPrice.TabIndex = 14
        Me.TotalPrice.Text = "$$$$"
        '
        'time_txt
        '
        Me.time_txt.AutoSize = True
        Me.time_txt.BackColor = System.Drawing.Color.Transparent
        Me.time_txt.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.time_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.time_txt.Location = New System.Drawing.Point(340, 243)
        Me.time_txt.Name = "time_txt"
        Me.time_txt.Size = New System.Drawing.Size(114, 20)
        Me.time_txt.TabIndex = 15
        Me.time_txt.Text = "欲觀賞日期"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(555, 498)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 23)
        Me.ComboBox1.TabIndex = 16
        '
        'OrderConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.資料庫管理test0.My.Resources.Resources.背景
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1182, 623)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.time_txt)
        Me.Controls.Add(Me.TotalPrice)
        Me.Controls.Add(Me.seat_id)
        Me.Controls.Add(Me.theater_txt)
        Me.Controls.Add(Me.mov_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.member_btn)
        Me.Controls.Add(Me.home_btn)
        Me.Controls.Add(Me.step2_btn)
        Me.Controls.Add(Me.step1_btn)
        Me.Controls.Add(Me.next_btn)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "OrderConfirm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovieTIX"
        CType(Me.next_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.step1_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.step2_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.home_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.member_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents next_btn As PictureBox
    Friend WithEvents step1_btn As PictureBox
    Friend WithEvents step2_btn As PictureBox
    Friend WithEvents home_btn As PictureBox
    Friend WithEvents member_btn As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mov_txt As Label
    Friend WithEvents theater_txt As Label
    Friend WithEvents seat_id As Label
    Friend WithEvents TotalPrice As Label
    Friend WithEvents time_txt As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
