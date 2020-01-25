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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InputTxt = New System.Windows.Forms.TextBox()
        Me.OutputTxt = New System.Windows.Forms.TextBox()
        Me.InputFileBrowseBtn = New System.Windows.Forms.Button()
        Me.OutputFileBrowseBtn = New System.Windows.Forms.Button()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TwoPassEncoding = New System.Windows.Forms.CheckBox()
        Me.AdditionalArguments = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.columns = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rows = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.quantizer = New System.Windows.Forms.NumericUpDown()
        Me.audioBitrate = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.speed = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RemoveTempFiles = New System.Windows.Forms.CheckBox()
        Me.BrowseTempLocation = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tempLocationPath = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ProgressLog = New System.Windows.Forms.RichTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.OutputFolderBrowseBtn = New System.Windows.Forms.Button()
        Me.InputFolderBrowseBtn = New System.Windows.Forms.Button()
        Me.NoPipes = New System.Windows.Forms.CheckBox()
        Me.ffmpegVersionLabel = New System.Windows.Forms.Label()
        Me.PauseResumeButton = New System.Windows.Forms.Button()
        Me.ClearLogBtn = New System.Windows.Forms.Button()
        Me.SaveLogBtn = New System.Windows.Forms.Button()
        Me.AdvancedOptionsButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.columns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.audioBitrate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Step 1: Browse for an input file or folder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Step 2: Browse for an output location:"
        '
        'InputTxt
        '
        Me.InputTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputTxt.Location = New System.Drawing.Point(6, 26)
        Me.InputTxt.Name = "InputTxt"
        Me.InputTxt.Size = New System.Drawing.Size(252, 20)
        Me.InputTxt.TabIndex = 1
        '
        'OutputTxt
        '
        Me.OutputTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputTxt.Location = New System.Drawing.Point(6, 68)
        Me.OutputTxt.Name = "OutputTxt"
        Me.OutputTxt.Size = New System.Drawing.Size(252, 20)
        Me.OutputTxt.TabIndex = 3
        '
        'InputFileBrowseBtn
        '
        Me.InputFileBrowseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputFileBrowseBtn.Location = New System.Drawing.Point(264, 23)
        Me.InputFileBrowseBtn.Name = "InputFileBrowseBtn"
        Me.InputFileBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.InputFileBrowseBtn.TabIndex = 2
        Me.InputFileBrowseBtn.Text = "Browse File"
        Me.InputFileBrowseBtn.UseVisualStyleBackColor = True
        '
        'OutputFileBrowseBtn
        '
        Me.OutputFileBrowseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputFileBrowseBtn.Location = New System.Drawing.Point(264, 66)
        Me.OutputFileBrowseBtn.Name = "OutputFileBrowseBtn"
        Me.OutputFileBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.OutputFileBrowseBtn.TabIndex = 4
        Me.OutputFileBrowseBtn.Text = "Browse File"
        Me.OutputFileBrowseBtn.UseVisualStyleBackColor = True
        '
        'StartBtn
        '
        Me.StartBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBtn.Location = New System.Drawing.Point(9, 307)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(430, 37)
        Me.StartBtn.TabIndex = 15
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "GUI by Moises Cardona"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(408, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "v1.4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.AdvancedOptionsButton)
        Me.GroupBox1.Controls.Add(Me.TwoPassEncoding)
        Me.GroupBox1.Controls.Add(Me.AdditionalArguments)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.columns)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.rows)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.quantizer)
        Me.GroupBox1.Controls.Add(Me.audioBitrate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.speed)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 145)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encoder Options"
        '
        'TwoPassEncoding
        '
        Me.TwoPassEncoding.AutoSize = True
        Me.TwoPassEncoding.Location = New System.Drawing.Point(304, 35)
        Me.TwoPassEncoding.Name = "TwoPassEncoding"
        Me.TwoPassEncoding.Size = New System.Drawing.Size(58, 17)
        Me.TwoPassEncoding.TabIndex = 46
        Me.TwoPassEncoding.Text = "2-Pass"
        Me.TwoPassEncoding.UseVisualStyleBackColor = True
        '
        'AdditionalArguments
        '
        Me.AdditionalArguments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdditionalArguments.Location = New System.Drawing.Point(9, 82)
        Me.AdditionalArguments.Name = "AdditionalArguments"
        Me.AdditionalArguments.Size = New System.Drawing.Size(415, 20)
        Me.AdditionalArguments.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Additional arguments:"
        '
        'columns
        '
        Me.columns.Location = New System.Drawing.Point(248, 32)
        Me.columns.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.columns.Name = "columns"
        Me.columns.Size = New System.Drawing.Size(50, 20)
        Me.columns.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(245, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Columns:"
        '
        'rows
        '
        Me.rows.Location = New System.Drawing.Point(192, 32)
        Me.rows.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.rows.Name = "rows"
        Me.rows.Size = New System.Drawing.Size(50, 20)
        Me.rows.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(189, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Rows:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Quantizer:"
        '
        'quantizer
        '
        Me.quantizer.Location = New System.Drawing.Point(136, 32)
        Me.quantizer.Maximum = New Decimal(New Integer() {63, 0, 0, 0})
        Me.quantizer.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.quantizer.Name = "quantizer"
        Me.quantizer.Size = New System.Drawing.Size(50, 20)
        Me.quantizer.TabIndex = 5
        Me.quantizer.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'audioBitrate
        '
        Me.audioBitrate.Location = New System.Drawing.Point(65, 32)
        Me.audioBitrate.Maximum = New Decimal(New Integer() {320, 0, 0, 0})
        Me.audioBitrate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.audioBitrate.Name = "audioBitrate"
        Me.audioBitrate.Size = New System.Drawing.Size(65, 20)
        Me.audioBitrate.TabIndex = 7
        Me.audioBitrate.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Audio Bitrate:"
        '
        'speed
        '
        Me.speed.Location = New System.Drawing.Point(9, 32)
        Me.speed.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.speed.Name = "speed"
        Me.speed.Size = New System.Drawing.Size(50, 20)
        Me.speed.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Speed:"
        '
        'RemoveTempFiles
        '
        Me.RemoveTempFiles.AutoSize = True
        Me.RemoveTempFiles.Checked = True
        Me.RemoveTempFiles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RemoveTempFiles.Location = New System.Drawing.Point(6, 135)
        Me.RemoveTempFiles.Name = "RemoveTempFiles"
        Me.RemoveTempFiles.Size = New System.Drawing.Size(143, 17)
        Me.RemoveTempFiles.TabIndex = 14
        Me.RemoveTempFiles.Text = "Remove Temporary Files"
        Me.RemoveTempFiles.UseVisualStyleBackColor = True
        '
        'BrowseTempLocation
        '
        Me.BrowseTempLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseTempLocation.Location = New System.Drawing.Point(361, 106)
        Me.BrowseTempLocation.Name = "BrowseTempLocation"
        Me.BrowseTempLocation.Size = New System.Drawing.Size(75, 23)
        Me.BrowseTempLocation.TabIndex = 13
        Me.BrowseTempLocation.Text = "Browse"
        Me.BrowseTempLocation.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Temporary File Location:"
        '
        'tempLocationPath
        '
        Me.tempLocationPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tempLocationPath.Location = New System.Drawing.Point(6, 109)
        Me.tempLocationPath.Name = "tempLocationPath"
        Me.tempLocationPath.Size = New System.Drawing.Size(349, 20)
        Me.tempLocationPath.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Log:"
        '
        'ProgressLog
        '
        Me.ProgressLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressLog.BackColor = System.Drawing.SystemColors.Window
        Me.ProgressLog.Location = New System.Drawing.Point(6, 26)
        Me.ProgressLog.Name = "ProgressLog"
        Me.ProgressLog.ReadOnly = True
        Me.ProgressLog.Size = New System.Drawing.Size(579, 329)
        Me.ProgressLog.TabIndex = 18
        Me.ProgressLog.Text = ""
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.OutputFolderBrowseBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputFolderBrowseBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NoPipes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ffmpegVersionLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OutputTxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputFileBrowseBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RemoveTempFiles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OutputFileBrowseBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StartBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BrowseTempLocation)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tempLocationPath)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PauseResumeButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ClearLogBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SaveLogBtn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProgressLog)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer1.Size = New System.Drawing.Size(1049, 393)
        Me.SplitContainer1.SplitterDistance = 448
        Me.SplitContainer1.TabIndex = 19
        '
        'OutputFolderBrowseBtn
        '
        Me.OutputFolderBrowseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputFolderBrowseBtn.Location = New System.Drawing.Point(345, 65)
        Me.OutputFolderBrowseBtn.Name = "OutputFolderBrowseBtn"
        Me.OutputFolderBrowseBtn.Size = New System.Drawing.Size(91, 23)
        Me.OutputFolderBrowseBtn.TabIndex = 49
        Me.OutputFolderBrowseBtn.Text = "Browse Folder"
        Me.OutputFolderBrowseBtn.UseVisualStyleBackColor = True
        '
        'InputFolderBrowseBtn
        '
        Me.InputFolderBrowseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputFolderBrowseBtn.Location = New System.Drawing.Point(345, 23)
        Me.InputFolderBrowseBtn.Name = "InputFolderBrowseBtn"
        Me.InputFolderBrowseBtn.Size = New System.Drawing.Size(91, 23)
        Me.InputFolderBrowseBtn.TabIndex = 48
        Me.InputFolderBrowseBtn.Text = "Browse Folder"
        Me.InputFolderBrowseBtn.UseVisualStyleBackColor = True
        '
        'NoPipes
        '
        Me.NoPipes.AutoSize = True
        Me.NoPipes.Location = New System.Drawing.Point(151, 135)
        Me.NoPipes.Name = "NoPipes"
        Me.NoPipes.Size = New System.Drawing.Size(107, 17)
        Me.NoPipes.TabIndex = 47
        Me.NoPipes.Text = "Do not use Pipes"
        Me.NoPipes.UseVisualStyleBackColor = True
        '
        'ffmpegVersionLabel
        '
        Me.ffmpegVersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ffmpegVersionLabel.AutoSize = True
        Me.ffmpegVersionLabel.Location = New System.Drawing.Point(6, 347)
        Me.ffmpegVersionLabel.Name = "ffmpegVersionLabel"
        Me.ffmpegVersionLabel.Size = New System.Drawing.Size(79, 13)
        Me.ffmpegVersionLabel.TabIndex = 17
        Me.ffmpegVersionLabel.Text = "ffmpeg version:"
        '
        'PauseResumeButton
        '
        Me.PauseResumeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PauseResumeButton.Enabled = False
        Me.PauseResumeButton.Location = New System.Drawing.Point(6, 361)
        Me.PauseResumeButton.Name = "PauseResumeButton"
        Me.PauseResumeButton.Size = New System.Drawing.Size(163, 23)
        Me.PauseResumeButton.TabIndex = 21
        Me.PauseResumeButton.Text = "Pause"
        Me.PauseResumeButton.UseVisualStyleBackColor = True
        '
        'ClearLogBtn
        '
        Me.ClearLogBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearLogBtn.Location = New System.Drawing.Point(175, 361)
        Me.ClearLogBtn.Name = "ClearLogBtn"
        Me.ClearLogBtn.Size = New System.Drawing.Size(202, 23)
        Me.ClearLogBtn.TabIndex = 20
        Me.ClearLogBtn.Text = "Clear Log"
        Me.ClearLogBtn.UseVisualStyleBackColor = True
        '
        'SaveLogBtn
        '
        Me.SaveLogBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveLogBtn.Location = New System.Drawing.Point(383, 361)
        Me.SaveLogBtn.Name = "SaveLogBtn"
        Me.SaveLogBtn.Size = New System.Drawing.Size(202, 23)
        Me.SaveLogBtn.TabIndex = 19
        Me.SaveLogBtn.Text = "Save Log"
        Me.SaveLogBtn.UseVisualStyleBackColor = True
        '
        'AdvancedOptionsButton
        '
        Me.AdvancedOptionsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvancedOptionsButton.Location = New System.Drawing.Point(304, 116)
        Me.AdvancedOptionsButton.Name = "AdvancedOptionsButton"
        Me.AdvancedOptionsButton.Size = New System.Drawing.Size(120, 23)
        Me.AdvancedOptionsButton.TabIndex = 47
        Me.AdvancedOptionsButton.Text = "Advanced Options"
        Me.AdvancedOptionsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 393)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "SVT-AV1 GUI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.columns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.audioBitrate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InputTxt As TextBox
    Friend WithEvents OutputTxt As TextBox
    Friend WithEvents InputFileBrowseBtn As Button
    Friend WithEvents OutputFileBrowseBtn As Button
    Friend WithEvents StartBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BrowseTempLocation As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tempLocationPath As TextBox
    Friend WithEvents speed As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents audioBitrate As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents RemoveTempFiles As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ProgressLog As RichTextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ClearLogBtn As Button
    Friend WithEvents SaveLogBtn As Button
    Friend WithEvents PauseResumeButton As Button
    Friend WithEvents quantizer As NumericUpDown
    Friend WithEvents ffmpegVersionLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents columns As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents rows As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents AdditionalArguments As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TwoPassEncoding As CheckBox
    Friend WithEvents NoPipes As CheckBox
    Friend WithEvents OutputFolderBrowseBtn As Button
    Friend WithEvents InputFolderBrowseBtn As Button
    Friend WithEvents AdvancedOptionsButton As Button
End Class
