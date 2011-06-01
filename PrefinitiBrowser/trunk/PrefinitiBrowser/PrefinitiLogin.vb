'
' $Id$
'
' 
' Copyright (C) 2011 John Willis
' 
' This file is part of Prefiniti.

' Prefiniti is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.

' Prefiniti is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License
' along with Prefiniti.  If not, see <http://www.gnu.org/licenses/>.
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
