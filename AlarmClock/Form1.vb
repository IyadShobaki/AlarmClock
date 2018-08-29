Public Class Form1
    Private seconds As Integer = 0
    Private minutes As Integer = 0
    Private hours As Integer = 0
    Private Sub SetAlarmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetAlarmToolStripMenuItem1.Click
        getTime.ShowDialog()
        Try
            lblTime.Text = getTime.setAlarm()
        Catch ex As Exception
            getTime.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeOfDay.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        RadioButton1.Checked = True
    End Sub

    Private Sub chkOnOff_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnOff.CheckedChanged
        Try
            If chkOnOff.Checked Then
                chkOnOff.Text = "on"
                Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("audiodg")
                For Each p As Process In pProcess
                    p.Kill()  ' Run Visual studio as administrator / if its cause a problem with sound, reopen visual studio, or replace it with 
                    ' this code " My.Computer.Audio.Stop() "
                Next
            Else
                chkOnOff.Text = "off"
            End If
        Catch ex As Exception
            MessageBox.Show("Please run visual studio as administrator")
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ResetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem1.Click
        getTime.ResetAlarm()
        lblTime.Text = ""  ' I forget this in the second submission
    End Sub

    Private Sub Add5SecondsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Add5SecondsToolStripMenuItem.Click
        lblTime.Text = DateAdd(DateInterval.Second, 5, CDate(lblTime.Text))
    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If chkOnOff.Checked Then

        ElseIf lblTimeOfDay.Text = lblTime.Text Then
            If RadioButton1.Checked = True Then
                My.Computer.Audio.Play(My.Resources.alarm_clock_1, AudioPlayMode.BackgroundLoop)
                Timer3.Start() ' I forget this in the first submission 
            ElseIf RadioButton2.Checked = True Then
                My.Computer.Audio.Play(My.Resources.alarm_clock_2, AudioPlayMode.BackgroundLoop) ' I didn't know how to save SAPI to WAV file
                Timer3.Start()
            End If

        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        Try
            Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("audiodg")
            For Each p As Process In pProcess
                p.Kill()  ' Run Visual studio as administrator  / if its cause a problem with sound, reopen visual studio, or replace it with 
                ' this code " My.Computer.Audio.Stop() "
            Next
        Catch ex As Exception
            MessageBox.Show("Please run visual studio as administrator")
        End Try

    End Sub


    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If chkOnOff.Checked Then
            lblAlarmOff.Text = ""
        Else
            seconds += 1
            If (seconds >= 60) Then
                minutes += 1
                seconds = 0

            End If
            If (minutes >= 60) Then
                hours += 1
                minutes = 0
            End If
            lblAlarmOff.Text = "Alarm will be off in 10 seconds " & hours.ToString() & ":" & minutes.ToString() & ":" & seconds.ToString()
            Timer4.Start()
        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Try
            If lblAlarmOff.Text = "Alarm will be off in 10 seconds 0:0:10" Then
                Timer3.Stop()
                Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("audiodg")
                For Each p As Process In pProcess
                    p.Kill()  ' Run Visual studio as administrator / if its cause a problem with sound, reopen visual studio, or replace it with 
                    ' this code " My.Computer.Audio.Stop() "
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Please run visual studio as administrator")
        End Try


    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("Alarm Clock made by Iyad Shobaki")
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        If chkOnOff.Checked Then
            MessageBox.Show("Switch Check box to on")
        Else
            My.Computer.Audio.Play(My.Resources.alarm_clock_1, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub TestToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem1.Click
        If chkOnOff.Checked Then
            MessageBox.Show("Switch Check box to on")
        Else
            Text = InputBox$("Enter a text")
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.rate = 1
            SAPI.Volume = 100
            If Text <> "" Then
                SAPI.Speak(Text)
            Else
                SAPI.speak("You have not typed anything")
            End If
        End If
    End Sub

    Private Sub ActivateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateToolStripMenuItem.Click
        RadioButton1.Checked = True
    End Sub

    Private Sub ActivateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActivateToolStripMenuItem1.Click
        RadioButton2.Checked = True
    End Sub
End Class
