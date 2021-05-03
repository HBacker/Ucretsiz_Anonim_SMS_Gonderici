Imports System.Collections
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.Web
Imports System.IO

Imports System.Net.Mail
Imports System.Net.Sockets
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class Panel
    Dim qad_result As String
    Dim index As Integer
    Dim cs As String
    Dim lock_s As String
    Dim gl_op As String = "hb.wait"
    Dim dresult As String
    Dim dat_api As String
    Dim baglanti As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
    Dim cmd As New MySqlCommand
    Dim rp_operator As String
    Dim responseText As String
    Dim current_mod As String = "chat"
    Dim sms_status As String
    Dim email As String = "bekliyor"
    Dim ip_data As String
    Dim nick As String = "@"
    Dim sonuc As String
    Dim wson_api As String 'irs 1
    Dim wson_kod As String 'iletim raporu sorgusu irs 2
    Dim cq As String = "0"
    Private urlToPost As String = ""
    Dim encode As String = "standart"
    Dim nV As String
    Dim nq_type As String = "format"
    Dim Charset As String = "T"
    Dim qdata As String = ""
    Dim qekdata As String = ""
    Dim identity As String
    Dim wappid As String = My.Settings.w_app_id
    Dim wappversion As String = My.Settings.w_app_version
    Dim wuiversion As String = My.Settings.w_ui_version

    Dim app_id As String = wappid.ToString
    Dim app_version As String = wappversion.ToString
    Dim ui_version As String = wuiversion.ToString
    Dim sms_report As String
    Dim zaman As String = DateTime.Now.ToString("$saat")
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idverify()


        api_op.SelectedItem = "Seçiniz..."
        nq_area.SelectedItem = "+90"
        nick = username.Text
        nq_format.Checked = True
        area.SelectedItem = "+90"


        mod_menu()
        go_online()

    End Sub
    Sub mod_menu()
        nav_menu.Checked = True
        sms_panel.Visible = False
        nav_sms.Checked = False
        api_panel.Visible = False
        nav_help.Checked = False
        nav_api.Checked = False
    End Sub
    Private Sub Header_kapat_Click(sender As Object, e As EventArgs) Handles header_kapat.Click
        Kullanıcı_Arayüz.pw.Text = ""
        Kullanıcı_Arayüz.Show()
        go_offline()


        SetPanel1.offliner.PerformClick()



        Me.Close()

    End Sub

    Private Sub Footer_Bar1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nav_sms_Click(sender As Object, e As EventArgs) Handles nav_sms.Click
        current_mod = "sms"
        mod_sms()
    End Sub

    Private Sub Nav_api_Click(sender As Object, e As EventArgs) Handles nav_api.Click
        current_mod = "api"
        mod_api()
    End Sub

    Private Sub Nav_help_Click(sender As Object, e As EventArgs) Handles nav_help.Click
        current_mod = "support"
        mod_support()
    End Sub

    Private Sub Gonderim_Paneli1_Load(sender As Object, e As EventArgs)

    End Sub
    Sub mod_api()
        nav_delivery.Checked = False
        nav_api.Checked = True
        nav_sms.Checked = False
        nav_help.Checked = False
        nav_menu.Checked = False
        sms_panel.Visible = False
        api_panel.Visible = True
        nav_query.Checked = False
        kredici.Stop()
        iletim_rapor.Visible = False
        nav_chat.Checked = False
        panel_chat.Visible = False
    End Sub
    Sub mod_sms()
        kredici.Stop()
        nav_delivery.Checked = False
        iletim_rapor.Visible = False
        sms_panel.Visible = True
        api_panel.Visible = False
        nav_sms.Checked = True
        nav_help.Checked = False
        nav_api.Checked = False
        nav_menu.Checked = False
        nav_query.Checked = False
        no_query.Visible = False

        nav_chat.Checked = False
        panel_chat.Visible = False
    End Sub
    Sub mod_chat()
        kredici.Start()
        nav_delivery.Checked = False
        iletim_rapor.Visible = False
        sms_panel.Visible = False
        api_panel.Visible = False
        nav_sms.Checked = False
        nav_help.Checked = False
        nav_api.Checked = False
        nav_menu.Checked = False
        nav_query.Checked = False
        no_query.Visible = False

        nav_chat.Checked = True
        panel_chat.Visible = True


    End Sub
    Sub mod_support()
        kredici.Start()
        nav_delivery.Checked = False
        iletim_rapor.Visible = False
        nav_help.Checked = True
        nav_sms.Checked = False
        nav_api.Checked = False
        nav_menu.Checked = False

        sms_panel.Visible = False
        api_panel.Visible = False
        nav_query.Checked = False
        no_query.Visible = False
        nav_chat.Checked = False
        panel_chat.Visible = False
    End Sub
    Sub mod_delivery()
        kredici.Stop()
        nav_delivery.Checked = True
        iletim_rapor.Visible = True
        nav_help.Checked = False
        nav_sms.Checked = False
        nav_api.Checked = False
        nav_menu.Checked = False

        sms_panel.Visible = False
        api_panel.Visible = False

        nav_query.Checked = False
        no_query.Visible = False
        nav_chat.Checked = False
        panel_chat.Visible = False
    End Sub
    Sub mod_noquery()
        kredici.Stop()
        nav_delivery.Checked = False
        iletim_rapor.Visible = False
        nav_help.Checked = False
        nav_sms.Checked = False
        nav_api.Checked = False
        nav_menu.Checked = False

        sms_panel.Visible = False
        api_panel.Visible = False
        nav_query.Checked = True
        no_query.Visible = True
        nav_chat.Checked = False
        panel_chat.Visible = False
    End Sub
    Private Sub Nav_menu_Click(sender As Object, e As EventArgs) Handles nav_menu.Click
        mod_menu()
        kredici.Start()
    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub api_panel_Load(sender As Object, e As EventArgs)

    End Sub



    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If list1.SelectedItem = "" Then
        Else
            api_sms77.Text = list1.SelectedItem.ToString
        End If

    End Sub

    Private Sub SendReq_Click(sender As Object, e As EventArgs) Handles SendReq.Click
        If number.Text = "" Or msg.Text = "" Or api_sms77.Text = "" Or api_sms77.Text = "$api" Then
            wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + " HATA!" + " >>  " + "Boş alan bırakmayınız..."
        Else
            If c_engflash.Checked = True And api_op.SelectedItem = "Direct7" Then
                box_sıfırla()
                box_ac()
                box_error_flash()


            Else
                If api_op.SelectedItem = "Direct7" Then
                    gonder_direct7()
                ElseIf api_op.SelectedItem = "SMS77" Then
                    gonder_sms77()

                Else
                    wlog.Text = "{" + zaman.ToString + "}" + " >>  " + "API Operatorü seçiniz..." + "
 "
                End If
            End If
        End If
        auto_ban_kontrol()
        wlog.SelectionStart = Len(wlog.Text)

        wlog.ScrollToCaret()

    End Sub
    Sub box_error_flash()
        box_flash_secenekler_buttons()
        error_name.Text = "Flash SMS
sadece SMS77 için Geçerlidir.

"
        error_desc.Text = "                              Direct7 Operatörü ile Flash SMS Göndermeyi denediniz. 
            fakat şu an için Flash (Pop-Up) SMS Alternatifini Sadece SMS77 Desteklemekte.

Çözüm: SMS77 Operatörünü Seçmek.

