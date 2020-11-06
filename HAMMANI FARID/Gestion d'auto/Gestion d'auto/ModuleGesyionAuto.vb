Imports System.Data.OleDb
Module ModuleGesyionAuto
    Public Con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\farid\Desktop\HAMMANI FARID\GestionAuto.accdb")
    Public Cmd As OleDbCommand
    Public Da As OleDbDataAdapter
    Public Dt As New DataTable

    Public Function LoginAuto(ByVal User As String, ByVal Password As Integer) As Boolean
        Dt = New DataTable
        Da = New OleDbDataAdapter(String.Format("SELECT * FROM Utilisateur WHERE [Nom Utilisateur]='{0}' AND [Mot De Passe]={1}", User, Password), Con)
        Da.Fill(Dt)
        If Dt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function LoadInfos(ByVal Str As String) As DataTable
        Dt = New DataTable
        Da = New OleDbDataAdapter(Str, Con)
        Da.Fill(Dt)
        Return Dt
    End Function

    Public Sub LoadCombo(ByVal Str As String, ByVal CB As ComboBox, ByVal Champ1 As String, ByVal Champ2 As String)
        Dt = New DataTable
        Da = New OleDbDataAdapter(Str, Con)
        Da.Fill(Dt)
        CB.DataSource = Dt
        CB.DisplayMember = Champ1
        CB.ValueMember = Champ2
    End Sub

    Public Sub AddVéhicule(ByVal Str As String)
        Cmd = New OleDbCommand(Str, Con)
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("Véhicule a été Ajouter avec succéss!", vbOKOnly + vbInformation, "Ajouter")
    End Sub

    Public Sub EditVéhicule(ByVal Str As String)
        Cmd = New OleDbCommand(Str, Con)
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("Véhicule a été Modifier avec succéss!", vbOKOnly + vbInformation, "Modifier")
    End Sub

    Public Sub DeleteVéhicule(ByVal Str As String)
        Cmd = New OleDbCommand(Str, Con)
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("Véhicule a été supprimer avec succéss!", vbOKOnly + vbInformation, "Supprimer")
    End Sub

    Public Sub AddMarque(ByVal Str As String)
        Cmd = New OleDbCommand(Str, Con)
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("Marque a été Ajouter avec succéss!", vbOKOnly + vbInformation, "Ajouter")
    End Sub

    Public Sub EditMarque(ByVal Str As String)
        Cmd = New OleDbCommand(Str, Con)
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("Marque a été Modifier avec succéss!", vbOKOnly + vbInformation, "Modifier")
    End Sub

    Public Sub DeleteMarque(ByVal Str As String)
        Cmd = New OleDbCommand(Str, Con)
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("Marque a été supprimer avec succéss!", vbOKOnly + vbInformation, "Supprimer")
    End Sub
End Module
