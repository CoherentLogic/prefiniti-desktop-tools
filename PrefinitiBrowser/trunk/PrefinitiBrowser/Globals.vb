'
' $Id$
'
Imports System.IO
Imports System.Net
Imports System.Text

Module Globals
    Public AuthenticationContext As Auth = New Auth
    Public BrowserWindows() As frmWorkspace
    Public CurrentBrowserWindow As frmWorkspace
    Public BrowserWindowCount As Integer = 1

    Public Sub NewWindow()
        Dim nWin As New frmWorkspace
        nWin.Show()
    End Sub

    Public Function PictureFromURL(ByVal PageURL As String) As Image

        Dim objImage As MemoryStream
        Dim objwebClient As WebClient
        Dim sURL As String = Trim(PageURL)
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
    End Function
End Module
