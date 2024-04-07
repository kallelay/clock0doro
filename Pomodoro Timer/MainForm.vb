Imports System.Math
Imports System.Configuration
Imports System.Windows.Forms.PropertyGridInternal

Public Class MainForm


    '***************************** "parameters" *********************'

    'Times for work and break
    Public WORK_TIME% = 25 * 60 '+ 1
    Public BREAK_TIME% = 5 * 60 '+ 1

    Public alarm_stop = "alarm14.wav"
    Public alarm_start = "ala1.wav"


    ' Public LABEL_BREAK_COLOR = Color.FromArgb(119, 221, 119)
    ' Public BACKG_BREAK_COLOR = Color.FromArgb(234, 255, 245)

    ' Public LABEL_WORK_COLOR = Color.FromArgb(92, 141, 239)
    ' Public BACKG_WORK_COLOR = Color.FromArgb(230, 240, 255)



    Enum MODES
        break = 0
        work = 1
        Invalid = -1
    End Enum

    '***************************** "Variables" *********************'


    Dim isPaused As Boolean = True          'Is it paused mode?
    Public CURRENT_MODE As MODES = MODES.work   'work or break
    Public curTime = WORK_TIME                  'countdown timer for both break and work

    'Update GUI pause info (either pause or play symbol)
    Sub updatePauseButton()
        If Not isPaused Then
            btnPause.Text = "⏸︎"
            btnPause.Font = New Font("arial", 6.75, FontStyle.Bold)
        Else
            btnPause.Text = "▶"
        End If

    End Sub

    'Start Pomodoro
    Sub startPomodoro(Optional setMode As MODES = MODES.Invalid)

        isPaused = False 'unset pause

        'Reset countdown timer according to the selected mode in argument
        If setMode = MODES.work Then
            CURRENT_MODE = MODES.work
            curTime = WORK_TIME
        ElseIf setMode = MODES.break Then
            CURRENT_MODE = MODES.break
            curTime = BREAK_TIME

        End If

        'Set timer 1 as enabled
        Timer1.Enabled = True

        'Update GUI
        Timer1_Tick(Nothing, Nothing)
        updatePauseButton()

        'Play sound
        playSound()


    End Sub

    'Pause/Resume pomodoro
    Sub pausePomodoro()


        isPaused = Not isPaused
        If Not isPaused Then startPomodoro()
        Timer2.Enabled = False 'Synchronize timer 2 and 1
        Timer1.Enabled = Not isPaused 'Force timer to start or stop
        Threading.Thread.Sleep(10)
        Timer2.Enabled = True

        updatePauseButton()

        If Not isPaused Then playSound()

    End Sub

    'Stop Podomoro
    Sub stopPomodoro()

        If CURRENT_MODE = MODES.break Then curTime = BREAK_TIME Else curTime = WORK_TIME
        Timer1.Stop()
        Timer1_Tick(Nothing, Nothing) 'update

        isPaused = True
        'update pause button
        updatePauseButton()


    End Sub

    'Stop button
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        stopPomodoro()

    End Sub

    'break button
    Private Sub btnBreak_Click(sender As Object, e As EventArgs) Handles btnBreak.Click
        startPomodoro(MODES.break)

    End Sub

    'Work button
    Private Sub btnWork_Click(sender As Object, e As EventArgs) Handles btnWork.Click
        curTime = 3600 - (Now.Minute * 60 - Now.Second)

        startPomodoro(MODES.work)
    End Sub

    Dim timeOutScreen = 0


    'Play different sound according to starting break or work
    Sub playSound()
        Try
            If CheckBox1.Checked Then

                If CURRENT_MODE = MODES.break Then
                    My.Computer.Audio.Play(alarm_stop)
                Else
                    My.Computer.Audio.Play(alarm_start)
                End If
            End If

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
        End Try
    End Sub

    'Main responsible for timing: Timer1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        curTime -= 1 'countdown timer

        'Check if elapsed, toggle mode and reset
        If curTime <= 0 Then
            CURRENT_MODE = 1 - CURRENT_MODE
            If CURRENT_MODE = MODES.break Then curTime = BREAK_TIME Else curTime = WORK_TIME
            playSound()
        End If


        'Update GUI
        lblTime.Text = Strings.Format(Int(curTime / 60), "00") & ":" &
        Strings.Format(curTime Mod 60, "00")

        'Window name
        If Me.WindowState = FormWindowState.Minimized Then
            Text = "Clock0doro (" & CURRENT_MODE.ToString & ", " & lblTime.Text & ")"
        Else
            Text = "Clock0doro" ' (" & CURRENT_MODE.ToString & ", " & lblTime.Text & ")"
        End If


        'Unused code, it used to make it possible to resize only if it's on hover
        Dim ptr_ = Cursor.Position - Me.Location - New Point(10, 10)
        If ptr_.X > 0 AndAlso ptr_.Y > 0 Then
            ptr_ = New Point(Me.Size.Width + 20, Me.Size.Height + 20) - ptr_
            If ptr_.X > 0 AndAlso ptr_.Y > 0 Then

                timeOutScreen = 0
            Else
                timeOutScreen += 1
            End If
        Else
            timeOutScreen += 1
        End If

        GoTo skip_resizable
        If timeOutScreen >= 3 Then
            Me.FormBorderStyle = FormBorderStyle.None
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable

        End If
