Option Explicit On
Imports System.ComponentModel.Component
Imports System.IO
Imports System.Collections
Imports System.Management
Imports MySql.Data.MySqlClient

Public Class SetPanel
    Dim durum As String = "katıldı"
    Dim zaman As String
    Dim flood As String

    Dim WindowsApplication1 As System.STAThreadAttribute()

    Private Sub SetPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Controller_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub gonder_Click(sender As Object, e As EventArgs) Handles gonder.Click

        If mesaj.Text = "Mesajınız..." Then
            MsgBox("Mesaj giriniz.")
            mesaj.Text = ""

        ElseIf mesaj.Text = "" Then
            MsgBox("Mesaj giriniz... alan boş!}")
        Else
            If mesaj.Text = flood Then
                MsgBox("Flood/Spam Yapmayınız!")
                mesaj.Text = ""
            Else
                gonder.Text = "3"
                gonder.Enabled = False
                mesaj_gonder()
                w1.Start()
            End If

        End If


    End Sub
    Sub ayrıl()


        w1.Stop()
        gonder.Enabled = False
        Akış_Yenile.Stop()
        winout.Stop()

    End Sub
    Sub katıl()

        Panel.autb.PerformClick()
        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim vcom As New MySqlCommand
        Try
            veritabanı.Open()
            vcom.Connection = veritabanı
            vcom.CommandText = "UPDATE kullanıcılar SET chat_status= 'in' WHERE nick= '" & Panel.username.Text & "'"
            vcom.ExecuteNonQuery()
            veritabanı.Dispose()

        Catch ex As Exception

        End Try
        Panel.kredici.Stop()
        akış.Enabled = True
        mesaj.Enabled = True
        in_out.Enabled = True
        button_katıl.Enabled = False
        button_ayrıl.Enabled = True
        bağlan()
        chat_join()
    End Sub
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles button_katıl.Click
        pload()
        Timer1.Start()


    End Sub
    Sub bağlan()

        Akış_Yenile.Start()
        winout.Start()
        gonder.Enabled = True


        yenile()

    End Sub
    Sub mesaj_gonder()

        Dim sunucu As New Net.WebClient
        Dim result As String
        Try

            sunucu.Credentials = New Net.NetworkCredential("3391146_chat", "ftp.hbr1780+")
            result = sunucu.DownloadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/server1-chat.txt")
            sunucu.UploadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/server1-chat.txt", result.ToString + vbNewLine + zaman.ToString + Panel.username.Text + " >> " + mesaj.Text)


        Catch ex As Exception
            MsgBox("Gönderilemedi")
        End Try
        sunucu.Dispose()
        If mesaj.Text.Contains("Selamun") Or mesaj.Text.Contains("Selamün") Or mesaj.Text.Contains("selamun") Or mesaj.Text.Contains("selamün") Then
            Try
                Dim sunucu_bot As New Net.WebClient
                sunucu_bot.Credentials = New Net.NetworkCredential("3391146_chat", "ftp.hbr1780+")
                Dim result_bot As String = sunucu_bot.DownloadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/server1-chat.txt")


                sunucu_bot.UploadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/server1-chat.txt", result_bot.ToString + vbNewLine + zaman.ToString + " BOT" + " >> " + "Aleyküm Selam! " + "@" + Panel.username.Text)

            Catch ex As Exception

            End Try
        Else

        End If
        If mesaj.Text.Contains("sikerim") Or mesaj.Text.Contains("sikeyim") Or mesaj.Text.Contains("ananı s") Or mesaj.Text.Contains("Ananı S") Or mesaj.Text.Contains("orosbu") Or mesaj.Text.Contains("Orosbu") Or mesaj.Text.Contains("orospu") Or mesaj.Text.Contains("Orospu") Or mesaj.Text.Contains("Piç") Or mesaj.Text.Contains("piç") Then
            Dim sunucu_bot As New Net.WebClient
            sunucu_bot.Credentials = New Net.NetworkCredential("3391146_chat", "ftp.hbr1780+")
            Dim result_bot As String = sunucu_bot.DownloadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/server1-chat.txt")


            sunucu_bot.UploadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/server1-chat.txt", result_bot.ToString + vbNewLine + zaman.ToString + " BOT" + " >> " + "@" + Panel.username.Text + " küfür yasak! tekrarlandığı takdirde durum yöneticiye bildirilecektir!")
        Else


        End If
        akış.SelectionStart = Len(akış.Text)

        akış.ScrollToCaret()
        flood = mesaj.Text
        mesaj.Text = ""

    End Sub
    Private Sub Akış_Yenile_Tick(sender As Object, e As EventArgs) Handles Akış_Yenile.Tick
        yenile()

    End Sub
    Sub yenile()

        Dim sunucu As New Net.WebClient
        Try

            sunucu.Credentials = New Net.NetworkCredential("3391146_chat", "ftp.hbr1780+")
            Dim result As String = sunucu.DownloadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/server1-chat.txt")
            akış.Text = result.ToString + "
