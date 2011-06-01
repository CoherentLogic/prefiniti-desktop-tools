'
' $Id$
'
Public Class PrefinitiLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Hide()
        AuthenticationContext.Login(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)

        If AuthenticationContext.LoggedIn = False Then
            MessageBox.Show("Invalid username or password. Please log in again.", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.UsernameTextBox.Text = ""
            Me.PasswordTextBox.Text = ""
            Me.UsernameTextBox.Focus()
        Else


            frmWorkspace.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub PrefinitiLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsernameTextBox.Focus()

    End Sub
End Class
