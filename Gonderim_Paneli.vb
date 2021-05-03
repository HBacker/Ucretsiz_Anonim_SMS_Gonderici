Imports System.Windows.Forms.Form
Public Class Gonderim_Paneli
    Inherits UserControl
    Dim wuser As String = My.Settings.wuser
    Dim wapi As String = My.Settings.wapi
    Dim wpass As String = My.Settings.wpass

    Dim log_set As String = My.Settings.logset
    Dim log_response As String = My.Settings.log_response

    Dim wcset As String
    Dim wtype As String = "T"

    Dim wappid As String = My.Settings.w_app_id
    Dim wappversion As String = My.Settings.w_app_version
    Dim wuiversion As String = My.Settings.w_ui_version

    Dim app_id As String = wappid.ToString
    Dim app_version As String = wappversion.ToString
    Dim ui_version As String = wuiversion.ToString


    Private Sub Gonderim_Paneli_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function Gönder_smsAla()
        Dim oauthAPI = wapi.ToString
        Dim authKey = wpass
        Dim type = wtype.ToString
        Dim cset = wcset.ToString
        Dim sender = "TSTALA"
        Dim message = mesaj.Text
        Dim numbers = teltext.Text
        Dim strGet As String
        Dim url As String = "http://api.smsala.com/api/SendSMS?"

        strGet = url + "api_id=" + oauthAPI _
        + "&api_password=" + authKey _
        + "&sms_type=" + type _
        + "&encoding=" + "" _
        + "&sender_id=" + sender _
        + "&phonenumber=" + numbers _
        + "&textmessage=" + message

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)
        log_response = result.ToString
        log_set = "read_start"
        Return result
    End Function

    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs) Handles GunaGroupBox1.Click

    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

    End Sub
    Sub Save()
        My.Settings.Save()
    End Sub

    Private Sub thtusers_list_CheckedChanged(sender As Object, e As EventArgs) Handles c_engflash.CheckedChanged
        wcset = "FS"
        Save()
    End Sub

    Private Sub w_list_CheckedChanged(sender As Object, e As EventArgs) Handles c_eng.CheckedChanged
        wcset = "T"
        Save()
    End Sub

    Private Sub hbacker_list_CheckedChanged(sender As Object, e As EventArgs) Handles c_tr.CheckedChanged
        wcset = "U"
        Save()
    End Sub

    Private Sub GunaRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles c_trflash.CheckedChanged
        wcset = "UFS"
        Save()
    End Sub

    Private Sub api_options_Click(sender As Object, e As EventArgs) Handles SendReq.Click

    End Sub

    Private Sub mesaj_TextChanged(sender As Object, e As EventArgs) Handles mesaj.TextChanged

    End Sub

    Private Sub numtext_TextChanged(sender As Object, e As EventArgs) Handles numtext.TextChanged

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click

    End Sub

    Private Sub GunaLabel6_Click(sender As Object, e As EventArgs) Handles GunaLabel6.Click

    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub teltext_Click(sender As Object, e As EventArgs) Handles teltext.Click

    End Sub

    Private Sub NewSMS_Click(sender As Object, e As EventArgs) Handles NewSMS.Click
        Reset()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click

    End Sub

    Private Sub h1_Click(sender As Object, e As EventArgs) Handles h1.Click

    End Sub
End Class
