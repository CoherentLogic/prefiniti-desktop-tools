Public Class PersonName
    Private szFirstName As String
    Private szMiddleInitial As String
    Private szLastName As String
    Private szNickname As String

    Public Sub New(ByVal FirstName As String, ByVal MiddleInitial As String, ByVal LastName As String)
        With Me
            .szFirstName = FirstName
            .szMiddleInitial = MiddleInitial
            .szLastName = LastName
        End With
    End Sub

    Public Sub New(ByVal FirstName As String, ByVal LastName As String)
        With Me
            .szFirstName = FirstName
            .szLastName = LastName
        End With
    End Sub

    Public Overrides Function ToString() As String
        If Me.szMiddleInitial.Length > 0 Then
            Return Me.szFirstName + " " + Me.szMiddleInitial + ". " + Me.szLastName
        Else
            Return Me.szFirstName + " " + Me.szLastName
        End If
    End Function

    Public ReadOnly Property FirstName() As String
        Get
            Return Me.szFirstName
        End Get
    End Property

    Public ReadOnly Property LastName() As String
        Get
            Return Me.szLastName
        End Get
    End Property

    Public ReadOnly Property MiddleInitial() As String
        Get
            Return Me.szMiddleInitial
        End Get
    End Property
End Class
