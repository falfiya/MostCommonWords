Public Class frmMain
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim x = New frmResults
        x.Show()
        x.giveMeTheBlood(txtBox.Text)
    End Sub
End Class
