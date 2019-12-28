Public Class frm_Main
    Private clicks As Integer = 0
    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)

    Private Sub btn_Click_Click(sender As Object, e As EventArgs) Handles btn_Click.Click
        tmr_Delay.Enabled = True
    End Sub

    Private Sub nud_Wait_ValueChanged(sender As Object, e As EventArgs) Handles nud_Wait.ValueChanged
        Dim intNewInterval As Integer = nud_Wait.Value * 1000
        tmr_Delay.Interval = intNewInterval
    End Sub

    Private Sub tmr_Click_Tick(sender As Object, e As EventArgs) Handles tmr_Click.Tick
        mouse_event(&H2, 0, 0, 0, 0)
        mouse_event(&H4, 0, 0, 0, 0)
        If clicks = nud_Click_Count.Value Then
            tmr_Click.Enabled = False
            clicks = 0
        Else
            clicks += 1
        End If

        lbl_Test.Text = intTest
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        tmr_Click.Enabled = False
    End Sub

    Dim intTest As Integer = 0
    Private Sub lbl_Test_Click(sender As Object, e As EventArgs) Handles lbl_Test.Click
        intTest += 1
    End Sub

    Private Sub tmr_Delay_Tick(sender As Object, e As EventArgs) Handles tmr_Delay.Tick
        tmr_Click.Enabled = True
        tmr_Delay.Enabled = False
    End Sub
End Class
