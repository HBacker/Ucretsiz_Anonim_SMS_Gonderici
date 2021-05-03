<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kullanıcı_Kayıt
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kullanıcı_Kayıt))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.username = New Guna.UI.WinForms.GunaTextBox()
        Me.register = New Guna.UI.WinForms.GunaGradientButton()
        Me.giris_yap = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.email = New Guna.UI.WinForms.GunaTextBox()
        Me.password = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.gb_verify = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel3 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.n4 = New System.Windows.Forms.Label()
        Me.n3 = New System.Windows.Forms.Label()
        Me.n2 = New System.Windows.Forms.Label()
        Me.n1 = New System.Windows.Forms.Label()
        Me.kod4 = New Guna.UI.WinForms.GunaTextBox()
        Me.kod3 = New Guna.UI.WinForms.GunaTextBox()
        Me.kod2 = New Guna.UI.WinForms.GunaTextBox()
        Me.kod1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaGradientButton3 = New Guna.UI.WinForms.GunaGradientButton()
        Me.block = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.nulltime = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.error_box = New Guna.UI.WinForms.GunaGroupBox()
        Me.error_name = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.error_desc = New Guna.UI.WinForms.GunaLabel()
        Me.piyon = New System.Windows.Forms.TextBox()
        Me.block_box = New System.Windows.Forms.PictureBox()
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.wc1 = New System.Windows.Forms.Timer(Me.components)
        Me.wc2 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.header_kapat = New Guna.UI.WinForms.GunaGradientButton()
        Me.header_icon = New Guna.UI.WinForms.GunaPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Header = New THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.FormSkin()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.gb_verify.SuspendLayout()
        Me.GunaGradient2Panel3.SuspendLayout()
        Me.block.SuspendLayout()
        Me.error_box.SuspendLayout()
        CType(Me.block_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel1.Location = New System.Drawing.Point(18, 67)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(77, 35)
        Me.GunaLabel1.TabIndex = 47
        Me.GunaLabel1.Text = "Nick:"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.Transparent
        Me.username.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.username.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.BorderSize = 1
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.FocusedBaseColor = System.Drawing.Color.White
        Me.username.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.username.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.username.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.username.Location = New System.Drawing.Point(126, 67)
        Me.username.MaxLength = 16
        Me.username.Name = "username"
        Me.username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username.Radius = 5
        Me.username.Size = New System.Drawing.Size(309, 36)
        Me.username.TabIndex = 45
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'register
        '
        Me.register.Animated = True
        Me.register.AnimationHoverSpeed = 10.0!
        Me.register.AnimationSpeed = 10.0!
        Me.register.BackColor = System.Drawing.Color.Transparent
        Me.register.BaseColor1 = System.Drawing.Color.Indigo
        Me.register.BaseColor2 = System.Drawing.Color.MidnightBlue
        Me.register.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.register.FocusedColor = System.Drawing.Color.Empty
        Me.register.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register.ForeColor = System.Drawing.Color.White
        Me.register.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.forward_96px
        Me.register.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.register.ImageOffsetX = -5
        Me.register.ImageSize = New System.Drawing.Size(36, 36)
        Me.register.Location = New System.Drawing.Point(178, 352)
        Me.register.Name = "register"
        Me.register.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.register.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.register.OnHoverBorderColor = System.Drawing.Color.White
        Me.register.OnHoverForeColor = System.Drawing.Color.White
        Me.register.OnHoverImage = Nothing
        Me.register.OnPressedColor = System.Drawing.Color.Crimson
        Me.register.Radius = 5
        Me.register.Size = New System.Drawing.Size(235, 60)
        Me.register.TabIndex = 46
        Me.register.Text = "Kayıt ol!"
        Me.register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'giris_yap
        '
        Me.giris_yap.Animated = True
        Me.giris_yap.AnimationHoverSpeed = 10.0!
        Me.giris_yap.AnimationSpeed = 10.0!
        Me.giris_yap.BackColor = System.Drawing.Color.Transparent
        Me.giris_yap.BaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.giris_yap.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.giris_yap.CheckedBaseColor = System.Drawing.Color.Gray
        Me.giris_yap.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.giris_yap.CheckedForeColor = System.Drawing.Color.White
        Me.giris_yap.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_321
        Me.giris_yap.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.giris_yap.FocusedColor = System.Drawing.Color.Empty
        Me.giris_yap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.giris_yap.ForeColor = System.Drawing.Color.White
        Me.giris_yap.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.password_96px
        Me.giris_yap.ImageSize = New System.Drawing.Size(42, 42)
        Me.giris_yap.LineBottom = 3
        Me.giris_yap.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.giris_yap.Location = New System.Drawing.Point(46, 352)
        Me.giris_yap.Name = "giris_yap"
        Me.giris_yap.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.giris_yap.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.giris_yap.OnHoverForeColor = System.Drawing.Color.White
        Me.giris_yap.OnHoverImage = Nothing
        Me.giris_yap.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.giris_yap.OnPressedColor = System.Drawing.Color.Black
        Me.giris_yap.Radius = 10
        Me.giris_yap.Size = New System.Drawing.Size(120, 54)
        Me.giris_yap.TabIndex = 49
        Me.giris_yap.Text = "Giriş Yap"
        Me.giris_yap.TextOffsetX = -5
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel2.Location = New System.Drawing.Point(23, 119)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(75, 35)
        Me.GunaLabel2.TabIndex = 52
        Me.GunaLabel2.Text = "Mail:"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.Transparent
        Me.email.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.email.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.BorderSize = 1
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.FocusedBaseColor = System.Drawing.Color.White
        Me.email.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.email.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.email.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.email.Location = New System.Drawing.Point(126, 119)
        Me.email.MaxLength = 32
        Me.email.Name = "email"
        Me.email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email.Radius = 5
        Me.email.Size = New System.Drawing.Size(309, 36)
        Me.email.TabIndex = 53
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.Transparent
        Me.password.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.password.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.BorderSize = 1
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.FocusedBaseColor = System.Drawing.Color.White
        Me.password.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.password.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.password.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.password.Location = New System.Drawing.Point(126, 170)
        Me.password.MaxLength = 20
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.password.Radius = 5
        Me.password.Size = New System.Drawing.Size(309, 36)
        Me.password.TabIndex = 55
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password.UseSystemPasswordChar = True
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel4.Location = New System.Drawing.Point(20, 171)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(82, 35)
        Me.GunaLabel4.TabIndex = 54
        Me.GunaLabel4.Text = "Şifre:"
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 7
        Me.GunaElipse2.TargetControl = Me.gb_verify
        '
        'gb_verify
        '
        Me.gb_verify.BackColor = System.Drawing.Color.Transparent
        Me.gb_verify.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.gb_verify.BorderColor = System.Drawing.Color.MidnightBlue
        Me.gb_verify.Controls.Add(Me.GunaLabel16)
        Me.gb_verify.Controls.Add(Me.GunaGradient2Panel3)
        Me.gb_verify.Controls.Add(Me.kod4)
        Me.gb_verify.Controls.Add(Me.kod3)
        Me.gb_verify.Controls.Add(Me.kod2)
        Me.gb_verify.Controls.Add(Me.kod1)
        Me.gb_verify.Controls.Add(Me.GunaGradientButton3)
        Me.gb_verify.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gb_verify.LineColor = System.Drawing.Color.Indigo
        Me.gb_verify.Location = New System.Drawing.Point(8, 216)
        Me.gb_verify.Name = "gb_verify"
        Me.gb_verify.Size = New System.Drawing.Size(433, 129)
        Me.gb_verify.TabIndex = 56
        Me.gb_verify.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel16.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel16.Location = New System.Drawing.Point(13, 12)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(184, 13)
        Me.GunaLabel16.TabIndex = 36
        Me.GunaLabel16.Text = "reCaptcha >> HBackeR.unaux.com"
        '
        'GunaGradient2Panel3
        '
        Me.GunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel3.Controls.Add(Me.n4)
        Me.GunaGradient2Panel3.Controls.Add(Me.n3)
        Me.GunaGradient2Panel3.Controls.Add(Me.n2)
        Me.GunaGradient2Panel3.Controls.Add(Me.n1)
        Me.GunaGradient2Panel3.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GunaGradient2Panel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GunaGradient2Panel3.Location = New System.Drawing.Point(13, 44)
        Me.GunaGradient2Panel3.Name = "GunaGradient2Panel3"
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(199, 75)
        Me.GunaGradient2Panel3.TabIndex = 35
        '
        'n4
        '
        Me.n4.AutoSize = True
        Me.n4.Font = New System.Drawing.Font("Caviar Dreams", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.n4.Location = New System.Drawing.Point(148, 14)
        Me.n4.Name = "n4"
        Me.n4.Size = New System.Drawing.Size(48, 53)
        Me.n4.TabIndex = 3
        Me.n4.Text = "_"
        '
        'n3
        '
        Me.n3.AutoSize = True
        Me.n3.Font = New System.Drawing.Font("Caviar Dreams", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.n3.Location = New System.Drawing.Point(96, 14)
        Me.n3.Name = "n3"
        Me.n3.Size = New System.Drawing.Size(48, 53)
        Me.n3.TabIndex = 2
        Me.n3.Text = "_"
        '
        'n2
        '
        Me.n2.AutoSize = True
        Me.n2.Font = New System.Drawing.Font("Caviar Dreams", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.n2.Location = New System.Drawing.Point(46, 14)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(48, 53)
        Me.n2.TabIndex = 1
        Me.n2.Text = "_"
        '
        'n1
        '
        Me.n1.AutoSize = True
        Me.n1.Font = New System.Drawing.Font("Caviar Dreams", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.n1.Location = New System.Drawing.Point(2, 14)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(48, 53)
        Me.n1.TabIndex = 0
        Me.n1.Text = "_"
        '
        'kod4
        '
        Me.kod4.BackColor = System.Drawing.Color.Transparent
        Me.kod4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.kod4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kod4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod4.FocusedBaseColor = System.Drawing.Color.White
        Me.kod4.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kod4.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kod4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod4.Location = New System.Drawing.Point(374, 49)
        Me.kod4.MaxLength = 1
        Me.kod4.Name = "kod4"
        Me.kod4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod4.Radius = 5
        Me.kod4.Size = New System.Drawing.Size(46, 70)
        Me.kod4.TabIndex = 34
        Me.kod4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kod3
        '
        Me.kod3.BackColor = System.Drawing.Color.Transparent
        Me.kod3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.kod3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kod3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod3.FocusedBaseColor = System.Drawing.Color.White
        Me.kod3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kod3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kod3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod3.Location = New System.Drawing.Point(322, 49)
        Me.kod3.MaxLength = 1
        Me.kod3.Name = "kod3"
        Me.kod3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod3.Radius = 5
        Me.kod3.Size = New System.Drawing.Size(46, 70)
        Me.kod3.TabIndex = 33
        Me.kod3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kod2
        '
        Me.kod2.BackColor = System.Drawing.Color.Transparent
        Me.kod2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.kod2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kod2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod2.FocusedBaseColor = System.Drawing.Color.White
        Me.kod2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kod2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kod2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod2.Location = New System.Drawing.Point(270, 49)
        Me.kod2.MaxLength = 1
        Me.kod2.Name = "kod2"
        Me.kod2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod2.Radius = 5
        Me.kod2.Size = New System.Drawing.Size(46, 70)
        Me.kod2.TabIndex = 32
        Me.kod2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kod1
        '
        Me.kod1.BackColor = System.Drawing.Color.Transparent
        Me.kod1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.kod1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kod1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod1.FocusedBaseColor = System.Drawing.Color.White
        Me.kod1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kod1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kod1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod1.Location = New System.Drawing.Point(218, 49)
        Me.kod1.MaxLength = 1
        Me.kod1.Name = "kod1"
        Me.kod1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod1.Radius = 5
        Me.kod1.Size = New System.Drawing.Size(46, 70)
        Me.kod1.TabIndex = 31
        Me.kod1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGradientButton3
        '
        Me.GunaGradientButton3.Animated = True
        Me.GunaGradientButton3.AnimationHoverSpeed = 10.0!
        Me.GunaGradientButton3.AnimationSpeed = 10.0!
        Me.GunaGradientButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton3.BaseColor1 = System.Drawing.Color.Indigo
        Me.GunaGradientButton3.BaseColor2 = System.Drawing.Color.MidnightBlue
        Me.GunaGradientButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton3.BorderSize = 1
        Me.GunaGradientButton3.Enabled = False
        Me.GunaGradientButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton3.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton3.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.forward_96px
        Me.GunaGradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaGradientButton3.ImageOffsetX = -5
        Me.GunaGradientButton3.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaGradientButton3.Location = New System.Drawing.Point(116, 148)
        Me.GunaGradientButton3.Name = "GunaGradientButton3"
        Me.GunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.OnHoverImage = Nothing
        Me.GunaGradientButton3.OnPressedColor = System.Drawing.Color.Crimson
        Me.GunaGradientButton3.Radius = 5
        Me.GunaGradientButton3.Size = New System.Drawing.Size(235, 60)
        Me.GunaGradientButton3.TabIndex = 29
        Me.GunaGradientButton3.Text = "Gönder"
        Me.GunaGradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'block
        '
        Me.block.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.block.BaseColor = System.Drawing.Color.Transparent
        Me.block.Controls.Add(Me.GunaGradientButton1)
        Me.block.Controls.Add(Me.nulltime)
        Me.block.Controls.Add(Me.GunaLabel9)
        Me.block.Controls.Add(Me.GunaLabel5)
        Me.block.Controls.Add(Me.error_box)
        Me.block.Controls.Add(Me.piyon)
        Me.block.Controls.Add(Me.block_box)
        Me.block.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.block.Location = New System.Drawing.Point(0, 55)
        Me.block.Name = "block"
        Me.block.Size = New System.Drawing.Size(449, 371)
        Me.block.TabIndex = 57
        Me.block.Visible = False
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.Animated = True
        Me.GunaGradientButton1.AnimationHoverSpeed = 10.0!
        Me.GunaGradientButton1.AnimationSpeed = 10.0!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.Indigo
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.MidnightBlue
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.approval_96px
        Me.GunaGradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaGradientButton1.ImageOffsetX = -5
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(142, 256)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Crimson
        Me.GunaGradientButton1.Radius = 5
        Me.GunaGradientButton1.Size = New System.Drawing.Size(204, 60)
        Me.GunaGradientButton1.TabIndex = 44
        Me.GunaGradientButton1.Text = "Tamam"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nulltime
        '
        Me.nulltime.AutoSize = True
        Me.nulltime.Font = New System.Drawing.Font("Trebuchet MS", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.nulltime.ForeColor = System.Drawing.Color.White
        Me.nulltime.Location = New System.Drawing.Point(182, 306)
        Me.nulltime.Name = "nulltime"
        Me.nulltime.Size = New System.Drawing.Size(7, 2)
        Me.nulltime.TabIndex = 48
        Me.nulltime.Text = "wnull"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel9.Location = New System.Drawing.Point(12, 329)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(197, 22)
        Me.GunaLabel9.TabIndex = 39
        Me.GunaLabel9.Text = "Lütfen Tekrar Deneyiniz..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(70, 29)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(348, 35)
        Me.GunaLabel5.TabIndex = 46
        Me.GunaLabel5.Text = "Oops! bir hata oldu galiba.."
        '
        'error_box
        '
        Me.error_box.BackColor = System.Drawing.Color.Transparent
        Me.error_box.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.error_box.BorderColor = System.Drawing.Color.MidnightBlue
        Me.error_box.Controls.Add(Me.error_name)
        Me.error_box.Controls.Add(Me.GunaLabel6)
        Me.error_box.Controls.Add(Me.error_desc)
        Me.error_box.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.error_box.LineColor = System.Drawing.Color.MidnightBlue
        Me.error_box.Location = New System.Drawing.Point(16, 78)
        Me.error_box.Name = "error_box"
        Me.error_box.Size = New System.Drawing.Size(425, 167)
        Me.error_box.TabIndex = 47
        Me.error_box.TextLocation = New System.Drawing.Point(10, 8)
        '
        'error_name
        '
        Me.error_name.AutoSize = True
        Me.error_name.BackColor = System.Drawing.Color.Transparent
        Me.error_name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.error_name.ForeColor = System.Drawing.Color.Silver
        Me.error_name.Location = New System.Drawing.Point(89, 6)
        Me.error_name.Name = "error_name"
        Me.error_name.Size = New System.Drawing.Size(100, 21)
        Me.error_name.TabIndex = 14
        Me.error_name.Text = "$error_name"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel6.Location = New System.Drawing.Point(10, 5)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(82, 21)
        Me.GunaLabel6.TabIndex = 13
        Me.GunaLabel6.Text = "HATA ! >>"
        '
        'error_desc
        '
        Me.error_desc.AutoSize = True
        Me.error_desc.Dock = System.Windows.Forms.DockStyle.Left
        Me.error_desc.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.error_desc.ForeColor = System.Drawing.Color.White
        Me.error_desc.Location = New System.Drawing.Point(0, 0)
        Me.error_desc.Name = "error_desc"
        Me.error_desc.Padding = New System.Windows.Forms.Padding(17, 45, 0, 0)
        Me.error_desc.Size = New System.Drawing.Size(215, 82)
        Me.error_desc.TabIndex = 38
        Me.error_desc.Text = "#error_name#"
        Me.error_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'piyon
        '
        Me.piyon.Location = New System.Drawing.Point(172, 275)
        Me.piyon.Name = "piyon"
        Me.piyon.Size = New System.Drawing.Size(13, 20)
        Me.piyon.TabIndex = 49
        '
        'block_box
        '
        Me.block_box.BackColor = System.Drawing.Color.Transparent
        Me.block_box.Location = New System.Drawing.Point(3, 20)
        Me.block_box.Name = "block_box"
        Me.block_box.Size = New System.Drawing.Size(446, 337)
        Me.block_box.TabIndex = 45
        Me.block_box.TabStop = False
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 7
        Me.GunaElipse3.TargetControl = Me.error_box
        '
        'wc1
        '
        Me.wc1.Interval = 1000
        '
        'wc2
        '
        Me.wc2.Interval = 1000
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel3.Location = New System.Drawing.Point(96, 15)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(250, 27)
        Me.GunaLabel3.TabIndex = 32
        Me.GunaLabel3.Text = "Kullanıcı Arayüzü >> Kayıt"
        '
        'header_kapat
        '
        Me.header_kapat.Animated = True
        Me.header_kapat.AnimationHoverSpeed = 10.0!
        Me.header_kapat.AnimationSpeed = 10.0!
        Me.header_kapat.BackColor = System.Drawing.Color.Transparent
        Me.header_kapat.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.header_kapat.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.header_kapat.BorderColor = System.Drawing.Color.Black
        Me.header_kapat.FocusedColor = System.Drawing.Color.Empty
        Me.header_kapat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.header_kapat.ForeColor = System.Drawing.Color.White
        Me.header_kapat.Image = Nothing
        Me.header_kapat.ImageSize = New System.Drawing.Size(20, 20)
        Me.header_kapat.Location = New System.Drawing.Point(398, 9)
        Me.header_kapat.Name = "header_kapat"
        Me.header_kapat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.header_kapat.OnHoverBaseColor2 = System.Drawing.Color.Crimson
        Me.header_kapat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.header_kapat.OnHoverForeColor = System.Drawing.Color.White
        Me.header_kapat.OnHoverImage = Nothing
        Me.header_kapat.OnPressedColor = System.Drawing.Color.Black
        Me.header_kapat.Radius = 6
        Me.header_kapat.Size = New System.Drawing.Size(43, 33)
        Me.header_kapat.TabIndex = 4
        Me.header_kapat.Text = "X"
        Me.header_kapat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'header_icon
        '
        Me.header_icon.BackColor = System.Drawing.Color.Transparent
        Me.header_icon.BaseColor = System.Drawing.Color.Transparent
        Me.header_icon.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.contact_details_96px
        Me.header_icon.InitialImage = CType(resources.GetObject("header_icon.InitialImage"), System.Drawing.Image)
        Me.header_icon.Location = New System.Drawing.Point(44, 5)
        Me.header_icon.Name = "header_icon"
        Me.header_icon.Size = New System.Drawing.Size(59, 44)
        Me.header_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.header_icon.TabIndex = 3
        Me.header_icon.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header.BorderColor = System.Drawing.Color.Transparent
        Me.Header.Controls.Add(Me.GunaLabel7)
        Me.Header.Controls.Add(Me.GunaGradientButton2)
        Me.Header.Controls.Add(Me.GunaPictureBox1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Header.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Header.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Header.HeaderMaximize = False
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(449, 52)
        Me.Header.TabIndex = 58
        Me.Header.Text = "Header"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel7.Location = New System.Drawing.Point(91, 12)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(276, 27)
        Me.GunaLabel7.TabIndex = 32
        Me.GunaLabel7.Text = "Kullanıcı Arayüzü >> Kayıt Ol"
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.Animated = True
        Me.GunaGradientButton2.AnimationHoverSpeed = 10.0!
        Me.GunaGradientButton2.AnimationSpeed = 10.0!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(397, 9)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 6
        Me.GunaGradientButton2.Size = New System.Drawing.Size(43, 33)
        Me.GunaGradientButton2.TabIndex = 4
        Me.GunaGradientButton2.Text = "X"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.contact_details_96px
        Me.GunaPictureBox1.InitialImage = CType(resources.GetObject("GunaPictureBox1.InitialImage"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(40, 3)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(59, 44)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 3
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel8.Location = New System.Drawing.Point(61, 410)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(90, 16)
        Me.GunaLabel8.TabIndex = 59
        Me.GunaLabel8.Text = "İletişim Formu"
        '
        'Kullanıcı_Kayıt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 428)
        Me.Controls.Add(Me.block)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.gb_verify)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.register)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.giris_yap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kullanıcı_Kayıt"
        Me.Text = "Yeni Kullanıcı Kaydı"
        Me.gb_verify.ResumeLayout(False)
        Me.gb_verify.PerformLayout()
        Me.GunaGradient2Panel3.ResumeLayout(False)
        Me.GunaGradient2Panel3.PerformLayout()
        Me.block.ResumeLayout(False)
        Me.block.PerformLayout()
        Me.error_box.ResumeLayout(False)
        Me.error_box.PerformLayout()
        CType(Me.block_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.header_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents username As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents register As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents giris_yap As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents password As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents email As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents header_kapat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents header_icon As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents block As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents nulltime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents error_box As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents error_desc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents error_name As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents block_box As PictureBox
    Friend WithEvents piyon As TextBox
    Friend WithEvents gb_verify As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents n4 As Label
    Friend WithEvents n3 As Label
    Friend WithEvents n2 As Label
    Friend WithEvents n1 As Label
    Friend WithEvents kod4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaGradientButton3 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents wc1 As Timer
    Friend WithEvents wc2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Header As FormSkin
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
End Class
