<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkspace
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkspace))
        Me.tsNavigate = New System.Windows.Forms.ToolStrip
        Me.tsBack = New System.Windows.Forms.ToolStripButton
        Me.tsForward = New System.Windows.Forms.ToolStripButton
        Me.tsbStop = New System.Windows.Forms.ToolStripButton
        Me.tsbReload = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbFavorite = New System.Windows.Forms.ToolStripButton
        Me.cboURL = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbDiscuss = New System.Windows.Forms.ToolStripButton
        Me.tsbChat = New System.Windows.Forms.ToolStripButton
        Me.tsbShare = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tbtxtSearch = New System.Windows.Forms.ToolStripTextBox
        Me.cmsFriend = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiViewProfile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmiLocateFriend = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiChatFriend = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiSharePageWithFriend = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiMail = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmiBlockFriend = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiReportUser = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDeleteFriend = New System.Windows.Forms.ToolStripMenuItem
        Me.msMain = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookmarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrefinitiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SocialWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ThisSiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllChatRoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ThisSiteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AllForumsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.scWorkspace = New System.Windows.Forms.SplitContainer
        Me.tcTools = New System.Windows.Forms.TabControl
        Me.tpCurrentPage = New System.Windows.Forms.TabPage
        Me.lblSiteType = New System.Windows.Forms.Label
        Me.pbSiteIcon = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mrCategories = New System.Windows.Forms.ComboBox
        Me.mrNoRating = New System.Windows.Forms.RadioButton
        Me.mrExcellent = New System.Windows.Forms.RadioButton
        Me.mrGood = New System.Windows.Forms.RadioButton
        Me.mrAverage = New System.Windows.Forms.RadioButton
        Me.mrPoor = New System.Windows.Forms.RadioButton
        Me.gbCommunityRating = New System.Windows.Forms.GroupBox
        Me.crCategories = New System.Windows.Forms.ComboBox
        Me.crNoRating = New System.Windows.Forms.RadioButton
        Me.crExcellent = New System.Windows.Forms.RadioButton
        Me.crGood = New System.Windows.Forms.RadioButton
        Me.crAverage = New System.Windows.Forms.RadioButton
        Me.crPoor = New System.Windows.Forms.RadioButton
        Me.tpFriends = New System.Windows.Forms.TabPage
        Me.lvwFriends = New System.Windows.Forms.ListView
        Me.tpRemoteFiles = New System.Windows.Forms.TabPage
        Me.tpLocalFiles = New System.Windows.Forms.TabPage
        Me.tpPrefiniti = New System.Windows.Forms.TabPage
        Me.tvwORMS = New System.Windows.Forms.TreeView
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tsNavStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsmiUsername = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsmiLongname = New System.Windows.Forms.ToolStripStatusLabel
        Me.tcBrowser = New System.Windows.Forms.TabControl
        Me.msPrefiniti = New System.Windows.Forms.MenuStrip
        Me.tscbSites = New System.Windows.Forms.ToolStripComboBox
        Me.tsmiProjects = New System.Windows.Forms.ToolStripMenuItem
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTimeCollection = New System.Windows.Forms.ToolStripMenuItem
        Me.NewTimeCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenTimeCardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiInvoicing = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiMyAccount = New System.Windows.Forms.ToolStripMenuItem
        Me.tsNavigate.SuspendLayout()
        Me.cmsFriend.SuspendLayout()
        Me.msMain.SuspendLayout()
        Me.scWorkspace.Panel1.SuspendLayout()
        Me.scWorkspace.Panel2.SuspendLayout()
        Me.scWorkspace.SuspendLayout()
        Me.tcTools.SuspendLayout()
        Me.tpCurrentPage.SuspendLayout()
        CType(Me.pbSiteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbCommunityRating.SuspendLayout()
        Me.tpFriends.SuspendLayout()
        Me.tpPrefiniti.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.msPrefiniti.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsNavigate
        '
        Me.tsNavigate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBack, Me.tsForward, Me.tsbStop, Me.tsbReload, Me.ToolStripSeparator1, Me.tsbFavorite, Me.cboURL, Me.ToolStripSeparator2, Me.tsbDiscuss, Me.tsbChat, Me.tsbShare, Me.ToolStripSeparator3, Me.tbtxtSearch})
        Me.tsNavigate.Location = New System.Drawing.Point(0, 24)
        Me.tsNavigate.Name = "tsNavigate"
        Me.tsNavigate.Size = New System.Drawing.Size(1065, 25)
        Me.tsNavigate.TabIndex = 0
        Me.tsNavigate.Text = "ToolStrip1"
        '
        'tsBack
        '
        Me.tsBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBack.Image = CType(resources.GetObject("tsBack.Image"), System.Drawing.Image)
        Me.tsBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBack.Name = "tsBack"
        Me.tsBack.Size = New System.Drawing.Size(23, 22)
        Me.tsBack.Text = "ToolStripButton1"
        Me.tsBack.ToolTipText = "Back"
        '
        'tsForward
        '
        Me.tsForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsForward.Image = CType(resources.GetObject("tsForward.Image"), System.Drawing.Image)
        Me.tsForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsForward.Name = "tsForward"
        Me.tsForward.Size = New System.Drawing.Size(23, 22)
        Me.tsForward.Text = "ToolStripButton1"
        Me.tsForward.ToolTipText = "Forward"
        '
        'tsbStop
        '
        Me.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbStop.Image = CType(resources.GetObject("tsbStop.Image"), System.Drawing.Image)
        Me.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStop.Name = "tsbStop"
        Me.tsbStop.Size = New System.Drawing.Size(23, 22)
        Me.tsbStop.Text = "ToolStripButton1"
        Me.tsbStop.ToolTipText = "Stop"
        '
        'tsbReload
        '
        Me.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbReload.Image = CType(resources.GetObject("tsbReload.Image"), System.Drawing.Image)
        Me.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReload.Name = "tsbReload"
        Me.tsbReload.Size = New System.Drawing.Size(23, 22)
        Me.tsbReload.Text = "ToolStripButton1"
        Me.tsbReload.ToolTipText = "Reload"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbFavorite
        '
        Me.tsbFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFavorite.Image = CType(resources.GetObject("tsbFavorite.Image"), System.Drawing.Image)
        Me.tsbFavorite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFavorite.Name = "tsbFavorite"
        Me.tsbFavorite.Size = New System.Drawing.Size(23, 22)
        Me.tsbFavorite.Text = "ToolStripButton1"
        '
        'cboURL
        '
        Me.cboURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboURL.Name = "cboURL"
        Me.cboURL.Size = New System.Drawing.Size(300, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbDiscuss
        '
        Me.tsbDiscuss.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDiscuss.Image = CType(resources.GetObject("tsbDiscuss.Image"), System.Drawing.Image)
        Me.tsbDiscuss.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDiscuss.Name = "tsbDiscuss"
        Me.tsbDiscuss.Size = New System.Drawing.Size(23, 22)
        Me.tsbDiscuss.Text = "Discuss"
        Me.tsbDiscuss.ToolTipText = "Discuss"
        '
        'tsbChat
        '
        Me.tsbChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbChat.Image = CType(resources.GetObject("tsbChat.Image"), System.Drawing.Image)
        Me.tsbChat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbChat.Name = "tsbChat"
        Me.tsbChat.Size = New System.Drawing.Size(23, 22)
        Me.tsbChat.Text = "Chat"
        '
        'tsbShare
        '
        Me.tsbShare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbShare.Image = CType(resources.GetObject("tsbShare.Image"), System.Drawing.Image)
        Me.tsbShare.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbShare.Name = "tsbShare"
        Me.tsbShare.Size = New System.Drawing.Size(23, 22)
        Me.tsbShare.Text = "ToolStripButton1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbtxtSearch
        '
        Me.tbtxtSearch.Name = "tbtxtSearch"
        Me.tbtxtSearch.Size = New System.Drawing.Size(100, 25)
        Me.tbtxtSearch.ToolTipText = "Search"
        '
        'cmsFriend
        '
        Me.cmsFriend.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiViewProfile, Me.ToolStripSeparator6, Me.tsmiLocateFriend, Me.tsmiChatFriend, Me.tsmiSharePageWithFriend, Me.tsmiMail, Me.ToolStripSeparator5, Me.tsmiBlockFriend, Me.tsmiReportUser, Me.tsmiDeleteFriend})
        Me.cmsFriend.Name = "cmsFriend"
        Me.cmsFriend.Size = New System.Drawing.Size(190, 192)
        '
        'tsmiViewProfile
        '
        Me.tsmiViewProfile.Image = Global.PrefinitiBrowser.My.Resources.Resources.zoom
        Me.tsmiViewProfile.Name = "tsmiViewProfile"
        Me.tsmiViewProfile.Size = New System.Drawing.Size(189, 22)
        Me.tsmiViewProfile.Text = "View Profile..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(186, 6)
        '
        'tsmiLocateFriend
        '
        Me.tsmiLocateFriend.Image = Global.PrefinitiBrowser.My.Resources.Resources.find
        Me.tsmiLocateFriend.Name = "tsmiLocateFriend"
        Me.tsmiLocateFriend.Size = New System.Drawing.Size(189, 22)
        Me.tsmiLocateFriend.Text = "Locate"
        '
        'tsmiChatFriend
        '
        Me.tsmiChatFriend.Image = Global.PrefinitiBrowser.My.Resources.Resources.comments1
        Me.tsmiChatFriend.Name = "tsmiChatFriend"
        Me.tsmiChatFriend.Size = New System.Drawing.Size(189, 22)
        Me.tsmiChatFriend.Text = "Instant Message"
        '
        'tsmiSharePageWithFriend
        '
        Me.tsmiSharePageWithFriend.Image = Global.PrefinitiBrowser.My.Resources.Resources.page_link
        Me.tsmiSharePageWithFriend.Name = "tsmiSharePageWithFriend"
        Me.tsmiSharePageWithFriend.Size = New System.Drawing.Size(189, 22)
        Me.tsmiSharePageWithFriend.Text = "Share Current Page"
        '
        'tsmiMail
        '
        Me.tsmiMail.Image = Global.PrefinitiBrowser.My.Resources.Resources.email
        Me.tsmiMail.Name = "tsmiMail"
        Me.tsmiMail.Size = New System.Drawing.Size(189, 22)
        Me.tsmiMail.Text = "Send Mail Message"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(186, 6)
        '
        'tsmiBlockFriend
        '
        Me.tsmiBlockFriend.Image = Global.PrefinitiBrowser.My.Resources.Resources._stop
        Me.tsmiBlockFriend.Name = "tsmiBlockFriend"
        Me.tsmiBlockFriend.Size = New System.Drawing.Size(189, 22)
        Me.tsmiBlockFriend.Text = "Block"
        '
        'tsmiReportUser
        '
        Me.tsmiReportUser.Image = Global.PrefinitiBrowser.My.Resources.Resources.report_user
        Me.tsmiReportUser.Name = "tsmiReportUser"
        Me.tsmiReportUser.Size = New System.Drawing.Size(189, 22)
        Me.tsmiReportUser.Text = "Report User..."
        '
        'tsmiDeleteFriend
        '
        Me.tsmiDeleteFriend.Image = Global.PrefinitiBrowser.My.Resources.Resources.user_delete
        Me.tsmiDeleteFriend.Name = "tsmiDeleteFriend"
        Me.tsmiDeleteFriend.Size = New System.Drawing.Size(189, 22)
        Me.tsmiDeleteFriend.Text = "Remove From Friends"
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.BookmarksToolStripMenuItem, Me.PrefinitiToolStripMenuItem, Me.SocialWebToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1065, 24)
        Me.msMain.TabIndex = 2
        Me.msMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.NewTabToolStripMenuItem, Me.ToolStripSeparator4, Me.tsmiExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.FileToolStripMenuItem.Text = "&Workspace"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Image = Global.PrefinitiBrowser.My.Resources.Resources.application_add
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.NewWindowToolStripMenuItem.Text = "New Window"
        '
        'NewTabToolStripMenuItem
        '
        Me.NewTabToolStripMenuItem.Image = Global.PrefinitiBrowser.My.Resources.Resources.tab_add
        Me.NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        Me.NewTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.NewTabToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.NewTabToolStripMenuItem.Text = "New Tab"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(185, 6)
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(188, 22)
        Me.tsmiExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.HistoryToolStripMenuItem.Text = "&History"
        '
        'BookmarksToolStripMenuItem
        '
        Me.BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem"
        Me.BookmarksToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.BookmarksToolStripMenuItem.Text = "&Bookmarks"
        '
        'PrefinitiToolStripMenuItem
        '
        Me.PrefinitiToolStripMenuItem.Name = "PrefinitiToolStripMenuItem"
        Me.PrefinitiToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.PrefinitiToolStripMenuItem.Text = "&Prefiniti"
        '
        'SocialWebToolStripMenuItem
        '
        Me.SocialWebToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChatToolStripMenuItem, Me.ForumToolStripMenuItem})
        Me.SocialWebToolStripMenuItem.Name = "SocialWebToolStripMenuItem"
        Me.SocialWebToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.SocialWebToolStripMenuItem.Text = "&Social Web"
        '
        'ChatToolStripMenuItem
        '
        Me.ChatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThisSiteToolStripMenuItem, Me.AllChatRoomsToolStripMenuItem})
        Me.ChatToolStripMenuItem.Image = Global.PrefinitiBrowser.My.Resources.Resources.group
        Me.ChatToolStripMenuItem.Name = "ChatToolStripMenuItem"
        Me.ChatToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChatToolStripMenuItem.Text = "Chat"
        '
        'ThisSiteToolStripMenuItem
        '
        Me.ThisSiteToolStripMenuItem.Name = "ThisSiteToolStripMenuItem"
        Me.ThisSiteToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ThisSiteToolStripMenuItem.Text = "This Site..."
        '
        'AllChatRoomsToolStripMenuItem
        '
        Me.AllChatRoomsToolStripMenuItem.Name = "AllChatRoomsToolStripMenuItem"
        Me.AllChatRoomsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AllChatRoomsToolStripMenuItem.Text = "All Chat Rooms"
        '
        'ForumToolStripMenuItem
        '
        Me.ForumToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThisSiteToolStripMenuItem1, Me.AllForumsToolStripMenuItem})
        Me.ForumToolStripMenuItem.Image = Global.PrefinitiBrowser.My.Resources.Resources.comments
        Me.ForumToolStripMenuItem.Name = "ForumToolStripMenuItem"
        Me.ForumToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ForumToolStripMenuItem.Text = "Discussion Forum"
        '
        'ThisSiteToolStripMenuItem1
        '
        Me.ThisSiteToolStripMenuItem1.Name = "ThisSiteToolStripMenuItem1"
        Me.ThisSiteToolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
        Me.ThisSiteToolStripMenuItem1.Text = "This Site..."
        '
        'AllForumsToolStripMenuItem
        '
        Me.AllForumsToolStripMenuItem.Image = Global.PrefinitiBrowser.My.Resources.Resources.world
        Me.AllForumsToolStripMenuItem.Name = "AllForumsToolStripMenuItem"
        Me.AllForumsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.AllForumsToolStripMenuItem.Text = "All Forums..."
        '
        'scWorkspace
        '
        Me.scWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scWorkspace.Location = New System.Drawing.Point(0, 49)
        Me.scWorkspace.Name = "scWorkspace"
        '
        'scWorkspace.Panel1
        '
        Me.scWorkspace.Panel1.Controls.Add(Me.tcTools)
        '
        'scWorkspace.Panel2
        '
        Me.scWorkspace.Panel2.Controls.Add(Me.StatusStrip1)
        Me.scWorkspace.Panel2.Controls.Add(Me.tcBrowser)
        Me.scWorkspace.Size = New System.Drawing.Size(1065, 616)
        Me.scWorkspace.SplitterDistance = 216
        Me.scWorkspace.TabIndex = 4
        '
        'tcTools
        '
        Me.tcTools.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tcTools.Controls.Add(Me.tpCurrentPage)
        Me.tcTools.Controls.Add(Me.tpFriends)
        Me.tcTools.Controls.Add(Me.tpRemoteFiles)
        Me.tcTools.Controls.Add(Me.tpLocalFiles)
        Me.tcTools.Controls.Add(Me.tpPrefiniti)
        Me.tcTools.Controls.Add(Me.TabPage1)
        Me.tcTools.Location = New System.Drawing.Point(3, 3)
        Me.tcTools.Multiline = True
        Me.tcTools.Name = "tcTools"
        Me.tcTools.SelectedIndex = 0
        Me.tcTools.Size = New System.Drawing.Size(195, 491)
        Me.tcTools.TabIndex = 0
        '
        'tpCurrentPage
        '
        Me.tpCurrentPage.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tpCurrentPage.Controls.Add(Me.lblSiteType)
        Me.tpCurrentPage.Controls.Add(Me.pbSiteIcon)
        Me.tpCurrentPage.Controls.Add(Me.GroupBox1)
        Me.tpCurrentPage.Controls.Add(Me.gbCommunityRating)
        Me.tpCurrentPage.Location = New System.Drawing.Point(23, 4)
        Me.tpCurrentPage.Name = "tpCurrentPage"
        Me.tpCurrentPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCurrentPage.Size = New System.Drawing.Size(168, 483)
        Me.tpCurrentPage.TabIndex = 1
        Me.tpCurrentPage.Text = "This Site"
        '
        'lblSiteType
        '
        Me.lblSiteType.AutoSize = True
        Me.lblSiteType.Location = New System.Drawing.Point(27, 7)
        Me.lblSiteType.Name = "lblSiteType"
        Me.lblSiteType.Size = New System.Drawing.Size(71, 13)
        Me.lblSiteType.TabIndex = 5
        Me.lblSiteType.Text = "Standard Site"
        '
        'pbSiteIcon
        '
        Me.pbSiteIcon.Location = New System.Drawing.Point(7, 7)
        Me.pbSiteIcon.Name = "pbSiteIcon"
        Me.pbSiteIcon.Size = New System.Drawing.Size(16, 16)
        Me.pbSiteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSiteIcon.TabIndex = 4
        Me.pbSiteIcon.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mrCategories)
        Me.GroupBox1.Controls.Add(Me.mrNoRating)
        Me.GroupBox1.Controls.Add(Me.mrExcellent)
        Me.GroupBox1.Controls.Add(Me.mrGood)
        Me.GroupBox1.Controls.Add(Me.mrAverage)
        Me.GroupBox1.Controls.Add(Me.mrPoor)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 170)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "My Rating"
        '
        'mrCategories
        '
        Me.mrCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mrCategories.FormattingEnabled = True
        Me.mrCategories.Items.AddRange(New Object() {"Overall", "Navigation", "Content", "Reliability"})
        Me.mrCategories.Location = New System.Drawing.Point(7, 19)
        Me.mrCategories.Name = "mrCategories"
        Me.mrCategories.Size = New System.Drawing.Size(142, 21)
        Me.mrCategories.TabIndex = 5
        '
        'mrNoRating
        '
        Me.mrNoRating.AutoSize = True
        Me.mrNoRating.Location = New System.Drawing.Point(20, 48)
        Me.mrNoRating.Name = "mrNoRating"
        Me.mrNoRating.Size = New System.Drawing.Size(73, 17)
        Me.mrNoRating.TabIndex = 4
        Me.mrNoRating.TabStop = True
        Me.mrNoRating.Text = "No Rating"
        Me.mrNoRating.UseVisualStyleBackColor = True
        '
        'mrExcellent
        '
        Me.mrExcellent.AutoSize = True
        Me.mrExcellent.Location = New System.Drawing.Point(21, 140)
        Me.mrExcellent.Name = "mrExcellent"
        Me.mrExcellent.Size = New System.Drawing.Size(68, 17)
        Me.mrExcellent.TabIndex = 3
        Me.mrExcellent.TabStop = True
        Me.mrExcellent.Text = "Excellent"
        Me.mrExcellent.UseVisualStyleBackColor = True
        '
        'mrGood
        '
        Me.mrGood.AutoSize = True
        Me.mrGood.Location = New System.Drawing.Point(20, 117)
        Me.mrGood.Name = "mrGood"
        Me.mrGood.Size = New System.Drawing.Size(51, 17)
        Me.mrGood.TabIndex = 2
        Me.mrGood.TabStop = True
        Me.mrGood.Text = "Good"
        Me.mrGood.UseVisualStyleBackColor = True
        '
        'mrAverage
        '
        Me.mrAverage.AutoSize = True
        Me.mrAverage.Location = New System.Drawing.Point(20, 94)
        Me.mrAverage.Name = "mrAverage"
        Me.mrAverage.Size = New System.Drawing.Size(65, 17)
        Me.mrAverage.TabIndex = 1
        Me.mrAverage.TabStop = True
        Me.mrAverage.Text = "Average"
        Me.mrAverage.UseVisualStyleBackColor = True
        '
        'mrPoor
        '
        Me.mrPoor.AutoSize = True
        Me.mrPoor.Location = New System.Drawing.Point(20, 71)
        Me.mrPoor.Name = "mrPoor"
        Me.mrPoor.Size = New System.Drawing.Size(47, 17)
        Me.mrPoor.TabIndex = 0
        Me.mrPoor.TabStop = True
        Me.mrPoor.Text = "Poor"
        Me.mrPoor.UseVisualStyleBackColor = True
        '
        'gbCommunityRating
        '
        Me.gbCommunityRating.Controls.Add(Me.crCategories)
        Me.gbCommunityRating.Controls.Add(Me.crNoRating)
        Me.gbCommunityRating.Controls.Add(Me.crExcellent)
        Me.gbCommunityRating.Controls.Add(Me.crGood)
        Me.gbCommunityRating.Controls.Add(Me.crAverage)
        Me.gbCommunityRating.Controls.Add(Me.crPoor)
        Me.gbCommunityRating.Location = New System.Drawing.Point(7, 29)
        Me.gbCommunityRating.Name = "gbCommunityRating"
        Me.gbCommunityRating.Size = New System.Drawing.Size(155, 170)
        Me.gbCommunityRating.TabIndex = 2
        Me.gbCommunityRating.TabStop = False
        Me.gbCommunityRating.Text = "Community Rating"
        '
        'crCategories
        '
        Me.crCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.crCategories.FormattingEnabled = True
        Me.crCategories.Items.AddRange(New Object() {"Overall", "Navigation", "Content", "Reliability"})
        Me.crCategories.Location = New System.Drawing.Point(7, 19)
        Me.crCategories.Name = "crCategories"
        Me.crCategories.Size = New System.Drawing.Size(142, 21)
        Me.crCategories.TabIndex = 5
        '
        'crNoRating
        '
        Me.crNoRating.AutoSize = True
        Me.crNoRating.Enabled = False
        Me.crNoRating.Location = New System.Drawing.Point(20, 48)
        Me.crNoRating.Name = "crNoRating"
        Me.crNoRating.Size = New System.Drawing.Size(73, 17)
        Me.crNoRating.TabIndex = 4
        Me.crNoRating.TabStop = True
        Me.crNoRating.Text = "No Rating"
        Me.crNoRating.UseVisualStyleBackColor = True
        '
        'crExcellent
        '
        Me.crExcellent.AutoSize = True
        Me.crExcellent.Enabled = False
        Me.crExcellent.Location = New System.Drawing.Point(21, 140)
        Me.crExcellent.Name = "crExcellent"
        Me.crExcellent.Size = New System.Drawing.Size(68, 17)
        Me.crExcellent.TabIndex = 3
        Me.crExcellent.TabStop = True
        Me.crExcellent.Text = "Excellent"
        Me.crExcellent.UseVisualStyleBackColor = True
        '
        'crGood
        '
        Me.crGood.AutoSize = True
        Me.crGood.Enabled = False
        Me.crGood.Location = New System.Drawing.Point(20, 117)
        Me.crGood.Name = "crGood"
        Me.crGood.Size = New System.Drawing.Size(51, 17)
        Me.crGood.TabIndex = 2
        Me.crGood.TabStop = True
        Me.crGood.Text = "Good"
        Me.crGood.UseVisualStyleBackColor = True
        '
        'crAverage
        '
        Me.crAverage.AutoSize = True
        Me.crAverage.Enabled = False
        Me.crAverage.Location = New System.Drawing.Point(20, 94)
        Me.crAverage.Name = "crAverage"
        Me.crAverage.Size = New System.Drawing.Size(65, 17)
        Me.crAverage.TabIndex = 1
        Me.crAverage.TabStop = True
        Me.crAverage.Text = "Average"
        Me.crAverage.UseVisualStyleBackColor = True
        '
        'crPoor
        '
        Me.crPoor.AutoSize = True
        Me.crPoor.Enabled = False
        Me.crPoor.Location = New System.Drawing.Point(20, 71)
        Me.crPoor.Name = "crPoor"
        Me.crPoor.Size = New System.Drawing.Size(47, 17)
        Me.crPoor.TabIndex = 0
        Me.crPoor.TabStop = True
        Me.crPoor.Text = "Poor"
        Me.crPoor.UseVisualStyleBackColor = True
        '
        'tpFriends
        '
        Me.tpFriends.Controls.Add(Me.lvwFriends)
        Me.tpFriends.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpFriends.Location = New System.Drawing.Point(23, 4)
        Me.tpFriends.Name = "tpFriends"
        Me.tpFriends.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFriends.Size = New System.Drawing.Size(168, 483)
        Me.tpFriends.TabIndex = 0
        Me.tpFriends.Text = "Friends"
        Me.tpFriends.UseVisualStyleBackColor = True
        '
        'lvwFriends
        '
        Me.lvwFriends.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwFriends.ContextMenuStrip = Me.cmsFriend
        Me.lvwFriends.Location = New System.Drawing.Point(0, 0)
        Me.lvwFriends.Name = "lvwFriends"
        Me.lvwFriends.Size = New System.Drawing.Size(144, 301)
        Me.lvwFriends.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwFriends.TabIndex = 0
        Me.lvwFriends.UseCompatibleStateImageBehavior = False
        '
        'tpRemoteFiles
        '
        Me.tpRemoteFiles.Location = New System.Drawing.Point(23, 4)
        Me.tpRemoteFiles.Name = "tpRemoteFiles"
        Me.tpRemoteFiles.Size = New System.Drawing.Size(168, 483)
        Me.tpRemoteFiles.TabIndex = 2
        Me.tpRemoteFiles.Text = "Remote Files"
        Me.tpRemoteFiles.UseVisualStyleBackColor = True
        '
        'tpLocalFiles
        '
        Me.tpLocalFiles.Location = New System.Drawing.Point(23, 4)
        Me.tpLocalFiles.Name = "tpLocalFiles"
        Me.tpLocalFiles.Size = New System.Drawing.Size(168, 483)
        Me.tpLocalFiles.TabIndex = 3
        Me.tpLocalFiles.Text = "Local Files"
        Me.tpLocalFiles.UseVisualStyleBackColor = True
        '
        'tpPrefiniti
        '
        Me.tpPrefiniti.Controls.Add(Me.tvwORMS)
        Me.tpPrefiniti.Location = New System.Drawing.Point(23, 4)
        Me.tpPrefiniti.Name = "tpPrefiniti"
        Me.tpPrefiniti.Size = New System.Drawing.Size(168, 483)
        Me.tpPrefiniti.TabIndex = 4
        Me.tpPrefiniti.Text = "Prefiniti Documents"
        Me.tpPrefiniti.UseVisualStyleBackColor = True
        '
        'tvwORMS
        '
        Me.tvwORMS.Location = New System.Drawing.Point(3, 3)
        Me.tvwORMS.Name = "tvwORMS"
        Me.tvwORMS.Size = New System.Drawing.Size(162, 477)
        Me.tvwORMS.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(168, 483)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Favorites"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNavStatus, Me.tsmiUsername, Me.tsmiLongname})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 594)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(845, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsNavStatus
        '
        Me.tsNavStatus.Margin = New System.Windows.Forms.Padding(0, 3, 50, 2)
        Me.tsNavStatus.Name = "tsNavStatus"
        Me.tsNavStatus.Size = New System.Drawing.Size(39, 17)
        Me.tsNavStatus.Text = "Ready"
        '
        'tsmiUsername
        '
        Me.tsmiUsername.Name = "tsmiUsername"
        Me.tsmiUsername.Size = New System.Drawing.Size(60, 17)
        Me.tsmiUsername.Text = "Username"
        '
        'tsmiLongname
        '
        Me.tsmiLongname.Name = "tsmiLongname"
        Me.tsmiLongname.Size = New System.Drawing.Size(64, 17)
        Me.tsmiLongname.Text = "Longname"
        '
        'tcBrowser
        '
        Me.tcBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcBrowser.Location = New System.Drawing.Point(0, 0)
        Me.tcBrowser.Name = "tcBrowser"
        Me.tcBrowser.SelectedIndex = 0
        Me.tcBrowser.Size = New System.Drawing.Size(845, 616)
        Me.tcBrowser.TabIndex = 1
        '
        'msPrefiniti
        '
        Me.msPrefiniti.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscbSites, Me.tsmiProjects, Me.tsmiTimeCollection, Me.tsmiInvoicing, Me.tsmiMyAccount})
        Me.msPrefiniti.Location = New System.Drawing.Point(0, 0)
        Me.msPrefiniti.Name = "msPrefiniti"
        Me.msPrefiniti.Size = New System.Drawing.Size(990, 27)
        Me.msPrefiniti.TabIndex = 5
        Me.msPrefiniti.Text = "MenuStrip1"
        Me.msPrefiniti.Visible = False
        '
        'tscbSites
        '
        Me.tscbSites.Name = "tscbSites"
        Me.tscbSites.Size = New System.Drawing.Size(121, 23)
        '
        'tsmiProjects
        '
        Me.tsmiProjects.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.FindProjectToolStripMenuItem})
        Me.tsmiProjects.Name = "tsmiProjects"
        Me.tsmiProjects.Size = New System.Drawing.Size(61, 23)
        Me.tsmiProjects.Text = "Projects"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NewProjectToolStripMenuItem.Text = "New Project"
        '
        'FindProjectToolStripMenuItem
        '
        Me.FindProjectToolStripMenuItem.Name = "FindProjectToolStripMenuItem"
        Me.FindProjectToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.FindProjectToolStripMenuItem.Text = "Find Project"
        '
        'tsmiTimeCollection
        '
        Me.tsmiTimeCollection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTimeCardToolStripMenuItem, Me.OpenTimeCardsToolStripMenuItem})
        Me.tsmiTimeCollection.Name = "tsmiTimeCollection"
        Me.tsmiTimeCollection.Size = New System.Drawing.Size(103, 23)
        Me.tsmiTimeCollection.Text = "Time Collection"
        '
        'NewTimeCardToolStripMenuItem
        '
        Me.NewTimeCardToolStripMenuItem.Name = "NewTimeCardToolStripMenuItem"
        Me.NewTimeCardToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NewTimeCardToolStripMenuItem.Text = "New Timesheet"
        '
        'OpenTimeCardsToolStripMenuItem
        '
        Me.OpenTimeCardsToolStripMenuItem.Name = "OpenTimeCardsToolStripMenuItem"
        Me.OpenTimeCardsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OpenTimeCardsToolStripMenuItem.Text = "Open Timesheets"
        '
        'tsmiInvoicing
        '
        Me.tsmiInvoicing.Name = "tsmiInvoicing"
        Me.tsmiInvoicing.Size = New System.Drawing.Size(68, 23)
        Me.tsmiInvoicing.Text = "Invoicing"
        '
        'tsmiMyAccount
        '
        Me.tsmiMyAccount.Name = "tsmiMyAccount"
        Me.tsmiMyAccount.Size = New System.Drawing.Size(84, 23)
        Me.tsmiMyAccount.Text = "My Account"
        '
        'frmWorkspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 665)
        Me.Controls.Add(Me.scWorkspace)
        Me.Controls.Add(Me.tsNavigate)
        Me.Controls.Add(Me.msMain)
        Me.Controls.Add(Me.msPrefiniti)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msPrefiniti
        Me.Name = "frmWorkspace"
        Me.Text = "Prefiniti Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsNavigate.ResumeLayout(False)
        Me.tsNavigate.PerformLayout()
        Me.cmsFriend.ResumeLayout(False)
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.scWorkspace.Panel1.ResumeLayout(False)
        Me.scWorkspace.Panel2.ResumeLayout(False)
        Me.scWorkspace.Panel2.PerformLayout()
        Me.scWorkspace.ResumeLayout(False)
        Me.tcTools.ResumeLayout(False)
        Me.tpCurrentPage.ResumeLayout(False)
        Me.tpCurrentPage.PerformLayout()
        CType(Me.pbSiteIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbCommunityRating.ResumeLayout(False)
        Me.gbCommunityRating.PerformLayout()
        Me.tpFriends.ResumeLayout(False)
        Me.tpPrefiniti.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.msPrefiniti.ResumeLayout(False)
        Me.msPrefiniti.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsNavigate As System.Windows.Forms.ToolStrip
    Friend WithEvents tsBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboURL As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsbDiscuss As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbChat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtxtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbReload As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbShare As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookmarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrefinitiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SocialWebToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThisSiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllChatRoomsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThisSiteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllForumsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsFriend As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiLocateFriend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiChatFriend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSharePageWithFriend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiBlockFriend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDeleteFriend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiReportUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiViewProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbFavorite As System.Windows.Forms.ToolStripButton
    Friend WithEvents scWorkspace As System.Windows.Forms.SplitContainer
    Friend WithEvents tcTools As System.Windows.Forms.TabControl
    Friend WithEvents tpCurrentPage As System.Windows.Forms.TabPage
    Friend WithEvents lblSiteType As System.Windows.Forms.Label
    Friend WithEvents pbSiteIcon As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mrCategories As System.Windows.Forms.ComboBox
    Friend WithEvents mrNoRating As System.Windows.Forms.RadioButton
    Friend WithEvents mrExcellent As System.Windows.Forms.RadioButton
    Friend WithEvents mrGood As System.Windows.Forms.RadioButton
    Friend WithEvents mrAverage As System.Windows.Forms.RadioButton
    Friend WithEvents mrPoor As System.Windows.Forms.RadioButton
    Friend WithEvents gbCommunityRating As System.Windows.Forms.GroupBox
    Friend WithEvents crCategories As System.Windows.Forms.ComboBox
    Friend WithEvents crNoRating As System.Windows.Forms.RadioButton
    Friend WithEvents crExcellent As System.Windows.Forms.RadioButton
    Friend WithEvents crGood As System.Windows.Forms.RadioButton
    Friend WithEvents crAverage As System.Windows.Forms.RadioButton
    Friend WithEvents crPoor As System.Windows.Forms.RadioButton
    Friend WithEvents tpFriends As System.Windows.Forms.TabPage
    Friend WithEvents lvwFriends As System.Windows.Forms.ListView
    Friend WithEvents tpRemoteFiles As System.Windows.Forms.TabPage
    Friend WithEvents tpLocalFiles As System.Windows.Forms.TabPage
    Friend WithEvents tpPrefiniti As System.Windows.Forms.TabPage
    Friend WithEvents tvwORMS As System.Windows.Forms.TreeView
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsNavStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsmiUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsmiLongname As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tcBrowser As System.Windows.Forms.TabControl
    Friend WithEvents msPrefiniti As System.Windows.Forms.MenuStrip
    Friend WithEvents tscbSites As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsmiProjects As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTimeCollection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiInvoicing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMyAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTimeCardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenTimeCardsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