"
    End Sub

    Sub Debug()

        If teltext.Text = "" Or teltext.Text = " " Or msg.Text = "" Or msg.Text = " " Then
            wlog.Text = wlog.Text + DateTime.Now.ToString("HH:mm:ss") + "  >>  " + "Telefon veya Mesaj Boş Bırakılmamalı!"

        Else
            gb_verify.Visible = True
        End If
        wlog.SelectionStart = Len(wlog.Text)

        wlog.ScrollToCaret()
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        gb_verify.Visible = False
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click

    End Sub

    Private Sub Header_Click(sender As Object, e As EventArgs) Handles Header.Click

    End Sub
    Sub go_online()
        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim vcom As New MySqlCommand
        Try
            veritabanı.Open()
            vcom.Connection = veritabanı
            vcom.CommandText = "UPDATE kullanıcılar SET status= 'online' WHERE nick= '" & username.Text & "'"
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
            vcom.CommandText = "UPDATE kullanıcılar SET status= 'offline' WHERE nick= '" & username.Text & "'"
            vcom.ExecuteNonQuery()
            veritabanı.Dispose()

        Catch ex As Exception

        End Try
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
        Dim nv1 As String = vRandom(1, 9)
        Dim nv2 As String = vRandom2(2, 8)
        Dim nv3 As String = vRandom3(3, 9)
        Dim nv4 As String = vRandom4(0, 5)
        nV = nv1 + nv2 + nv3 + nv4
    End Sub
    Sub query_wlg()


        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim komut As New MySqlCommand
        Dim okuyucu As MySqlDataReader
        Try
            Dim zaman = DateTime.Now



            komut.Connection = veritabanı
            veritabanı.Open()
            'işlem
            komut.CommandText = "INSERT INTO query_log (nick,numara,tür,zaman,ip) VALUES ('" & username.Text & "','" & nq_area.SelectedItem.ToString + nq_numara.Text & "','" & nq_type.ToString & "','" & zaman.ToString & "','" & ip_data.TrimEnd.ToString & "')"
            komut.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        veritabanı.Dispose()
        MsgBox(username.Text + " " + nq_area.ToString + "" + zaman.ToString + " " + ip_data.TrimEnd.ToString)
    End Sub
    Sub wlg_delivery()


        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim komut As New MySqlCommand
        Dim okuyucu As MySqlDataReader
        Try
            Dim zaman = DateTime.Now



            komut.Connection = veritabanı
            veritabanı.Open()
            'işlem
            komut.CommandText = "INSERT INTO wlog_delivery (nick, message_id, api, durum, zaman, ip) VALUES ('" & username.Text & "','" & rapor_iletim.Text & "','" & rapor_api.Text & "', '" & report_label.Text & "','" & zaman.ToString & "','" & ip_data.ToString & "')"
            komut.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        veritabanı.Dispose()
    End Sub

    Sub wlg_sms()


        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim komut As New MySqlCommand
        Dim okuyucu As MySqlDataReader
        Try
            Dim zaman = DateTime.Now



            komut.Connection = veritabanı
            veritabanı.Open()
            'işlem
            komut.CommandText = "INSERT INTO wlog_sms (nick,alıcı,tür,mesaj,durum,message_id,zaman,ip) VALUES ('" & username.Text & "','" & area.Text + number.Text & "','" & encode.ToString & "', '" & msg.Text & "', '" & sms_status.ToString & "', '" & sms_report.ToString & "', '" & zaman.ToString & "','" & ip_data.ToString & "')"
            komut.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        veritabanı.Dispose()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub gonder_sms77()
        msg.Enabled = False
        number.Enabled = False
        area.Enabled = False
        c_tr.Enabled = False
        c_engflash.Enabled = False
        If number.Text = "" Or msg.Text = "" Then
            wlog.Text = vbNewLine + wlog.Text + vbNewLine + DateTime.Now.ToString("HH:mm:ss") + "Boş alan bırakmayınız..."
            wlog.SelectionStart = Len(wlog.Text)

            wlog.ScrollToCaret()

        Else
            If encode = "flash" Then
                Try
                    Dim oauthAPI = api_sms77.Text
                    Dim cxmesaj = msg.Text
                    Dim alıcılar = area.Text + number.Text
                    Dim GET_webÇıktısı As String
                    Dim gonderici = "sms77.io"
                    Dim auth_key = api_sms77.Text
                    Dim flash As String = "1"

                    Dim url As String = "https://gateway.sms77.io/api/sms"

                    GET_webÇıktısı = url + "?p=" + oauthAPI _
               + "&flash=" + flash _
                 + "&from=" + gonderici _
            + "&to=" + alıcılar _
            + "&text=" + cxmesaj + "&return_msg_id=1"

                    Dim webClient As New Net.WebClient
                    Dim writeÇıktı As String = webClient.DownloadString(GET_webÇıktısı)

                    sms_report = writeÇıktı.ToString
                    If sms_report.Contains("?100") Then
                        sms_report = sms_report.Replace("?100", "")

                        sms_report = Regex.Replace(sms_report, "^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline)
                        son_iletim.Text = sms_report.ToString
                        rapor_api.Text = sms_report.ToString
                    Else
                        sms_report = "Başarısız(iff)"
                    End If
                    sms_status = "Başarılı(f)"
                    wlg_sms()
                    wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >> " + "SMS Başarıyla İşleme alınmıştır! Gönderim Durumu sekmesinde iletim durumunu sorgulatabilirsiniz."
                    wlog.SelectionStart = Len(wlog.Text)
                    wlog.Text = wlog.Text + vbNewLine + writeÇıktı.TrimEnd.ToString
                    wlog.ScrollToCaret()
                Catch ex As Exception
                    sms_report = "Başarısız(f)"
                    wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >> " + "Sunucuyla bağlantıda bir problem meydana geldi. Lütfen tekrar veya daha sonra deneyiniz."
                    wlog.SelectionStart = Len(wlog.Text)
                    wlog.Text = wlog.Text + vbNewLine + ex.Message.ToString
                    wlog.ScrollToCaret()

                End Try
            Else
                Try
                    Dim oauthAPI = api_sms77.Text
                    Dim cxmesaj = msg.Text
                    Dim alıcılar = area.Text + number.Text
                    Dim GET_webÇıktısı As String
                    Dim gonderici = "sms77.io"
                    Dim auth_key = api_sms77.Text
                    Dim wtype As String = "direct"
                    Dim flash As String = "0"

                    Dim url As String = "https://gateway.sms77.io/api/sms"

                    GET_webÇıktısı = url + "?p=" + oauthAPI _
                        + "&to=" + alıcılar _
                         + "&text=" + cxmesaj _
                + "&type=" + wtype _
                + "&flash=" + flash _
                 + "&from=" + gonderici _
                     + "&return_msg_id=1"



                    Dim webClient As New Net.WebClient
                    Dim writeÇıktı As String = webClient.DownloadString(GET_webÇıktısı)

                    wlog.Text = writeÇıktı.ToString
                    sms_report = writeÇıktı.ToString
                    If sms_report.Contains("?100") Then
                        sms_report = sms_report.Replace("?100", "")

                        sms_report = Regex.Replace(sms_report, "^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline)
                        son_iletim.Text = sms_report.ToString
                        rapor_api.Text = sms_report.ToString
                    Else
                        sms_report = "Başarısız(iff)"
                    End If

                    sms_status = "Başarılı"


                    'gönderim durumu bilgilerini aktar


                    wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >> " + "SMS Başarıyla İşleme alınmıştır! Gönderim Durumu sekmesinde iletim durumunu sorgulatabilirsiniz."
                    wlog.Text = wlog.Text + vbNewLine + writeÇıktı.TrimEnd.ToString
                    wlog.SelectionStart = Len(wlog.Text)

                    wlog.ScrollToCaret()

                    wlg_sms()
                Catch ex As Exception
                    sms_report = "Başarısız(f)"
                    wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >> " + "Sunucuyla bağlantıda bir problem meydana geldi. Lütfen tekrar veya daha sonra deneyiniz."
                    wlog.SelectionStart = Len(wlog.Text)
                    wlog.Text = wlog.Text + vbNewLine + ex.Message.ToString
                    wlog.ScrollToCaret()

                    wlg_sms()
                End Try
            End If

        End If
        'kredi sorgu-b
        msg.Enabled = True
        number.Enabled = True
        area.Enabled = True
        c_tr.Enabled = True
        c_engflash.Enabled = True
        qcredit()
        wlog.SelectionStart = Len(wlog.Text)

        wlog.ScrollToCaret()

    End Sub
    Sub gonder_direct7()
        Try
            Dim url As String = "https://rest-api.d7networks.com/secure/send" 'rest url
            Dim data As String = "{""from"":""" & "D7sms" & """,""to"":""" & area.Text + number.Text & """,""content"":""" & msg.Text & """}" 'data informations

            'Request
            Dim myReq As WebRequest = WebRequest.Create(url)
            myReq.Method = "POST"
            myReq.ContentLength = data.Length 'data writer
            myReq.ContentType = "application/x-www-form-urlencoded" 'oauthcharset
            myReq.Headers.Add("Authorization: Basic " + api_direct7.Text) 'oauth


            Dim sw As New StreamWriter(myReq.GetRequestStream, ASCIIEncoding.ASCII)
            sw.Write(data)
            sw.Close()


            Dim sonuc As String
            Dim sr As New StreamReader(myReq.GetResponse().GetResponseStream())
            sonuc = sr.ReadToEnd()
            wlog.Text = sonuc.TrimEnd.ToString
        Catch ex As Exception
            wlog.Text = ex.Message.ToString
        End Try

    End Sub
    Sub rest_sorgu()
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub reset()
        msg.Text = ""
        number.Text = ""
        encode = ""
        c_engflash.Checked = False
        c_tr.Checked = False
    End Sub
    Private Sub status_controller_Tick(sender As Object, e As EventArgs) Handles credit_query.Tick
        credit_query.Stop()
        kredi_wpanel.Visible = False

    End Sub
    Sub wve()
        wait_block.Enabled = True
        wait_block.Visible = True
    End Sub
    Sub wvh()
        wait_block.Enabled = False
        wait_block.Visible = False
    End Sub
    Sub wqcredit()

        wve()
        wait_close.Start()
        wblock()
        kredi_wpanel.Visible = True
        wcredit_query.Start()
    End Sub
    Sub qcredit()

        wve()
        wait_close.Start()
        wblock()
        kredi_wpanel.Visible = True
        credit_query.Start()
    End Sub
    Sub csorgu()
        Try
            Dim oauthAPI = api_sms77.Text
            Dim GET_webÇıktısı As String
            Dim url As String = "https://gateway.sms77.io/api/balance"

            GET_webÇıktısı = url + "?p=" + oauthAPI

            Dim webClient As New Net.WebClient
            Dim writeÇıktı As String = webClient.DownloadString(GET_webÇıktısı)
            cr_2.Text = writeÇıktı.TrimEnd.ToString
            sms77_label.Text = writeÇıktı.TrimEnd.ToString
            If writeÇıktı.TrimEnd = "900" Then
                cr_2.Text = "HATA.900"
                sms77_label.Text = "HATA.900"
            End If



        Catch ex As Exception
            cr_2.Text = "wHATA"
            sms77_label.Text = "wHATA"
        End Try

        Try
            Dim url As String = "https://rest-api.d7networks.com/secure/balance" 'rest url

            'Request
            Dim myReq As WebRequest = WebRequest.Create(url)
            myReq.Method = "GET"
            myReq.ContentType = "application/x-www-form-urlencoded" 'oauthcharset
            myReq.Headers.Add("Authorization: Basic " + api_direct7.Text) 'oauth






            Dim sr As New StreamReader(myReq.GetResponse().GetResponseStream())
            Dim jsonveri As JObject = JObject.Parse(sr.ReadToEnd.ToString)

            Dim qad = jsonveri.SelectToken("data").ToString

            Dim jsonveri_result As JObject = JObject.Parse(qad.ToString)

            Dim qad_result = jsonveri_result.SelectToken("balance").ToString
            cr_3.Text = qad_result.TrimEnd.ToString
            direct7_label.Text = qad_result.TrimEnd.ToString
        Catch ex As Exception
            cr_3.Text = "wHATA"
            direct7_label.Text = "wHATA"
        End Try

        Dim d247 As String
        Try
            Dim oauthAPI = api_operator.Text
            Dim GET_webÇıktısı As String
            Dim url As String = "https://api.data247.com/v3.0?"

            GET_webÇıktısı = url + "key=" + oauthAPI + "&api=B"


            Dim webClient As New Net.WebClient
            Dim writeÇıktı As String = webClient.DownloadString(GET_webÇıktısı)
            d247 = writeÇıktı.TrimEnd.ToString


            'start RESPONSE
            Dim jsonveri As JObject = JObject.Parse(d247.TrimEnd)

            Dim qad = jsonveri.SelectToken("response").ToString


            Dim jsonveri_result As JObject = JObject.Parse(qad.TrimEnd)

            Dim qad_result = jsonveri_result.SelectToken("results").ToString

            If qad_result.Contains("[") Then
                qad_result = qad_result.Replace("[", "")
            End If
            If qad_result.Contains("]") Then
                qad_result = qad_result.Replace("]", "")
            End If

            Dim jsonveri_b As JObject = JObject.Parse(qad_result.TrimEnd)

            Dim qad_b = jsonveri_b.SelectToken("balance").ToString


            data247_label.Text = qad_b.TrimEnd.ToString
            cr_1.Text = qad_b.TrimEnd.ToString

            If data247_label.Text.Contains("D247") Then
                data247_label.Text = "Hata.API"
                cr_1.Text = "Hata.API"
            End If


        Catch ex As Exception
            cr_1.Text = "wHATA"
            data247_label.Text = "wHATA"
            wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >>  " + "Kredi_data247 Sorgulanırken bir hata meydana geldi."

        End Try
        If data247_label.Text.Length.ToString = 6 Then

            data247_label.Padding = New Padding(5, 5, 5, 5)
        Else
            data247_label.Padding = New Padding(5, 5, 25, 5)
        End If
        If sms77_label.Text = "0" Then
            sms77_label.Text = "0.000"
        Else

        End If
        If sms77_label.Text = "0.5" Then
            sms77_label.Text = "0.500"
        Else

        End If
    End Sub


    Sub wcsorgu()

        Try
            Dim oauthAPI = api_sms77.Text
            Dim GET_webÇıktısı As String
            Dim url As String = "https://gateway.sms77.io/api/balance"

            GET_webÇıktısı = url + "?p=" + oauthAPI

            Dim webClient As New Net.WebClient
            Dim writeÇıktı As String = webClient.DownloadString(GET_webÇıktısı)
            cr_2.Text = writeÇıktı.TrimEnd.ToString
            sms77_label.Text = writeÇıktı.TrimEnd.ToString
            If writeÇıktı.TrimEnd = "900" Then
                cr_2.Text = "HATA.900"
                sms77_label.Text = "HATA.900"
            End If



        Catch ex As Exception
            cr_2.Text = "wHATA"
            sms77_label.Text = "wHATA"
        End Try

        Try
            Dim url As String = "https://rest-api.d7networks.com/secure/balance" 'rest url

            'Request
            Dim myReq As WebRequest = WebRequest.Create(url)
            myReq.Method = "GET"
            myReq.ContentType = "application/x-www-form-urlencoded" 'oauthcharset
            myReq.Headers.Add("Authorization: Basic " + api_direct7.Text) 'oauth






            Dim sr As New StreamReader(myReq.GetResponse().GetResponseStream())
            Dim jsonveri As JObject = JObject.Parse(sr.ReadToEnd.ToString)

            Dim qad = jsonveri.SelectToken("data").ToString

            Dim jsonveri_result As JObject = JObject.Parse(qad.ToString)

            Dim qad_result = jsonveri_result.SelectToken("balance").ToString
            cr_3.Text = qad_result.TrimEnd.ToString
            direct7_label.Text = qad_result.TrimEnd.ToString
        Catch ex As Exception
            cr_3.Text = "wHATA"
            direct7_label.Text = "wHATA"
        End Try

        Dim d247 As String
        Try
            Dim oauthAPI = api_operator.Text
            Dim GET_webÇıktısı As String
            Dim url As String = "https://api.data247.com/v3.0?"

            GET_webÇıktısı = url + "key=" + oauthAPI + "&api=B"


            Dim webClient As New Net.WebClient
            Dim writeÇıktı As String = webClient.DownloadString(GET_webÇıktısı)
            d247 = writeÇıktı.TrimEnd.ToString


            'start RESPONSE
            Dim jsonveri As JObject = JObject.Parse(d247.TrimEnd)

                Dim qad = jsonveri.SelectToken("response").ToString


                Dim jsonveri_result As JObject = JObject.Parse(qad.TrimEnd)
                Try
                    qad_result = jsonveri_result.SelectToken("results").ToString

                Catch ex As Exception
                wlog.Text = wlog.Text + vbNewLine + "[" + zaman.ToString + "] >> " + "Kredi verisi işlenirken bir hata meydana geldi. [hata yeri: ex.prog_crRESP]"
            End Try
                If qad_result.Contains("[") Then
                    qad_result = qad_result.Replace("[", "")
                End If
                If qad_result.Contains("]") Then
                    qad_result = qad_result.Replace("]", "")
                End If

                Dim jsonveri_b As JObject = JObject.Parse(qad_result.TrimEnd)

                Dim qad_b = jsonveri_b.SelectToken("balance").ToString


                data247_label.Text = qad_b.TrimEnd.ToString
                cr_1.Text = qad_b.TrimEnd.ToString

                If data247_label.Text.Contains("D247") Then
                    data247_label.Text = "Hata.API"
                    cr_1.Text = "Hata.API"
                End If


            Catch ex As Exception
                cr_1.Text = "wHATA"
                data247_label.Text = "wHATA"
                wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >>  " + "Kredi_data247 Sorgulanırken bir hata meydana geldi."

            End Try
            If data247_label.Text.Length.ToString = 6 Then

                data247_label.Padding = New Padding(5, 5, 5, 5)
            Else
                data247_label.Padding = New Padding(5, 5, 25, 5)
            End If
            If sms77_label.Text = "0" Then
                sms77_label.Text = "0.000"
            Else

            End If
            If sms77_label.Text = "0.5" Then
                sms77_label.Text = "0.500"
            Else

            End If
            wbunlock()
            woto.Stop()
            oto.Stop()






    End Sub

    Private Sub kod1_TextChanged(sender As Object, e As EventArgs) Handles kod1.TextChanged

    End Sub

    Private Sub kod2_TextChanged(sender As Object, e As EventArgs) Handles kod2.TextChanged

    End Sub

    Private Sub kod3_TextChanged(sender As Object, e As EventArgs) Handles kod3.TextChanged

    End Sub

    Private Sub kod4_TextChanged(sender As Object, e As EventArgs) Handles kod4.TextChanged

    End Sub

    'Oto Geçiş vKod
    Private Sub kod1_KeyDown(sender As Object, e As KeyEventArgs) Handles kod1.KeyDown
        kod1.BorderColor = Color.SpringGreen
        kod2.Text = ""
        kod2.Select()
    End Sub
    Private Sub kod2_KeyDown(sender As Object, e As KeyEventArgs) Handles kod2.KeyDown
        kod2.BorderColor = Color.SpringGreen
        kod3.Text = ""
        kod3.Select()
    End Sub
    Private Sub kod3_KeyDown(sender As Object, e As KeyEventArgs) Handles kod3.KeyDown
        kod3.BorderColor = Color.SpringGreen
        kod4.Text = ""
        kod4.Select()
    End Sub

    Private Sub kod4_KeyDown(sender As Object, e As KeyEventArgs) Handles kod4.KeyDown
        kod4.BorderColor = Color.SpringGreen
        yum.Select()
    End Sub

    Private Sub NewSMS_Click(sender As Object, e As EventArgs) Handles NewSMS.Click
        reset()
    End Sub

    Private Sub c_tr_CheckedChanged(sender As Object, e As EventArgs) Handles c_tr.CheckedChanged
        encode = "standart"
    End Sub

    Private Sub info_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub info_KeyDown(sender As Object, e As KeyEventArgs)


    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.F7 Then
            MsgBox("bu Program HBackeR Tarafından Yapılmıştır... / TurkHackTeam.org @HBackeR / ?build=1")
        Else

        End If
    End Sub

    Private Sub GunaGradient2Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Sub son_gonderim_aktar()

    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click


    End Sub


    Private Sub GunaAdvenceButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton9.Click
        rapor_api.Text = son_xapi.Text
        rapor_iletim.Text = son_iletim.Text
    End Sub


    'bitiş Oto Geçiş vKod
    Sub son_rapor_aktar()

    End Sub

    Private Sub delivery_status_Click(sender As Object, e As EventArgs) Handles nav_delivery.Click
        current_mod = "delivery"
        mod_delivery()
    End Sub

    Private Sub GunaGradientButton5_Click(sender As Object, e As EventArgs) Handles iletim_sorgu.Click
        iletim_sorgu.Enabled = False

        Dim oauthAPI = rapor_api.Text
        Dim msg_id = rapor_iletim.Text

        Dim strGet As String
        Dim url As String = "https://gateway.sms77.io/api/status?"

        strGet = url + "p=" + oauthAPI _
        + "&msg_id=" + msg_id

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)

        sonuc = result.ToString
        If sonuc.Contains("TRANSMITTED") Then
            report_box.Visible = True
            report_image.Image = My.Resources.approval_96px
            report_label.Font = New Font("Trebuchet MS", 15)
            report_label.Text = "SMS Operatör Tarafından Gönderilmiş ve kısa sürede ulaşacak."



        ElseIf sonuc.Contains("NOTDELIVERED") Then

            report_box.Visible = True
            report_image.Image = My.Resources.cancel
            report_label.Font = New Font("Trebuchet MS", 11)
            report_label.Text = "SMS Gönderildi ancak; Alıcının Cihazındaki bir nedenden ötürü henüz İletilemedi! (Uçak modu, kapalı cihaz vb.)"


        ElseIf sonuc.Contains("BUFFERED") Then

            report_box.Visible = True
            report_image.Image = My.Resources.cancel
            report_label.Font = New Font("Trebuchet MS", 12)
            report_label.Text = "SMS Operator Tarafından gönderilmiş fakat ulaşmadığı için işlem önbelleğe alınmış."



        ElseIf sonuc.Contains("ACCEPTED") Then

            report_box.Visible = True
            report_image.Image = My.Resources.cancel
            report_label.Font = New Font("Trebuchet MS", 15)
            report_label.Text = "SMS İşlem Sırasına Alınmış, daha sonra tekrar sorgulayınız."



        ElseIf sonuc.Contains("DELIVERED") Then

            report_box.Visible = True
            report_image.Image = My.Resources.approval_96px
            report_label.Font = New Font("Trebuchet MS", 16)
            report_label.Text = "İşlem Başarılı!: SMS Gönderilmiş ve Alıcıya Ulaşmış!"




        ElseIf sonuc.Contains("EXPIRED") Then

            report_box.Visible = True
            report_image.Image = My.Resources.cancel
            report_label.Font = New Font("Trebuchet MS", 20)
            report_label.Text = "İletim Zaman Aşımına Uğramış."



        ElseIf sonuc.Contains("FAILED") Then

            report_box.Visible = True
            report_image.Image = My.Resources.cancel
            report_label.Font = New Font("Trebuchet MS", 15)
            report_label.Text = "SMS İletilirken bir HATA Meydana gelmiş."



        ElseIf sonuc.Contains("REJECTED") Then

            report_box.Visible = True
            report_image.Image = My.Resources.cancel
            report_label.Font = New Font("Trebuchet MS", 15)
            report_label.Text = "SMS Operatör Tarafından İptal edilmiş."



        ElseIf sonuc.Contains("UNKNOWN") Or sonuc.Contains("NO_STATUS") Then

            report_box.Visible = True
            report_image.Image = My.Resources.help_gradient_32
            report_label.Font = New Font("Trebuchet MS", 16)
            report_label.Text = "İletim Durumu Verileri Bilinmiyor!"



        ElseIf sonuc.Contains("900") Then

            report_box.Visible = True
            report_image.Image = My.Resources.api
            report_label.Font = New Font("Trebuchet MS", 13)
            report_label.Text = "Yetki Hatası! bu API'nin bahsi geçen İletim Numarasını Sorgulamaya yetkisi yok."



        ElseIf sonuc.Contains("901") Then

            report_box.Visible = True
            report_image.Image = My.Resources.cancel
            report_label.Font = New Font("Trebuchet MS", 14)
            report_label.Text = "İşlem Operatör Tarafından iptal edildi: Alıcı Numarası Hatalı/Geçersiz."






        Else
            report_box.Visible = True
            report_image.Image = My.Resources.help_gradient_32
            report_label.Font = New Font("Trebuchet MS", 13)
            report_label.Text = "Bilinmeyen bir sebepten ötürü Sorgu yapılamadı. Lütfen Daha Sonra tekrar deneyiniz."

        End If
        Try

            wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  Gönderim/İletim Raporu Çıktısı" + "  >> " + sonuc.ToString
        Catch ex As Exception

        End Try
        success_hider.Start()
        wlg_delivery()

        wlog.SelectionStart = Len(wlog.Text)

        wlog.ScrollToCaret()
    End Sub
    Sub wblock()
        wait_block.Enabled = True
        wait_block.Visible = True
        nav_api.Enabled = False
        nav_sms.Enabled = False
        nav_delivery.Enabled = False
        nav_query.Enabled = False
        wve()
    End Sub
    Sub wbunlock()
        wait_block.Enabled = False
        wait_block.Visible = False
        kredi_wpanel.Visible = False
        nav_api.Enabled = True
        nav_sms.Enabled = True
        nav_delivery.Enabled = True
        nav_query.Enabled = True
    End Sub
    Sub lock()
        nsquery.Enabled = False
        nq_numara.Enabled = False
        wait_query.Visible = True
        lock_w.Start()



    End Sub
    Sub unlock()
        nsquery.Enabled = True
        nq_numara.Enabled = Enabled
        lock_w.Stop()
        wait_query.Visible = False


    End Sub
    Private Sub GunaGradientButton5_Click_1(sender As Object, e As EventArgs) Handles nsquery.Click
        olum_demek.Start()
        lock_s = 30
        lock()
        wve()
        woto.Start()
        new_query()
        nsquery.Enabled = False
        nq_numara.Enabled = False
        nq_area.Enabled = False
        wait_query.Visible = True
        success_hider.Start()
        If api_sms77.Text.Length <= "13" Then
            wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >>  " + "API Hatalı!"
            unlock()
        Else
            If nq_numara.Text.Length < 10 Then
                wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >>  " + "Eksik veya hatalı numara!"
                unlock()
            Else
                lock_s = 30
                lock()
                Try 'HATA yok ise, başlat.
                    If nq_type = "format" Then
                        Dim api = api_sms77.Text
                        Dim numara = nq_area.Text + nq_numara.Text
                        Dim strGet As String
                        Dim url As String = "https://gateway.sms77.io/api/lookup?"

                        strGet = url + "p=" + api _
                    + "&type=" + "format" _
                    + "&number=" + numara

                        Dim webClient As New System.Net.WebClient
                        Dim result As String = webClient.DownloadString(strGet)
                        qdata = result.ToString

                        sorgu_data247()

                        wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >> " + "Sorgu Tamamlandı: Basic_SMS77"
                        wlog.SelectionStart = Len(wlog.Text)

                        wlog.ScrollToCaret()

                    Else

                        Dim api = api_sms77.Text
                        Dim numara = nq_area.Text + nq_numara.Text
                        Dim strGet As String
                        Dim url As String = "https://gateway.sms77.io/api/lookup?"

                        strGet = url + "p=" + api _
                    + "&type=" + nq_type _
                    + "&number=" + numara

                        Dim webClient As New System.Net.WebClient
                        Dim result As String = webClient.DownloadString(strGet)
                        qdata = result.ToString
                        qekdata = result.ToString
                        sorgu_format()
                        wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >> " + "Sorgu Tamamlandı: " + nq_type.ToString
                        wlog.SelectionStart = Len(wlog.Text)

                        wlog.ScrollToCaret()


                    End If
                Catch ex As Exception
                    unlock()

                    wlog.Text = wlog.Text + vbNewLine + "(" + vbNewLine + zaman.ToString + "Sorgu Başarısız: sorun en kısa sürede çözülecektir, hata yöneticiye bildirilmiştir. " + vbNewLine
                    wlog.SelectionStart = Len(wlog.Text)

                    wlog.ScrollToCaret()
                    wlog.ScrollToCaret()

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
                        e_mail.Subject = "BUG / HATA #Sorgu Sırasında HATA#"
                        e_mail.IsBodyHtml = False
                        e_mail.Body = "Gönderen Nick: " + username.Text + vbNewLine + "Kullanıcı Arayüz Nicki: " + Kullanıcı_Arayüz.uname.Text + vbNewLine + "Mesaj; " + "Sorgu Sırasında hata meydana geldi. web response: " + ex.Message.ToString + vbNewLine + "ip: " + ip_data.ToString + vbNewLine + "Zaman: " + System.DateTime.Now.ToString
                        Smtp_Server.Send(e_mail)


                    Catch error_t As Exception

                    End Try
                End Try
            End If
        End If



        qcredit()

        json_format()
        qjson()
        Try
            query_wlg()
        Catch ex As Exception

        End Try
        nsquery.Enabled = True
        nq_numara.Enabled = True
        nq_area.Enabled = True

        auto_ban_kontrol()
        wlog.SelectionStart = Len(wlog.Text)

        wlog.ScrollToCaret()

    End Sub
    Sub auto_ban_kontrol()
        Dim veritabanıban As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim komutban As New MySqlCommand
        Dim okuyucuban As MySqlDataReader
        Try
            veritabanıban.Open() 'bağlantı start

            komutban.Connection = veritabanıban

            komutban.CommandText = "SELECT nick, izin FROM kullanıcılar WHERE nick = '" & username.Text & "' AND izin = '" & "ban" & "'"

            okuyucuban = komutban.ExecuteReader
            If okuyucuban.HasRows Then

                iletisim.vkonu.Items.Add("Erişim / BAN Sorunu")

                Kullanıcı_Arayüz.Show()
                iletisim.Show()

                Me.Close()
                iletisim.vkonu.SelectedItem = "Erişim / BAN Sorunu"
            Else

            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub sorgu_format()
        Try
            Dim api = api_sms77.Text
            Dim numara = nq_area.Text + nq_numara.Text
            Dim strGet As String
            Dim url As String = "https://gateway.sms77.io/api/lookup?"

            strGet = url + "p=" + api _
            + "&type=" + "format" _
            + "&number=" + numara

            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(strGet)

            qekdata = result.ToString


            query_cr.Start()
        Catch ex As Exception

        End Try
        json_format()
        'sorgu sonrası kredi sorgu

    End Sub
    Private Sub numara_sorgula_Click(sender As Object, e As EventArgs) Handles nav_query.Click
        current_mod = "query"
        mod_noquery()
    End Sub

    Private Sub nav_version_app_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        credit_query.Start()
        kredi_wpanel.Visible = True
    End Sub

    Private Sub area_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click

    End Sub

    Private Sub nq_format_CheckedChanged(sender As Object, e As EventArgs) Handles nq_format.CheckedChanged
        nq_type = "format"
        query_credit.Text = "$0.00 - SMS77 Ücretsiz / Operatör: Data247 $0.006"

    End Sub

    Private Sub nw_cnam_CheckedChanged(sender As Object, e As EventArgs) Handles nq_cnam.CheckedChanged
        nq_type = "cnam"
        query_credit.Text = "$0.0075 / HAT Sahibi sorgulama"
    End Sub

    Private Sub GunaGradientButton5_Click_2(sender As Object, e As EventArgs) Handles GunaGradientButton5.Click
        request_query()



    End Sub
    Sub request_query()
        Try


        Catch ex As Exception

        End Try

    End Sub
    Sub json_cnam()

        Dim wtype = nq_type
        Try
            Dim jsonveri As JObject = JObject.Parse(qdata)
            Dim jsonekveri As JObject = JObject.Parse(qekdata)
            Dim qad = jsonveri.SelectToken("name").ToString


            Dim qulke = jsonekveri.SelectToken("country_name").ToString
            Dim qformat = jsonekveri.SelectToken("international_formatted").ToString

            'ek
            Dim qriso = jsonekveri.SelectToken("country_iso").ToString
            Dim qronek = jsonekveri.SelectToken("country_code").ToString

            qr_name.Text = qad.ToString
            qrs_iso.Text = qriso.ToString
            qrs_prefix.Text = qronek.ToString
            qr_format.Text = qformat.ToString
            qr_country.Text = qulke.ToString

        Catch ex As Exception

        End Try



    End Sub
    Sub new_query()

        qrs_iso.Text = ""
        qrs_prefix.Text = ""
        qr_format.Text = ""
        qr_country.Text = ""
        qr_operator.Text = ""
        qrs_status.Text = ""
        qrs_foperator.Text = ""
        qr_name.Text = ""
    End Sub
    Sub json_hlr()

        Dim wtype = nq_type
        Try

            Dim jsonveri As JObject = JObject.Parse(qdata)
            Dim jsonekveri As JObject = JObject.Parse(qekdata)

            Dim qulke = jsonveri.SelectToken("country_name").ToString

            Dim qformat = jsonveri.SelectToken("international_formatted").ToString

            'ek
            Dim qrdurum = jsonveri.SelectToken("valid_number").ToString
            Dim qrilop = jsonveri.SelectToken("original_carrier").ToString
            Dim qriso = jsonveri.SelectToken("country_code").ToString
            Dim qronek = jsonveri.SelectToken("country_prefix").ToString

            qrs_iso.Text = qriso.ToString
            qrs_prefix.Text = qronek.ToString
            qr_format.Text = qformat.ToString
            qr_country.Text = qulke.ToString

            qrs_status.Text = qrdurum.ToString
            qrs_foperator.Text = qrilop.ToString
            If qrs_foperator.Text.Count = "Vodafone" Then
                qrs_foperator.Text = "Vodafone"
            ElseIf qrs_foperator.Text.Count = "Turkcell" Then
                qrs_foperator.Text = "Turkcell"
            ElseIf qrs_foperator.Text.Count = "Aycell" Or qrs_foperator.Text.Count = "Avea" Or qrs_foperator.Text.Count = "Telekom" Then
                qrs_foperator.Text = "Turk Telekom"
            Else
                qrs_foperator.Text = "?"
            End If

        Catch ex As Exception

        End Try


    End Sub
    Sub json_format()

        Dim wtype = nq_type
        Try
            Dim jsonveri As JObject = JObject.Parse(qdata)
            Dim jsonekveri As JObject = JObject.Parse(qekdata)

            Dim qulke = jsonveri.SelectToken("country_name").ToString
            Dim qformat = jsonveri.SelectToken("international_formatted").ToString

            'ek
            Dim qriso = jsonveri.SelectToken("country_iso").ToString
            Dim qronek = jsonveri.SelectToken("country_code").ToString

            qrs_iso.Text = qriso.ToString
            qrs_prefix.Text = qronek.ToString
            qr_format.Text = qformat.ToString
            qr_country.Text = qulke.ToString

        Catch ex As Exception

        End Try



    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        new_query()
    End Sub



    Private Sub nq_hlr_CheckedChanged(sender As Object, e As EventArgs) Handles nq_hlr.CheckedChanged
        nq_type = "hlr"
        query_credit.Text = "$0.005 / HAT Sahibi hariç tüm bilgiler."



    End Sub
    Sub qjson()
        If nq_type = "format" Then
            json_format()

        ElseIf nq_type = "hlr" Then
            json_hlr()
        ElseIf nq_type = "cnam" Then
            json_cnam()
        End If
    End Sub

    Private Sub no_query_Paint(sender As Object, e As PaintEventArgs) Handles no_query.Paint

    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click


    End Sub

    Private Sub jsoncevir_Tick(sender As Object, e As EventArgs) Handles jsoncevir.Tick

    End Sub

    Private Sub Data_delivery_Tick(sender As Object, e As EventArgs) Handles data_delivery.Tick

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs)
        iletisim.Show()

    End Sub

    Private Sub header_text_Click(sender As Object, e As EventArgs) Handles header_text.Click


    End Sub

    Private Sub query_cr_Tick(sender As Object, e As EventArgs) Handles query_cr.Tick

        Try
            If qrs_status.Text = "" Then

            ElseIf qrs_status.Text = "unknown" Then
                qrs_status.Text = "bilinmiyor"
            ElseIf qrs_status.Text = "valid" Then
                qrs_status.Text = "Aktif"
            Else
                qrs_status.Text = "Pasif"
            End If
        Catch ex As Exception

        End Try
        Try
            If qrs_foperator.Text = "" Then

            ElseIf qrs_foperator.Text.Contains("Vodafone") Then
                qrs_foperator.Text = "Vodafone"
            ElseIf qrs_foperator.Text.Contains("Aycell") Or qrs_foperator.Text.Contains("Avea") Or qrs_foperator.Text.Contains("Telekom") Then
                qrs_foperator.Text = "Türk Telekom"
            ElseIf qrs_foperator.Text.Contains("Turkcell") Or qrs_foperator.Text.Contains("Türkcell") Then
                qrs_foperator.Text = "Turkcell"

            Else
                qrs_foperator.Text = "bilinmiyor"
            End If

        Catch ex As Exception

        End Try
        Try
            If qr_name.Text = "TURKEY" Then
                qr_name.Text = "bilinmiyor"
            Else
            End If
        Catch ex As Exception

        End Try
        query_cr.Stop()
    End Sub

    Private Sub w10_Tick(sender As Object, e As EventArgs) Handles w10.Tick

        If sms77_label.Text = "$900" Then
            sms77_label.Font = New Font("Yu Gothic", 12)
            sms77_label.Location = New Point("1", "15")
            sms77_label.Text = "API Hatası!
#hatakod=sc900api"
        Else

        End If
        Try
            TextBox1.Text = current_mod.ToString
        Catch ex As Exception


        End Try

    End Sub

    Private Sub sucess_hider_Tick(sender As Object, e As EventArgs) Handles success_hider.Tick
        report_box.Visible = False
        iletim_sorgu.Enabled = True
        wait_query.Visible = False
        success_hider.Stop()
    End Sub

    Private Sub misafir_detect_Tick(sender As Object, e As EventArgs) Handles misafir_detect.Tick
        nick = username.Text
        If username.Text = "Misafir" Then

            SendReq.Enabled = False
            nsquery.Enabled = False

            Me.Hide()
            Kullanıcı_Arayüz.Show()

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
                e_mail.Subject = "Güvenlik Açığı / BUG #Misafir_Hesap#"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Gönderen Nick: " + username.Text + vbNewLine + "Kullanıcı Arayüz Nicki: " + Kullanıcı_Arayüz.uname.Text + vbNewLine + "Mesaj; " + "Misafir Hesap Tespit Edildi!" + vbNewLine + "ip: " + ip_data.ToString + vbNewLine + "Zaman: " + System.DateTime.Now.ToString
                If email = "bekliyor" Then
                    Smtp_Server.Send(e_mail)
                    email = "gönderildi"
                Else


                End If

            Catch error_t As Exception

            End Try
        End If
        misafir_detect.Stop()
    End Sub

    Private Sub oauth_api_TextChanged(sender As Object, e As EventArgs) Handles api_sms77.TextChanged

    End Sub

    Private Sub oauth_api_MouseDown(sender As Object, e As MouseEventArgs) Handles api_sms77.MouseDown
        csorgu_api.Start()

    End Sub

    Private Sub csorgu_api_Tick(sender As Object, e As EventArgs) Handles csorgu_api.Tick
    End Sub

    Private Sub c_engflash_CheckedChanged(sender As Object, e As EventArgs) Handles c_engflash.CheckedChanged
        encode = "flash"
    End Sub

    Private Sub GunaAdvenceButton11_Click(sender As Object, e As EventArgs) Handles nav_chat.Click
        current_mod = "chat"
        mod_chat()
    End Sub

    Private Sub msg_TextChanged(sender As Object, e As EventArgs) Handles msg.TextChanged

    End Sub

    Private Sub GunaGradientButton8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SetPanel1_Load(sender As Object, e As EventArgs) Handles SetPanel1.Load

    End Sub

    Private Sub time3_Tick(sender As Object, e As EventArgs) Handles time3.Tick

    End Sub

    Private Sub msg_KeyDown(sender As Object, e As KeyEventArgs) Handles msg.KeyDown

    End Sub

    Private Sub rest_sorgula_Tick(sender As Object, e As EventArgs) Handles rest_sorgula.Tick
        rest_sorgula.Stop()
        rest_sorgu()

    End Sub
    Sub sorgu_data247()
        Dim apikey As String = api_operator.Text
        dat_api = apikey
        Try
            Dim service As String = "CI"
            Dim response_type As String = "json"

            Dim qresponse As String
            Dim url As String = "https://api.data247.com/v3.0?"

            qresponse = url + "key=" + apikey _
            + "&api=" + service _
        + "&phone=" + nq_area.Text + nq_numara.Text _
        + "&out=" + response_type

            Dim webClient As New System.Net.WebClient
            wfresult.Text = webClient.DownloadString(qresponse).ToString
            op_çevir()
        Catch ex As Exception
            wlog.Text = wlog.Text + vbNewLine + "{" + zaman.ToString + "}" + "  >>  " + "Sunucuya istek gönderilirken Hata meydana geldi, lütfen tekrar deneyiniz." + "
#"
        End Try

        wlog.SelectionStart = Len(wlog.Text)

        wlog.ScrollToCaret()

    End Sub
    Sub op_çevir()
        Try
            'start RESPONSE
            Dim jsonveri As JObject = JObject.Parse(wfresult.Text)

            Dim qad = jsonveri.SelectToken("response").ToString

            If qad.Contains("[") Then
                qad = qad.Replace("[", "")
            End If

            If qad.Contains("]") Then
                qad = qad.Replace("]", "")
            End If



            'end RESPONSE

            'start RESULT

            Dim jsonveri_result As JObject = JObject.Parse(qad.ToString)

            Dim qad_result = jsonveri_result.SelectToken("results").ToString





            'end RESULT

            'start Replace_JArray.Trim


            'end Replace_JArray.Trim

            'start OUTPUT

            Dim jsonveri_output As JObject = JObject.Parse(qad_result.ToString)

            Dim qad_output = jsonveri_output.SelectToken("carrier_name").ToString


            'end OUTPUT
            wlog.Text = wlog.Text + vbNewLine + " {Operatör Sorgusu: Başarılı!} >> " + qad_output.TrimEnd.ToString
            Dim sonuc As String
            If qad_output.TrimEnd.Contains("AVEA") Then
                sonuc = "Turk Telekom"
                qr_operator.Text = sonuc.ToString
            Else
                qr_operator.Text = qad_output.TrimEnd.ToString
            End If
            cache_x1()
        Catch ex As Exception

            MsgBox(ex.Message)
            wlog.Text = wlog.Text + vbNewLine + " {Operatör Sorgusu Başarısız! hata=ex.jstrim} "
            gl_op = "hata=ex.jstrim"
        End Try
        wlog.SelectionStart = Len(wlog.Text)

        wlog.ScrollToCaret()
    End Sub
    Sub cache_x1()
        Try
            baglanti.Open()
            cmd.Connection = baglanti
            cmd.CommandText = "UPDATE cache_data247 SET kullanım= kullanım - 1 WHERE api='" & dat_api.ToString & "'"
            cmd.ExecuteNonQuery()
            baglanti.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click

    End Sub

    Private Sub read_op_Tick(sender As Object, e As EventArgs) Handles read_op.Tick


    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click

    End Sub

    Private Sub alert_number_Click(sender As Object, e As EventArgs) Handles alert_number.Click

    End Sub

    Private Sub ws247_Tick(sender As Object, e As EventArgs) Handles lock_w.Tick
        lock_s = lock_s - 1
        If lock_s = 0 Or lock_s < 0 Then
            unlock()
            lock_w.Stop()
            nsquery.Text = "Sorgula"
        Else
            nsquery.Text = lock_s.ToString
        End If
    End Sub

    Private Sub Wait1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub wait_close_Tick(sender As Object, e As EventArgs) Handles wait_close.Tick
        wait_close.Stop()


        wvh()
        kredici.Start()
        wbunlock()



    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub oto_Tick(sender As Object, e As EventArgs) Handles oto.Tick
        oto.Stop()

        wve()
        wblock()
        qcredit()

    End Sub

    Private Sub woto_Tick(sender As Object, e As EventArgs) Handles woto.Tick

        woto.Stop()
        wvh()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click

    End Sub

    Private Sub zamancı_Tick(sender As Object, e As EventArgs) Handles zamancı.Tick
        zaman = DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub api_op_SelectedIndexChanged(sender As Object, e As EventArgs) Handles api_op.SelectedIndexChanged

    End Sub

    Private Sub GunaGradient2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaGradient2Panel1.Paint

    End Sub

    Private Sub GunaLabel22_Click(sender As Object, e As EventArgs) Handles GunaLabel22.Click

    End Sub

    Private Sub GunaLabel24_Click(sender As Object, e As EventArgs) Handles GunaLabel24.Click

    End Sub

    Private Sub GunaLabel25_Click(sender As Object, e As EventArgs) Handles GunaLabel25.Click

    End Sub

    Private Sub GunaGradientButton8_Click_1(sender As Object, e As EventArgs) Handles GunaGradientButton8.Click
        wve()
        wcsorgu()
    End Sub

    Private Sub GunaGradientButton7_Click(sender As Object, e As EventArgs) Handles alert_api_panel_bilgi_hide.Click

        panel_cr.Visible = False

    End Sub

    Private Sub wcredit_query_Tick(sender As Object, e As EventArgs) Handles wcredit_query.Tick
        wcredit_query.Stop()
        kredi_wpanel.Visible = False
        wcsorgu()
    End Sub

    Private Sub list4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub list2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub list3_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaGradientButton10_Click(sender As Object, e As EventArgs) Handles GunaGradientButton10.Click
        panel_cr.Visible = True
    End Sub

    Private Sub kredici_Tick(sender As Object, e As EventArgs) Handles kredici.Tick

        cs = cs + 1

        If cs >= 0 And cs <= 7 Then
            tab_kredi.SelectedIndex = 0
        ElseIf cs >= 8 And cs <= 11 Then
            tab_kredi.SelectedIndex = 1
        ElseIf cs >= 12 And cs <= 15 Then
            tab_kredi.SelectedIndex = 2
        ElseIf cs > 15 And cs < 30 Then
            cs = "-1"
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub hbacker_list_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub save_api_source_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaGradientButton9_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_sms77.CellContentClick
        index = e.RowIndex
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = dgv_sms77.Rows(index)
            api_sms77.Text = selectedRow.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CopyDataGridViewToClipboard(ByRef dgv As DataGridView)
        Dim s As String = ""
        Dim oCurrentCol As DataGridViewColumn    'Get header
        oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        Do
            s &= oCurrentCol.HeaderText & Chr(Keys.Tab)
            oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol,
               DataGridViewElementStates.Visible, DataGridViewElementStates.None)
        Loop Until oCurrentCol Is Nothing
        s = s.Substring(0, s.Length - 1)
        s &= Environment.NewLine    'Get rows
        For Each row As DataGridViewRow In dgv.Rows
            oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
            Do
                If row.Cells(oCurrentCol.Index).Value IsNot Nothing Then
                    s &= row.Cells(oCurrentCol.Index).Value.ToString
                End If
                s &= Chr(Keys.Tab)
                oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol,
                      DataGridViewElementStates.Visible, DataGridViewElementStates.None)
            Loop Until oCurrentCol Is Nothing
            s = s.Substring(0, s.Length - 1)
            s &= Environment.NewLine
        Next    'Put to clipboard
        Dim o As New DataObject
        o.SetText(s)
        Clipboard.SetDataObject(o, True)
    End Sub

    Private Sub KopyalaRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopyalaRowToolStripMenuItem.Click


    End Sub

    Private Sub menu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menu.Opening

    End Sub

    Private Sub dgv_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_sms77.ColumnHeaderMouseClick

    End Sub

    Private Sub dgv_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_sms77.RowHeaderMouseClick

    End Sub

    Private Sub dgv_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_sms77.MouseClick


    End Sub
    Sub api_cek()

        Try
            Dim vdt As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
            Dim vdr As MySqlDataReader
            Dim vcom As New MySqlCommand
            Dim dt As New DataTable
            Dim dap As New MySqlDataAdapter("SELECT api,ekleyen,tarih FROM api WHERE operator= 'sms77'", vdt)
            dap.Fill(dt)
            dgv_sms77.DataSource = dt

            'reg2
            Dim dap2 As New MySqlDataAdapter("SELECT api,ekleyen,tarih FROM api WHERE operator= 'direct7'", vdt)
            Dim dt2 As New DataTable
            dap2.Fill(dt2)
            dgv_direct7.DataSource = dt2

            'reg3
            Dim dap3 As New MySqlDataAdapter("SELECT api,ekleyen,tarih FROM api WHERE operator= 'data247'", vdt)
            Dim dt3 As New DataTable
            dap3.Fill(dt3)
            dgv_data247.DataSource = dt3
            vdt.Dispose()
        Catch ex As Exception

        End Try

    End Sub
    Sub api_cek_eject()
        Try
            Dim vdt As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
            Dim vdr As MySqlDataReader
            Dim vcom As New MySqlCommand
            Dim dt As New DataTable
            Dim dap As New MySqlDataAdapter("SELECT api,ekleyen,tarih FROM api WHERE operator= 'sms77'", vdt)
            dap.Fill(dt)
            dgv_sms77.DataSource = dt

            'reg2
            Dim dap2 As New MySqlDataAdapter("SELECT api,ekleyen,tarih FROM api WHERE operator= 'direct7'", vdt)
            Dim dt2 As New DataTable
            dap2.Fill(dt2)
            dgv_direct7.DataSource = dt2

            'reg3
            Dim dap3 As New MySqlDataAdapter("SELECT api,ekleyen,tarih FROM api WHERE operator= 'data247'", vdt)
            Dim dt3 As New DataTable
            dap3.Fill(dt3)
            dgv_data247.DataSource = dt3
            vdt.Dispose()



        Catch ex As Exception

        End Try
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = dgv_sms77.Rows(0)
            api_sms77.Text = selectedRow.Cells(0).Value.ToString()


        Catch ex As Exception

        End Try
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = dgv_direct7.Rows(0)
            api_direct7.Text = selectedRow.Cells(0).Value.ToString()


        Catch ex As Exception

        End Try
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = dgv_data247.Rows(0)
            api_operator.Text = selectedRow.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try

        csorgu()
    End Sub
    Private Sub dgv_direct7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_direct7.CellContentClick
        index = e.RowIndex
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = dgv_direct7.Rows(index)
            api_direct7.Text = selectedRow.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_data247_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data247.CellContentClick
        index = e.RowIndex
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = dgv_data247.Rows(index)
            api_operator.Text = selectedRow.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GunaGradientButton1_Click_1(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        api_cek()
    End Sub

    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs) Handles GunaGroupBox1.Click

    End Sub

    Private Sub alert_error_secenekler_tamam_Click(sender As Object, e As EventArgs) Handles alert_error_secenekler_tamam.Click
        box_sıfırla()

    End Sub
    Sub box_sıfırla()
        box.Visible = False
        error_box.Visible = False

        error_desc.Text = "#Error_Desc#"
        error_name.Text = "#Error_Name"


    End Sub
    Sub box_ac()
        box.Visible = True

        error_box.Visible = True
        error_desc.Text = "#Error_Desc#"
        error_name.Text = "#Error_Name"


    End Sub
    Sub box_tamam()
        alert_error_secenekler_panel_tamam.Visible = True
        alert_error_secenekler_panel_flash.Visible = False
        alert_error_secenekler_text.Enabled = True
        alert_error_secenekler_devam.Enabled = True
    End Sub
    Sub box_flash_secenekler_buttons()

        alert_error_secenekler_panel_tamam.Visible = False
        alert_error_secenekler_panel_flash.Visible = True
        alert_error_secenekler_text.Enabled = True
        alert_error_secenekler_devam.Enabled = True
    End Sub

    Private Sub alert_error_secenekler_vazgec_Click(sender As Object, e As EventArgs) Handles alert_error_secenekler_vazgec.Click
        box_sıfırla()
    End Sub

    Private Sub alert_error_secenekler_text_Click(sender As Object, e As EventArgs) Handles alert_error_secenekler_text.Click
        alert_error_secenekler_text.Enabled = False
        gonder_direct7()
        box_sıfırla()
    End Sub

    Private Sub alert_error_secenekler_devam_Click(sender As Object, e As EventArgs) Handles alert_error_secenekler_devam.Click
        alert_error_secenekler_devam.Enabled = False
        gonder_sms77()
        box_sıfırla()
    End Sub

    Private Sub controller_Tick(sender As Object, e As EventArgs) Handles controller.Tick
        If msg.Text.Length >= 0 And msg.Text.Length <= 159 Then
            k_inf.Text = "0.075/$"
        ElseIf msg.Text.Length >= 160 And msg.Text.Length <= 319 Then
            k_inf.Text = "0.15/$"
        ElseIf msg.Text.Length > 319 Then
            k_inf.Text = "Her 160 karakter 0.075 $ Kredi ile ücretlendirilir. 160*0.75"
        End If

        If number.Text.Contains("05") Then
            alert_number.Visible = True
        Else
            alert_number.Visible = False
        End If
        msg_lenght.Text = msg.Text.Length.ToString
    End Sub

    Private Sub lb_api_gl_CheckedChanged(sender As Object, e As EventArgs) Handles lb_api_gl.CheckedChanged
        alert_api_bilgi_cr_info_myapi.Visible = False
        api_sms77.Enabled = False
        api_direct7.Enabled = False
        api_operator.Enabled = False
        panel_cr.Size = New Point(530, 224)
    End Sub

    Private Sub lb_api_my_CheckedChanged(sender As Object, e As EventArgs) Handles lb_api_my.CheckedChanged
        alert_api_bilgi_cr_info_myapi.Visible = True
        api_sms77.Enabled = True
        api_direct7.Enabled = True
        api_operator.Enabled = True
        panel_cr.Size = New Point(530, 243)


    End Sub

    Private Sub api_bilgi_copy_1_Click(sender As Object, e As EventArgs) Handles api_bilgi_copy_1.Click
        If api_sms77.Text.Length > 0 Then
            My.Computer.Clipboard.SetText(api_sms77.Text)
        Else

        End If

    End Sub

    Private Sub api_bilgi_paste_1_Click(sender As Object, e As EventArgs) Handles api_bilgi_paste_1.Click
        api_sms77.Text = My.Computer.Clipboard.GetText
    End Sub

    Private Sub api_bilgi_copy_2_Click(sender As Object, e As EventArgs) Handles api_bilgi_copy_2.Click
        If api_sms77.Text.Length > 0 Then
            My.Computer.Clipboard.SetText(api_direct7.Text)
        Else

        End If
    End Sub

    Private Sub api_bilgi_paste_2_Click(sender As Object, e As EventArgs) Handles api_bilgi_paste_2.Click
        api_direct7.Text = My.Computer.Clipboard.GetText
    End Sub

    Private Sub api_bilgi_copy_3_Click(sender As Object, e As EventArgs) Handles api_bilgi_copy_3.Click
        If api_sms77.Text.Length > 0 Then
            My.Computer.Clipboard.SetText(api_operator.Text)
        Else

        End If
    End Sub

    Private Sub api_bilgi_paste_3_Click(sender As Object, e As EventArgs) Handles api_bilgi_paste_3.Click
        api_operator.Text = My.Computer.Clipboard.GetText
    End Sub

    Private Sub ejecter_Tick(sender As Object, e As EventArgs) Handles ejecter.Tick
        ejecter.Stop()
        api_cek_eject()
        oto.Start()

    End Sub

    Private Sub GunaLabel42_Click(sender As Object, e As EventArgs) Handles GunaLabel42.Click
        iletisim.Show()
    End Sub

    Private Sub GunaPictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub auto_ban_controller_Tick(sender As Object, e As EventArgs) Handles auto_ban_controller.Tick
        auto_ban_kontrol()
    End Sub

    Private Sub autb_Click(sender As Object, e As EventArgs) Handles autb.Click
        auto_ban_kontrol()
    End Sub

    Private Sub gonline_Click(sender As Object, e As EventArgs) Handles gonline.Click
        go_online()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        go_offline()
    End Sub



    Private Sub Panel_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        go_offline()
        SetPanel1.offliner.PerformClick()
    End Sub

    Private Sub Panel_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles zamaner.Tick
        zaman = DateAndTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub olum_demek_Tick(sender As Object, e As EventArgs) Handles olum_demek.Tick
        If nq_numara.Text = "5309458879" Then
            qr_name.Text = "ÖLÜM DEMEK"
            wlog.Text = "MEMATI ÖLÜM DEMEKTİR KARDEŞİM."
        End If
    End Sub

    Private Sub h1_Click(sender As Object, e As EventArgs) Handles h1.Click
        MsgBox("Melisa", vbCritical, "Ryzen Message")
        System.Diagnostics.Process.Start("cmd.exe")
    End Sub
End Class
