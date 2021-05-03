<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Footer_Bar
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
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.footet_split = New System.Windows.Forms.Splitter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.footer_grad_credit = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.ft_credit_label = New Guna.UI.WinForms.GunaLabel()
        Me.footer_grad_status = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.footer_status_label = New Guna.UI.WinForms.GunaLabel()
        Me.log_status = New System.Windows.Forms.RichTextBox()
        Me.auth_api = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.status_controller = New System.Windows.Forms.Timer(Me.components)
        Me.footer_status = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.footer_credit = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.footer_grad_credit.SuspendLayout()
        Me.footer_grad_status.SuspendLayout()
        Me.GunaContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.footer_status)
        Me.GunaPanel1.Controls.Add(Me.Splitter2)
        Me.GunaPanel1.Controls.Add(Me.footer_credit)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(697, 39)
        Me.GunaPanel1.TabIndex = 0
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(0, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 39)
        Me.Splitter2.TabIndex = 6
        Me.Splitter2.TabStop = False
        '
        'footet_split
        '
        Me.footet_split.BackColor = System.Drawing.Color.Blue
        Me.footet_split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.footet_split.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.footet_split.Location = New System.Drawing.Point(0, 39)
        Me.footet_split.Name = "footet_split"
        Me.footet_split.Size = New System.Drawing.Size(3, 118)
        Me.footet_split.TabIndex = 1
        Me.footet_split.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.footer_grad_credit)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Panel1MinSize = 170
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.footer_grad_status)
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SplitContainer1.Panel2MinSize = 490
        Me.SplitContainer1.Size = New System.Drawing.Size(690, 81)
        Me.SplitContainer1.SplitterDistance = 170
        Me.SplitContainer1.SplitterIncrement = 3
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 2
        '
        'footer_grad_credit
        '
        Me.footer_grad_credit.BackColor = System.Drawing.Color.Transparent
        Me.footer_grad_credit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.footer_grad_credit.Controls.Add(Me.ft_credit_label)
        Me.footer_grad_credit.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.footer_grad_credit.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.footer_grad_credit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.footer_grad_credit.Location = New System.Drawing.Point(5, 2)
        Me.footer_grad_credit.Name = "footer_grad_credit"
        Me.footer_grad_credit.Size = New System.Drawing.Size(167, 71)
        Me.footer_grad_credit.TabIndex = 0
        '
        'ft_credit_label
        '
        Me.ft_credit_label.AutoSize = True
        Me.ft_credit_label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ft_credit_label.ForeColor = System.Drawing.Color.AliceBlue
        Me.ft_credit_label.Location = New System.Drawing.Point(4, 11)
        Me.ft_credit_label.Name = "ft_credit_label"
        Me.ft_credit_label.Size = New System.Drawing.Size(152, 48)
        Me.ft_credit_label.TabIndex = 1
        Me.ft_credit_label.Text = "Üzgünüz! Bu Operatör" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Kredi Sorgulamayı" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Desteklemiyor"
        Me.ft_credit_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'footer_grad_status
        '
        Me.footer_grad_status.BackColor = System.Drawing.Color.Transparent
        Me.footer_grad_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.footer_grad_status.Controls.Add(Me.footer_status_label)
        Me.footer_grad_status.Controls.Add(Me.log_status)
        Me.footer_grad_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.footer_grad_status.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.footer_grad_status.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.footer_grad_status.Location = New System.Drawing.Point(3, 6)
        Me.footer_grad_status.Name = "footer_grad_status"
        Me.footer_grad_status.Size = New System.Drawing.Size(502, 70)
        Me.footer_grad_status.TabIndex = 1
        '
        'footer_status_label
        '
        Me.footer_status_label.AutoSize = True
        Me.footer_status_label.BackColor = System.Drawing.Color.Black
        Me.footer_status_label.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.footer_status_label.ForeColor = System.Drawing.Color.White
        Me.footer_status_label.Location = New System.Drawing.Point(3, 52)
        Me.footer_status_label.Name = "footer_status_label"
        Me.footer_status_label.Size = New System.Drawing.Size(91, 15)
        Me.footer_status_label.TabIndex = 2
        Me.footer_status_label.Text = "SMS Bekleniyor."
        '
        'log_status
        '
        Me.log_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.log_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.log_status.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.log_status.ForeColor = System.Drawing.Color.SpringGreen
        Me.log_status.Location = New System.Drawing.Point(3, 3)
        Me.log_status.Name = "log_status"
        Me.log_status.Size = New System.Drawing.Size(494, 46)
        Me.log_status.TabIndex = 2
        Me.log_status.Text = ""
        '
        'auth_api
        '
        Me.auth_api.BackColor = System.Drawing.Color.Transparent
        Me.auth_api.BaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.auth_api.BorderColor = System.Drawing.Color.MidnightBlue
        Me.auth_api.BorderSize = 1
        Me.auth_api.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.auth_api.FocusedBaseColor = System.Drawing.Color.White
        Me.auth_api.FocusedBorderColor = System.Drawing.Color.Crimson
        Me.auth_api.FocusedForeColor = System.Drawing.Color.MidnightBlue
        Me.auth_api.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.auth_api.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.auth_api.Location = New System.Drawing.Point(9, 122)
        Me.auth_api.Name = "auth_api"
        Me.auth_api.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.auth_api.Radius = 3
        Me.auth_api.Size = New System.Drawing.Size(680, 30)
        Me.auth_api.TabIndex = 2
        Me.auth_api.Text = "$oauth_api"
        Me.auth_api.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.GunaContextMenuStrip1.Name = "GunaContextMenuStrip1"
        Me.GunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.GunaContextMenuStrip1.Size = New System.Drawing.Size(78, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem2.Text = ","
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.AliceBlue
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 130)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(75, 13)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Kullanımda:"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'status_controller
        '
        Me.status_controller.Enabled = True
        Me.status_controller.Interval = 1000
        '
        'footer_status
        '
        Me.footer_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.footer_status.Animated = True
        Me.footer_status.AnimationHoverSpeed = 0.07!
        Me.footer_status.AnimationSpeed = 0.03!
        Me.footer_status.BackColor = System.Drawing.Color.Transparent
        Me.footer_status.BaseColor = System.Drawing.Color.Transparent
        Me.footer_status.BorderColor = System.Drawing.Color.Black
        Me.footer_status.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.footer_status.CheckedBorderColor = System.Drawing.Color.Black
        Me.footer_status.CheckedForeColor = System.Drawing.Color.White
        Me.footer_status.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.icons8_hashtag_100px
        Me.footer_status.CheckedLineColor = System.Drawing.Color.SpringGreen
        Me.footer_status.FocusedColor = System.Drawing.Color.Empty
        Me.footer_status.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.footer_status.ForeColor = System.Drawing.Color.White
        Me.footer_status.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.icons8_hashtag_100px
        Me.footer_status.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.footer_status.ImageSize = New System.Drawing.Size(35, 35)
        Me.footer_status.LineBottom = 3
        Me.footer_status.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.footer_status.Location = New System.Drawing.Point(185, 1)
        Me.footer_status.Name = "footer_status"
        Me.footer_status.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.footer_status.OnHoverBorderColor = System.Drawing.Color.Black
        Me.footer_status.OnHoverForeColor = System.Drawing.Color.White
        Me.footer_status.OnHoverImage = Nothing
        Me.footer_status.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.footer_status.OnPressedColor = System.Drawing.Color.Black
        Me.footer_status.Radius = 5
        Me.footer_status.Size = New System.Drawing.Size(505, 36)
        Me.footer_status.TabIndex = 2
        Me.footer_status.Text = "Durum"
        Me.footer_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'footer_credit
        '
        Me.footer_credit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.footer_credit.Animated = True
        Me.footer_credit.AnimationHoverSpeed = 0.07!
        Me.footer_credit.AnimationSpeed = 0.03!
        Me.footer_credit.BackColor = System.Drawing.Color.Transparent
        Me.footer_credit.BaseColor = System.Drawing.Color.Transparent
        Me.footer_credit.BorderColor = System.Drawing.Color.Black
        Me.footer_credit.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.footer_credit.CheckedBorderColor = System.Drawing.Color.Black
        Me.footer_credit.CheckedForeColor = System.Drawing.Color.White
        Me.footer_credit.CheckedImage = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.icons8_us_dollar_100px
        Me.footer_credit.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.footer_credit.FocusedColor = System.Drawing.Color.Empty
        Me.footer_credit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.footer_credit.ForeColor = System.Drawing.Color.White
        Me.footer_credit.Image = Global.THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.My.Resources.Resources.icons8_us_dollar_100px
        Me.footer_credit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.footer_credit.ImageSize = New System.Drawing.Size(27, 27)
        Me.footer_credit.LineBottom = 3
        Me.footer_credit.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.footer_credit.Location = New System.Drawing.Point(7, 3)
        Me.footer_credit.Name = "footer_credit"
        Me.footer_credit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.footer_credit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.footer_credit.OnHoverForeColor = System.Drawing.Color.White
        Me.footer_credit.OnHoverImage = Nothing
        Me.footer_credit.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.footer_credit.OnPressedColor = System.Drawing.Color.Black
        Me.footer_credit.Radius = 5
        Me.footer_credit.Size = New System.Drawing.Size(163, 33)
        Me.footer_credit.TabIndex = 1
        Me.footer_credit.Text = "Kredi"
        Me.footer_credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Footer_Bar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.auth_api)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.footet_split)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "Footer_Bar"
        Me.Size = New System.Drawing.Size(697, 157)
        Me.GunaPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.footer_grad_credit.ResumeLayout(False)
        Me.footer_grad_credit.PerformLayout()
        Me.footer_grad_status.ResumeLayout(False)
        Me.footer_grad_status.PerformLayout()
        Me.GunaContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents footer_credit As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents footer_status As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents footet_split As Splitter
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents footer_grad_credit As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents ft_credit_label As Guna.UI.WinForms.GunaLabel
    Friend WithEvents footer_grad_status As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents auth_api As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents log_status As RichTextBox
    Friend WithEvents footer_status_label As Guna.UI.WinForms.GunaLabel
    Friend WithEvents status_controller As Timer
End Class
