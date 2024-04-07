Public Class config

    Dim isinit As Boolean = False
    Private Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Value = My.Settings.WORK_TIME
        NumericUpDown2.Value = My.Settings.BREAK_TIME
        TextBox1.Text = My.Settings.alarm_start
        TextBox2.Text = My.Settings.alarm_stop

        isinit = True
        TextBox1_TextChanged(TextBox1, Nothing)
        TextBox2_TextChanged(TextBox2, Nothing)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, NumericUpDown1.TextChanged
        If Not isinit Then Return
        My.Settings.WORK_TIME = NumericUpDown1.Value
        MainForm.WORK_TIME = My.Settings.WORK_TIME * 60
        My.Settings.Save()
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged, NumericUpDown2.TextChanged
        If Not isinit Then Return
        My.Settings.BREAK_TIME = NumericUpDown2.Value
        MainForm.BREAK_TIME = My.Settings.BREAK_TIME * 60
        My.Settings.Save()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IO.File.Exists(TextBox1.Text) Then
            TextBox1.BackColor = Color.Lavender
            My.Settings.alarm_start = TextBox1.Text
            MainForm.alarm_start = My.Settings.alarm_start
            My.Settings.Save()
        Else
            TextBox1.BackColor = Color.LightPink

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If IO.File.Exists(TextBox2.Text) Then
            TextBox2.BackColor = Color.Lavender
            My.Settings.alarm_stop = TextBox2.Text
            MainForm.alarm_stop = My.Settings.alarm_stop
            My.Settings.Save()
        Else
            TextBox2.BackColor = Color.LightPink

        End If
    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class