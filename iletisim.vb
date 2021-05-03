Imports System.Net
Imports System.IO
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class iletisim
    Dim ip_data As String
    Private Sub Iletisim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        footer_kapat()
        ip_data_cek()

    End Sub
    Sub sql_bağlantı()
        Try
            Dim conn As New MySqlConnection("server=37.59.55.185;userid=5ppHi53t5f;password=1in5T7VSrK;database=5ppHi53t5f;port=;SslMode=None;charset=utf8;")

            conn.Open()
            MsgBox("OK!")
        Catch ex As Exception
            MsgBox("ERROR!" + vbNewLine + ex.Message)
        End Try
    End Sub
    Private Function ip_data_cek() As Net.IPAddress
        Dim client As New WebClient
        client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR1.0.3705;)")
        Dim baseurl As String = "http://checkip.dyndns.org/"
        Dim proxy As IWebProxy = WebRequest.GetSystemWebProxy()
        proxy.Credentials = CredentialCache.DefaultNetworkCredentials
        client.Proxy = proxy
        Dim data As Stream
        Try
            data = client.OpenRead(baseurl)
        Catch ex As Exception
        End Try
        Dim reader As StreamReader = New StreamReader(data)
        ip_data = reader.ReadToEnd()
        data.Close()
        reader.Close()
        ip_data = ip_data.Replace("<html><head><title>Current IP Check</title></head><body>Current IP Address:", "").Replace("</body></html>", "").ToString()
        ip_data = ip_data.Trim
    End Function
    Private Sub NewSMS_Click(sender As Object, e As EventArgs) Handles NewSMS.Click
        Sıfırla()
    End Sub
    Sub Sıfırla()
        footer_kapat()

        vnick.Text = ""
        vmail.Text = ""
        vkonu.SelectedItem = "Seçiniz..."
        vmesaj.Text = ""
        x1.Visible = False
        x2.Visible = False
    End Sub

    Private Sub SendReq_Click(sender As Object, e As EventArgs) Handles SendReq.Click
        mail_smtp()
    End Sub
    Sub mail_smtp()
        If vnick.Text = "" Or vmail.Text = "" Or vkonu.SelectedItem = "Seçiniz..." Or vmesaj.Text = "" Then
            footer_ac()
            empty_error()

        Else
            waiter.Visible = True
            SendReq.Enabled = False
            restart.Start()
            alert_box.Visible = False
            PictureBox1.Visible = True
            footer_ac()
            gonderildi()

            Try
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("destek.hbr@yandex.com", "tht.1234567hb+")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.yandex.com.tr"

                e_mail = New MailMessage()
                e_mail.From = New MailAddress("destek.hbr@yandex.com")
                e_mail.To.Add("destek.hbr@yandex.com")
                e_mail.Subject = vkonu.SelectedItem.ToString
                e_mail.IsBodyHtml = False
                e_mail.Body = "Gönderen Nick: " + vnick.Text + vbNewLine + "Kullanıcı Arayüz Nick: " + Kullanıcı_Arayüz.uname.Text + vbNewLine + "Mail: " + vmail.Text + vbNewLine + "Mesaj; " + vmesaj.Text + vbNewLine + "ip: " + ip_data.ToString + vbNewLine + "Gönderim Zamanı: " + DateAndTime.Today.ToString("dd.mm.yyyy") + "  /  " + TimeOfDay.ToString("hh:mm:ss")
                Smtp_Server.Send(e_mail)
                gonder.Start()
            Catch error_t As Exception
                gonderilemedi()
                x1.Visible = True
                x2.Visible = True
            End Try
        End If

    End Sub
    Sub footer_ac()
        Me.Width = "383"
        Me.Height = "545"
    End Sub
    Sub footer_kapat()
        Me.Width = "383"
        Me.Height = "436"
    End Sub
    Sub empty_error()
        alert_text.Visible = True
        alert_box.Visible = True
        alert_text.Text = "Boş yer bırakmayınız..."
    End Sub
    Sub gonderildi()
        alert_box.Visible = False
        alert_text.Visible = False

    End Sub
    Sub gonderilemedi()
        alert_text.Visible = True
        alert_box.Visible = True
        alert_text.Text = "Gönderim Sırasında HATA!"
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        footer_kapat()
    End Sub

    Private Sub Gonder_Tick(sender As Object, e As EventArgs) Handles gonder.Tick
        gonderildi()
        gonder.Stop()
    End Sub

    Private Sub Restart_Tick(sender As Object, e As EventArgs) Handles restart.Tick
        waiter.Visible = False
        SendReq.Enabled = True
    End Sub

    Private Sub Header_kapat_Click(sender As Object, e As EventArgs) Handles header_kapat.Click
        Me.Hide()
        Sıfırla()

    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click
        sql_bağlantı()
    End Sub

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click

    End Sub
End Class