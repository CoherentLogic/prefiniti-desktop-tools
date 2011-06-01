Public Class frmWorkspace
    Public Navigators() As WebNavigation
    Public CurrentNavigator As Integer = 0
    Private NavigatorCount As Integer = 0
    Private HomePage As String = "http://prefiniti15.prefiniti.com/homeres/Home.cfm"


    Private Sub NewTab()
        ReDim Preserve Me.Navigators(Me.NavigatorCount)
        Me.Navigators(Me.NavigatorCount) = New WebNavigation(Me)
        Me.Navigators(Me.NavigatorCount).Go(Me.HomePage)
        Me.Navigators(Me.NavigatorCount).SwitchTo()
        Me.CurrentNavigator = Me.NavigatorCount
        Me.NavigatorCount += 1
    End Sub




    Private Sub cboURL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboURL.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Navigators(CurrentNavigator).Go(Me.cboURL.Text)
        End If
    End Sub

    Private Sub frmWorkspace_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load        
        Me.tsmiUsername.Text = AuthenticationContext.Username
        Me.tsmiLongname.Text = AuthenticationContext.UserAccount.RealName.ToString()
       
        Dim i As UserAccount
        Dim j As New ImageList()

        j.ImageSize = New System.Drawing.Size(48, 48)

        Dim idx As Integer = 0

        Dim lp As New LoginProgress
        lp.pbrLoading.Value = 0
        lp.Show()
        lp.Refresh()

        lp.pbrLoading.Maximum = AuthenticationContext.FriendCount

        For Each i In AuthenticationContext.uaFriends
            lp.lblLoading.Text = "Loading friend picture for " + i.RealName.ToString() + "..."
            lp.pbrLoading.Value = idx
            lp.Refresh()
            Me.lvwFriends.Items.Add(i.UserName, i.RealName.ToString(), idx)
            j.Images.Add(i.Picture)
            idx += 1        
        Next

        Me.lvwFriends.LargeImageList = j
        lp.Dispose()


        NewTab()
    End Sub

    Private Sub tsBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsBack.Click
        Me.Navigators(Me.CurrentNavigator).Back()
    End Sub

    Private Sub tsForward_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsForward.Click
        Me.Navigators(Me.CurrentNavigator).Forward()
    End Sub

    
    Private Sub frmWorkspace_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.tcBrowser.Width = Me.scWorkspace.Panel2.ClientRectangle.Width
        Me.tcBrowser.Height = Me.scWorkspace.Panel2.ClientRectangle.Height

        Me.tcTools.Width = Me.scWorkspace.Panel1.ClientRectangle.Width
        Me.tcTools.Height = Me.scWorkspace.Panel1.ClientRectangle.Height

        Me.tpFriends.Width = Me.tcTools.ClientRectangle.Width
        Me.tpFriends.Height = Me.tcTools.ClientRectangle.Height


        Me.lvwFriends.Width = Me.tpFriends.ClientRectangle.Width
        Me.lvwFriends.Height = Me.tpFriends.ClientRectangle.Height
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        NewWindow()

    End Sub

    Private Sub NewTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTabToolStripMenuItem.Click
        NewTab()
    End Sub

    Private Sub tcBrowser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CurrentNavigator = Me.tcBrowser.SelectedIndex
        Me.Navigators(Me.CurrentNavigator).SetNavButtonState()
        Me.Navigators(Me.CurrentNavigator).SetLocation("Browsing")
    End Sub

    Private Sub tbtxtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbtxtSearch.KeyPress
        Dim searchStr As String

        If Asc(e.KeyChar) = 13 Then
            searchStr = "http://www.google.com/search?q=" + System.Web.HttpUtility.UrlEncode(Me.tbtxtSearch.Text)
            Me.Navigators(Me.CurrentNavigator).Go(searchStr)
        End If
    End Sub

    Private Sub tsmiExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExit.Click
        AuthenticationContext.ExitPrefiniti()
    End Sub

    Private Sub tsbStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbStop.Click
        Me.Navigators(Me.CurrentNavigator).StopLoading()
    End Sub

    Private Sub tsbReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbReload.Click
        Me.Navigators(Me.CurrentNavigator).Reload()
    End Sub


    Private Sub tsmiLocateFriend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLocateFriend.Click

        Dim SocialFriend As ListViewItem
        Dim LocateWindows() As LocateUser
        Dim lwc As Integer = 0

        Dim sc As New PAFSocial.SocialConnection
        Dim uo As New PAFUser.UserResource


        Dim ua As New UserAccount

        For Each SocialFriend In lvwFriends.SelectedItems
            ReDim Preserve LocateWindows(lwc)
            LocateWindows(lwc) = New LocateUser
            ua.Load(SocialFriend.Name)

            With LocateWindows(lwc)
                .lblName.Text = SocialFriend.Text
                .pbUser.Image = ua.Picture
                If uo.IsOnline(SocialFriend.Name) = True Then
                    .lblStatus.Text = "Is currently " + LCase(sc.GetActivity(SocialFriend.Name)) + " on " + sc.GetLocation(SocialFriend.Name) + "."
                    .url = sc.GetLocationURL(SocialFriend.Name)
                    .lblStatus.Text += vbCrLf + vbCrLf + "They have been signed in since " + uo.SigninDate(SocialFriend.Name) + "."
                Else
                    .btnGo.Enabled = False
                    .lblStatus.Text = SocialFriend.Text + " is not currently signed into The Prefiniti Network." + vbCrLf + vbCrLf
                    .lblStatus.Text += SocialFriend.Text + " was last seen " + LCase(sc.GetActivity(SocialFriend.Name)) + " " + sc.GetLocation(SocialFriend.Name) + " on " + uo.LastSeen(SocialFriend.Name) + "."
                End If
            End With

            LocateWindows(lwc).Show()
            lwc += 1
        Next

    End Sub

    Private Sub crCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Navigators(Me.CurrentNavigator).PopulateCommunityRating(Me.crCategories.SelectedItem)

    End Sub

    Private Sub mrCategories_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Navigators(Me.CurrentNavigator).PopulateMyRating(Me.mrCategories.SelectedItem)

    End Sub

    Private Sub mrNoRating_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If mrNoRating.Checked = True Then

        End If
    End Sub

    Private Sub mrPoor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If mrPoor.Checked = True Then
            Me.Navigators(Me.CurrentNavigator).SetMyRating(Me.mrCategories.SelectedText, 1)
            Me.Navigators(Me.CurrentNavigator).PopulateCommunityRating(Me.crCategories.SelectedText)
        End If

    End Sub

    Private Sub mrAverage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If mrAverage.Checked = True Then
            Me.Navigators(Me.CurrentNavigator).SetMyRating(Me.mrCategories.SelectedText, 2)
            Me.Navigators(Me.CurrentNavigator).PopulateCommunityRating(Me.crCategories.SelectedText)
        End If

    End Sub

    Private Sub mrGood_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If mrGood.Checked = True Then
            Me.Navigators(Me.CurrentNavigator).SetMyRating(Me.mrCategories.SelectedText, 3)
            Me.Navigators(Me.CurrentNavigator).PopulateCommunityRating(Me.crCategories.SelectedText)
        End If

    End Sub

    Private Sub mrExcellent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If mrExcellent.Checked = True Then
            Me.Navigators(Me.CurrentNavigator).SetMyRating(Me.mrCategories.SelectedText, 4)
            Me.Navigators(Me.CurrentNavigator).PopulateCommunityRating(Me.crCategories.SelectedText)
        End If

    End Sub
End Class