<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        components = New ComponentModel.Container()
        btnPause = New Button()
        btnBreak = New Button()
        btnStop = New Button()
        btnWork = New Button()
        Button1 = New Button()
        lblTime = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Label1 = New Label()
        Timer3 = New Timer(components)
        Timer4 = New Timer(components)
        Panel3 = New Panel()
        syncbt = New Button()
        Panel1 = New Label()
        Panel2 = New Label()
        ToolTip1 = New ToolTip(components)
        Button3 = New Button()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' btnPause
        ' 
        btnPause.Anchor = AnchorStyles.Bottom
        btnPause.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPause.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnPause.FlatAppearance.BorderColor = Color.Gray
        btnPause.FlatStyle = FlatStyle.Flat
        btnPause.Font = New Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPause.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnPause.ImageAlign = ContentAlignment.BottomCenter
        btnPause.Location = New Point(53, 167)
        btnPause.Name = "btnPause"
        btnPause.Size = New Size(20, 20)
        btnPause.TabIndex = 1
        btnPause.Text = "▶"
        btnPause.TextAlign = ContentAlignment.TopCenter
        ToolTip1.SetToolTip(btnPause, "Pause/Resume")
        btnPause.UseCompatibleTextRendering = True
        btnPause.UseMnemonic = False
        btnPause.UseVisualStyleBackColor = False
        ' 
        ' btnBreak
        ' 
        btnBreak.Anchor = AnchorStyles.Bottom
        btnBreak.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnBreak.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnBreak.FlatAppearance.BorderColor = Color.Gray
        btnBreak.FlatStyle = FlatStyle.Flat
        btnBreak.Font = New Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnBreak.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnBreak.ImageAlign = ContentAlignment.BottomCenter
        btnBreak.Location = New Point(100, 167)
        btnBreak.Name = "btnBreak"
        btnBreak.Size = New Size(20, 20)
        btnBreak.TabIndex = 1
        btnBreak.Text = "B"
        btnBreak.TextAlign = ContentAlignment.TopCenter
        btnBreak.TextImageRelation = TextImageRelation.TextAboveImage
        ToolTip1.SetToolTip(btnBreak, "Break time")
        btnBreak.UseCompatibleTextRendering = True
        btnBreak.UseMnemonic = False
        btnBreak.UseVisualStyleBackColor = False
        ' 
        ' btnStop
        ' 
        btnStop.Anchor = AnchorStyles.Bottom
        btnStop.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnStop.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnStop.FlatAppearance.BorderColor = Color.Gray
        btnStop.FlatStyle = FlatStyle.Flat
        btnStop.Font = New Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnStop.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnStop.ImageAlign = ContentAlignment.BottomCenter
        btnStop.Location = New Point(76, 167)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(20, 20)
        btnStop.TabIndex = 1
        btnStop.Text = "⏹"
        btnStop.TextAlign = ContentAlignment.TopCenter
        ToolTip1.SetToolTip(btnStop, "Stop")
        btnStop.UseCompatibleTextRendering = True
        btnStop.UseMnemonic = False
        btnStop.UseVisualStyleBackColor = False
        ' 
        ' btnWork
        ' 
        btnWork.Anchor = AnchorStyles.Bottom
        btnWork.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnWork.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnWork.FlatAppearance.BorderColor = Color.Gray
        btnWork.FlatStyle = FlatStyle.Flat
        btnWork.Font = New Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnWork.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnWork.ImageAlign = ContentAlignment.BottomCenter
        btnWork.Location = New Point(126, 167)
        btnWork.Name = "btnWork"
        btnWork.Size = New Size(20, 20)
        btnWork.TabIndex = 1
        btnWork.Text = "Work time"
        btnWork.TextAlign = ContentAlignment.TopCenter
        btnWork.TextImageRelation = TextImageRelation.TextAboveImage
        ToolTip1.SetToolTip(btnWork, "Work Time")
        btnWork.UseCompatibleTextRendering = True
        btnWork.UseMnemonic = False
        btnWork.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom
        Button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Button1.FlatAppearance.BorderColor = Color.Gray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(28, 167)
        Button1.Name = "Button1"
        Button1.Size = New Size(20, 20)
        Button1.TabIndex = 0
        Button1.Text = "T"
        Button1.TextAlign = ContentAlignment.TopCenter
        ToolTip1.SetToolTip(Button1, "Toggle top most ")
        Button1.UseCompatibleTextRendering = True
        Button1.UseMnemonic = False
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTime.AutoEllipsis = True
        lblTime.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblTime.Font = New Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point)
        lblTime.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblTime.Location = New Point(56, 8)
        lblTime.Margin = New Padding(0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(70, 20)
        lblTime.TabIndex = 3
        lblTime.Text = "00:00"
        lblTime.TextAlign = ContentAlignment.TopCenter
        lblTime.UseCompatibleTextRendering = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 90
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Dock = DockStyle.Fill
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 195)
        Label1.TabIndex = 4
        ' 
        ' Timer3
        ' 
        Timer3.Enabled = True
        Timer3.Interval = 1000
        ' 
        ' Timer4
        ' 
        Timer4.Interval = 1000
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel3.Location = New Point(27, 31)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(133, 121)
        Panel3.TabIndex = 7
        ' 
        ' syncbt
        ' 
        syncbt.Anchor = AnchorStyles.Bottom
        syncbt.AutoSizeMode = AutoSizeMode.GrowAndShrink
        syncbt.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        syncbt.FlatAppearance.BorderColor = Color.Gray
        syncbt.FlatStyle = FlatStyle.Flat
        syncbt.Font = New Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point)
        syncbt.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        syncbt.ImageAlign = ContentAlignment.BottomCenter
        syncbt.Location = New Point(152, 167)
        syncbt.Name = "syncbt"
        syncbt.Size = New Size(20, 20)
        syncbt.TabIndex = 1
        syncbt.Text = "Synchronize"
        syncbt.TextAlign = ContentAlignment.TopCenter
        syncbt.TextImageRelation = TextImageRelation.TextAboveImage
        syncbt.UseCompatibleTextRendering = True
        syncbt.UseMnemonic = False
        syncbt.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Location = New Point(24, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(148, 132)
        Panel1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel2.Location = New Point(0, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(22, 194)
        Panel2.TabIndex = 9
        ' 
        ' Button3
        ' 
        Button3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button3.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Button3.FlatAppearance.BorderColor = Color.Gray
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.ImageAlign = ContentAlignment.BottomCenter
        Button3.Location = New Point(4, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(20, 20)
        Button3.TabIndex = 11
        Button3.Text = "⚙"
        Button3.TextAlign = ContentAlignment.TopCenter
        ToolTip1.SetToolTip(Button3, "Settings")
        Button3.UseCompatibleTextRendering = True
        Button3.UseMnemonic = False
        Button3.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Black
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(160, 7)
        CheckBox1.Margin = New Padding(2, 2, 2, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(12, 11)
        CheckBox1.TabIndex = 10
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(177, 195)
        Controls.Add(Button3)
        Controls.Add(CheckBox1)
        Controls.Add(syncbt)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblTime)
        Controls.Add(Panel3)
        Controls.Add(btnWork)
        Controls.Add(btnBreak)
        Controls.Add(btnStop)
        Controls.Add(btnPause)
        Controls.Add(Button1)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        MaximizeBox = False
        MinimizeBox = False
        Name = "MainForm"
        Text = "Clock0doro"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'this is magic code that has an enormous positive effect on reducing flickering.
        'don't remove this.
        'found this nugget here: http://www.vbmigration.com/detknowledgebase.aspx?Id=692
        Get
            Dim params As CreateParams = MyBase.CreateParams
            params.ExStyle = params.ExStyle Or &H2000000
            Return params
        End Get
    End Property


    Friend WithEvents btnPause As Button
    Friend WithEvents btnBreak As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnWork As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Label
    Friend WithEvents Panel2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents syncbt As Button
    Friend WithEvents Button3 As Button
End Class
