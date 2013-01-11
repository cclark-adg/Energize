<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Me.pbSplashScreen = New System.Windows.Forms.PictureBox()
        CType(Me.pbSplashScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSplashScreen
        '
        Me.pbSplashScreen.Image = Global.Energize.My.Resources.Resources.splashScreen
        Me.pbSplashScreen.InitialImage = Global.Energize.My.Resources.Resources.splashScreen
        Me.pbSplashScreen.Location = New System.Drawing.Point(0, 0)
        Me.pbSplashScreen.Name = "pbSplashScreen"
        Me.pbSplashScreen.Size = New System.Drawing.Size(159, 162)
        Me.pbSplashScreen.TabIndex = 0
        Me.pbSplashScreen.TabStop = False
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(159, 161)
        Me.Controls.Add(Me.pbSplashScreen)
        Me.Name = "frmSplashScreen"
        Me.ShowIcon = False
        Me.Text = "Energize"
        Me.TopMost = True
        CType(Me.pbSplashScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbSplashScreen As System.Windows.Forms.PictureBox
End Class
