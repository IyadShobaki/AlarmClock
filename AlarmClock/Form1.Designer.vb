<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAlarmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdjustToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add5SecondsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlarmToneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeepingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextSoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAlarmOff = New System.Windows.Forms.Label()
        Me.chkOnOff = New System.Windows.Forms.CheckBox()
        Me.lblTimeOfDay = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SetAlarmToolStripMenuItem, Me.AdjustToolStripMenuItem, Me.AlarmToneToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SetAlarmToolStripMenuItem
        '
        Me.SetAlarmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetAlarmToolStripMenuItem1, Me.ResetToolStripMenuItem1, Me.StopToolStripMenuItem})
        Me.SetAlarmToolStripMenuItem.Name = "SetAlarmToolStripMenuItem"
        Me.SetAlarmToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.SetAlarmToolStripMenuItem.Text = "Settings"
        '
        'SetAlarmToolStripMenuItem1
        '
        Me.SetAlarmToolStripMenuItem1.Name = "SetAlarmToolStripMenuItem1"
        Me.SetAlarmToolStripMenuItem1.Size = New System.Drawing.Size(120, 26)
        Me.SetAlarmToolStripMenuItem1.Text = "Set"
        '
        'ResetToolStripMenuItem1
        '
        Me.ResetToolStripMenuItem1.Name = "ResetToolStripMenuItem1"
        Me.ResetToolStripMenuItem1.Size = New System.Drawing.Size(120, 26)
        Me.ResetToolStripMenuItem1.Text = "Reset"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'AdjustToolStripMenuItem
        '
        Me.AdjustToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add5SecondsToolStripMenuItem})
        Me.AdjustToolStripMenuItem.Name = "AdjustToolStripMenuItem"
        Me.AdjustToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.AdjustToolStripMenuItem.Text = "Adjust"
        '
        'Add5SecondsToolStripMenuItem
        '
        Me.Add5SecondsToolStripMenuItem.Name = "Add5SecondsToolStripMenuItem"
        Me.Add5SecondsToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.Add5SecondsToolStripMenuItem.Text = "Add 5 seconds"
        '
        'AlarmToneToolStripMenuItem
        '
        Me.AlarmToneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeepingToolStripMenuItem, Me.TextSoundToolStripMenuItem})
        Me.AlarmToneToolStripMenuItem.Name = "AlarmToneToolStripMenuItem"
        Me.AlarmToneToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.AlarmToneToolStripMenuItem.Text = "Alarm Tone"
        '
        'BeepingToolStripMenuItem
        '
        Me.BeepingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.ActivateToolStripMenuItem})
        Me.BeepingToolStripMenuItem.Name = "BeepingToolStripMenuItem"
        Me.BeepingToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.BeepingToolStripMenuItem.Text = "Beeping"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'ActivateToolStripMenuItem
        '
        Me.ActivateToolStripMenuItem.Name = "ActivateToolStripMenuItem"
        Me.ActivateToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ActivateToolStripMenuItem.Text = "Activate"
        '
        'TextSoundToolStripMenuItem
        '
        Me.TextSoundToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem1, Me.ActivateToolStripMenuItem1})
        Me.TextSoundToolStripMenuItem.Name = "TextSoundToolStripMenuItem"
        Me.TextSoundToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.TextSoundToolStripMenuItem.Text = "Text Sound"
        '
        'TestToolStripMenuItem1
        '
        Me.TestToolStripMenuItem1.Name = "TestToolStripMenuItem1"
        Me.TestToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
        Me.TestToolStripMenuItem1.Text = "Test"
        '
        'ActivateToolStripMenuItem1
        '
        Me.ActivateToolStripMenuItem1.Name = "ActivateToolStripMenuItem1"
        Me.ActivateToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
        Me.ActivateToolStripMenuItem1.Text = "Activate"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(141, 26)
        Me.AboutToolStripMenuItem1.Text = "AboutUs"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.lblAlarmOff)
        Me.GroupBox1.Controls.Add(Me.chkOnOff)
        Me.GroupBox1.Controls.Add(Me.lblTimeOfDay)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(632, 393)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alarm Clock"
        '
        'lblAlarmOff
        '
        Me.lblAlarmOff.AutoSize = True
        Me.lblAlarmOff.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmOff.Location = New System.Drawing.Point(16, 122)
        Me.lblAlarmOff.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlarmOff.Name = "lblAlarmOff"
        Me.lblAlarmOff.Size = New System.Drawing.Size(0, 30)
        Me.lblAlarmOff.TabIndex = 3
        '
        'chkOnOff
        '
        Me.chkOnOff.AutoSize = True
        Me.chkOnOff.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnOff.Location = New System.Drawing.Point(223, 60)
        Me.chkOnOff.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOnOff.Name = "chkOnOff"
        Me.chkOnOff.Size = New System.Drawing.Size(48, 22)
        Me.chkOnOff.TabIndex = 2
        Me.chkOnOff.Text = "off"
        Me.chkOnOff.UseVisualStyleBackColor = True
        '
        'lblTimeOfDay
        '
        Me.lblTimeOfDay.AutoSize = True
        Me.lblTimeOfDay.Font = New System.Drawing.Font("Georgia", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOfDay.Location = New System.Drawing.Point(16, 161)
        Me.lblTimeOfDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeOfDay.Name = "lblTimeOfDay"
        Me.lblTimeOfDay.Size = New System.Drawing.Size(0, 91)
        Me.lblTimeOfDay.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(16, 53)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 30)
        Me.lblTime.TabIndex = 0
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(496, 53)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(112, 21)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Text sound"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(496, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(136, 21)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Beeping sound"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 425)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shobaki.AlarmClockLab"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetAlarmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetAlarmToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdjustToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Add5SecondsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlarmToneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeepingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextSoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblTimeOfDay As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkOnOff As CheckBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAlarmOff As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ActivateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
