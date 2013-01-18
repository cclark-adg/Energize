<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoyaltyProgram
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SM_gbTstatControls = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SM_tbTstatSlider = New System.Windows.Forms.TrackBar()
        Me.SM_nudSetPoint = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SM_gbTVControls = New System.Windows.Forms.GroupBox()
        Me.SM_rbTvOff = New System.Windows.Forms.RadioButton()
        Me.SM_rbTvOn = New System.Windows.Forms.RadioButton()
        Me.SM_gbLights = New System.Windows.Forms.GroupBox()
        Me.SM_rbDigitalOn = New System.Windows.Forms.RadioButton()
        Me.SM_rbDigitalOff = New System.Windows.Forms.RadioButton()
        Me.SM_cbAreas = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SM_tcShades = New System.Windows.Forms.TabControl()
        Me.SM_tpSetting1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SM_rbShadeOpen = New System.Windows.Forms.RadioButton()
        Me.SM_rbShadeClosed = New System.Windows.Forms.RadioButton()
        Me.SM_tpSetting2 = New System.Windows.Forms.TabPage()
        Me.SM_tbAnalogValue = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SM_lblAnalogZero = New System.Windows.Forms.Label()
        Me.SM_lblAnalogHundred = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SM_rbSunTrackOn = New System.Windows.Forms.RadioButton()
        Me.SM_rbSunTrackOff = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SM_cbDevices = New System.Windows.Forms.ComboBox()
        Me.GroupBox4.SuspendLayout()
        Me.SM_gbTstatControls.SuspendLayout()
        CType(Me.SM_tbTstatSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SM_nudSetPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SM_gbTVControls.SuspendLayout()
        Me.SM_gbLights.SuspendLayout()
        Me.SM_tcShades.SuspendLayout()
        Me.SM_tpSetting1.SuspendLayout()
        Me.SM_tpSetting2.SuspendLayout()
        CType(Me.SM_tbAnalogValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(338, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(338, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer ID:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SM_gbTstatControls)
        Me.GroupBox4.Controls.Add(Me.SM_gbTVControls)
        Me.GroupBox4.Controls.Add(Me.SM_gbLights)
        Me.GroupBox4.Controls.Add(Me.SM_tcShades)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.SM_cbDevices)
        Me.GroupBox4.Location = New System.Drawing.Point(144, 190)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(515, 223)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Device Settings"
        '
        'SM_gbTstatControls
        '
        Me.SM_gbTstatControls.Controls.Add(Me.Label11)
        Me.SM_gbTstatControls.Controls.Add(Me.Label9)
        Me.SM_gbTstatControls.Controls.Add(Me.SM_tbTstatSlider)
        Me.SM_gbTstatControls.Controls.Add(Me.SM_nudSetPoint)
        Me.SM_gbTstatControls.Controls.Add(Me.Label6)
        Me.SM_gbTstatControls.Location = New System.Drawing.Point(275, 16)
        Me.SM_gbTstatControls.Name = "SM_gbTstatControls"
        Me.SM_gbTstatControls.Size = New System.Drawing.Size(159, 200)
        Me.SM_gbTstatControls.TabIndex = 19
        Me.SM_gbTstatControls.TabStop = False
        Me.SM_gbTstatControls.Text = "Thermostat Controls"
        Me.SM_gbTstatControls.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "90"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "60"
        '
        'SM_tbTstatSlider
        '
        Me.SM_tbTstatSlider.Location = New System.Drawing.Point(96, 22)
        Me.SM_tbTstatSlider.Maximum = 90
        Me.SM_tbTstatSlider.Minimum = 60
        Me.SM_tbTstatSlider.Name = "SM_tbTstatSlider"
        Me.SM_tbTstatSlider.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.SM_tbTstatSlider.Size = New System.Drawing.Size(45, 169)
        Me.SM_tbTstatSlider.TabIndex = 3
        Me.SM_tbTstatSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.SM_tbTstatSlider.Value = 60
        '
        'SM_nudSetPoint
        '
        Me.SM_nudSetPoint.Location = New System.Drawing.Point(13, 83)
        Me.SM_nudSetPoint.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.SM_nudSetPoint.Minimum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.SM_nudSetPoint.Name = "SM_nudSetPoint"
        Me.SM_nudSetPoint.Size = New System.Drawing.Size(43, 20)
        Me.SM_nudSetPoint.TabIndex = 2
        Me.SM_nudSetPoint.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Set Point:"
        '
        'SM_gbTVControls
        '
        Me.SM_gbTVControls.Controls.Add(Me.SM_rbTvOff)
        Me.SM_gbTVControls.Controls.Add(Me.SM_rbTvOn)
        Me.SM_gbTVControls.Location = New System.Drawing.Point(275, 16)
        Me.SM_gbTVControls.Name = "SM_gbTVControls"
        Me.SM_gbTVControls.Size = New System.Drawing.Size(169, 201)
        Me.SM_gbTVControls.TabIndex = 18
        Me.SM_gbTVControls.TabStop = False
        Me.SM_gbTVControls.Text = "Television Controls"
        Me.SM_gbTVControls.Visible = False
        '
        'SM_rbTvOff
        '
        Me.SM_rbTvOff.AutoSize = True
        Me.SM_rbTvOff.Location = New System.Drawing.Point(36, 114)
        Me.SM_rbTvOff.Name = "SM_rbTvOff"
        Me.SM_rbTvOff.Size = New System.Drawing.Size(55, 17)
        Me.SM_rbTvOff.TabIndex = 1
        Me.SM_rbTvOff.TabStop = True
        Me.SM_rbTvOff.Text = "Tv Off"
        Me.SM_rbTvOff.UseVisualStyleBackColor = True
        '
        'SM_rbTvOn
        '
        Me.SM_rbTvOn.AutoSize = True
        Me.SM_rbTvOn.Location = New System.Drawing.Point(36, 68)
        Me.SM_rbTvOn.Name = "SM_rbTvOn"
        Me.SM_rbTvOn.Size = New System.Drawing.Size(55, 17)
        Me.SM_rbTvOn.TabIndex = 0
        Me.SM_rbTvOn.TabStop = True
        Me.SM_rbTvOn.Text = "Tv On"
        Me.SM_rbTvOn.UseVisualStyleBackColor = True
        '
        'SM_gbLights
        '
        Me.SM_gbLights.Controls.Add(Me.SM_rbDigitalOn)
        Me.SM_gbLights.Controls.Add(Me.SM_rbDigitalOff)
        Me.SM_gbLights.Controls.Add(Me.SM_cbAreas)
        Me.SM_gbLights.Controls.Add(Me.Label8)
        Me.SM_gbLights.Location = New System.Drawing.Point(279, 16)
        Me.SM_gbLights.Name = "SM_gbLights"
        Me.SM_gbLights.Size = New System.Drawing.Size(168, 200)
        Me.SM_gbLights.TabIndex = 17
        Me.SM_gbLights.TabStop = False
        Me.SM_gbLights.Text = "Lighting Controls"
        '
        'SM_rbDigitalOn
        '
        Me.SM_rbDigitalOn.AutoSize = True
        Me.SM_rbDigitalOn.Location = New System.Drawing.Point(63, 91)
        Me.SM_rbDigitalOn.Name = "SM_rbDigitalOn"
        Me.SM_rbDigitalOn.Size = New System.Drawing.Size(39, 17)
        Me.SM_rbDigitalOn.TabIndex = 2
        Me.SM_rbDigitalOn.TabStop = True
        Me.SM_rbDigitalOn.Text = "On"
        Me.SM_rbDigitalOn.UseVisualStyleBackColor = True
        '
        'SM_rbDigitalOff
        '
        Me.SM_rbDigitalOff.AutoSize = True
        Me.SM_rbDigitalOff.Location = New System.Drawing.Point(63, 132)
        Me.SM_rbDigitalOff.Name = "SM_rbDigitalOff"
        Me.SM_rbDigitalOff.Size = New System.Drawing.Size(39, 17)
        Me.SM_rbDigitalOff.TabIndex = 3
        Me.SM_rbDigitalOff.TabStop = True
        Me.SM_rbDigitalOff.Text = "Off"
        Me.SM_rbDigitalOff.UseVisualStyleBackColor = True
        '
        'SM_cbAreas
        '
        Me.SM_cbAreas.FormattingEnabled = True
        Me.SM_cbAreas.Items.AddRange(New Object() {"Entry", "Desk", "Lamps", "Bath", "Nightlight"})
        Me.SM_cbAreas.Location = New System.Drawing.Point(13, 38)
        Me.SM_cbAreas.Name = "SM_cbAreas"
        Me.SM_cbAreas.Size = New System.Drawing.Size(123, 21)
        Me.SM_cbAreas.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Area/Loads"
        '
        'SM_tcShades
        '
        Me.SM_tcShades.Controls.Add(Me.SM_tpSetting1)
        Me.SM_tcShades.Controls.Add(Me.SM_tpSetting2)
        Me.SM_tcShades.Controls.Add(Me.TabPage1)
        Me.SM_tcShades.Location = New System.Drawing.Point(279, 16)
        Me.SM_tcShades.Name = "SM_tcShades"
        Me.SM_tcShades.SelectedIndex = 0
        Me.SM_tcShades.Size = New System.Drawing.Size(169, 201)
        Me.SM_tcShades.TabIndex = 16
        '
        'SM_tpSetting1
        '
        Me.SM_tpSetting1.BackColor = System.Drawing.SystemColors.Control
        Me.SM_tpSetting1.Controls.Add(Me.Label4)
        Me.SM_tpSetting1.Controls.Add(Me.SM_rbShadeOpen)
        Me.SM_tpSetting1.Controls.Add(Me.SM_rbShadeClosed)
        Me.SM_tpSetting1.Location = New System.Drawing.Point(4, 22)
        Me.SM_tpSetting1.Name = "SM_tpSetting1"
        Me.SM_tpSetting1.Padding = New System.Windows.Forms.Padding(3)
        Me.SM_tpSetting1.Size = New System.Drawing.Size(161, 175)
        Me.SM_tpSetting1.TabIndex = 0
        Me.SM_tpSetting1.Text = "Setting 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Shades Open/Closed"
        '
        'SM_rbShadeOpen
        '
        Me.SM_rbShadeOpen.AutoSize = True
        Me.SM_rbShadeOpen.Location = New System.Drawing.Point(59, 46)
        Me.SM_rbShadeOpen.Name = "SM_rbShadeOpen"
        Me.SM_rbShadeOpen.Size = New System.Drawing.Size(51, 17)
        Me.SM_rbShadeOpen.TabIndex = 12
        Me.SM_rbShadeOpen.TabStop = True
        Me.SM_rbShadeOpen.Text = "Open"
        Me.SM_rbShadeOpen.UseVisualStyleBackColor = True
        '
        'SM_rbShadeClosed
        '
        Me.SM_rbShadeClosed.AutoSize = True
        Me.SM_rbShadeClosed.Location = New System.Drawing.Point(59, 87)
        Me.SM_rbShadeClosed.Name = "SM_rbShadeClosed"
        Me.SM_rbShadeClosed.Size = New System.Drawing.Size(57, 17)
        Me.SM_rbShadeClosed.TabIndex = 11
        Me.SM_rbShadeClosed.TabStop = True
        Me.SM_rbShadeClosed.Text = "Closed"
        Me.SM_rbShadeClosed.UseVisualStyleBackColor = True
        '
        'SM_tpSetting2
        '
        Me.SM_tpSetting2.BackColor = System.Drawing.SystemColors.Control
        Me.SM_tpSetting2.Controls.Add(Me.SM_tbAnalogValue)
        Me.SM_tpSetting2.Controls.Add(Me.Label3)
        Me.SM_tpSetting2.Controls.Add(Me.SM_lblAnalogZero)
        Me.SM_tpSetting2.Controls.Add(Me.SM_lblAnalogHundred)
        Me.SM_tpSetting2.Location = New System.Drawing.Point(4, 22)
        Me.SM_tpSetting2.Name = "SM_tpSetting2"
        Me.SM_tpSetting2.Padding = New System.Windows.Forms.Padding(3)
        Me.SM_tpSetting2.Size = New System.Drawing.Size(161, 175)
        Me.SM_tpSetting2.TabIndex = 1
        Me.SM_tpSetting2.Text = "Setting 2"
        '
        'SM_tbAnalogValue
        '
        Me.SM_tbAnalogValue.Location = New System.Drawing.Point(88, 5)
        Me.SM_tbAnalogValue.Name = "SM_tbAnalogValue"
        Me.SM_tbAnalogValue.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.SM_tbAnalogValue.Size = New System.Drawing.Size(45, 164)
        Me.SM_tbAnalogValue.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Shade Percent"
        '
        'SM_lblAnalogZero
        '
        Me.SM_lblAnalogZero.AutoSize = True
        Me.SM_lblAnalogZero.Location = New System.Drawing.Point(134, 147)
        Me.SM_lblAnalogZero.Name = "SM_lblAnalogZero"
        Me.SM_lblAnalogZero.Size = New System.Drawing.Size(21, 13)
        Me.SM_lblAnalogZero.TabIndex = 7
        Me.SM_lblAnalogZero.Text = "0%"
        '
        'SM_lblAnalogHundred
        '
        Me.SM_lblAnalogHundred.AutoSize = True
        Me.SM_lblAnalogHundred.Location = New System.Drawing.Point(125, 12)
        Me.SM_lblAnalogHundred.Name = "SM_lblAnalogHundred"
        Me.SM_lblAnalogHundred.Size = New System.Drawing.Size(33, 13)
        Me.SM_lblAnalogHundred.TabIndex = 8
        Me.SM_lblAnalogHundred.Text = "100%"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.SM_rbSunTrackOn)
        Me.TabPage1.Controls.Add(Me.SM_rbSunTrackOff)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(161, 175)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Setting 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Sun Tracking"
        '
        'SM_rbSunTrackOn
        '
        Me.SM_rbSunTrackOn.AutoSize = True
        Me.SM_rbSunTrackOn.Location = New System.Drawing.Point(62, 62)
        Me.SM_rbSunTrackOn.Name = "SM_rbSunTrackOn"
        Me.SM_rbSunTrackOn.Size = New System.Drawing.Size(39, 17)
        Me.SM_rbSunTrackOn.TabIndex = 13
        Me.SM_rbSunTrackOn.TabStop = True
        Me.SM_rbSunTrackOn.Text = "On"
        Me.SM_rbSunTrackOn.UseVisualStyleBackColor = True
        '
        'SM_rbSunTrackOff
        '
        Me.SM_rbSunTrackOff.AutoSize = True
        Me.SM_rbSunTrackOff.Location = New System.Drawing.Point(62, 104)
        Me.SM_rbSunTrackOff.Name = "SM_rbSunTrackOff"
        Me.SM_rbSunTrackOff.Size = New System.Drawing.Size(39, 17)
        Me.SM_rbSunTrackOff.TabIndex = 14
        Me.SM_rbSunTrackOff.TabStop = True
        Me.SM_rbSunTrackOff.Text = "Off"
        Me.SM_rbSunTrackOff.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Type of Device"
        '
        'SM_cbDevices
        '
        Me.SM_cbDevices.FormattingEnabled = True
        Me.SM_cbDevices.Location = New System.Drawing.Point(17, 50)
        Me.SM_cbDevices.Name = "SM_cbDevices"
        Me.SM_cbDevices.Size = New System.Drawing.Size(126, 21)
        Me.SM_cbDevices.TabIndex = 1
        '
        'frmLoyaltyProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 434)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmLoyaltyProgram"
        Me.Text = "Loyalty Program"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.SM_gbTstatControls.ResumeLayout(False)
        Me.SM_gbTstatControls.PerformLayout()
        CType(Me.SM_tbTstatSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SM_nudSetPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SM_gbTVControls.ResumeLayout(False)
        Me.SM_gbTVControls.PerformLayout()
        Me.SM_gbLights.ResumeLayout(False)
        Me.SM_gbLights.PerformLayout()
        Me.SM_tcShades.ResumeLayout(False)
        Me.SM_tpSetting1.ResumeLayout(False)
        Me.SM_tpSetting1.PerformLayout()
        Me.SM_tpSetting2.ResumeLayout(False)
        Me.SM_tpSetting2.PerformLayout()
        CType(Me.SM_tbAnalogValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents SM_gbTstatControls As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SM_tbTstatSlider As System.Windows.Forms.TrackBar
    Friend WithEvents SM_nudSetPoint As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SM_gbTVControls As System.Windows.Forms.GroupBox
    Friend WithEvents SM_rbTvOff As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbTvOn As System.Windows.Forms.RadioButton
    Friend WithEvents SM_gbLights As System.Windows.Forms.GroupBox
    Friend WithEvents SM_rbDigitalOn As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbDigitalOff As System.Windows.Forms.RadioButton
    Friend WithEvents SM_cbAreas As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SM_tcShades As System.Windows.Forms.TabControl
    Friend WithEvents SM_tpSetting1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SM_rbShadeOpen As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbShadeClosed As System.Windows.Forms.RadioButton
    Friend WithEvents SM_tpSetting2 As System.Windows.Forms.TabPage
    Friend WithEvents SM_tbAnalogValue As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SM_lblAnalogZero As System.Windows.Forms.Label
    Friend WithEvents SM_lblAnalogHundred As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SM_rbSunTrackOn As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbSunTrackOff As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SM_cbDevices As System.Windows.Forms.ComboBox
End Class
