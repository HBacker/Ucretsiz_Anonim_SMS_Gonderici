<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iletisim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iletisim))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.vnick = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.vmail = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.vkonu = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.vmesaj = New System.Windows.Forms.RichTextBox()
        Me.alert_box = New System.Windows.Forms.Panel()
        Me.x2 = New Guna.UI.WinForms.GunaLabel()
        Me.x1 = New Guna.UI.WinForms.GunaLabel()
        Me.alert_text = New Guna.UI.WinForms.GunaLabel()
        Me.gonder = New System.Windows.Forms.Timer(Me.components)
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.header_text = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.restart = New System.Windows.Forms.Timer(Me.components)
        Me.waiter = New Guna.UI.WinForms.GunaLabel()
        Me.Header = New THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.FormSkin()
        Me.header_kapat = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.NewSMS = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SendReq = New Guna.UI.WinForms.GunaGradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.header_icon = New Guna.UI.WinForms.GunaPictureBox()
        Me.alert_box.SuspendLayout()
        Me.Header.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'vnick
        '
        Me.vnick.BackColor = System.Drawing.Color.Transparent
        Me.vnick.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.vnick.BorderColor = System.Drawing.Color.Aquamarine
        Me.vnick.BorderSize = 1
        Me.vnick.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.vnick.FocusedBaseColor = System.Drawing.Color.White
        Me.vnick.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vnick.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.vnick.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.vnick.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.vnick.Location = New System.Drawing.Point(142, 66)
        Me.vnick.MaxLength = 16
        Me.vnick.Name = "vnick"
        Me.vnick.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.vnick.Radius = 5
        Me.vnick.Size = New System.Drawing.Size(231, 36)
        Me.vnick.TabIndex = 35
        Me.vnick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel2.Location = New System.Drawing.Point(9, 69)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(129, 27)
        Me.GunaLabel2.TabIndex = 37
        Me.GunaLabel2.Text = "THT Nick -->"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel1.Location = New System.Drawing.Point(7, 117)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(83, 27)
        Me.GunaLabel1.TabIndex = 38
        Me.GunaLabel1.Text = "Mail -->"
        '
        'vmail
        '
        Me.vmail.BackColor = System.Drawing.Color.Transparent
        Me.vmail.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.vmail.BorderColor = System.Drawing.Color.Aquamarine
        Me.vmail.BorderSize = 1
        Me.vmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.vmail.FocusedBaseColor = System.Drawing.Color.White
        Me.vmail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vmail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.vmail.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.vmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.vmail.Location = New System.Drawing.Point(87, 113)
        Me.vmail.MaxLength = 32
        Me.vmail.Name = "vmail"
        Me.vmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.vmail.Radius = 5
        Me.vmail.Size = New System.Drawing.Size(286, 36)
        Me.vmail.TabIndex = 39
        Me.vmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel3.Location = New System.Drawing.Point(7, 172)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(64, 27)
        Me.GunaLabel3.TabIndex = 40
        Me.GunaLabel3.Text = "Konu:"
        '
        'vkonu
        '
        Me.vkonu.BackColor = System.Drawing.Color.Transparent
        Me.vkonu.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.vkonu.BorderColor = System.Drawing.Color.Aqua
        Me.vkonu.BorderSize = 1
        Me.vkonu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.vkonu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vkonu.FocusedColor = System.Drawing.Color.Empty
        Me.vkonu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.vkonu.ForeColor = System.Drawing.Color.White
        Me.vkonu.FormattingEnabled = True
        Me.vkonu.ItemHeight = 27
        Me.vkonu.Items.AddRange(New Object() {"Seçiniz...", "BUG / HATA Bildirimi", "Öneri / istek", "Diğer"})
        Me.vkonu.Location = New System.Drawing.Point(77, 169)
        Me.vkonu.Name = "vkonu"
        Me.vkonu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.vkonu.OnHoverItemForeColor = System.Drawing.Color.Indigo
        Me.vkonu.Radius = 3
        Me.vkonu.Size = New System.Drawing.Size(296, 33)
        Me.vkonu.TabIndex = 48
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel4.Location = New System.Drawing.Point(4, 220)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(107, 27)
        Me.GunaLabel4.TabIndex = 50
        Me.GunaLabel4.Text = "Mesajınız;"
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'vmesaj
        '
        Me.vmesaj.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.vmesaj.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.vmesaj.ForeColor = System.Drawing.Color.White
        Me.vmesaj.Location = New System.Drawing.Point(5, 250)
        Me.vmesaj.MaxLength = 1000
        Me.vmesaj.Name = "vmesaj"
        Me.vmesaj.Size = New System.Drawing.Size(364, 100)
        Me.vmesaj.TabIndex = 53
        Me.vmesaj.Text = ""
        '
        'alert_box
        '
        Me.alert_box.Controls.Add(Me.x2)
        Me.alert_box.Controls.Add(Me.x1)
        Me.alert_box.Controls.Add(Me.alert_text)
        Me.alert_box.Controls.Add(Me.GunaGradientButton2)
        Me.alert_box.Location = New System.Drawing.Point(5, 439)
        Me.alert_box.Name = "alert_box"
        Me.alert_box.Size = New System.Drawing.Size(364, 100)
        Me.alert_box.TabIndex = 55
        '
        'x2
        '
        Me.x2.AutoSize = True
        Me.x2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.x2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.x2.Location = New System.Drawing.Point(205, 79)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(156, 18)
        Me.x2.TabIndex = 58
        Me.x2.Text = "hbacker@protonmail.com"
        Me.x2.Visible = False
        '
        'x1
        '
        Me.x1.AutoSize = True
        Me.x1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.x1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.x1.Location = New System.Drawing.Point(1, 79)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(206, 18)
        Me.x1.TabIndex = 59
        Me.x1.Text = "Sorunu Manuel Olarak Bildiriniz ->"
        Me.x1.Visible = False
        '
        'alert_text
        '
        Me.alert_text.AutoSize = True
        Me.alert_text.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.alert_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.alert_text.Location = New System.Drawing.Point(73, 9)
        Me.alert_text.Name = "alert_text"
        Me.alert_text.Size = New System.Drawing.Size(229, 27)
        Me.alert_text.TabIndex = 57
        Me.alert_text.Text = "Boş yer bırakmayınız..."
        '
        'gonder
        '
        Me.gonder.Interval = 5000
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.Animated = True
        Me.GunaGradientButton1.AnimationHoverSpeed = 10.0!
        Me.GunaGradientButton1.AnimationSpeed = 10.0!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(332, 7)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 6
        Me.GunaGradientButton1.Size = New System.Drawing.Size(43, 33)
        Me.GunaGradientButton1.TabIndex = 4
        Me.GunaGradientButton1.Text = "X"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'header_text
        '
        Me.header_text.AutoSize = True
        Me.header_text.BackColor = System.Drawing.Color.Transparent
        Me.header_text.Dock = System.Windows.Forms.DockStyle.Left
        Me.header_text.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.header_text.ForeColor = System.Drawing.Color.White
        Me.header_text.Location = New System.Drawing.Point(0, 0)
        Me.header_text.Name = "header_text"
        Me.header_text.Padding = New System.Windows.Forms.Padding(160, 7, 0, 0)
        Me.header_text.Size = New System.Drawing.Size(239, 37)
        Me.header_text.TabIndex = 2
        Me.header_text.Text = "İletişim"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel6.Location = New System.Drawing.Point(11, 517)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(112, 18)
        Me.GunaLabel6.TabIndex = 58
        Me.GunaLabel6.Text = "Mesaj Gönderildi!"
        '
        'restart
        '
        Me.restart.Interval = 30000
        '
        'waiter
        '
        Me.waiter.AutoSize = True
        Me.waiter.BackColor = System.Drawing.Color.White
        Me.waiter.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.waiter.ForeColor = System.Drawing.Color.Black
        Me.waiter.Location = New System.Drawing.Point(16, 289)
        Me.waiter.Name = "waiter"
        Me.waiter.Size = New System.Drawing.Size(342, 22)
        Me.waiter.TabIndex = 59
        Me.waiter.Text = "Bir sonraki gönderim için 30 saniye bekleyiniz."
        Me.waiter.Visible = False
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header.BorderColor = System.Drawing.Color.Transparent
        Me.Header.Controls.Add(Me.header_kapat)
        Me.Header.Controls.Add(Me.GunaPictureBox1)
        Me.Header.Controls.Add(Me.GunaLabel5)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Header.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Header.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Header.HeaderMaximize = False
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(384, 52)
        Me.Header.TabIndex = 56
        Me.Header.Text = "Header"
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
        Me.header_kapat.Location = New System.Drawing.Point(335, 8)
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
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(-232, 3)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Padding = New System.Windows.Forms.Padding(330, 7, 0, 0)
        Me.GunaLabel5.Size = New System.Drawing.Size(531, 37)
        Me.GunaLabel5.TabIndex = 2
        Me.GunaLabel5.Text = "İletişim >> HBackeR"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.sms
        Me.GunaPictureBox1.InitialImage = CType(resources.GetObject("GunaPictureBox1.InitialImage"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(37, 3)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(59, 44)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 3
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.Animated = True
        Me.GunaGradientButton2.AnimationHoverSpeed = 10.0!
        Me.GunaGradientButton2.AnimationSpeed = 10.0!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.BorderSize = 1
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.approval_96px
        Me.GunaGradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaGradientButton2.ImageOffsetX = -5
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(162, 38)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Crimson
        Me.GunaGradientButton2.Radius = 5
        Me.GunaGradientButton2.Size = New System.Drawing.Size(45, 40)
        Me.GunaGradientButton2.TabIndex = 56
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewSMS
        '
        Me.NewSMS.Animated = True
        Me.NewSMS.AnimationHoverSpeed = 10.0!
        Me.NewSMS.AnimationSpeed = 10.0!
        Me.NewSMS.BackColor = System.Drawing.Color.Transparent
        Me.NewSMS.BaseColor = System.Drawing.Color.Transparent
        Me.NewSMS.BorderColor = System.Drawing.Color.Black
        Me.NewSMS.CheckedBaseColor = System.Drawing.Color.Gray
        Me.NewSMS.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewSMS.CheckedForeColor = System.Drawing.Color.White
        Me.NewSMS.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_321
        Me.NewSMS.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.NewSMS.FocusedColor = System.Drawing.Color.Empty
        Me.NewSMS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NewSMS.ForeColor = System.Drawing.Color.White
        Me.NewSMS.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.icons8_plus_96px
        Me.NewSMS.ImageSize = New System.Drawing.Size(42, 42)
        Me.NewSMS.LineBottom = 3
        Me.NewSMS.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.NewSMS.Location = New System.Drawing.Point(12, 366)
        Me.NewSMS.Name = "NewSMS"
        Me.NewSMS.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.NewSMS.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.NewSMS.OnHoverForeColor = System.Drawing.Color.White
        Me.NewSMS.OnHoverImage = Nothing
        Me.NewSMS.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.NewSMS.OnPressedColor = System.Drawing.Color.Black
        Me.NewSMS.Radius = 8
        Me.NewSMS.Size = New System.Drawing.Size(148, 60)
        Me.NewSMS.TabIndex = 52
        Me.NewSMS.Text = "Yeni  Mesaj..."
        '
        'SendReq
        '
        Me.SendReq.Animated = True
        Me.SendReq.AnimationHoverSpeed = 10.0!
        Me.SendReq.AnimationSpeed = 10.0!
        Me.SendReq.BackColor = System.Drawing.Color.Transparent
        Me.SendReq.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.SendReq.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SendReq.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SendReq.BorderSize = 1
        Me.SendReq.FocusedColor = System.Drawing.Color.Empty
        Me.SendReq.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendReq.ForeColor = System.Drawing.Color.White
        Me.SendReq.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.forward_96px
        Me.SendReq.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SendReq.ImageOffsetX = -5
        Me.SendReq.ImageSize = New System.Drawing.Size(36, 36)
        Me.SendReq.Location = New System.Drawing.Point(167, 366)
        Me.SendReq.Name = "SendReq"
        Me.SendReq.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.SendReq.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.SendReq.OnHoverBorderColor = System.Drawing.Color.White
        Me.SendReq.OnHoverForeColor = System.Drawing.Color.White
        Me.SendReq.OnHoverImage = Nothing
        Me.SendReq.OnPressedColor = System.Drawing.Color.Crimson
        Me.SendReq.Radius = 5
        Me.SendReq.Size = New System.Drawing.Size(202, 59)
        Me.SendReq.TabIndex = 51
        Me.SendReq.Text = "Gönder"
        Me.SendReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.loading1
        Me.PictureBox1.Location = New System.Drawing.Point(5, 439)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'header_icon
        '
        Me.header_icon.BackColor = System.Drawing.Color.Transparent
        Me.header_icon.BaseColor = System.Drawing.Color.Transparent
        Me.header_icon.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.sms
        Me.header_icon.InitialImage = CType(resources.GetObject("header_icon.InitialImage"), System.Drawing.Image)
        Me.header_icon.Location = New System.Drawing.Point(101, 0)
        Me.header_icon.Name = "header_icon"
        Me.header_icon.Size = New System.Drawing.Size(59, 44)
        Me.header_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.header_icon.TabIndex = 3
        Me.header_icon.TabStop = False
        '
        'iletisim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 544)
        Me.Controls.Add(Me.waiter)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.alert_box)
        Me.Controls.Add(Me.vmesaj)
        Me.Controls.Add(Me.NewSMS)
        Me.Controls.Add(Me.SendReq)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.vkonu)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.vmail)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.vnick)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "iletisim"
        Me.Text = "İletişim / API Gönder >> THT Ücretsiz Anonim SMS Gönderici"
        Me.alert_box.ResumeLayout(False)
        Me.alert_box.PerformLayout()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.header_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents header_icon As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents header_text As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents vmail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents vnick As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents vkonu As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents SendReq As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents NewSMS As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents vmesaj As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents alert_box As Windows.Forms.Panel
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents alert_text As Guna.UI.WinForms.GunaLabel
    Friend WithEvents x2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents x1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents gonder As Timer
    Friend WithEvents Header As FormSkin
    Friend WithEvents header_kapat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents restart As Timer
    Friend WithEvents waiter As Guna.UI.WinForms.GunaLabel
End Class