"

        Catch ex As Exception

        End Try
        sunucu.Dispose()

        If Panel.TextBox1.Text = "chat" Then
        Else
            chat_left()

        End If

        akış.SelectionStart = Len(akış.Text)

        akış.ScrollToCaret()
    End Sub
    Sub chat_join()
        nowtime.Start()
        If durum = "ayrıldı" Then

            Dim sunucu As New Net.WebClient
            Try

                sunucu.Credentials = New Net.NetworkCredential("3391146_chat", "ftp.hbr1780+")
                Dim result As String = sunucu.DownloadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/in_out.txt")
                sunucu.UploadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/in_out.txt", in_out.Text + vbNewLine + zaman.ToString + Panel.username.Text + " >> " + "# Chat'e katıldı. #")


            Catch ex As Exception

            End Try
            sunucu.Dispose()
        Else

        End If
        durum = "katıldı"

        Dim sunucu2 As New Net.WebClient
        Try

            sunucu2.Credentials = New Net.NetworkCredential("3391146_chat", "ftp.hbr1780+")
            Dim result2 As String = sunucu2.DownloadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/in_out.txt")
            in_out.Text = result2.ToString

        Catch ex As Exception

        End Try
        sunucu2.Dispose()

        in_out.SelectionStart = Len(in_out.Text)

        in_out.ScrollToCaret()



    End Sub
    Sub chat_left()
        nowtime.Stop()

        If durum = "katıldı" Then
            Dim zaman As String = " {" + DateTime.Now + "}  "
            Dim sunucu As New Net.WebClient
            Try

                sunucu.Credentials = New Net.NetworkCredential("3391146_chat", "ftp.hbr1780+")
                Dim result As String = sunucu.DownloadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/in_out.txt")
                sunucu.UploadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/in_out.txt", in_out.Text + vbNewLine + zaman.ToString + Panel.username.Text + " >> " + "# Chat'ten ayrıldı. #")


            Catch ex As Exception

            End Try
            sunucu.Dispose()
        Else

        End If
        durum = "ayrıldı"
        Dim zaman2 As String = DateTime.Now
        Dim sunucu2 As New Net.WebClient
        Try

            sunucu2.Credentials = New Net.NetworkCredential("3391146_chat", "ftp.hbr1780+")
            Dim result2 As String = sunucu2.DownloadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/in_out.txt")
            in_out.Text = result2.ToString

        Catch ex As Exception

        End Try
        sunucu2.Dispose()

        in_out.SelectionStart = Len(in_out.Text)

        in_out.ScrollToCaret()

    End Sub


    Private Sub w1_Tick(sender As Object, e As EventArgs) Handles w1.Tick

        gonder.Text = gonder.Text - 1
        If gonder.Text = "-1" Or gonder.Text = "0" Then
            gonder.Enabled = True
            gonder.Text = "Gönder"
            w1.Stop()
        Else
            w1.Start()
        End If

    End Sub
    Sub offline()
        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim vcom As New MySqlCommand
        Try
            veritabanı.Open()
            vcom.Connection = veritabanı
            vcom.CommandText = "UPDATE kullanıcılar SET chat_status= 'out' WHERE nick= '" & Panel.username.Text & "'"
            vcom.ExecuteNonQuery()
            veritabanı.Dispose()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles button_ayrıl.Click
        offline()

        Panel.kredici.Start()
        akış.Enabled = False

        in_out.Enabled = False
        mesaj.Enabled = False
        button_katıl.Enabled = True
        button_ayrıl.Enabled = False
        ayrıl()
        chat_left()
    End Sub

    Private Sub winout_Tick(sender As Object, e As EventArgs) Handles winout.Tick
        Try
            Dim sunucu As New Net.WebClient

            sunucu.Credentials = New Net.NetworkCredential("3391146_chat", "ftp.hbr1780+")
            Dim input_output As String = sunucu.DownloadString("ftp://hbacker.atwebpages.com/hbacker.atwebpages.com/w/DONT_UPLOAD_HERE/in_out.txt")
            in_out.Text = input_output.ToString
        Catch ex As Exception

        End Try

        in_out.SelectionStart = Len(in_out.Text)

        in_out.ScrollToCaret()

    End Sub

    Private Sub lock_controls_Tick(sender As Object, e As EventArgs) Handles lock_controls.Tick

    End Sub

    Private Sub GunaGradientButton1_Click_1(sender As Object, e As EventArgs) Handles button_katıl.Click

    End Sub

    Private Sub nowtime_Tick(sender As Object, e As EventArgs) Handles nowtime.Tick
        zaman = " {" + DateTime.Now.ToString + "}  "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
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
        Return DriveSerial.ToString("X2")

    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles offliner.Click
        offline()
    End Sub

    Private Sub GunaGradientButton1_Click_2(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        upanel.Visible = True
        Timer2.Start()
        pload()

        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim vcom As New MySqlCommand
        Dim vr As MySqlDataReader

        Try
            veritabanı.Open()

            vcom.Connection = veritabanı
            vcom.CommandText = "SELECT * FROM kullanıcılar WHERE chat_status = 'in'"
            vcom.ExecuteNonQuery()
            vr = vcom.ExecuteReader
            in_user_list.Items.Clear()

            While vr.Read
                in_user_list.Items.Add(vr("nick"))
            End While
            veritabanı.Dispose()

        Catch ex As Exception

        End Try
        Dim veritabanıx As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim vcomx As New MySqlCommand
        Dim vrx As MySqlDataReader

        Try
            veritabanıx.Open()

            vcomx.Connection = veritabanıx
            vcomx.CommandText = "SELECT COUNT(*)FROM kullanıcılar WHERE chat_status LIKE 'in'"
            vcomx.ExecuteNonQuery()
            vrx = vcomx.ExecuteReader


            While vrx.Read
                in_chat_total.Text = (vrx.GetString(0)).ToString
            End While
            veritabanı.Dispose()

        Catch ex As Exception
            in_chat_total.Text = "Hata yeri: Ex.chat_SP-gctu"
        End Try

    End Sub

    Sub pload()
        loader.Visible = True
        tload.Start()
    End Sub

    Private Sub tload_Tick(sender As Object, e As EventArgs) Handles tload.Tick
        loader.Visible = False
        tload.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        katıl()


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim veritabanı As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim vcom As New MySqlCommand
        Dim vr As MySqlDataReader

        Try
            in_user_list.Items.Clear()
            veritabanı.Open()

            vcom.Connection = veritabanı
            vcom.CommandText = "SELECT * FROM kullanıcılar WHERE chat_status = 'in'"
            vr = vcom.ExecuteReader

            While vr.Read
                in_user_list.Items.Add(vr("nick"))
            End While
            veritabanı.Dispose()

        Catch ex As Exception

        End Try

        Dim veritabanıx As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=firesql;port=3306;SslMode=None;charset=utf8;")
        Dim vcomx As New MySqlCommand
        Dim vrx As MySqlDataReader

        Try
            veritabanıx.Open()

            vcomx.Connection = veritabanıx
            vcomx.CommandText = "SELECT COUNT(*)FROM kullanıcılar WHERE chat_status LIKE 'in'"
            vcomx.ExecuteNonQuery()
            vrx = vcomx.ExecuteReader


            While vrx.Read
                in_chat_total.Text = (vrx.GetString(0)).ToString
            End While
            veritabanı.Dispose()

        Catch ex As Exception
            in_chat_total.Text = "Hata yeri: Ex.chat_SP-gctu"
        End Try
    End Sub

    Private Sub header_kapat_Click(sender As Object, e As EventArgs) Handles header_kapat.Click
        Timer2.Stop()
        upanel.Visible = False
    End Sub

    Private Sub GunaGradientButton2_Click_1(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click

    End Sub
End Class
