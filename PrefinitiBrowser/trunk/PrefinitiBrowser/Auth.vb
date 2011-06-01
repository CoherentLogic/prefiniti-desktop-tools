'
' $Id$
'
Public Class Auth
    Private ws As New PAFAuth.Authentication
    Private uaActiveUser As UserAccount

    Private szUsername As String
    Private szKey As String = "0"
    Private bLoggedIn As Boolean

    Public uaFriends() As UserAccount
    Private nFriendCount As Integer = 0

    Public ReadOnly Property FriendCount()
        Get
            Return Me.nFriendCount + 1
        End Get
    End Property

    Public ReadOnly Property Key() As String
        Get
            Return Me.szKey
        End Get
    End Property

    Public ReadOnly Property UserAccount() As UserAccount
        Get
            Return Me.uaActiveUser
        End Get
    End Property

    Public ReadOnly Property LoggedIn() As Boolean
        Get
            Return Me.bLoggedIn
        End Get
    End Property

    Public ReadOnly Property Username() As String
        Get
            Return Me.szUsername
        End Get
    End Property

    Public Function ValidateToken() As Boolean

    End Function

    Public Function Login(ByVal Username As String, ByVal Password As String) As Boolean

        Dim progWin As New LoginProgress
        Dim fc As Integer


        Me.szKey = Me.ws.GetKey(Username, Password)
        Me.szUsername = Username

        fc = Me.GetFriendCount()

        progWin.pbrLoading.Maximum = fc
        progWin.Show()
        progWin.Refresh()




        If Me.Key <> "0" Then
            Me.bLoggedIn = True
            Me.uaActiveUser = New UserAccount()
            Me.uaActiveUser.Load(Username)
            Me.LoadFriends(progWin)
            progWin.Dispose()

            Return True
        Else
            Me.bLoggedIn = False
            Return False
        End If

    End Function

    Public Sub ExitPrefiniti()
        Me.ws.Logout(Me.szKey)
        End
    End Sub

    Private Sub LoadFriends(ByVal ProgressWindow As LoginProgress)
        Dim wsSocial As PAFSocial.SocialConnection
        Dim fo As Object
        Dim i As Object


        wsSocial = New PAFSocial.SocialConnection
        fo = wsSocial.GetFriends(Me.Username)

        For Each i In fo
            ReDim Preserve Me.uaFriends(Me.nFriendCount)
            Me.uaFriends(Me.nFriendCount) = New UserAccount
            Me.uaFriends(Me.nFriendCount).Load(i)
            ProgressWindow.pbrLoading.Value = Me.nFriendCount
            ProgressWindow.lblLoading.Text = "Loading " + Me.uaFriends(Me.nFriendCount).RealName.ToString() + "..."
            Me.nFriendCount += 1
            ProgressWindow.Refresh()
        Next


    End Sub

    Private Function GetFriendCount() As Integer
        Dim wsSocial As New PAFSocial.SocialConnection

        Return wsSocial.GetFriendCount(Me.Username)
    End Function

End Class
