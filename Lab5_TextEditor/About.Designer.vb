<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.txtAboutInfo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAboutInfo
        '
        Me.txtAboutInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAboutInfo.Location = New System.Drawing.Point(165, 66)
        Me.txtAboutInfo.Multiline = True
        Me.txtAboutInfo.Name = "txtAboutInfo"
        Me.txtAboutInfo.ReadOnly = True
        Me.txtAboutInfo.Size = New System.Drawing.Size(312, 127)
        Me.txtAboutInfo.TabIndex = 0
        Me.txtAboutInfo.Text = "NETD 2202" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lab 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nirmal Patel"
        Me.txtAboutInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 263)
        Me.Controls.Add(Me.txtAboutInfo)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAboutInfo As TextBox
End Class
