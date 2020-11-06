Public Class MarquesForm
    Private Sub SelectInfos()
        If DGVMarques.Rows.Count = 0 Then Exit Sub
        txtMarque.Text = DGVMarques.SelectedRows(0).Cells(1).Value
    End Sub

    Private Sub MarquesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVMarques.DataSource = LoadInfos("SELECT * FROM Marques")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtMarque.Text) Then Exit Sub
        AddMarque(String.Format("INSERT INTO Marques(NomMarque) VALUES('{0}')", txtMarque.Text))
        DGVMarques.DataSource = LoadInfos("SELECT * FROM Marques")
        SelectInfos()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtMarque.Text) Then Exit Sub
        If txtMarque.Text = DGVMarques.SelectedRows(0).Cells(1).Value Then Exit Sub
        EditMarque(String.Format("UPDATE Marques SET NomMarque = '{0}' WHERE CodeMarque = {1}", txtMarque.Text, DGVMarques.SelectedRows(0).Cells(0).Value))
        DGVMarques.DataSource = LoadInfos("SELECT * FROM Marques")
        SelectInfos()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DGVMarques.Rows.Count = 0 Then Exit Sub
        If MsgBox("Voulez-vous vraiment supprimer ce marque?", vbYesNo + vbCritical, "Supprimer") = MsgBoxResult.Yes Then
            DeleteMarque("DELETE FROM Marques WHERE CodeMarque = " & DGVMarques.SelectedRows(0).Cells(0).Value)
            DGVMarques.DataSource = LoadInfos("SELECT * FROM Marques")
            SelectInfos()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub DGVMarques_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMarques.CellClick
        SelectInfos()
    End Sub
End Class