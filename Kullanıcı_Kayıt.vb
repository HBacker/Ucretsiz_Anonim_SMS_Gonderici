Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Kullanıcı_Kayıt
    Shared random As New Random()
    Dim version_app As String = "3.0.0"
    Dim version_ui As String = "4.0.0"
    Dim nv1 As String
    Dim nv2 As String
    Dim nv3 As String
    Dim zaman As String
    Dim nv4 As String
    Dim nV As String
    Dim identity As String
    Dim ip_data As String
    Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
    Dim komut As New MySqlCommand
    Dim okuyucu As MySqlDataReader

    Dim veritabanı2 As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
    Dim komut2 As New MySqlCommand
    Dim okuyucu2 As MySqlDataReader

    Dim veritabanı3 As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
    Dim komut3 As New MySqlCommand
    Dim okuyucu3 As MySqlDataReader
    Public Function idverify() As String
        Dim DriveSerial As Integer
        'Create a FileSystemObject object
        Dim fso As Object = CreateObject("Scripting.FileSystemObject")
        Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        'çıktı
        identity = DriveSerial.ToString
        Return DriveSerial.ToString("X2")

    End Function
    Sub hata_rc()
        block.Visible = True
        error_name.Text = "reCaptcha"
        error_desc.Text = "hatalı reCaptcha kodu."
    End Sub
    Sub hata_cr()
        block.Visible = True
        error_name.Text = "Kayıt Bilgileri"
        error_desc.Text = "Üzgünüz, bu mail adresine 
veya nick'e sahip bir kullanıcı
 zaten mevcut.
"
    End Sub
    Sub hata_empty()
        block.Visible = True
        error_name.Text = "Eksik veya Hatalı Kayıt Bilgileri"
        error_desc.Text = "Eksik veya hatalı bilgiler."
    End Sub
    Sub success()

    End Sub

    Sub kayıt_ol()


        nVerifer()
        If username.Text = "" Or password.Text = "" Or email.Text = "" Then
            hata_empty()
        Else
            If password.Text.Contains(" ") Then
                password.Text.Replace(" ", "")
            Else

            End If
            If email.Text.Contains(" ") Then
                email.Text.Replace(" ", "")
            Else

            End If

            'sORGU
            Try
                veritabanı2.Open()
                veritabanı3.Open()
                veritabanı.Open()

                komut.Connection = veritabanı
                komut2.Connection = veritabanı2
                komut3.Connection = veritabanı3




                komut2.CommandText = "SELECT nick FROM kullanıcılar WHERE nick = '" & username.Text & "'"
                komut2.ExecuteNonQuery()
                okuyucu2 = komut2.ExecuteReader
                komut3.CommandText = "SELECT mail FROM kullanıcılar WHERE mail = '" & email.Text & "'"
                komut3.ExecuteNonQuery()

                okuyucu3 = komut3.ExecuteReader

                If okuyucu2.HasRows Then
                    hata_cr()
                Else
                    If okuyucu3.HasRows Then
                        hata_cr()
                    Else
                        Try




                            komut.CommandText = "INSERT INTO kullanıcılar (nick,mail,pwd,ek,kayıt_tarihi,kayıt_ip,izin,son_giriş,son_ip,son_fail,identity) VALUES ('" & username.Text & "','" & email.Text & "','" & password.Text & "','" & "null" & "','" & zaman.ToString & "','" & ip_data.ToString & "','" & "null" & "', '" & zaman.ToString & "', '" & ip_data.ToString & "', '" & "yok" & "', '" & identity.ToString & "')"
                            komut.ExecuteNonQuery()
                            register.Enabled = False
                            register.Text = "Tamamlandı!"
                            register.Image = My.Resources.approval_96px
                            giris_yap.LineColor = Color.SpringGreen
                            wc1.Start()
                        Catch ex_mailer As Exception

                            MsgBox("Oops! kayıt sırasında bir hata oluştu, lütfen daha sonra tekrar deneyiniz. 'HATA Yöneticiye bildirilmiştir. en yakın zamanda düzeltilecektir.'")
                            register.Enabled = True
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
                                e_mail.Subject = "BUG / HATA # Kullanıcı_Kayıt #"
                                e_mail.IsBodyHtml = False
                                e_mail.Body = "Gönderen Nick: " + "Kayıt Olunmamış / " + "'" + username.Text + "'" + vbNewLine + "Mail: " + email.Text + vbNewLine + "HATA; " + ex_mailer.Message + vbNewLine + "ip: " + ip_data.ToString + vbNewLine + "Exception yeri:" + "Ex Mailer" + vbNewLine + "BUG Build Time: " + zaman.ToString
                                Smtp_Server.Send(e_mail)
                            Catch error_t As Exception
                                register.Enabled = True
                            End Try


                        End Try
                    End If


                End If

            Catch ex_sql As Exception
                MsgBox("Oops! kayıt sırasında bir hata oluştu, lütfen daha sonra tekrar deneyiniz. 'HATA Yöneticiye bildirilmiştir. en yakın zamanda düzeltilecektir.'")
                register.Enabled = True
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
                    e_mail.Subject = "BUG / HATA # Kullanıcı_Kayıt #"
                    e_mail.IsBodyHtml = False
                    e_mail.Body = "Gönderen Nick: " + "Kayıt Olunmamış / " + "'" + username.Text + "'" + vbNewLine + "Mail: " + email.Text + vbNewLine + "HATA; " + ex_sql.Message + vbNewLine + "ip: " + ip_data.ToString + vbNewLine + "Exception yeri:" + "Ex Sql" + vbNewLine + "BUG Build Time: " + zaman.ToString
                    Smtp_Server.Send(e_mail)
                Catch error_t As Exception
                    register.Enabled = True

                End Try
            End Try
        End If

        veritabanı.Dispose()
        veritabanı2.Dispose()
        veritabanı3.Dispose()
        username.Enabled = True
        email.Enabled = True
        password.Enabled = True

    End Sub
    Private Sub login_Click(sender As Object, e As EventArgs) Handles register.Click
        Try
            Dim vt As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
            Dim com As New MySqlCommand
            Dim dr As MySqlDataReader

            vt.Open()
            com.Connection = vt
            com.CommandText = "SELECT identity FROM kullanıcılar WHERE identity= '" & identity.ToString & "'"
            com.ExecuteNonQuery()
            dr = com.ExecuteReader

            If dr.HasRows Then
                block.Visible = True
                error_name.Text = "Ek Üyelik"
                error_desc.Text = "Üzgünüz, Aynı PC üzerinden
