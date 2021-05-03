Public Class Api_List
    Dim wapi As String = My.Settings.wapi
    Private Sub Header_kapat_Click(sender As Object, e As EventArgs) Handles header_kapat.Click
        panel_api_list.Visible = False
    End Sub

    Private Sub Api_options_Click(sender As Object, e As EventArgs) Handles api_options.Click
        panel_api_list.Visible = True
    End Sub

    Private Sub Panel_api_list_Click(sender As Object, e As EventArgs) Handles panel_api_list.Click

    End Sub

    Private Sub Api_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_list.SelectedItem = "10 Dakika"
    End Sub
    Sub Save()
        My.Settings.Save()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        wapi = ListBox1.SelectedIndex.ToString
        Save()
    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged

        wapi = ListBox1.SelectedIndex.ToString
        Save()
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        wapi = ListBox1.SelectedIndex.ToString
        wapi = ListBox1.SelectedItem.ToString
        Save()
    End Sub

    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs) Handles GunaGroupBox1.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click

    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub tht_1_Click(sender As Object, e As EventArgs) Handles tht_1.Click

    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub update_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles update_list.SelectedIndexChanged

    End Sub

    Private Sub GunaLabel6_Click(sender As Object, e As EventArgs) Handles GunaLabel6.Click

    End Sub

    Private Sub w_list_CheckedChanged(sender As Object, e As EventArgs) Handles w_list.CheckedChanged

    End Sub

    Private Sub thtusers_list_CheckedChanged(sender As Object, e As EventArgs) Handles thtusers_list.CheckedChanged

    End Sub

    Private Sub hbacker_list_CheckedChanged(sender As Object, e As EventArgs) Handles hbacker_list.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
