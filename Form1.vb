Imports System.Runtime.InteropServices

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        frmMain.Show()
        If OptYes.Checked Then
            Score = Score + 1

        End If



    End Sub

End Class
