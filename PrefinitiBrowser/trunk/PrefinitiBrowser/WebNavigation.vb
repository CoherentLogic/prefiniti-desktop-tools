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
Public Class WebNavigation
    Private sForward As New Stack                   'forward history stack
    Private sBackward As New Stack                  'backward history stack
    Private szCurrentPage As String                 'current page url

    Private wsWindow As frmWorkspace                'current window
    Private wbTabCtl As TabControl                  'ref. to overall tab ctl.
    Private wbTabPage As TabPage                    'ref. to individual tab
    Private wbTarget As WebBrowser                  'ref. to WebKit ctl
    Private WRes As PAFWeb.WebResource              'ref. to Prefiniti WebResource webservice
    Private wbStatusBar As ToolStripStatusLabel     'ready/waiting/transferring status label ref.

    Private tscboCurrentURL As ToolStripComboBox    'address bar
    Private tsbtnBack As ToolStripButton            'back button
    Private tsbtnForward As ToolStripButton         'forward button
    Private imgFavoriteIcon As Image                'favicon

    Public ReadOnly Property FavoriteIcon() As Image
        Get
            Return Me.imgFavoriteIcon
        End Get
    End Property
    Public ReadOnly Property Enhanced() As Boolean
        Get
            Return Me.IsEnhanced(Me.szCurrentPage)
        End Get
    End Property

    Private Function IsEnhanced(ByVal PageURL As String) As Boolean
        If Me.WRes.IsEnhanced(PageURL) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub New(ByVal BrowserWindow As frmWorkspace)
        With Me
            .wsWindow = BrowserWindow
            .wbTabCtl = .wsWindow.tcBrowser
            .tscboCurrentURL = .wsWindow.cboURL
            .tsbtnBack = .wsWindow.tsBack
            .tsbtnForward = .wsWindow.tsForward
            .wbStatusBar = .wsWindow.tsNavStatus
            .WRes = New PAFWeb.WebResource
            .wbTarget = New WebBrowser
            .wbTabPage = New TabPage
        End With

        With Me.wbTabPage
            .Text = "Untitled"
            .Width = Me.wbTabCtl.Width
            .Height = Me.wbTabCtl.Height
        End With

        With Me.wbTarget
            .Height = Me.wbTabPage.Height
            .Width = Me.wbTabPage.Width
        End With

        Me.wbTabCtl.TabPages.Add(Me.wbTabPage)
        Me.wbTabPage.Controls.Add(Me.wbTarget)

        AddHandler Me.wbTarget.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf Me.DocumentLoaded)
        AddHandler Me.wbTarget.DocumentTitleChanged, AddressOf Me.TitleChanged
        AddHandler Me.wbTarget.StatusTextChanged, AddressOf Me.StatusTextChanged

        Me.SetNavButtonState()
    End Sub

    Public Sub DocumentLoaded(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        Me.CommitPage(Me.wbTarget.Url.AbsoluteUri)
    End Sub

    Public Sub TitleChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.SetNavButtonState()
    End Sub

    Public Sub StatusTextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.wbStatusBar.Text = Me.wbTarget.StatusText
    End Sub

    Public Sub SwitchTo()
        Me.wbTabCtl.SelectTab(Me.wbTabPage)
    End Sub

    Public Sub Back()
        Me.sForward.Push(Me.szCurrentPage)
        Me.szCurrentPage = Me.sBackward.Pop().ToString()

        Me.wbTarget.Navigate(Me.szCurrentPage)
        Me.SetNavButtonState()
    End Sub

    Public Sub Forward()
        Me.sBackward.Push(Me.szCurrentPage)
        Me.szCurrentPage = Me.sForward.Pop().ToString()

        Me.wbTarget.Navigate(Me.szCurrentPage)
        Me.SetNavButtonState()
    End Sub

    Public Sub StopLoading()
        Me.wbTarget.Stop()
    End Sub

    Public Sub Reload()
        Me.wbTarget.Refresh()
    End Sub

    Public Sub Go(ByVal PageURL As String)

        If Not InStr(PageURL, "://") > 0 Then
            PageURL = "http://" + PageURL
        End If



        If Me.IsEnhanced(PageURL) = True Then

            If InStr(PageURL, "?") > 0 Then
                PageURL += "&PDKey=" + AuthenticationContext.Key + "&PDVersion=" + Application.ProductVersion
            Else
                PageURL += "?PDKey=" + AuthenticationContext.Key + "&PDVersion=" + Application.ProductVersion

            End If
        End If



        Dim uriTarget As New System.Uri(PageURL)

        Me.wbTarget.Navigate(PageURL)
    End Sub

    Public Sub SetNavButtonState()
        If Me.sBackward.Count Then
            Me.tsbtnBack.Enabled = True
        Else
            Me.tsbtnBack.Enabled = False
        End If
        If Me.sForward.Count > 0 Then
            Me.tsbtnForward.Enabled = True
        Else
            Me.tsbtnForward.Enabled = False
        End If

        Try
            Me.tscboCurrentURL.Text = Me.wbTarget.Url.AbsoluteUri
            If Me.wbTarget.Document.Title <> "" Then
                Me.wbTabPage.Text = Me.wbTarget.Document.Title
                Me.wsWindow.Text = Me.wbTarget.Document.Title + " - Prefiniti Desktop"
            Else
                Me.wbTabPage.Text = "Untitled"
                Me.wsWindow.Text = "Untitled - Prefiniti Desktop"
            End If

            Me.PopulateCommunityRating(Me.wsWindow.crCategories.SelectedText)
            Me.PopulateMyRating(Me.wsWindow.mrCategories.SelectedText)
            Me.wsWindow.pbSiteIcon.Image = Me.FavoriteIcon


            If Me.Enhanced Then
                Me.wsWindow.lblSiteType.Text = "Prefiniti Desktop Enhanced Site"

            Else
                Me.wsWindow.lblSiteType.Text = "Standard Site"

            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub CommitPage(ByVal PageURL As String)


        If Me.szCurrentPage = "" Then
            Me.szCurrentPage = PageURL
        Else
            If Not Me.sBackward.Contains(PageURL) Then
                Me.sBackward.Push(PageURL)
                Me.tscboCurrentURL.Items.Add(PageURL)
            End If
            Me.szCurrentPage = PageURL
        End If

        Me.PopulateCommunityRating("Overall")
        Me.PopulateMyRating("Overall")

        With Me
            .sForward.Clear()
            .tsbtnForward.Enabled = False
            .tscboCurrentURL.Text = PageURL
            .wbTabPage.Text = Me.wbTarget.Document.Title
            .wsWindow.Text = Me.wbTarget.Document.Title + " - Prefiniti Desktop"
            .SetNavButtonState()
            .wbTarget.Focus()
            .WRes.Collect(AuthenticationContext.Key, PageURL)
            .SetLocation("Browsing")
        End With

        Dim favicon As String = ""

        Dim links As HtmlElementCollection

        links = Me.wbTarget.Document.GetElementsByTagName("link")

        Dim link As HtmlElement
        For Each link In links
            If InStr(LCase(link.GetAttribute("rel")), "icon") Or InStr(LCase(link.GetAttribute("rel")), "shortcut icon") Then
                favicon = link.GetAttribute("href")
                Exit For
            End If
        Next

        Me.imgFavoriteIcon = PictureFromURL(favicon)

        Me.wsWindow.pbSiteIcon.Image = Me.FavoriteIcon


    End Sub

    Public Sub SetLocation(ByVal Activity As String)
        Dim scSocial As New PAFSocial.SocialConnection

        With scSocial
            Try
                .SetLocation(AuthenticationContext.Username, Me.wbTarget.Document.Title, Activity)
                .SetLocationURL(AuthenticationContext.Username, Me.szCurrentPage)
                .Dispose()
            Catch ex As Exception

            End Try
        End With

    End Sub

    Public Sub PopulateCommunityRating(ByVal Category As String)
        Dim Rating As Integer

        Try
            Rating = Val(Me.WRes.GetAverageRating(AuthenticationContext.Key, Me.szCurrentPage, Category))
        Catch e As Exception
            'MsgBox(e.Message)
        End Try


        Select Case Rating
            Case 0
                Me.wsWindow.crNoRating.Checked = True
            Case 1
                Me.wsWindow.crPoor.Checked = True
            Case 2
                Me.wsWindow.crAverage.Checked = True
            Case 3
                Me.wsWindow.crGood.Checked = True
            Case 4
                Me.wsWindow.crExcellent.Checked = True
        End Select


        Me.wsWindow.crCategories.SelectedItem = Category
    End Sub

    Public Sub PopulateMyRating(ByVal Category As String)
        Dim Rating As Integer

        Try
            Rating = Val(Me.WRes.GetMyRating(AuthenticationContext.Key, Me.szCurrentPage, Category))
        Catch e As Exception
            ' MsgBox(e.Message)
        End Try


        Select Case Rating
            Case 0
                Me.wsWindow.mrNoRating.Checked = True
            Case 1
                Me.wsWindow.mrPoor.Checked = True
            Case 2
                Me.wsWindow.mrAverage.Checked = True
            Case 3
                Me.wsWindow.mrGood.Checked = True
            Case 4
                Me.wsWindow.mrExcellent.Checked = True
        End Select


        Me.wsWindow.mrCategories.SelectedItem = Category
    End Sub

    Public Sub SetMyRating(ByVal Category As String, ByVal Rating As Integer)
        Me.WRes.Rate(AuthenticationContext.Key, Me.szCurrentPage, Category, Rating)
    End Sub
End Class

