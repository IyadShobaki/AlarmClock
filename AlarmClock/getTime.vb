Imports System.Windows.Forms

Public Class getTime

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Function setAlarm() As String
        Dim result As String = "12:00:00 AM"
        Try
            result = mskTime.Text
            If radAM.Checked Then
                result &= " AM"
            Else
                result &= " PM"
            End If
            Return result
        Catch ex As Exception
            MessageBox.Show("Error entering time:" & ex.Message)
            result = "12:00:00 AM"
            Return result
        End Try
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetAlarm()
    End Sub
    Public Sub ResetAlarm()
        mskTime.Text = ""
        radAM.Checked = False
        radPM.Checked = False
    End Sub
    Public Sub Add5sec()
        mskTime.Text = DateAdd(DateInterval.Second, 5, CDate(mskTime.Text))
    End Sub

    Private Sub getTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
