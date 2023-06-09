<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.lblShowScore = New System.Windows.Forms.Label()
        Me.lblShoowScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblShowScore
        '
        Me.lblShowScore.AutoSize = True
        Me.lblShowScore.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblShowScore.Location = New System.Drawing.Point(172, 196)
        Me.lblShowScore.Name = "lblShowScore"
        Me.lblShowScore.Size = New System.Drawing.Size(0, 50)
        Me.lblShowScore.TabIndex = 0
        Me.lblShowScore.Tag = "Label1"
        '
        'lblShoowScore
        '
        Me.lblShoowScore.AutoSize = True
        Me.lblShoowScore.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblShoowScore.Location = New System.Drawing.Point(191, 173)
        Me.lblShoowScore.Name = "lblShoowScore"
        Me.lblShoowScore.Size = New System.Drawing.Size(0, 50)
        Me.lblShoowScore.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(874, 519)
        Me.Controls.Add(Me.lblShoowScore)
        Me.Controls.Add(Me.lblShowScore)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblShowScore As Label
    Friend WithEvents lblShoowScore As Label
End Class
