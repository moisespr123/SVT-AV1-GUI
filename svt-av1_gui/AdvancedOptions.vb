Public Class AdvancedOptions
    Private Sub HME_CheckedChanged(sender As Object, e As EventArgs) Handles HME.CheckedChanged
        My.Settings.HME = HME.Checked
        My.Settings.Save()
    End Sub

    Private Sub HME0_CheckedChanged(sender As Object, e As EventArgs) Handles HME0.CheckedChanged
        My.Settings.HME0 = HME0.Checked
        My.Settings.Save()
    End Sub

    Private Sub HME1_CheckedChanged(sender As Object, e As EventArgs) Handles HME1.CheckedChanged
        My.Settings.HME1 = HME1.Checked
        My.Settings.Save()
    End Sub

    Private Sub HME2_CheckedChanged(sender As Object, e As EventArgs) Handles HME2.CheckedChanged
        My.Settings.HME2 = HME2.Checked
        My.Settings.Save()
    End Sub

    Private Sub OpenGOP_CheckedChanged(sender As Object, e As EventArgs) Handles OpenGOP.CheckedChanged
        My.Settings.OpenGOP = OpenGOP.Checked
        My.Settings.Save()
    End Sub

    Private Sub ClosedGOP_CheckedChanged(sender As Object, e As EventArgs) Handles ClosedGOP.CheckedChanged
        My.Settings.ClosedGOP = ClosedGOP.Checked
        My.Settings.Save()

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
End Class