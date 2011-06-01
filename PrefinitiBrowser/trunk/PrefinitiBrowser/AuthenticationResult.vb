'
' $Id$
'
Public Class AuthenticationResult
    Private bSuccess As Boolean
    Private bFatal As Boolean
    Private szMessage As String

    Public ReadOnly Property Fatal() As Boolean
        Get
            Return Me.bFatal
        End Get
    End Property
    Public ReadOnly Property Success() As Boolean
        Get
            Return Me.bSuccess
        End Get
    End Property

    Public ReadOnly Property Message() As String
        Get
            Return Me.szMessage
        End Get
    End Property
    Public Sub New(ByVal Success As Boolean, ByVal Fatal As Boolean, ByVal Message As String)
        With Me
            .bSuccess = Success
            .bFatal = Fatal
            .szMessage = Message
        End With
    End Sub

End Class
