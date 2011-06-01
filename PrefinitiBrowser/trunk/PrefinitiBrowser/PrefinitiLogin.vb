'
' $Id$
'
Public Class PrefinitiLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Hide()
        Dim result As AuthenticationResult

        result = AuthenticationContext.Login(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)

        If result.Success = False Then
            MessageBox.Show(result.Message, "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If result.Fatal = False Then
                Me.UsernameTextBox.Text = ""
                Me.PasswordTextBox.Text = ""
                Me.UsernameTextBox.Focus()
            Else
                End
            End If
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
