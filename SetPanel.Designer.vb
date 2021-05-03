<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Frame = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.akış = New System.Windows.Forms.RichTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.mesaj = New Guna.UI.WinForms.GunaTextBox()
        Me.Akış_Yenile = New System.Windows.Forms.Timer(Me.components)
        Me.w1 = New System.Windows.Forms.Timer(Me.components)
        Me.in_out = New System.Windows.Forms.RichTextBox()
        Me.winout = New System.Windows.Forms.Timer(Me.components)
        Me.lock_controls = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.nowtime = New System.Windows.Forms.Timer(Me.components)
        Me.offliner = New System.Windows.Forms.Button()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.loader = New System.Windows.Forms.Panel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.tload = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.upanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.in_chat_total = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.header_kapat = New Guna.UI.WinForms.GunaGradientButton()
        Me.in_user_list = New System.Windows.Forms.ListBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.button_ayrıl = New Guna.UI.WinForms.GunaGradientButton()
        Me.button_katıl = New Guna.UI.WinForms.GunaGradientButton()
        Me.gonder = New Guna.UI.WinForms.GunaGradientButton()
        Me.loader.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.upanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame
        '
        Me.Frame.Radius = 7
        Me.Frame.TargetControl = Me
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 20
        Me.GunaElipse1.TargetControl = Me
        '
        'akış
        '
        Me.akış.Enabled = False
        Me.akış.Location = New System.Drawing.Point(26, 64)
        Me.akış.Name = "akış"
        Me.akış.Size = New System.Drawing.Size(588, 295)
        Me.akış.TabIndex = 13
        Me.akış.Text = "Chati görüntülemek için lütfen ""KATIL"" Butonuna tıklayın!"
        Me.akış.ZoomFactor = 1.25!
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(262, 7)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(107, 46)
        Me.GunaLabel1.TabIndex = 14
        Me.GunaLabel1.Text = "Chat "
        '
        'mesaj
        '
        Me.mesaj.BackColor = System.Drawing.Color.Transparent
        Me.mesaj.BaseColor = System.Drawing.Color.White
        Me.mesaj.BorderColor = System.Drawing.Color.Silver
        Me.mesaj.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mesaj.Enabled = False
        Me.mesaj.FocusedBaseColor = System.Drawing.Color.Silver
        Me.mesaj.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mesaj.FocusedForeColor = System.Drawing.Color.Indigo
        Me.mesaj.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mesaj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mesaj.Location = New System.Drawing.Point(26, 407)
        Me.mesaj.Name = "mesaj"
        Me.mesaj.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mesaj.Radius = 10
        Me.mesaj.Size = New System.Drawing.Size(443, 49)
        Me.mesaj.TabIndex = 15
        Me.mesaj.Text = "Mesajınız..."
        Me.mesaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Akış_Yenile
        '
        Me.Akış_Yenile.Interval = 8000
        '
        'w1
        '
        Me.w1.Interval = 1000
        '
        'in_out
        '
        Me.in_out.Enabled = False
        Me.in_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.in_out.Location = New System.Drawing.Point(26, 365)
        Me.in_out.Name = "in_out"
        Me.in_out.Size = New System.Drawing.Size(409, 34)
        Me.in_out.TabIndex = 19
        Me.in_out.Text = "Chatte yapılan Giriş & Çıkış işlemleri."
        Me.in_out.ZoomFactor = 1.25!
        '
        'winout
        '
        Me.winout.Interval = 15000
        '
        'lock_controls
        '
        Me.lock_controls.Interval = 1000
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 10
        Me.GunaElipse2.TargetControl = Me.akış
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 5
        Me.GunaElipse3.TargetControl = Me.in_out
        '
        'nowtime
        '
        Me.nowtime.Interval = 1000
        '
        'offliner
        '
        Me.offliner.Location = New System.Drawing.Point(3, 407)
        Me.offliner.Name = "offliner"
        Me.offliner.Size = New System.Drawing.Size(20, 23)
        Me.offliner.TabIndex = 20
        Me.offliner.UseVisualStyleBackColor = True
        Me.offliner.Visible = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaLabel2.Location = New System.Drawing.Point(240, 234)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(184, 37)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Yükleniyor..."
        '
        'loader
        '
        Me.loader.BackColor = System.Drawing.Color.White
        Me.loader.Controls.Add(Me.GunaLabel2)
        Me.loader.Controls.Add(Me.GunaPictureBox1)
        Me.loader.Location = New System.Drawing.Point(0, 0)
        Me.loader.Name = "loader"
        Me.loader.Size = New System.Drawing.Size(647, 469)
        Me.loader.TabIndex = 21
        Me.loader.Visible = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.available_updates_64px
        Me.GunaPictureBox1.Location = New System.Drawing.Point(291, 167)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.Animated = True
        Me.GunaGradientButton1.AnimationHoverSpeed = 10.0!
        Me.GunaGradientButton1.AnimationSpeed = 10.0!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.RoyalBlue
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.SpringGreen
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(441, 365)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 3
        Me.GunaGradientButton1.Size = New System.Drawing.Size(173, 34)
        Me.GunaGradientButton1.TabIndex = 22
        Me.GunaGradientButton1.Text = "Chat'te Aktif Kullanıcı Listesi"
        Me.GunaGradientButton1.TextOffsetX = 4
        '
        'tload
        '
        Me.tload.Enabled = True
        Me.tload.Interval = 3000
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 15000
        '
        'upanel
        '
        Me.upanel.BackColor = System.Drawing.Color.Transparent
        Me.upanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.upanel.Controls.Add(Me.GunaGradientButton2)
        Me.upanel.Controls.Add(Me.in_chat_total)
        Me.upanel.Controls.Add(Me.GunaLabel6)
        Me.upanel.Controls.Add(Me.GunaLabel4)
        Me.upanel.Controls.Add(Me.header_kapat)
        Me.upanel.Controls.Add(Me.in_user_list)
        Me.upanel.Controls.Add(Me.GunaLabel3)
        Me.upanel.Location = New System.Drawing.Point(378, 64)
        Me.upanel.Name = "upanel"
        Me.upanel.Size = New System.Drawing.Size(236, 335)
        Me.upanel.TabIndex = 23
        Me.upanel.Visible = False
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.Animated = True
        Me.GunaGradientButton2.AnimationHoverSpeed = 10.0!
        Me.GunaGradientButton2.AnimationSpeed = 10.0!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.Gray
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientButton2.BorderColor = System.Drawing.SystemColors.WindowText
        Me.GunaGradientButton2.Enabled = False
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GunaGradientButton2.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.system_report_64px
        Me.GunaGradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(33, 292)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.Aqua
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.SpringGreen
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 3
        Me.GunaGradientButton2.Size = New System.Drawing.Size(173, 36)
        Me.GunaGradientButton2.TabIndex = 27
        Me.GunaGradientButton2.Text = "Şikayet et"
        Me.GunaGradientButton2.TextOffsetX = 4
        '
        'in_chat_total
        '
        Me.in_chat_total.AutoSize = True
        Me.in_chat_total.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.in_chat_total.ForeColor = System.Drawing.Color.SpringGreen
        Me.in_chat_total.Location = New System.Drawing.Point(62, 269)
        Me.in_chat_total.Name = "in_chat_total"
        Me.in_chat_total.Size = New System.Drawing.Size(28, 22)
        Me.in_chat_total.TabIndex = 26
        Me.in_chat_total.Text = "---"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(87, 271)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(138, 18)
        Me.GunaLabel6.TabIndex = 25
        Me.GunaLabel6.Text = "Kullanıcı Chat'te Aktif!"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(12, 271)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(54, 18)
        Me.GunaLabel4.TabIndex = 25
        Me.GunaLabel4.Text = "Toplam:"
        '
        'header_kapat
        '
        Me.header_kapat.Animated = True
        Me.header_kapat.AnimationHoverSpeed = 5.0!
        Me.header_kapat.AnimationSpeed = 5.0!
        Me.header_kapat.BackColor = System.Drawing.Color.Transparent
        Me.header_kapat.BaseColor1 = System.Drawing.Color.SpringGreen
        Me.header_kapat.BaseColor2 = System.Drawing.Color.DeepSkyBlue
        Me.header_kapat.BorderColor = System.Drawing.Color.Black
        Me.header_kapat.FocusedColor = System.Drawing.Color.Empty
        Me.header_kapat.Font = New System.Drawing.Font("Caviar Dreams", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.header_kapat.ForeColor = System.Drawing.Color.Blue
        Me.header_kapat.Image = Nothing
        Me.header_kapat.ImageSize = New System.Drawing.Size(20, 20)
        Me.header_kapat.Location = New System.Drawing.Point(193, 9)
        Me.header_kapat.Name = "header_kapat"
        Me.header_kapat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.header_kapat.OnHoverBaseColor2 = System.Drawing.Color.Crimson
        Me.header_kapat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.header_kapat.OnHoverForeColor = System.Drawing.Color.White
        Me.header_kapat.OnHoverImage = Nothing
        Me.header_kapat.OnPressedColor = System.Drawing.Color.Black
        Me.header_kapat.Radius = 7
        Me.header_kapat.Size = New System.Drawing.Size(30, 22)
        Me.header_kapat.TabIndex = 24
        Me.header_kapat.Text = "_"
        Me.header_kapat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'in_user_list
        '
        Me.in_user_list.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.in_user_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.in_user_list.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.in_user_list.ForeColor = System.Drawing.Color.White
        Me.in_user_list.FormattingEnabled = True
        Me.in_user_list.ItemHeight = 27
        Me.in_user_list.Location = New System.Drawing.Point(15, 48)
        Me.in_user_list.Name = "in_user_list"
        Me.in_user_list.Size = New System.Drawing.Size(208, 218)
        Me.in_user_list.TabIndex = 0
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 12)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(176, 18)
        Me.GunaLabel3.TabIndex = 14
        Me.GunaLabel3.Text = "Chat'te Aktif olan Kullanıcılar"
        '
        'button_ayrıl
        '
        Me.button_ayrıl.Animated = True
        Me.button_ayrıl.AnimationHoverSpeed = 10.0!
        Me.button_ayrıl.AnimationSpeed = 10.0!
        Me.button_ayrıl.BackColor = System.Drawing.Color.Transparent
        Me.button_ayrıl.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.button_ayrıl.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button_ayrıl.BorderColor = System.Drawing.Color.Black
        Me.button_ayrıl.Enabled = False
        Me.button_ayrıl.FocusedColor = System.Drawing.Color.Empty
        Me.button_ayrıl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button_ayrıl.ForeColor = System.Drawing.Color.White
        Me.button_ayrıl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.button_ayrıl.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.forward_96px
        Me.button_ayrıl.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.button_ayrıl.ImageSize = New System.Drawing.Size(36, 36)
        Me.button_ayrıl.Location = New System.Drawing.Point(495, 9)
        Me.button_ayrıl.Name = "button_ayrıl"
        Me.button_ayrıl.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_ayrıl.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.button_ayrıl.OnHoverBorderColor = System.Drawing.Color.Black
        Me.button_ayrıl.OnHoverForeColor = System.Drawing.Color.White
        Me.button_ayrıl.OnHoverImage = Nothing
        Me.button_ayrıl.OnPressedColor = System.Drawing.Color.Black
        Me.button_ayrıl.Radius = 20
        Me.button_ayrıl.Size = New System.Drawing.Size(119, 49)
        Me.button_ayrıl.TabIndex = 18
        Me.button_ayrıl.Text = "Ayrıl"
        Me.button_ayrıl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'button_katıl
        '
        Me.button_katıl.Animated = True
        Me.button_katıl.AnimationHoverSpeed = 10.0!
        Me.button_katıl.AnimationSpeed = 10.0!
        Me.button_katıl.BackColor = System.Drawing.Color.Transparent
        Me.button_katıl.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.button_katıl.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button_katıl.BorderColor = System.Drawing.Color.Black
        Me.button_katıl.FocusedColor = System.Drawing.Color.Empty
        Me.button_katıl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button_katıl.ForeColor = System.Drawing.Color.White
        Me.button_katıl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.button_katıl.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.collaboration_96px
        Me.button_katıl.ImageSize = New System.Drawing.Size(36, 36)
        Me.button_katıl.Location = New System.Drawing.Point(26, 9)
        Me.button_katıl.Name = "button_katıl"
        Me.button_katıl.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.button_katıl.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.button_katıl.OnHoverBorderColor = System.Drawing.Color.Black
        Me.button_katıl.OnHoverForeColor = System.Drawing.Color.White
        Me.button_katıl.OnHoverImage = Nothing
        Me.button_katıl.OnPressedColor = System.Drawing.Color.Black
        Me.button_katıl.Radius = 20
        Me.button_katıl.Size = New System.Drawing.Size(119, 49)
        Me.button_katıl.TabIndex = 16
        Me.button_katıl.Text = "KATIL"
        '
        'gonder
        '
        Me.gonder.Animated = True
        Me.gonder.AnimationHoverSpeed = 10.0!
        Me.gonder.AnimationSpeed = 10.0!
        Me.gonder.BackColor = System.Drawing.Color.Transparent
        Me.gonder.BaseColor1 = System.Drawing.Color.Indigo
        Me.gonder.BaseColor2 = System.Drawing.Color.Teal
        Me.gonder.BorderColor = System.Drawing.SystemColors.WindowText
        Me.gonder.Enabled = False
        Me.gonder.FocusedColor = System.Drawing.Color.Empty
        Me.gonder.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gonder.ForeColor = System.Drawing.Color.White
        Me.gonder.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.sms
        Me.gonder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.gonder.ImageSize = New System.Drawing.Size(36, 36)
        Me.gonder.Location = New System.Drawing.Point(475, 407)
        Me.gonder.Name = "gonder"
        Me.gonder.OnHoverBaseColor1 = System.Drawing.Color.Teal
        Me.gonder.OnHoverBaseColor2 = System.Drawing.Color.SpringGreen
        Me.gonder.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gonder.OnHoverForeColor = System.Drawing.Color.White
        Me.gonder.OnHoverImage = Nothing
        Me.gonder.OnPressedColor = System.Drawing.Color.Black
        Me.gonder.Radius = 3
        Me.gonder.Size = New System.Drawing.Size(139, 49)
        Me.gonder.TabIndex = 12
        Me.gonder.Text = "Gönder"
        Me.gonder.TextOffsetX = 4
        '
        'SetPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.loader)
        Me.Controls.Add(Me.upanel)
        Me.Controls.Add(Me.offliner)
        Me.Controls.Add(Me.in_out)
        Me.Controls.Add(Me.button_ayrıl)
        Me.Controls.Add(Me.button_katıl)
        Me.Controls.Add(Me.mesaj)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.gonder)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.Controls.Add(Me.akış)
        Me.Name = "SetPanel"
        Me.Size = New System.Drawing.Size(650, 469)
        Me.loader.ResumeLayout(False)
        Me.loader.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.upanel.ResumeLayout(False)
        Me.upanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Frame As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents gonder As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents button_katıl As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents mesaj As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents akış As RichTextBox
    Friend WithEvents Akış_Yenile As Timer
    Friend WithEvents w1 As Timer
    Friend WithEvents button_ayrıl As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents in_out As RichTextBox
    Friend WithEvents winout As Timer
    Friend WithEvents lock_controls As Timer
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents nowtime As Timer
    Friend WithEvents offliner As Button
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents loader As Windows.Forms.Panel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents tload As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents upanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents in_user_list As ListBox
    Friend WithEvents header_kapat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents in_chat_total As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
End Class
