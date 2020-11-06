Public Class MenuForm
    Private Sub MarquesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarquesToolStripMenuItem.Click
        MarquesForm.ShowDialog()
    End Sub

    Private Sub VéhiculesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VéhiculesToolStripMenuItem.Click
        VéhiculesForm.ShowDialog()
    End Sub

    Private Sub StatistiquesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatistiquesToolStripMenuItem.Click
        StatistiquesForm.ShowDialog()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Close()
        LoginForm.Show()
    End Sub
End Class