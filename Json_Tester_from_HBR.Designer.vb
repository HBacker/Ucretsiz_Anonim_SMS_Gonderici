<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Json_Tester_from_HBR
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
        Me.raw = New System.Windows.Forms.RichTextBox()
        Me.response = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.son = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exer = New System.Windows.Forms.RichTextBox()
        Me.data = New System.Windows.Forms.TextBox()
        Me.FlatButton2 = New THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.FlatButton()
        Me.FlatButton1 = New THT_Ücretsiz_Anonim_SMS_Gönderici_____HBackeR____.FlatButton()
        Me.SuspendLayout()
        '
        'raw
        '
        Me.raw.Location = New System.Drawing.Point(8, 17)
        Me.raw.Name = "raw"
        Me.raw.Size = New System.Drawing.Size(327, 112)
        Me.raw.TabIndex = 1
        Me.raw.Text = "{""data"": {""balance"": ""0.2000"", ""sms_count"": ""ND""}}"
        '
        'response
        '
        Me.response.Location = New System.Drawing.Point(8, 148)
        Me.response.Name = "response"
        Me.response.Size = New System.Drawing.Size(327, 153)
        Me.response.TabIndex = 2
        Me.response.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RAW"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Reponse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Result"
        '
        'son
        '
        Me.son.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.son.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.son.Location = New System.Drawing.Point(341, 148)
        Me.son.Name = "son"
        Me.son.Size = New System.Drawing.Size(327, 156)
        Me.son.TabIndex = 5
        Me.son.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, -23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sub String"
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(341, 17)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(327, 112)
        Me.result.TabIndex = 7
        Me.result.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(482, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Output"
        '
        'exer
        '
        Me.exer.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.exer.ForeColor = System.Drawing.Color.White
        Me.exer.Location = New System.Drawing.Point(8, 341)
        Me.exer.Name = "exer"
        Me.exer.Size = New System.Drawing.Size(656, 106)
        Me.exer.TabIndex = 11
        Me.exer.Text = ""
        Me.exer.ZoomFactor = 2.5!
        '
        'data
        '
        Me.data.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.data.Location = New System.Drawing.Point(8, 307)
        Me.data.Multiline = True
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(331, 28)
        Me.data.TabIndex = 12
        Me.data.Text = "carrier_name"
        Me.data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.MidnightBlue
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(527, 308)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(141, 29)
        Me.FlatButton2.TabIndex = 13
        Me.FlatButton2.Text = "DataBase"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(345, 307)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(176, 29)
        Me.FlatButton1.TabIndex = 9
        Me.FlatButton1.Text = "start"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Json_Tester_from_HBR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(680, 452)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.exer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.son)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.response)
        Me.Controls.Add(Me.raw)
        Me.Name = "Json_Tester_from_HBR"
        Me.Text = "Json_Tester_from_HBR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents raw As RichTextBox
    Friend WithEvents response As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents son As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents result As RichTextBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents Label5 As Label
    Friend WithEvents exer As RichTextBox
    Friend WithEvents data As TextBox
    Friend WithEvents FlatButton2 As FlatButton
End Class
