<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class config
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        NumericUpDown1 = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        NumericUpDown2 = New NumericUpDown()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Button1 = New Button()
        Button2 = New Button()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.BackColor = Color.Black
        NumericUpDown1.ForeColor = Color.White
        NumericUpDown1.Location = New Point(173, 36)
        NumericUpDown1.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 31)
        NumericUpDown1.TabIndex = 0
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 25)
        Label1.TabIndex = 1
        Label1.Text = "Work Time:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 25)
        Label2.TabIndex = 3
        Label2.Text = "Break Time:"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.BackColor = Color.Black
        NumericUpDown2.ForeColor = Color.White
        NumericUpDown2.Location = New Point(173, 86)
        NumericUpDown2.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(120, 31)
        NumericUpDown2.TabIndex = 2
        NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(27, 167)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(27, 249)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 31)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 25)
        Label3.TabIndex = 1
        Label3.Text = "Start Alarm:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 25)
        Label4.TabIndex = 6
        Label4.Text = "Stop Alarm"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "ofd"
        OpenFileDialog1.Filter = ".WAV file (*.wav)|*.wav"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(282, 167)
        Button1.Name = "Button1"
        Button1.Size = New Size(41, 28)
        Button1.TabIndex = 7
        Button1.Text = "..."
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.TextImageRelation = TextImageRelation.TextAboveImage
        Button1.UseCompatibleTextRendering = True
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(282, 247)
        Button2.Name = "Button2"
        Button2.Size = New Size(41, 28)
        Button2.TabIndex = 8
        Button2.Text = "..."
        Button2.TextAlign = ContentAlignment.TopCenter
        Button2.TextImageRelation = TextImageRelation.TextAboveImage
        Button2.UseCompatibleTextRendering = True
        Button2.UseVisualStyleBackColor = True
        ' 
        ' config
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(335, 292)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(NumericUpDown2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(NumericUpDown1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "config"
        Text = "Configuration"
        TopMost = True
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