skip_resizable:


    End Sub

    'Cycle color (unusued code)
    Private Function cycleColor(c1 As Color, c2 As Color, it As Integer, maxit As Integer)
        Dim coef! = Abs(Sin(2.0 * PI * it / (2 * maxit)))
        cycleColor = Color.FromArgb(c1.R * coef + (1 - coef) * c2.R, c1.G * coef + (1 - coef) * c2.G, c1.B * coef + (1 - coef) * c2.B)
    End Function

    Dim tickCounter = 0 'Tick for animation


    'Timer 2: responsible for animating "Panel2" (label on the left)
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Panel3.Invalidate() 'invalidate dummy (no longer required)
        Panel2.Invalidate() 'invalidate state

        tickCounter += 1
        If Timer1.Enabled Then 'not paused
            lblTime.ForeColor = Color.GhostWhite
        Else 'if paused (breathing animation)
            Dim r = CInt(Cos(tickCounter / 100 * 2 * PI) * 64 + 164)
            lblTime.ForeColor = Color.FromArgb(r, r, r)

        End If



        '  If CURRENT_MODE = MODES.break Then
        '  Me.BackColor = cycleColor(BACKG_BREAK_COLOR, Color.White, System.Environment.TickCount, BREATHING_CYCLE * 1000.0)
        '  Else
        '  Me.BackColor = cycleColor(BACKG_WORK_COLOR, Color.White, System.Environment.TickCount, BREATHING_CYCLE * 1000.0)
        '  End If
    End Sub
    'Toggle top most
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TopMost = Not TopMost
    End Sub

    'Force aspect ratio during resizing
    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.Width = Me.Height / 1.2124352331606219 'keep aspect ratio
    End Sub

    'Timer 3: responsible for updating the analog clock face
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick


        ' Me.InvokePaint()
        Panel1.Invalidate()

        'Me.InvokePaint(Nothing,Me)
    End Sub

    'Panel 1: Analog clock face
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.CompositingQuality = Drawing2D.CompositingQuality.AssumeLinear
        g.InterpolationMode = Drawing2D.InterpolationMode.High

        'Square of hour size
        Dim sq% = Panel1.Height / 138 * 118 ' Dim sq% = 115


        'hand line sizes
        Dim hrHand = Panel1.Height / 138 * 30
        Dim mnHand = Panel1.Height / 138 * 40
        Dim scHand = Panel1.Height / 138 * 50

        g.TranslateTransform(8, 8) 'not fixed

        'hour numeral pos
        Dim hrnumpos = sq / 2.45
        Dim numfnt = New Font("Arial Normal", Panel1.Height / 138 * 10) 'numeral fonts

        'draw circle
        If Not isPaused Then
            If CURRENT_MODE = MODES.break Then
                g.DrawArc(New Pen(Color.PaleVioletRed, 2), New Rectangle(-7.5, -7.5, sq + 15, sq + 15), CSng(-90), CSng(curTime / BREAK_TIME * 360))
            Else
                g.DrawArc(New Pen(Color.LawnGreen, 2), New Rectangle(-7.5, -7.5, sq + 15, sq + 15), CSng(-90), CSng(curTime / WORK_TIME * 360))
            End If
        End If

        ' Draw clock face
        g.FillEllipse(Brushes.Black, New Rectangle(0, 0, sq, sq))

        'Draw pomodoro pies (give me remaining time for work and break in analog clock as a chartpie in green and/or red)
        If Not isPaused Then
            If CURRENT_MODE = MODES.break Then
                g.FillPie(New SolidBrush(Color.FromArgb(96, 255, 192, 192)), New Rectangle(0, 0, sq, sq), CSng(-90 + (Now.Minute + Now.Second / 60) / 60 * 360), CSng(curTime / 3600 * 360))
            Else
                g.FillPie(New SolidBrush(Color.FromArgb(79, 180, 255, 201)), New Rectangle(0, 0, sq, sq), CSng(-90 + (Now.Minute + Now.Second / 60) / 60 * 360), CSng(curTime / 3600 * 360))
                g.FillPie(New SolidBrush(Color.FromArgb(96, 255, 192, 192)), New Rectangle(0, 0, sq, sq), CSng(-90 + (Now.Minute + Now.Second / 60) / 60 * 360) + CSng(curTime / 3600 * 360), CSng(BREAK_TIME / 3600 * 360))

            End If

        End If

        'face's outline
        g.DrawEllipse(New Pen(Color.Gray, 2), New Rectangle(0, 0, sq, sq))

        'draw numbers
        Dim dimString As PointF 'store temp dimension of string
        For k = 1 To 12
            g.DrawEllipse(Pens.GhostWhite, CInt(sq / 2 + Cos(-PI / 2 + k / 12 * 2 * PI) * sq / 2) - 1, CInt(sq / 2 + Sin(-PI / 2 + k / 12 * 2 * PI) * sq / 2) - 1, 2, 2)
            dimString = g.MeasureString(k, numfnt)
            g.DrawString(k, numfnt, New SolidBrush(Color.White), New Point(sq / 2 + Cos(-PI / 2 + k / 12 * 2 * PI) * hrnumpos - dimString.X / 2, sq / 2 + Sin(-PI / 2 + k / 12 * 2 * PI) * hrnumpos - dimString.Y / 2.5))

        Next

        'Hand's actual angles (/12 for hour, /60 for minutes/seconds)
        Dim hourAngle As Double = (Now.Hour - 1) Mod 12 + 1 + Now.Minute / 60.0
        Dim minuteAngle As Double = Now.Minute + Now.Second / 60.0
        Dim secondAngle As Double = Now.Second

        Dim p = New Pen(Color.GhostWhite, Panel1.Height / 138 * 5)
        p.EndCap = Drawing2D.LineCap.Round
        g.DrawLine(p, New Point(sq / 2, sq / 2), New Point(sq / 2 + Cos(-PI / 2 + hourAngle / 12 * 2 * PI) * hrHand, sq / 2 + Sin(-PI / 2 + hourAngle / 12 * 2 * PI) * hrHand))

        p = New Pen(Color.White, Panel1.Height / 138 * 3)
        p.EndCap = Drawing2D.LineCap.Round
        g.DrawLine(p, New Point(sq / 2, sq / 2), New Point(sq / 2 + Cos(-PI / 2 + minuteAngle / 60 * 2 * PI) * mnHand, sq / 2 + Sin(-PI / 2 + minuteAngle / 60 * 2 * PI) * mnHand))

        p = New Pen(Color.Red, Panel1.Height / 138 * 2)
        p.EndCap = Drawing2D.LineCap.Round
        g.DrawLine(p, New Point(sq / 2, sq / 2), New Point(sq / 2 + Cos(-PI / 2 + secondAngle / 60 * 2 * PI) * scHand, sq / 2 + Sin(-PI / 2 + secondAngle / 60 * 2 * PI) * scHand))

        'Circle on the middle
        g.FillEllipse(Brushes.DimGray, CInt(sq / 2 - Panel1.Height / 138 * 4), CInt(sq / 2 - Panel1.Height / 138 * 4), CInt(Panel1.Height / 138 * 8), CInt(Panel1.Height / 138 * 8))


    End Sub

    'Toggle pause button click
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        pausePomodoro()
    End Sub

    'Timer 2: responsible for that label on the left (paused/work time or break time)
    Dim DLatchTimer% = 25 '10 cycles
    Dim prevMode = 0

    'Draw Panel on the left
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.TranslateTransform(2, Me.Height - 45 - DLatchTimer / 3) 'to the bottom
        g.RotateTransform(-90) 'rotate text -90°

        Dim curMode% = isPaused * 2 + CURRENT_MODE 'current mode enum

        If (prevMode <> curMode%) And (DLatchTimer > 0 And DLatchTimer <= 25) Then DLatchTimer% = -25 Else DLatchTimer += Abs(Int(DLatchTimer < 25))




        If DLatchTimer = 0 Then prevMode = isPaused * 2 + CURRENT_MODE




        'Normal cycle (slow blinking)
        If prevMode And 2 Then
            Panel2.BackColor = Color.FromArgb(128 + DLatchTimer% * 5, 60, 60, 60)
            Dim r = CInt(Cos(tickCounter / 100 * 2 * PI) * 64 + 164)
            g.DrawString("Paused", New Font("Arial", 10, FontStyle.Bold), New SolidBrush(Color.FromArgb(r, r, r)), New Point(0, 0))
        Else
            If prevMode = MODES.work Then
                Panel2.BackColor = Color.FromArgb(128 + DLatchTimer% * 5, 63, 75, 63)
                Dim r = CInt(Cos(tickCounter / 100 * 2 * PI) * 28 + 184)
                g.DrawString("Work Time", New Font("Arial", 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(r, r + 10, r)), New Point(0, 0))
            Else
                Panel2.BackColor = Color.FromArgb(128 + DLatchTimer% * 5, 75, 63, 63)
                Dim r = CInt(Cos(tickCounter / 100 * 2 * PI) * 28 + 184)
                g.DrawString("Break Time", New Font("Arial", 8, FontStyle.Bold), New SolidBrush(Color.FromArgb(r + 10, r, r)), New Point(0, 0))

            End If

        End If

        g.ResetTransform()
    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim g As Graphics = e.Graphics
        Dim r = CInt(Cos(Environment.TickCount / 10000.0 * 2 * PI) * 64 + 164)
        g.DrawString("Paused", New Font("Arial", 10), New SolidBrush(Color.FromArgb(r, r, r)), New Point(0, 0))
        g.Clear(Panel3.BackColor)
        g.ResetTransform()

    End Sub


    Private Sub Syncbt_Click(sender As Object, e As EventArgs) Handles syncbt.Click
        curTime = (3600 - (Now.Minute * 60 + Now.Second)) Mod (BREAK_TIME + WORK_TIME)

        Dim cct = curTime + 0
        If curTime < BREAK_TIME Then
            startPomodoro(MODES.break)
        Else
            startPomodoro(MODES.work)
            cct -= BREAK_TIME
        End If
        curTime = cct

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '"ala1.wav"


        'If My.Application.
        WORK_TIME = My.Settings.WORK_TIME * 60
        BREAK_TIME = My.Settings.BREAK_TIME * 60

        alarm_stop = My.Settings.alarm_stop
        alarm_start = My.Settings.alarm_start
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        config.Show()
    End Sub
End Class

