Public Class RelationshipStatus
    Private szRelationshipType As String
    Private uaSignificantOther As UserAccount

    Public Sub New(ByVal RelationshipType As String, ByVal SignificantOther As UserAccount)
        With Me
            .szRelationshipType = RelationshipType
            .uaSignificantOther = SignificantOther
        End With
    End Sub

    Public Overrides Function ToString() As String
        Select Case LCase(Me.szRelationshipType)
            Case "married"
                Return Me.szRelationshipType + " to " + Me.uaSignificantOther.RealName.ToString()
            Case "in a relationship"
                Return Me.szRelationshipType + " with " + Me.uaSignificantOther.RealName.ToString()
            Case "in an open relationship"
                Return Me.szRelationshipType + " with " + Me.uaSignificantOther.RealName.ToString()
            Case "it's complicated"
                Return Me.szRelationshipType + " with " + Me.uaSignificantOther.RealName.ToString()
            Case "divorced"
                Return Me.szRelationshipType
            Case "single"
                Return Me.szRelationshipType
            Case Else
                Return "I'm not telling"
        End Select
    End Function

    Public ReadOnly Property RelationshipType() As String
        Get
            Return Me.szRelationshipType
        End Get
    End Property

    Public ReadOnly Property SignificantOther() As String
        Get
            Return Me.uaSignificantOther.RealName.ToString()
        End Get
    End Property
End Class
