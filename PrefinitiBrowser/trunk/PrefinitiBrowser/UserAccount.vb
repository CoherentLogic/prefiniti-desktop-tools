'
' $Id$
'
Imports System.IO
Imports System.Net
Imports System.Text

Public Class UserAccount
    Private szUsername As String
    Private szPasswordHash As String
    Private szEMail As String
    Private pnRealName As PersonName
    Private szSMSNumber As String
    Private szPictureURL As String
    Private bAccountEnabled As Boolean
    Private szGender As String
    Private dtBirthday As Date
    Private bSearchAllowed As Boolean
    Private szORMSID As String
    Private lDatabaseID As Long
    Private szZipCode As String
    Private UserResourceObject As Object
    Private rsRelationshipStatus As RelationshipStatus

    Public Function Load(ByVal UserName As String) As Boolean

        Dim UserWebService As New PAFUser.UserResource
        Dim Kword As String
        Dim Kvalue As String

        Dim tmpFirst As String = ""
        Dim tmpMiddle As String = ""
        Dim tmpLast As String = ""
        Dim tmpRelStat As String = ""
        Dim tmpSOID As Long = 0

        Me.UserResourceObject = UserWebService.Load(UserName)

        For Each i In Me.UserResourceObject
            Kword = RTrim(Left(i, 20))
            Kvalue = Trim(Mid(i, 21))

            Select Case Kword
                Case "id"
                    Me.lDatabaseID = Val(Kvalue)
                Case "username"
                    Me.szUsername = Kvalue
                Case "password"
                    Me.szPasswordHash = Kvalue
                Case "email"
                    Me.szEMail = Kvalue
                Case "smsnumber"
                    Me.szSMSNumber = Kvalue
                Case "picture"
                    Me.szPictureURL = Kvalue
                Case "accountenabled"
                    If Kvalue = 0 Then
                        Me.bAccountEnabled = False
                    Else
                        Me.bAccountEnabled = True
                    End If
                Case "gender"
                    Me.szGender = Kvalue
                Case "firstname"
                    tmpFirst = Kvalue
                Case "lastname"
                    tmpLast = Kvalue
                Case "middleinitial"
                    tmpMiddle = Kvalue
                Case "allowsearch"
                    If Kvalue = 0 Then
                        Me.bSearchAllowed = False
                    Else
                        Me.bSearchAllowed = True
                    End If
                Case "birthday"
                    Me.dtBirthday = CDate(Kvalue)
                Case "relationshipstatus"
                    tmpRelStat = Kvalue
                Case "soid"
                    tmpSOID = Val(Kvalue)
                Case "zipcode"
                    Me.szZipCode = Kvalue
            End Select

        Next

        Me.pnRealName = New PersonName(tmpFirst, tmpMiddle, tmpLast)

    End Function

    Public ReadOnly Property UserID() As Long
        Get
            Return Me.lDatabaseID
        End Get
    End Property

    Public ReadOnly Property UserName() As String
        Get
            Return Me.szUsername
        End Get
    End Property
    Public ReadOnly Property SMSNumber() As String
        Get
            Return Me.szSMSNumber
        End Get
    End Property

    Public ReadOnly Property Enabled() As Boolean
        Get
            Return Me.bAccountEnabled        
        End Get
    End Property

    Public ReadOnly Property SearchAllowed() As Boolean
        Get
            Return Me.bSearchAllowed
        End Get
    End Property

    Public ReadOnly Property Birthday() As Date
        Get
            Return Me.dtBirthday
        End Get
    End Property

    Public ReadOnly Property ZIPCode() As String
        Get
            Return Me.szZipCode
        End Get
    End Property

    Public ReadOnly Property Gender() As String
        Get
            Return Me.szGender
        End Get
    End Property
    Public ReadOnly Property Picture() As Image
        Get
            Dim objImage As MemoryStream
            Dim objwebClient As WebClient
            Dim sURL As String = Trim(Me.szPictureURL)
            Dim bAns As Boolean
            Dim tmpImage As Image

            Try
                If Not sURL.ToLower().StartsWith("http://") Then
                    sURL = "http://" & sURL
                End If

                objwebClient = New WebClient()


                objImage = New MemoryStream(objwebClient.DownloadData(sURL))
                tmpImage = Image.FromStream(objImage)
                bAns = True
            Catch ex As Exception

                tmpImage = My.Resources.file_broken
            End Try

            Return tmpImage
        End Get
    End Property

    Public Property RealName() As PersonName
        Get
            Return Me.pnRealName
        End Get
        Set(ByVal value As PersonName)
            Me.pnRealName = value
        End Set
    End Property


End Class
