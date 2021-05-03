<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Api_List
    Inherits System.Windows.Forms.UserControl

    'UserControl, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Api_List))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.panel_api_list = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.tht_1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.header_kapat = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.update_list = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.w_list = New Guna.UI.WinForms.GunaRadioButton()
        Me.thtusers_list = New Guna.UI.WinForms.GunaRadioButton()
        Me.hbacker_list = New Guna.UI.WinForms.GunaRadioButton()
        Me.api_options = New Guna.UI.WinForms.GunaGradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_api_list.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Items.AddRange(New Object() {"API389236204787"})
        Me.ListBox1.Location = New System.Drawing.Point(20, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(235, 427)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ListBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 25
        Me.ListBox2.Items.AddRange(New Object() {"API389236204787"})
        Me.ListBox2.Location = New System.Drawing.Point(261, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(235, 427)
        Me.ListBox2.TabIndex = 2
        '
        'panel_api_list
        '
        Me.panel_api_list.BackgroundImage = CType(resources.GetObject("panel_api_list.BackgroundImage"), System.Drawing.Image)
        Me.panel_api_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_api_list.Controls.Add(Me.GunaLabel4)
        Me.panel_api_list.Controls.Add(Me.GunaLabel3)
        Me.panel_api_list.Controls.Add(Me.tht_1)
        Me.panel_api_list.Controls.Add(Me.GunaLabel2)
        Me.panel_api_list.Controls.Add(Me.header_kapat)
        Me.panel_api_list.Controls.Add(Me.GunaLabel1)
        Me.panel_api_list.Controls.Add(Me.update_list)
        Me.panel_api_list.Controls.Add(Me.GunaGroupBox1)
        Me.panel_api_list.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panel_api_list.GradientColor2 = System.Drawing.Color.Black
        Me.panel_api_list.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.panel_api_list.GradientColor4 = System.Drawing.Color.Black
        Me.panel_api_list.Location = New System.Drawing.Point(133, 125)
        Me.panel_api_list.Name = "panel_api_list"
        Me.panel_api_list.Size = New System.Drawing.Size(473, 226)
        Me.panel_api_list.TabIndex = 7
        Me.panel_api_list.Text = "Panel API List"
        Me.panel_api_list.Visible = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(372, 199)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(102, 13)
        Me.GunaLabel4.TabIndex = 11
        Me.GunaLabel4.Text = "TurkHackTeam.org"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(436, 131)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(32, 40)
        Me.GunaLabel3.TabIndex = 10
        Me.GunaLabel3.Text = "T"
        '
        'tht_1
        '
        Me.tht_1.AutoSize = True
        Me.tht_1.BackColor = System.Drawing.Color.Transparent
        Me.tht_1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tht_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tht_1.Location = New System.Drawing.Point(436, 61)
        Me.tht_1.Name = "tht_1"
        Me.tht_1.Size = New System.Drawing.Size(32, 40)
        Me.tht_1.TabIndex = 8
        Me.tht_1.Text = "T"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(432, 93)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(38, 40)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "H"
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
        Me.header_kapat.Location = New System.Drawing.Point(431, 12)
        Me.header_kapat.Name = "header_kapat"
        Me.header_kapat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.header_kapat.OnHoverBaseColor2 = System.Drawing.Color.Crimson
        Me.header_kapat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.header_kapat.OnHoverForeColor = System.Drawing.Color.White
        Me.header_kapat.OnHoverImage = Nothing
        Me.header_kapat.OnPressedColor = System.Drawing.Color.Black
        Me.header_kapat.Radius = 6
        Me.header_kapat.Size = New System.Drawing.Size(39, 31)
        Me.header_kapat.TabIndex = 5
        Me.header_kapat.Text = "X"
        Me.header_kapat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel1.Location = New System.Drawing.Point(20, 194)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(204, 18)
        Me.GunaLabel1.TabIndex = 7
        Me.GunaLabel1.Text = "API Listesini Güncelleme Sıklığı;"
        '
        'update_list
        '
        Me.update_list.BackColor = System.Drawing.Color.Transparent
        Me.update_list.BaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.update_list.BorderColor = System.Drawing.Color.Crimson
        Me.update_list.BorderSize = 1
        Me.update_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.update_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.update_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_list.FocusedColor = System.Drawing.Color.Empty
        Me.update_list.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.update_list.ForeColor = System.Drawing.Color.White
        Me.update_list.FormattingEnabled = True
        Me.update_list.Items.AddRange(New Object() {"5 Dakika", "10 Dakika", "15 Dakika"})
        Me.update_list.Location = New System.Drawing.Point(230, 192)
        Me.update_list.Name = "update_list"
        Me.update_list.OnHoverItemBaseColor = System.Drawing.Color.RoyalBlue
        Me.update_list.OnHoverItemForeColor = System.Drawing.Color.White
        Me.update_list.Radius = 3
        Me.update_list.Size = New System.Drawing.Size(139, 26)
        Me.update_list.TabIndex = 6
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.MidnightBlue
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.w_list)
        Me.GunaGroupBox1.Controls.Add(Me.thtusers_list)
        Me.GunaGroupBox1.Controls.Add(Me.hbacker_list)
        Me.GunaGroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.RoyalBlue
        Me.GunaGroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(412, 176)
        Me.GunaGroupBox1.TabIndex = 1
        Me.GunaGroupBox1.Text = "API Kaynağını Seçiniz..."
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel6.Location = New System.Drawing.Point(299, 7)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(110, 13)
        Me.GunaLabel6.TabIndex = 13
        Me.GunaLabel6.Text = "HBackeR.unaux.com"
        '
        'w_list
        '
        Me.w_list.BaseColor = System.Drawing.SystemColors.Control
        Me.w_list.CheckedOffColor = System.Drawing.Color.Gray
        Me.w_list.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.w_list.FillColor = System.Drawing.Color.White
        Me.w_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.w_list.Location = New System.Drawing.Point(63, 119)
        Me.w_list.Name = "w_list"
        Me.w_list.Size = New System.Drawing.Size(310, 28)
        Me.w_list.TabIndex = 2
        Me.w_list.Text = "Kendi API'mi Kullanacağım..."
        '
        'thtusers_list
        '
        Me.thtusers_list.BaseColor = System.Drawing.SystemColors.Control
        Me.thtusers_list.CheckedOffColor = System.Drawing.Color.Gray
        Me.thtusers_list.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.thtusers_list.FillColor = System.Drawing.Color.White
        Me.thtusers_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.thtusers_list.Location = New System.Drawing.Point(10, 80)
        Me.thtusers_list.Name = "thtusers_list"
        Me.thtusers_list.Size = New System.Drawing.Size(437, 28)
        Me.thtusers_list.TabIndex = 1
        Me.thtusers_list.Text = "THT Üyeleri Tarafından Eklenenleri Kullan"
        '
        'hbacker_list
        '
        Me.hbacker_list.BaseColor = System.Drawing.SystemColors.Control
        Me.hbacker_list.CheckedOffColor = System.Drawing.Color.Gray
        Me.hbacker_list.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.hbacker_list.FillColor = System.Drawing.Color.White
        Me.hbacker_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.hbacker_list.Location = New System.Drawing.Point(10, 41)
        Me.hbacker_list.Name = "hbacker_list"
        Me.hbacker_list.Size = New System.Drawing.Size(383, 28)
        Me.hbacker_list.TabIndex = 0
        Me.hbacker_list.Text = "Admin Tarafından Eklenenleri Kullan"
        '
        'api_options
        '
        Me.api_options.Animated = True
        Me.api_options.AnimationHoverSpeed = 10.0!
        Me.api_options.AnimationSpeed = 10.0!
        Me.api_options.BackColor = System.Drawing.Color.Transparent
        Me.api_options.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.api_options.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.api_options.BorderColor = System.Drawing.Color.Black
        Me.api_options.FocusedColor = System.Drawing.Color.Empty
        Me.api_options.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.api_options.ForeColor = System.Drawing.Color.White
        Me.api_options.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.api_options.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.settings_96px
        Me.api_options.ImageSize = New System.Drawing.Size(36, 36)
        Me.api_options.Location = New System.Drawing.Point(502, 388)
        Me.api_options.Name = "api_options"
        Me.api_options.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.api_options.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.api_options.OnHoverBorderColor = System.Drawing.Color.Black
        Me.api_options.OnHoverForeColor = System.Drawing.Color.White
        Me.api_options.OnHoverImage = Nothing
        Me.api_options.OnPressedColor = System.Drawing.Color.Black
        Me.api_options.Radius = 5
        Me.api_options.Size = New System.Drawing.Size(200, 64)
        Me.api_options.TabIndex = 6
        Me.api_options.Text = "           API Tercihlerini Görüntüle"
        Me.api_options.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PictureBox1.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.api
        Me.PictureBox1.Location = New System.Drawing.Point(502, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 350)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Api_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Controls.Add(Me.panel_api_list)
        Me.Controls.Add(Me.api_options)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Api_List"
        Me.Size = New System.Drawing.Size(710, 471)
        Me.panel_api_list.ResumeLayout(False)
        Me.panel_api_list.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents api_options As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents panel_api_list As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents w_list As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents thtusers_list As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents hbacker_list As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents header_kapat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tht_1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents update_list As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
End Class
