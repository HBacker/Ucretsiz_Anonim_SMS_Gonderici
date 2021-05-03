Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports System.ComponentModel

Public Class Kullanıcı_Arayüz
    Shared random As New Random()
    Dim version_app As String = "3.0.0"
    Dim version_ui As String = "4.0.0"
    Dim nv1 As String
    Dim nv2 As String
    Dim nv3 As String
    Dim nv4 As String
    Dim nV As String
    Dim ip_data As String = "#bekleniyor#"
    Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
    Dim veritabanı2 As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")

    Dim okuyucu As MySqlDataReader
    Dim komut As New MySqlCommand
    Dim okuyucu2 As MySqlDataReader
    Dim komut2 As New MySqlCommand

    Dim veritabanı3 As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")

    Dim okuyucu3 As MySqlDataReader
    Dim komut3 As New MySqlCommand

    Dim veritabanıban As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")

    Dim okuyucuban As MySqlDataReader
    Dim komutban As New MySqlCommand
    Private Sub Kullanıcı_Arayüz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vui.Text = "v" + version_ui.ToString
        vapp.Text = "v" + version_app.ToString
        nVerifer()
        ip_data_cek()
    End Sub
    Public Function vRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(1, 9)
    End Function
    Public Function vRandom2(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(4, 8)
    End Function
    Public Function vRandom3(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(1, 7)
    End Function
    Public Function vRandom4(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(0, 5)
    End Function
    Sub nVerifer()
        nv1 = vRandom(1, 9)
        nv2 = vRandom2(2, 8)
        nv3 = vRandom3(3, 9)
        nv4 = vRandom4(0, 5)
        n1.Text = nv1.ToString
        n2.Text = nv2.ToString
        n3.Text = nv3.ToString
        n4.Text = nv4.ToString
        nV = nv1 + nv2 + nv3 + nv4

    End Sub
    Sub hata_ban()
        block.Visible = True
        error_name.Text = "Erişim / BAN Sorunu"
        error_desc.Text = "Üzgünüz, Panele Erişiminiz yok! 
BANlanmış olabilirsiniz."
    End Sub
    'BEGIN of Section Giriş

    Sub user_login()
        Dim zaman As String = System.DateTime.Now

        Try
            veritabanı.Open() 'bağlantı start

            komut.Connection = veritabanı

            komut.CommandText = "SELECT nick, pwd FROM kullanıcılar WHERE nick = '" & uname.Text & "' AND pwd = '" & pw.Text & "'"

            okuyucu = komut.ExecuteReader




            Try
                veritabanıban.Open() 'bağlantı start

                komutban.Connection = veritabanıban

                komutban.CommandText = "SELECT nick, izin FROM kullanıcılar WHERE nick = '" & uname.Text & "' AND izin = '" & "ban" & "'"

                okuyucuban = komutban.ExecuteReader
                If okuyucuban.HasRows Then
                    hata_ban()
                    iletisim.vkonu.Items.Add("Erişim / BAN Sorunu")
                    Panel.Close()
                    iletisim.Show()
                    iletisim.vkonu.SelectedItem = "Erişim / BAN Sorunu"
                Else
                    If okuyucu.HasRows Then
                        Panel.username.Text = uname.Text
                        Me.Hide()
                        Panel.Show()
                        pw.Text = ""
                        nVerifer()

                        Try
                            veritabanı2.Open()
                            komut2.Connection = veritabanı2

                            komut2.CommandText = "UPDATE kullanıcılar SET son_giriş = '" & zaman.ToString & "', son_ip = '" & ip_data.ToString & "' WHERE nick= '" & uname.Text & "'"

                            komut2.ExecuteNonQuery()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Else
                        nVerifer()
                        hata_cr()
                        pw.Text = ""
                        Try
                            veritabanı2.Open()
                            komut2.Connection = veritabanı2

                            komut2.CommandText = "UPDATE kullanıcılar SET son_fail = '" & zaman.ToString & "' WHERE nick= '" & uname.Text & "'"

                            komut2.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try


                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try




        Catch ex As Exception
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
                e_mail.Subject = "BUG / HATA # Kullanıcı_Arayüz #"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Gönderen Nick: " + "Giriş Yapılmamış / " + "'" + uname.Text + "'" + vbNewLine + "Mail: " + "Mail yok." + vbNewLine + "HATA; " + ex.Message + vbNewLine + "ip: " + ip_data.ToString + vbNewLine + "BUG Build Time: " + zaman.ToString
                Smtp_Server.Send(e_mail)
            Catch error_t As Exception

            End Try
        End Try
        veritabanı.Dispose()
        veritabanı2.Dispose()
        veritabanıban.Dispose()
        login.Enabled = True
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
        Try
            Dim reader As StreamReader = New StreamReader(data)
            ip_data = reader.ReadToEnd()
            data.Close()
            reader.Close()
            ip_data = ip_data.Replace("<html><head><title>Current IP Check</title></head><body>Current IP Address:", "").Replace("</body></html>", "").ToString()
            ip_data = ip_data.Trim
        Catch ex As Exception
            MsgBox("Program Başlatılırken bir hata oluştu. Lütfen Daha Sonra Tekrar Deneyiniz... (hata yeri: ex.1intP_drw)")
        End Try

    End Function

    Sub hata_rc()
        block.Visible = True
        error_name.Text = "reCaptcha"
        error_desc.Text = "hatalı reCaptcha kodu."
    End Sub
    Sub hata_cr()
        block.Visible = True
        error_name.Text = "Giriş Bilgileri"
        error_desc.Text = "Nick veya Şifre hatalı!"
    End Sub
    'END of Section Giriş
    Sub go_online()
        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim vcom As New MySqlCommand
        Try
            veritabanı.Open()
            vcom.Connection = veritabanı
            vcom.CommandText = "UPDATE kullanıcılar SET status= 'online' WHERE nick= '" & uname.Text & "'"
            vcom.ExecuteNonQuery()
            veritabanı.Dispose()

        Catch ex As Exception

        End Try
    End Sub
    Sub go_offline()
        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim vcom As New MySqlCommand
        Try
            veritabanı.Open()
            vcom.Connection = veritabanı
            vcom.CommandText = "UPDATE kullanıcılar SET status= 'offline' WHERE nick= '" & uname.Text & "'"
            vcom.ExecuteNonQuery()
            veritabanı.Dispose()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        login.Enabled = False

        Try
            veritabanı.Dispose()
            veritabanı2.Dispose()
            veritabanıban.Dispose()
        Catch ex As Exception

        End Try
        If kod1.Text + kod2.Text + kod3.Text + kod4.Text = nV.ToString Then
            user_login()
            go_online()

            nVerifer()
        Else
            nVerifer()
            hata_rc()
            kod1.Text = ""
            kod2.Text = ""
            kod3.Text = ""
            kod4.Text = ""
            kod1.Select()

        End If

    End Sub

    Private Sub x2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub kod1_TextChanged(sender As Object, e As EventArgs) Handles kod1.TextChanged

    End Sub

    Private Sub kod2_TextChanged(sender As Object, e As EventArgs) Handles kod2.TextChanged

    End Sub

    Private Sub kod3_TextChanged(sender As Object, e As EventArgs) Handles kod3.TextChanged

    End Sub

    Private Sub kod4_TextChanged(sender As Object, e As EventArgs) Handles kod4.TextChanged

    End Sub

    Private Sub kod1_KeyDown(sender As Object, e As KeyEventArgs) Handles kod1.KeyDown
        kod2.Text = ""
        kod2.Select()
    End Sub
    Private Sub kod2_KeyDown(sender As Object, e As KeyEventArgs) Handles kod2.KeyDown
        kod3.Text = ""
        kod3.Select()
    End Sub
    Private Sub kod3_KeyDown(sender As Object, e As KeyEventArgs) Handles kod3.KeyDown
        kod4.Text = ""
        kod4.Select()
    End Sub
    Private Sub kod4_KeyDown(sender As Object, e As KeyEventArgs) Handles kod4.KeyDown
        piyon.Text = ""
        piyon.Select()
    End Sub

    Private Sub GunaTextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaTextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaTextBox3_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub GunaTextBox2_KeyDown(sender As Object, e As KeyEventArgs)
        piyon.Text = ""
        piyon.Select()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        nVerifer()
        login.Enabled = True
        block.Visible = False

    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub yeni_uye_Click(sender As Object, e As EventArgs) Handles yeni_uye.Click
        Me.Hide()
        Kullanıcı_Kayıt.Show()
    End Sub

    Private Sub header_kapat_Click(sender As Object, e As EventArgs) Handles header_kapat.Click

        Try
            Me.Close()
            Kullanıcı_Kayıt.Close()
            Panel.Close()
            iletisim.Close()
        Catch ex As Exception
            Me.Close()
        End Try


    End Sub

    Private Sub block_box_Click(sender As Object, e As EventArgs) Handles block_box.Click

    End Sub

    Private Sub GunaLabel8_Click(sender As Object, e As EventArgs) Handles GunaLabel8.Click
        iletisim.Show()
    End Sub

    Private Sub Kullanıcı_Arayüz_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        go_offline()
    End Sub

    Private Sub Kullanıcı_Arayüz_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        go_offline()
    End Sub
End Class