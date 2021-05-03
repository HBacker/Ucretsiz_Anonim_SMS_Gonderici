Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Web
Imports System.Net


Public Class Json_Tester_from_HBR
    Dim baglanti As New MySqlConnection("server=37.59.55.185;userid=5ppHi53t5f;password=1in5T7VSrK;database=5ppHi53t5f;port=;SslMode=None;charset=utf8;")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click



    End Sub

    Sub req()



    End Sub

    Private Sub sorgu()
        Try
            'start RESPONSE
            Dim jsonveri As JObject = JObject.Parse(raw.Text.ToString)

            Dim qad = jsonveri.SelectToken("data").ToString

            Dim jsonveri_result As JObject = JObject.Parse(qad.TrimEnd)

            Dim qad_result = jsonveri_result.SelectToken("balance").ToString
            son.Text = qad_result.Trimend.ToString
        Catch ex As Exception
            exer.Text = ex.Message.ToString
        End Try
    End Sub

    Private Sub data_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub data_KeyDown(sender As Object, e As KeyEventArgs)


    End Sub


    Private Sub data_KeyPress(sender As Object, e As KeyPressEventArgs) Handles data.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            sorgu()
            SendKeys.Send("{BackSpace}")
        Else

        End If
    End Sub

    Private Sub raw_TextChanged(sender As Object, e As EventArgs) Handles raw.TextChanged

    End Sub

    Private Sub raw_KeyDown(sender As Object, e As KeyEventArgs) Handles raw.KeyDown

    End Sub

    Private Sub raw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles raw.KeyPress

    End Sub

    Private Sub data_TextChanged_1(sender As Object, e As EventArgs) Handles data.TextChanged

    End Sub

    Private Sub Json_Tester_from_HBR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub DB()
        Try
            baglanti.Open()
            cmd.Connection = baglanti
            cmd.CommandText = "UPDATE cache_data247 SET kullanım= kullanım - 1 WHERE id='" & "1" & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Başarıyla güncellendi....")
            baglanti.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        DB()
    End Sub
End Class