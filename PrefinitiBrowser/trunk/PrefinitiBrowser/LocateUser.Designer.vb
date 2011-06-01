<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocateUser
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
        Me.btnGo = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblName = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.pbUser = New System.Windows.Forms.PictureBox
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(216, 172)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(115, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Join Them"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(337, 172)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(119, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(101, 30)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "John Doe"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(124, 47)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(288, 110)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Is currently doing nothing"
        '
        'pbUser
        '
        Me.pbUser.Image = Global.PrefinitiBrowser.My.Resources.Resources.web1
        Me.pbUser.Location = New System.Drawing.Point(13, 13)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(100, 100)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUser.TabIndex = 2
        Me.pbUser.TabStop = False
        '
        'LocateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 207)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbUser)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "LocateUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Locate User"
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pbUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
