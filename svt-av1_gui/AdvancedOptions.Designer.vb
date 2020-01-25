<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedOptions
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
        Me.HME2 = New System.Windows.Forms.CheckBox()
        Me.HME1 = New System.Windows.Forms.CheckBox()
        Me.HME0 = New System.Windows.Forms.CheckBox()
        Me.HME = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpenGOP = New System.Windows.Forms.RadioButton()
        Me.ClosedGOP = New System.Windows.Forms.RadioButton()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HME2
        '
        Me.HME2.AutoSize = True
        Me.HME2.Location = New System.Drawing.Point(182, 19)
        Me.HME2.Name = "HME2"
        Me.HME2.Size = New System.Drawing.Size(56, 17)
        Me.HME2.TabIndex = 43
        Me.HME2.Text = "HME2"
        Me.HME2.UseVisualStyleBackColor = True
        '
        'HME1
        '
        Me.HME1.AutoSize = True
        Me.HME1.Location = New System.Drawing.Point(120, 19)
        Me.HME1.Name = "HME1"
        Me.HME1.Size = New System.Drawing.Size(56, 17)
        Me.HME1.TabIndex = 42
        Me.HME1.Text = "HME1"
        Me.HME1.UseVisualStyleBackColor = True
        '
        'HME0
        '
        Me.HME0.AutoSize = True
        Me.HME0.Location = New System.Drawing.Point(62, 19)
        Me.HME0.Name = "HME0"
        Me.HME0.Size = New System.Drawing.Size(56, 17)
        Me.HME0.TabIndex = 41
        Me.HME0.Text = "HME0"
        Me.HME0.UseVisualStyleBackColor = True
        '
        'HME
        '
        Me.HME.AutoSize = True
        Me.HME.Location = New System.Drawing.Point(6, 19)
        Me.HME.Name = "HME"
        Me.HME.Size = New System.Drawing.Size(50, 17)
        Me.HME.TabIndex = 40
        Me.HME.Text = "HME"
        Me.HME.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HME)
        Me.GroupBox1.Controls.Add(Me.HME2)
        Me.GroupBox1.Controls.Add(Me.HME0)
        Me.GroupBox1.Controls.Add(Me.HME1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 53)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HME"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ClosedGOP)
        Me.GroupBox2.Controls.Add(Me.OpenGOP)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 46)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GOP Type:"
        '
        'OpenGOP
        '
        Me.OpenGOP.AutoSize = True
        Me.OpenGOP.Location = New System.Drawing.Point(6, 19)
        Me.OpenGOP.Name = "OpenGOP"
        Me.OpenGOP.Size = New System.Drawing.Size(51, 17)
        Me.OpenGOP.TabIndex = 0
        Me.OpenGOP.TabStop = True
        Me.OpenGOP.Text = "Open"
        Me.OpenGOP.UseVisualStyleBackColor = True
        '
        'ClosedGOP
        '
        Me.ClosedGOP.AutoSize = True
        Me.ClosedGOP.Location = New System.Drawing.Point(63, 19)
        Me.ClosedGOP.Name = "ClosedGOP"
        Me.ClosedGOP.Size = New System.Drawing.Size(57, 17)
        Me.ClosedGOP.TabIndex = 1
        Me.ClosedGOP.TabStop = True
        Me.ClosedGOP.Text = "Closed"
        Me.ClosedGOP.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(12, 134)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(247, 23)
        Me.CloseBtn.TabIndex = 46
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'AdvancedOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 169)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdvancedOptions"
        Me.Text = "Advanced Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HME2 As CheckBox
    Friend WithEvents HME1 As CheckBox
    Friend WithEvents HME0 As CheckBox
    Friend WithEvents HME As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ClosedGOP As RadioButton
    Friend WithEvents OpenGOP As RadioButton
    Friend WithEvents CloseBtn As Button
End Class
