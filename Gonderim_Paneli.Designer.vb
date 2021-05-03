<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gonderim_Paneli
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
        Me.teltext = New Guna.UI.WinForms.GunaLabel()
        Me.numtext = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.c_trflash = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.c_eng = New Guna.UI.WinForms.GunaRadioButton()
        Me.c_engflash = New Guna.UI.WinForms.GunaRadioButton()
        Me.c_tr = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.mesaj = New System.Windows.Forms.RichTextBox()
        Me.NewSMS = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SendReq = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.h1 = New Guna.UI.WinForms.GunaLabel()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton5 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'teltext
        '
        Me.teltext.AutoSize = True
        Me.teltext.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.teltext.ForeColor = System.Drawing.Color.White
        Me.teltext.Location = New System.Drawing.Point(22, 72)
        Me.teltext.Name = "teltext"
        Me.teltext.Size = New System.Drawing.Size(226, 29)
        Me.teltext.TabIndex = 1
        Me.teltext.Text = "Telefon Numarası->"
        '
        'numtext
        '
        Me.numtext.BackColor = System.Drawing.Color.Transparent
        Me.numtext.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.numtext.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numtext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numtext.FocusedBaseColor = System.Drawing.Color.White
        Me.numtext.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numtext.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.numtext.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.numtext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.numtext.Location = New System.Drawing.Point(253, 60)
        Me.numtext.MaxLength = 16
        Me.numtext.Name = "numtext"
        Me.numtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.numtext.Radius = 5
        Me.numtext.Size = New System.Drawing.Size(366, 55)
        Me.numtext.TabIndex = 2
        Me.numtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.MidnightBlue
        Me.GunaGroupBox1.Controls.Add(Me.GunaAdvenceButton2)
        Me.GunaGroupBox1.Controls.Add(Me.c_trflash)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.c_eng)
        Me.GunaGroupBox1.Controls.Add(Me.c_engflash)
        Me.GunaGroupBox1.Controls.Add(Me.c_tr)
        Me.GunaGroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Indigo
        Me.GunaGroupBox1.Location = New System.Drawing.Point(27, 136)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(665, 106)
        Me.GunaGroupBox1.TabIndex = 5
        Me.GunaGroupBox1.Text = "Mesaj Stili {Charset & Görüntülenme Biçimi}"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.Animated = True
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 10.0!
        Me.GunaAdvenceButton2.AnimationSpeed = 10.0!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_321
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_32
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(42, 42)
        Me.GunaAdvenceButton2.LineBottom = 3
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(592, 37)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 8
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(63, 55)
        Me.GunaAdvenceButton2.TabIndex = 15
        '
        'c_trflash
        '
        Me.c_trflash.BaseColor = System.Drawing.SystemColors.Control
        Me.c_trflash.CheckedOffColor = System.Drawing.Color.Gray
        Me.c_trflash.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c_trflash.FillColor = System.Drawing.Color.White
        Me.c_trflash.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.c_trflash.Location = New System.Drawing.Point(405, 57)
        Me.c_trflash.Name = "c_trflash"
        Me.c_trflash.Size = New System.Drawing.Size(171, 28)
        Me.c_trflash.TabIndex = 14
        Me.c_trflash.Text = "Unicode Flash"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel6.Location = New System.Drawing.Point(542, 9)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(110, 13)
        Me.GunaLabel6.TabIndex = 13
        Me.GunaLabel6.Text = "HBackeR.unaux.com"
        '
        'c_eng
        '
        Me.c_eng.BaseColor = System.Drawing.SystemColors.Control
        Me.c_eng.CheckedOffColor = System.Drawing.Color.Gray
        Me.c_eng.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c_eng.FillColor = System.Drawing.Color.White
        Me.c_eng.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.c_eng.Location = New System.Drawing.Point(30, 57)
        Me.c_eng.Name = "c_eng"
        Me.c_eng.Size = New System.Drawing.Size(80, 28)
        Me.c_eng.TabIndex = 2
        Me.c_eng.Text = "Latin"
        '
        'c_engflash
        '
        Me.c_engflash.BaseColor = System.Drawing.SystemColors.Control
        Me.c_engflash.CheckedOffColor = System.Drawing.Color.Gray
        Me.c_engflash.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c_engflash.FillColor = System.Drawing.Color.White
        Me.c_engflash.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.c_engflash.Location = New System.Drawing.Point(248, 57)
        Me.c_engflash.Name = "c_engflash"
        Me.c_engflash.Size = New System.Drawing.Size(139, 28)
        Me.c_engflash.TabIndex = 1
        Me.c_engflash.Text = "Latin Flash"
        '
        'c_tr
        '
        Me.c_tr.BaseColor = System.Drawing.SystemColors.Control
        Me.c_tr.CheckedOffColor = System.Drawing.Color.Gray
        Me.c_tr.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c_tr.FillColor = System.Drawing.Color.White
        Me.c_tr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.c_tr.Location = New System.Drawing.Point(129, 57)
        Me.c_tr.Name = "c_tr"
        Me.c_tr.Size = New System.Drawing.Size(112, 28)
        Me.c_tr.TabIndex = 0
        Me.c_tr.Text = "Unicode"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 447)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(192, 13)
        Me.GunaLabel2.TabIndex = 14
        Me.GunaLabel2.Text = "TurkHackTeam.org v SpyHackerz.org"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(22, 253)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(118, 29)
        Me.GunaLabel3.TabIndex = 15
        Me.GunaLabel3.Text = "Mesajınız:"
        '
        'mesaj
        '
        Me.mesaj.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.mesaj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mesaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mesaj.ForeColor = System.Drawing.Color.SpringGreen
        Me.mesaj.Location = New System.Drawing.Point(27, 285)
        Me.mesaj.MaxLength = 320
        Me.mesaj.Name = "mesaj"
        Me.mesaj.Size = New System.Drawing.Size(615, 95)
        Me.mesaj.TabIndex = 16
        Me.mesaj.Text = "{16:45}->"
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
        Me.NewSMS.Location = New System.Drawing.Point(321, 400)
        Me.NewSMS.Name = "NewSMS"
        Me.NewSMS.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.NewSMS.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.NewSMS.OnHoverForeColor = System.Drawing.Color.White
        Me.NewSMS.OnHoverImage = Nothing
        Me.NewSMS.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.NewSMS.OnPressedColor = System.Drawing.Color.Black
        Me.NewSMS.Radius = 8
        Me.NewSMS.Size = New System.Drawing.Size(130, 60)
        Me.NewSMS.TabIndex = 18
        Me.NewSMS.Text = "Yeni SMS"
        '
        'SendReq
        '
        Me.SendReq.Animated = True
        Me.SendReq.AnimationHoverSpeed = 10.0!
        Me.SendReq.AnimationSpeed = 10.0!
        Me.SendReq.BackColor = System.Drawing.Color.Transparent
        Me.SendReq.BaseColor1 = System.Drawing.Color.Indigo
        Me.SendReq.BaseColor2 = System.Drawing.Color.MidnightBlue
        Me.SendReq.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SendReq.BorderSize = 1
        Me.SendReq.FocusedColor = System.Drawing.Color.Empty
        Me.SendReq.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendReq.ForeColor = System.Drawing.Color.White
        Me.SendReq.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.forward_96px
        Me.SendReq.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SendReq.ImageOffsetX = -5
        Me.SendReq.ImageSize = New System.Drawing.Size(36, 36)
        Me.SendReq.Location = New System.Drawing.Point(457, 400)
        Me.SendReq.Name = "SendReq"
        Me.SendReq.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SendReq.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.SendReq.OnHoverBorderColor = System.Drawing.Color.White
        Me.SendReq.OnHoverForeColor = System.Drawing.Color.White
        Me.SendReq.OnHoverImage = Nothing
        Me.SendReq.OnPressedColor = System.Drawing.Color.Crimson
        Me.SendReq.Radius = 5
        Me.SendReq.Size = New System.Drawing.Size(235, 60)
        Me.SendReq.TabIndex = 17
        Me.SendReq.Text = "Gönder"
        Me.SendReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.Animated = True
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 10.0!
        Me.GunaAdvenceButton3.AnimationSpeed = 10.0!
        Me.GunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_321
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_32
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(42, 42)
        Me.GunaAdvenceButton3.LineBottom = 3
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(648, 285)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Radius = 8
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(67, 95)
        Me.GunaAdvenceButton3.TabIndex = 16
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = True
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 10.0!
        Me.GunaAdvenceButton1.AnimationSpeed = 10.0!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_321
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_32
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(42, 42)
        Me.GunaAdvenceButton1.LineBottom = 3
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(629, 60)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 8
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(63, 55)
        Me.GunaAdvenceButton1.TabIndex = 4
        '
        'h1
        '
        Me.h1.AutoSize = True
        Me.h1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.h1.ForeColor = System.Drawing.Color.AliceBlue
        Me.h1.Location = New System.Drawing.Point(281, 3)
        Me.h1.Name = "h1"
        Me.h1.Size = New System.Drawing.Size(170, 35)
        Me.h1.TabIndex = 19
        Me.h1.Text = "SMS Gönder"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 768)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(668, 129)
        Me.RichTextBox2.TabIndex = 38
        Me.RichTextBox2.Text = ""
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.AliceBlue
        Me.GunaLabel1.Location = New System.Drawing.Point(222, 480)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(302, 35)
        Me.GunaLabel1.TabIndex = 37
        Me.GunaLabel1.Text = "Numara Bilgisi Sorgula"
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
        Me.GunaGradientButton1.BorderSize = 1
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.forward_96px
        Me.GunaGradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaGradientButton1.ImageOffsetX = -5
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(379, 665)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Crimson
        Me.GunaGradientButton1.Radius = 5
        Me.GunaGradientButton1.Size = New System.Drawing.Size(224, 60)
        Me.GunaGradientButton1.TabIndex = 35
        Me.GunaGradientButton1.Text = "Gönder"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.Animated = True
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 10.0!
        Me.GunaAdvenceButton4.AnimationSpeed = 10.0!
        Me.GunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_321
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.icons8_plus_96px
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(42, 42)
        Me.GunaAdvenceButton4.LineBottom = 3
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(228, 665)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Radius = 8
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(145, 60)
        Me.GunaAdvenceButton4.TabIndex = 36
        Me.GunaAdvenceButton4.Text = "Yeni Sorgu"
        '
        'GunaAdvenceButton5
        '
        Me.GunaAdvenceButton5.Animated = True
        Me.GunaAdvenceButton5.AnimationHoverSpeed = 10.0!
        Me.GunaAdvenceButton5.AnimationSpeed = 10.0!
        Me.GunaAdvenceButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton5.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton5.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_321
        Me.GunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton5.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.help_gradient_32
        Me.GunaAdvenceButton5.ImageSize = New System.Drawing.Size(42, 42)
        Me.GunaAdvenceButton5.LineBottom = 3
        Me.GunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaAdvenceButton5.Location = New System.Drawing.Point(612, 592)
        Me.GunaAdvenceButton5.Name = "GunaAdvenceButton5"
        Me.GunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.OnHoverImage = Nothing
        Me.GunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.Radius = 8
        Me.GunaAdvenceButton5.Size = New System.Drawing.Size(63, 55)
        Me.GunaAdvenceButton5.TabIndex = 34
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaTextBox1.Location = New System.Drawing.Point(228, 592)
        Me.GunaTextBox1.MaxLength = 15
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Radius = 5
        Me.GunaTextBox1.Size = New System.Drawing.Size(375, 55)
        Me.GunaTextBox1.TabIndex = 33
        Me.GunaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(16, 607)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(206, 25)
        Me.GunaLabel4.TabIndex = 32
        Me.GunaLabel4.Text = "Telefon Numarası ->"
        '
        'Gonderim_Paneli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.Controls.Add(Me.GunaAdvenceButton4)
        Me.Controls.Add(Me.GunaAdvenceButton5)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.h1)
        Me.Controls.Add(Me.NewSMS)
        Me.Controls.Add(Me.SendReq)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.mesaj)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.numtext)
        Me.Controls.Add(Me.teltext)
        Me.Name = "Gonderim_Paneli"
        Me.Size = New System.Drawing.Size(710, 1035)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents teltext As Guna.UI.WinForms.GunaLabel
    Friend WithEvents numtext As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents c_eng As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents c_engflash As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents c_tr As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents c_trflash As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents mesaj As RichTextBox
    Friend WithEvents SendReq As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents NewSMS As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents h1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton5 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
End Class
