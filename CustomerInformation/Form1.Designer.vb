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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TxtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TxtFirst
        '
        Me.TxtFirst.Location = New System.Drawing.Point(109, 65)
        Me.TxtFirst.Name = "TxtFirst"
        Me.TxtFirst.Size = New System.Drawing.Size(100, 20)
        Me.TxtFirst.TabIndex = 1
        Me.TxtFirst.Tag = ""
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(275, 65)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(130, 20)
        Me.txtLast.TabIndex = 2
        Me.txtLast.Tag = ""
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(128, 114)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(277, 20)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Tag = ""
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(128, 163)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 4
        Me.txtCity.Tag = ""
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(305, 163)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 5
        Me.txtZip.Tag = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(604, 397)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = true
        Me.lblFirst.Location = New System.Drawing.Point(74, 68)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(29, 13)
        Me.lblFirst.TabIndex = 8
        Me.lblFirst.Text = "&First:"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = true
        Me.lblMessage.Location = New System.Drawing.Point(74, 397)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(93, 13)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.Text = "Information Saved"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = true
        Me.lblLast.Location = New System.Drawing.Point(239, 68)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(30, 13)
        Me.lblLast.TabIndex = 10
        Me.lblLast.Text = "&Last:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = true
        Me.lblAddress.Location = New System.Drawing.Point(74, 117)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "&Address:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = true
        Me.lblCity.Location = New System.Drawing.Point(74, 166)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 12
        Me.lblCity.Text = "&City:"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = true
        Me.lblZip.Location = New System.Drawing.Point(260, 166)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(25, 13)
        Me.lblZip.TabIndex = 13
        Me.lblZip.Text = "&Zip:"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.TxtFirst)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Customer Information"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TxtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
