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
