Public Class Footer_Bar
    Dim wuser As String = My.Settings.wuser
    Dim wapi As String = My.Settings.wapi
    Dim wpass As String = My.Settings.wpass
    Dim wcset As String = My.Settings.wcset
    Dim wtype As String = My.Settings.wtype
    Dim wappid As String = My.Settings.w_app_id
    Dim wappversion As String = My.Settings.w_app_version
    Dim wuiversion As String = My.Settings.w_ui_version

    Dim log_set As String = My.Settings.logset
    Dim log_response As String = My.Settings.log_response

    Dim app_id As String = wappid.ToString
    Dim app_version As String = wappversion.ToString
    Dim ui_version As String = wuiversion.ToString
    Private Sub Footer_Bar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        footer_credit.Checked = True
        footer_status.Checked = True

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Footer_grad_status_Paint(sender As Object, e As PaintEventArgs) Handles footer_grad_status.Paint

    End Sub

    Private Sub Auth_api_TextChanged(sender As Object, e As EventArgs) Handles auth_api.TextChanged

    End Sub

    Private Sub Status_controller_Tick(sender As Object, e As EventArgs) Handles status_controller.Tick
        If log_status.Text.Contains("""status"":""S""") Then
            footer_status.CheckedLineColor = Color.Crimson
        Else
            footer_status.CheckedLineColor = Color.SpringGreen
        End If
        If log_set = "read_start" Then
            log_status.Text = log_response
            log_set = "read_stop"
        Else

        End If
        auth_api.Text = wapi.ToString
    End Sub

    Private Sub footer_status_Click(sender As Object, e As EventArgs) Handles footer_status.Click

    End Sub

    Private Sub footer_status_label_Click(sender As Object, e As EventArgs) Handles footer_status_label.Click

    End Sub

    Private Sub footer_credit_Click(sender As Object, e As EventArgs) Handles footer_credit.Click

    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub
End Class
