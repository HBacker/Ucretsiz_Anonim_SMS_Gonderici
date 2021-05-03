<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kullanıcı_Arayüz
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kullanıcı_Arayüz))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.uname = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.pw = New Guna.UI.WinForms.GunaTextBox()
        Me.login = New Guna.UI.WinForms.GunaGradientButton()
        Me.gb_verify = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaGradient2Panel3 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.n4 = New System.Windows.Forms.Label()
        Me.n3 = New System.Windows.Forms.Label()
        Me.n2 = New System.Windows.Forms.Label()
        Me.n1 = New System.Windows.Forms.Label()
        Me.kod4 = New Guna.UI.WinForms.GunaTextBox()
        Me.kod3 = New Guna.UI.WinForms.GunaTextBox()
        Me.kod2 = New Guna.UI.WinForms.GunaTextBox()
        Me.kod1 = New Guna.UI.WinForms.GunaTextBox()
        Me.FormSkin2 = New THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.FormSkin()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradientButton3 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.vapp = New Guna.UI.WinForms.GunaLabel()
        Me.vui = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.block = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.nulltime = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.verify = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.error_desc = New Guna.UI.WinForms.GunaLabel()
        Me.FormSkin1 = New THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.FormSkin()
        Me.error_name = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.block_box = New System.Windows.Forms.PictureBox()
        Me.yeni_uye = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Header = New THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.FormSkin()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.header_kapat = New Guna.UI.WinForms.GunaGradientButton()
        Me.header_icon = New Guna.UI.WinForms.GunaPictureBox()
        Me.piyon = New THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.FlatTextBox()
        Me.verifybox = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.gb_verify.SuspendLayout()
        Me.GunaGradient2Panel3.SuspendLayout()
        Me.FormSkin2.SuspendLayout()
        Me.block.SuspendLayout()
        Me.verify.SuspendLayout()
        Me.FormSkin1.SuspendLayout()
        CType(Me.block_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        CType(Me.header_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'uname
        '
        Me.uname.BackColor = System.Drawing.Color.Transparent
        Me.uname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.uname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.uname.FocusedBaseColor = System.Drawing.Color.White
        Me.uname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.uname.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.uname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.uname.Location = New System.Drawing.Point(90, 70)
        Me.uname.MaxLength = 16
        Me.uname.Name = "uname"
        Me.uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.uname.Radius = 5
        Me.uname.Size = New System.Drawing.Size(392, 55)
        Me.uname.TabIndex = 23
        Me.uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel1.Location = New System.Drawing.Point(10, 78)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(77, 35)
        Me.GunaLabel1.TabIndex = 31
        Me.GunaLabel1.Text = "Nick:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel2.Location = New System.Drawing.Point(10, 157)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(82, 35)
        Me.GunaLabel2.TabIndex = 32
        Me.GunaLabel2.Text = "Şifre:"
        '
        'pw
        '
        Me.pw.BackColor = System.Drawing.Color.Transparent
        Me.pw.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pw.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pw.FocusedBaseColor = System.Drawing.Color.White
        Me.pw.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pw.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.pw.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.pw.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pw.Location = New System.Drawing.Point(90, 146)
        Me.pw.MaxLength = 20
        Me.pw.Name = "pw"
        Me.pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.pw.Radius = 5
        Me.pw.Size = New System.Drawing.Size(392, 55)
        Me.pw.TabIndex = 33
        Me.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pw.UseSystemPasswordChar = True
        '
        'login
        '
        Me.login.Animated = True
        Me.login.AnimationHoverSpeed = 10.0!
        Me.login.AnimationSpeed = 10.0!
        Me.login.BackColor = System.Drawing.Color.Transparent
        Me.login.BaseColor1 = System.Drawing.Color.Indigo
        Me.login.BaseColor2 = System.Drawing.Color.MidnightBlue
        Me.login.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.login.FocusedColor = System.Drawing.Color.Empty
        Me.login.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.White
        Me.login.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.forward_96px
        Me.login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.login.ImageOffsetX = -5
        Me.login.ImageSize = New System.Drawing.Size(36, 36)
        Me.login.Location = New System.Drawing.Point(243, 346)
        Me.login.Name = "login"
        Me.login.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.login.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.login.OnHoverBorderColor = System.Drawing.Color.White
        Me.login.OnHoverForeColor = System.Drawing.Color.White
        Me.login.OnHoverImage = Nothing
        Me.login.OnPressedColor = System.Drawing.Color.Crimson
        Me.login.Radius = 5
        Me.login.Size = New System.Drawing.Size(235, 60)
        Me.login.TabIndex = 29
        Me.login.Text = "Giris Yap"
        Me.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gb_verify
        '
        Me.gb_verify.BackColor = System.Drawing.Color.Transparent
        Me.gb_verify.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.gb_verify.BorderColor = System.Drawing.Color.MidnightBlue
        Me.gb_verify.Controls.Add(Me.GunaGradient2Panel3)
        Me.gb_verify.Controls.Add(Me.kod4)
        Me.gb_verify.Controls.Add(Me.kod3)
        Me.gb_verify.Controls.Add(Me.kod2)
        Me.gb_verify.Controls.Add(Me.kod1)
        Me.gb_verify.Controls.Add(Me.FormSkin2)
        Me.gb_verify.Controls.Add(Me.GunaGradientButton3)
        Me.gb_verify.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gb_verify.LineColor = System.Drawing.Color.RoyalBlue
        Me.gb_verify.Location = New System.Drawing.Point(8, 211)
        Me.gb_verify.Name = "gb_verify"
        Me.gb_verify.Size = New System.Drawing.Size(472, 129)
        Me.gb_verify.TabIndex = 34
        Me.gb_verify.TextLocation = New System.Drawing.Point(10, 8)
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
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(238, 75)
        Me.GunaGradient2Panel3.TabIndex = 35
        '
        'n4
        '
        Me.n4.AutoSize = True
        Me.n4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.n4.Location = New System.Drawing.Point(172, 11)
        Me.n4.Name = "n4"
        Me.n4.Size = New System.Drawing.Size(50, 55)
        Me.n4.TabIndex = 3
        Me.n4.Text = "_"
        '
        'n3
        '
        Me.n3.AutoSize = True
        Me.n3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.n3.Location = New System.Drawing.Point(120, 11)
        Me.n3.Name = "n3"
        Me.n3.Size = New System.Drawing.Size(50, 55)
        Me.n3.TabIndex = 2
        Me.n3.Text = "_"
        '
        'n2
        '
        Me.n2.AutoSize = True
        Me.n2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.n2.Location = New System.Drawing.Point(68, 11)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(50, 55)
        Me.n2.TabIndex = 1
        Me.n2.Text = "_"
        '
        'n1
        '
        Me.n1.AutoSize = True
        Me.n1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.n1.Location = New System.Drawing.Point(16, 11)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(50, 55)
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
        Me.kod4.Location = New System.Drawing.Point(416, 50)
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
        Me.kod3.Location = New System.Drawing.Point(364, 50)
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
        Me.kod2.Location = New System.Drawing.Point(312, 50)
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
        Me.kod1.Location = New System.Drawing.Point(260, 50)
        Me.kod1.MaxLength = 1
        Me.kod1.Name = "kod1"
        Me.kod1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod1.Radius = 5
        Me.kod1.Size = New System.Drawing.Size(46, 69)
        Me.kod1.TabIndex = 31
        Me.kod1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormSkin2
        '
        Me.FormSkin2.BackColor = System.Drawing.Color.White
        Me.FormSkin2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin2.Controls.Add(Me.GunaLabel16)
        Me.FormSkin2.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin2.HeaderColor = System.Drawing.Color.Indigo
        Me.FormSkin2.HeaderMaximize = False
        Me.FormSkin2.Location = New System.Drawing.Point(0, 1)
        Me.FormSkin2.Name = "FormSkin2"
        Me.FormSkin2.Size = New System.Drawing.Size(482, 38)
        Me.FormSkin2.TabIndex = 36
        Me.FormSkin2.Text = "FormSkin2"
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel16.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel16.Location = New System.Drawing.Point(14, 15)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(175, 13)
        Me.GunaLabel16.TabIndex = 13
        Me.GunaLabel16.Text = "reCaptcha >> Güvenlik Düzeyi: 1"
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
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel6.Location = New System.Drawing.Point(2, 403)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(31, 18)
        Me.GunaLabel6.TabIndex = 37
        Me.GunaLabel6.Text = "UI ="
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel7.Location = New System.Drawing.Point(1, 384)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(41, 18)
        Me.GunaLabel7.TabIndex = 38
        Me.GunaLabel7.Text = "App ="
        '
        'vapp
        '
        Me.vapp.AutoSize = True
        Me.vapp.BackColor = System.Drawing.Color.Transparent
        Me.vapp.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.vapp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.vapp.Location = New System.Drawing.Point(42, 384)
        Me.vapp.Name = "vapp"
        Me.vapp.Size = New System.Drawing.Size(50, 18)
        Me.vapp.TabIndex = 39
        Me.vapp.Text = "$v_app"
        '
        'vui
        '
        Me.vui.AutoSize = True
        Me.vui.BackColor = System.Drawing.Color.Transparent
        Me.vui.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.vui.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.vui.Location = New System.Drawing.Point(43, 402)
        Me.vui.Name = "vui"
        Me.vui.Size = New System.Drawing.Size(40, 18)
        Me.vui.TabIndex = 40
        Me.vui.Text = "$v_ui"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(353, 386)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(4, 4)
        Me.Label1.TabIndex = 42
        Me.Label1.Tag = ""
        Me.Label1.Text = "."
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 10
        Me.GunaElipse2.TargetControl = Me
        '
        'block
        '
        Me.block.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.block.BaseColor = System.Drawing.Color.Transparent
        Me.block.Controls.Add(Me.GunaGradientButton1)
        Me.block.Controls.Add(Me.nulltime)
        Me.block.Controls.Add(Me.GunaLabel5)
        Me.block.Controls.Add(Me.verify)
        Me.block.Controls.Add(Me.block_box)
        Me.block.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.block.Location = New System.Drawing.Point(1, 48)
        Me.block.Name = "block"
        Me.block.Size = New System.Drawing.Size(485, 371)
        Me.block.TabIndex = 43
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(149, 278)
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
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(84, 26)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(348, 35)
        Me.GunaLabel5.TabIndex = 46
        Me.GunaLabel5.Text = "Oops! bir hata oldu galiba.."
        '
        'verify
        '
        Me.verify.BackColor = System.Drawing.Color.Transparent
        Me.verify.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.verify.BorderColor = System.Drawing.Color.MidnightBlue
        Me.verify.Controls.Add(Me.GunaLabel9)
        Me.verify.Controls.Add(Me.error_desc)
        Me.verify.Controls.Add(Me.FormSkin1)
        Me.verify.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.verify.LineColor = System.Drawing.Color.RoyalBlue
        Me.verify.Location = New System.Drawing.Point(16, 78)
        Me.verify.Name = "verify"
        Me.verify.Size = New System.Drawing.Size(461, 185)
        Me.verify.TabIndex = 47
        Me.verify.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.White
        Me.GunaLabel9.Location = New System.Drawing.Point(3, 162)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(197, 22)
        Me.GunaLabel9.TabIndex = 39
        Me.GunaLabel9.Text = "Lütfen Tekrar Deneyiniz..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'error_desc
        '
        Me.error_desc.AutoSize = True
        Me.error_desc.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.error_desc.ForeColor = System.Drawing.Color.White
        Me.error_desc.Location = New System.Drawing.Point(11, 59)
        Me.error_desc.Name = "error_desc"
        Me.error_desc.Size = New System.Drawing.Size(198, 37)
        Me.error_desc.TabIndex = 38
        Me.error_desc.Text = "#error_name#"
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.error_name)
        Me.FormSkin1.Controls.Add(Me.GunaLabel4)
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.Indigo
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 1)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(482, 38)
        Me.FormSkin1.TabIndex = 36
        Me.FormSkin1.Text = "FormSkin1"
        '
        'error_name
        '
        Me.error_name.AutoSize = True
        Me.error_name.BackColor = System.Drawing.Color.Transparent
        Me.error_name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.error_name.ForeColor = System.Drawing.Color.Silver
        Me.error_name.Location = New System.Drawing.Point(93, 12)
        Me.error_name.Name = "error_name"
        Me.error_name.Size = New System.Drawing.Size(100, 21)
        Me.error_name.TabIndex = 14
        Me.error_name.Text = "$error_name"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel4.Location = New System.Drawing.Point(14, 11)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(82, 21)
        Me.GunaLabel4.TabIndex = 13
        Me.GunaLabel4.Text = "HATA ! >>"
        '
        'block_box
        '
        Me.block_box.BackColor = System.Drawing.Color.Transparent
        Me.block_box.Location = New System.Drawing.Point(3, 20)
        Me.block_box.Name = "block_box"
        Me.block_box.Size = New System.Drawing.Size(489, 346)
        Me.block_box.TabIndex = 45
        Me.block_box.TabStop = False
        '
        'yeni_uye
        '
        Me.yeni_uye.Animated = True
        Me.yeni_uye.AnimationHoverSpeed = 10.0!
        Me.yeni_uye.AnimationSpeed = 10.0!
        Me.yeni_uye.BackColor = System.Drawing.Color.Transparent
        Me.yeni_uye.BaseColor = System.Drawing.Color.Transparent
        Me.yeni_uye.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.yeni_uye.CheckedBaseColor = System.Drawing.Color.Gray
        Me.yeni_uye.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.yeni_uye.CheckedForeColor = System.Drawing.Color.White
        Me.yeni_uye.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_321
        Me.yeni_uye.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.yeni_uye.FocusedColor = System.Drawing.Color.Empty
        Me.yeni_uye.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.yeni_uye.ForeColor = System.Drawing.Color.White
        Me.yeni_uye.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.icons8_plus_96px
        Me.yeni_uye.ImageSize = New System.Drawing.Size(42, 42)
        Me.yeni_uye.LineBottom = 3
        Me.yeni_uye.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.yeni_uye.Location = New System.Drawing.Point(106, 346)
        Me.yeni_uye.Name = "yeni_uye"
        Me.yeni_uye.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.yeni_uye.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.yeni_uye.OnHoverForeColor = System.Drawing.Color.White
        Me.yeni_uye.OnHoverImage = Nothing
        Me.yeni_uye.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.yeni_uye.OnPressedColor = System.Drawing.Color.Black
        Me.yeni_uye.Radius = 8
        Me.yeni_uye.Size = New System.Drawing.Size(130, 60)
        Me.yeni_uye.TabIndex = 44
        Me.yeni_uye.Text = "Yeni Kayıt"
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 6
        Me.GunaElipse3.TargetControl = Me.yeni_uye
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header.BorderColor = System.Drawing.Color.Transparent
        Me.Header.Controls.Add(Me.GunaLabel3)
        Me.Header.Controls.Add(Me.header_kapat)
        Me.Header.Controls.Add(Me.header_icon)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Header.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Header.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Header.HeaderMaximize = False
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(489, 52)
        Me.Header.TabIndex = 30
        Me.Header.Text = "Header"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel3.Location = New System.Drawing.Point(101, 12)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(286, 27)
        Me.GunaLabel3.TabIndex = 32
        Me.GunaLabel3.Text = "Kullanıcı Arayüzü >> Giriş Yap"
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
        Me.header_kapat.Location = New System.Drawing.Point(439, 9)
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
        Me.header_icon.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.password_96px
        Me.header_icon.InitialImage = CType(resources.GetObject("header_icon.InitialImage"), System.Drawing.Image)
        Me.header_icon.Location = New System.Drawing.Point(50, 3)
        Me.header_icon.Name = "header_icon"
        Me.header_icon.Size = New System.Drawing.Size(59, 44)
        Me.header_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.header_icon.TabIndex = 3
        Me.header_icon.TabStop = False
        '
        'piyon
        '
        Me.piyon.BackColor = System.Drawing.Color.Transparent
        Me.piyon.Location = New System.Drawing.Point(311, 359)
        Me.piyon.MaxLength = 32767
        Me.piyon.Multiline = False
        Me.piyon.Name = "piyon"
        Me.piyon.ReadOnly = False
        Me.piyon.Size = New System.Drawing.Size(10, 29)
        Me.piyon.TabIndex = 33
        Me.piyon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.piyon.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.piyon.UseSystemPasswordChar = False
        '
        'verifybox
        '
        Me.verifybox.Radius = 7
        Me.verifybox.TargetControl = Me.verify
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel8.Location = New System.Drawing.Point(1, 368)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(90, 16)
        Me.GunaLabel8.TabIndex = 45
        Me.GunaLabel8.Text = "İletişim Formu"
        '
        'Kullanıcı_Arayüz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(489, 422)
        Me.Controls.Add(Me.block)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vui)
        Me.Controls.Add(Me.vapp)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.gb_verify)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.piyon)
        Me.Controls.Add(Me.yeni_uye)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kullanıcı_Arayüz"
        Me.Text = "Giriş Yap"
        Me.gb_verify.ResumeLayout(False)
        Me.GunaGradient2Panel3.ResumeLayout(False)
        Me.GunaGradient2Panel3.PerformLayout()
        Me.FormSkin2.ResumeLayout(False)
        Me.FormSkin2.PerformLayout()
        Me.block.ResumeLayout(False)
        Me.block.PerformLayout()
        Me.verify.ResumeLayout(False)
        Me.verify.PerformLayout()
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.block_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.header_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents uname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents user As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents login As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents pw As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Header As FormSkin
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents header_kapat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents header_icon As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents gb_verify As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents n4 As Label
    Friend WithEvents n3 As Label
    Friend WithEvents n2 As Label
    Friend WithEvents n1 As Label
    Friend WithEvents kod4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents FormSkin2 As FormSkin
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton3 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents piyon As FlatTextBox
    Friend WithEvents vui As Guna.UI.WinForms.GunaLabel
    Friend WithEvents vapp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents block As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents verify As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents error_desc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents error_name As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents block_box As PictureBox
    Friend WithEvents yeni_uye As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents nulltime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents verifybox As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
End Class