2 hesap ile kayıt olamazsınız.
(Daha önce kayıt olunmuş.)"
                vt.Dispose()
            Else

                veritabanı.Dispose()
                veritabanı2.Dispose()
                veritabanı3.Dispose()

                If kod1.Text + kod2.Text + kod3.Text + kod4.Text = nV.ToString Then
                    register.Enabled = False
                    username.Enabled = False
                    email.Enabled = False
                    password.Enabled = False
                    kayıt_ol()

                Else
                    nVerifer()
                    hata_rc()
                End If
            End If

        Catch ex As Exception
            block.Visible = True
            error_name.Text = "Yürütme Hatası"
            error_desc.Text = "Oops, Komutlar Yürütülürken
bir HATA Meydana geldi.
(hata yeri: ex.reg_clhw)"

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

    Private Sub giris_yap_Click(sender As Object, e As EventArgs) Handles giris_yap.Click
        nVerifer()
        Me.Close()
        Kullanıcı_Arayüz.Show()
    End Sub

    Private Sub Kullanıcı_Kayıt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nVerifer()
        idverify()
        ip_data_cek()
    End Sub
    Public Function vRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(2, 8)
    End Function
    Public Function vRandom2(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(1, 6)
    End Function
    Public Function vRandom3(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(3, 9)
    End Function
    Public Function vRandom4(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(1, 5)
    End Function
    Sub nVerifer()
        nv1 = vRandom(2, 8)
        nv2 = vRandom2(1, 6)
        nv3 = vRandom3(3, 9)
        nv4 = vRandom4(1, 5)
        n1.Text = nv1.ToString
        n2.Text = nv2.ToString
        n3.Text = nv3.ToString
        n4.Text = nv4.ToString
        nV = nv1 + nv2 + nv3 + nv4

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

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        nVerifer()
        password.Text = ""
        block.Visible = False
    End Sub

    Private Sub w3_Tick(sender As Object, e As EventArgs) Handles wc1.Tick
        giris_yap.LineColor = Color.RoyalBlue
        wc2.Start()
        wc1.Stop()
    End Sub


    Private Sub block_Paint(sender As Object, e As PaintEventArgs) Handles block.Paint

    End Sub

    Private Sub wc2_Tick(sender As Object, e As EventArgs) Handles wc2.Tick
        giris_yap.LineColor = Color.SpringGreen
        wc1.Start()
        wc2.Stop()
    End Sub

    Private Sub header_kapat_Click(sender As Object, e As EventArgs) Handles header_kapat.Click
        Me.Close()
        Kullanıcı_Arayüz.Show()
    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        zaman = DateAndTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        Kullanıcı_Arayüz.Show()
        Me.Close()

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click

    End Sub

    Private Sub GunaLabel8_Click(sender As Object, e As EventArgs) Handles GunaLabel8.Click
        iletisim.Show()
    End Sub
End Class