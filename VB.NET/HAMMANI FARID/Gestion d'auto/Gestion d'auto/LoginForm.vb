Public Class LoginForm
    Private Sub LoginConfirm()
        If String.IsNullOrWhiteSpace(txtUser.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then Exit Sub
        If LoginAuto(txtUser.Text, txtPassword.Text) Then
            Hide()
            MenuForm.Show()
            txtPassword.Clear()
        Else
            MsgBox("L'utilisateur ou mot de passe est incorrect!", vbOKOnly + vbExclamation, "Attention")
        End If
    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Select()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginConfirm()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginConfirm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then e.Handled = True
    End Sub
End Class
