<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtChannel = New System.Windows.Forms.TextBox()
        Me.lblChannel = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtChatOut = New System.Windows.Forms.TextBox()
        Me.txtChatIn = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnChangeStreams = New System.Windows.Forms.Button()
        Me.wbStream = New System.Windows.Forms.WebBrowser()
        Me.btnSaveLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtChannel
        '
        Me.txtChannel.Location = New System.Drawing.Point(88, 364)
        Me.txtChannel.Name = "txtChannel"
        Me.txtChannel.Size = New System.Drawing.Size(144, 20)
        Me.txtChannel.TabIndex = 1
        '
        'lblChannel
        '
        Me.lblChannel.AutoSize = True
        Me.lblChannel.Location = New System.Drawing.Point(35, 367)
        Me.lblChannel.Name = "lblChannel"
        Me.lblChannel.Size = New System.Drawing.Size(46, 13)
        Me.lblChannel.TabIndex = 2
        Me.lblChannel.Text = "Channel"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(35, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(81, 13)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Broadcast Title:"
        '
        'txtChatOut
        '
        Me.txtChatOut.Location = New System.Drawing.Point(413, 33)
        Me.txtChatOut.Multiline = True
        Me.txtChatOut.Name = "txtChatOut"
        Me.txtChatOut.ReadOnly = True
        Me.txtChatOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChatOut.Size = New System.Drawing.Size(201, 312)
        Me.txtChatOut.TabIndex = 4
        '
        'txtChatIn
        '
        Me.txtChatIn.Location = New System.Drawing.Point(413, 350)
        Me.txtChatIn.Name = "txtChatIn"
        Me.txtChatIn.Size = New System.Drawing.Size(150, 20)
        Me.txtChatIn.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(569, 348)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(45, 23)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnChangeStreams
        '
        Me.btnChangeStreams.Location = New System.Drawing.Point(238, 350)
        Me.btnChangeStreams.Name = "btnChangeStreams"
        Me.btnChangeStreams.Size = New System.Drawing.Size(75, 47)
        Me.btnChangeStreams.TabIndex = 7
        Me.btnChangeStreams.Text = "Change Streams"
        Me.btnChangeStreams.UseVisualStyleBackColor = True
        '
        'wbStream
        '
        Me.wbStream.Location = New System.Drawing.Point(38, 33)
        Me.wbStream.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbStream.Name = "wbStream"
        Me.wbStream.Size = New System.Drawing.Size(369, 312)
        Me.wbStream.TabIndex = 8
        Me.wbStream.Url = New System.Uri("", System.UriKind.Relative)
        '
        'btnSaveLogin
        '
        Me.btnSaveLogin.Location = New System.Drawing.Point(208, 414)
        Me.btnSaveLogin.Name = "btnSaveLogin"
        Me.btnSaveLogin.Size = New System.Drawing.Size(174, 23)
        Me.btnSaveLogin.TabIndex = 9
        Me.btnSaveLogin.Text = "Save Current Login"
        Me.btnSaveLogin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 619)
        Me.Controls.Add(Me.btnSaveLogin)
        Me.Controls.Add(Me.wbStream)
        Me.Controls.Add(Me.btnChangeStreams)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtChatIn)
        Me.Controls.Add(Me.txtChatOut)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblChannel)
        Me.Controls.Add(Me.txtChannel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtChannel As System.Windows.Forms.TextBox
    Friend WithEvents lblChannel As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtChatOut As System.Windows.Forms.TextBox
    Friend WithEvents txtChatIn As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnChangeStreams As System.Windows.Forms.Button
    Friend WithEvents wbStream As System.Windows.Forms.WebBrowser
    Friend WithEvents btnSaveLogin As System.Windows.Forms.Button

End Class
