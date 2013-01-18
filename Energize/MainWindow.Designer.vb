<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Energize
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Energize))
        Me.lvAlarms = New System.Windows.Forms.ListView()
        Me.Time_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Room_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Alarm_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Priority = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsLvAlarms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiLvAlarmAcknowledge = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAcknowledge = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmsKPI = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddKPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveKPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRoomsOffline = New System.Windows.Forms.Label()
        Me.keyPointsOfInterest = New System.Windows.Forms.GroupBox()
        Me.btnViewTVS = New System.Windows.Forms.Button()
        Me.pKPIToWatch = New System.Windows.Forms.Panel()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.btnKPIDetail = New System.Windows.Forms.Button()
        Me.lblStatToWatch = New System.Windows.Forms.Label()
        Me.btnViewWarnings = New System.Windows.Forms.Button()
        Me.btnViewAck = New System.Windows.Forms.Button()
        Me.btnViewAlarms = New System.Windows.Forms.Button()
        Me.btnViewOffline = New System.Windows.Forms.Button()
        Me.lblTvOn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWarnings = New System.Windows.Forms.Label()
        Me.lblAlarmsAckn = New System.Windows.Forms.Label()
        Me.lblAlarms = New System.Windows.Forms.Label()
        Me.details = New System.Windows.Forms.GroupBox()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblSolution = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.lblAlarmCode = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTimeStamp = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.tmrAlarm = New System.Windows.Forms.Timer(Me.components)
        Me.btnReports = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLServerConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.NotifyIconEnergize = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotifyIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlarmsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcknowledgedAlarmsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.WarningsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsLvAlarms.SuspendLayout()
        Me.cmsKPI.SuspendLayout()
        Me.keyPointsOfInterest.SuspendLayout()
        Me.pKPIToWatch.SuspendLayout()
        Me.details.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.cmsNotifyIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvAlarms
        '
        Me.lvAlarms.CheckBoxes = True
        Me.lvAlarms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Time_Date, Me.Room_Number, Me.Description, Me.Alarm_Code, Me.Priority})
        Me.TableLayoutPanel1.SetColumnSpan(Me.lvAlarms, 4)
        Me.lvAlarms.ContextMenuStrip = Me.cmsLvAlarms
        Me.lvAlarms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvAlarms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAlarms.FullRowSelect = True
        Me.lvAlarms.GridLines = True
        Me.lvAlarms.LabelEdit = True
        Me.lvAlarms.Location = New System.Drawing.Point(10, 266)
        Me.lvAlarms.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lvAlarms.MultiSelect = False
        Me.lvAlarms.Name = "lvAlarms"
        Me.lvAlarms.Size = New System.Drawing.Size(1047, 474)
        Me.lvAlarms.TabIndex = 0
        Me.lvAlarms.UseCompatibleStateImageBehavior = False
        Me.lvAlarms.View = System.Windows.Forms.View.Details
        '
        'Time_Date
        '
        Me.Time_Date.Text = "Time/Date"
        Me.Time_Date.Width = 166
        '
        'Room_Number
        '
        Me.Room_Number.Text = "Room Number"
        Me.Room_Number.Width = 141
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 578
        '
        'Alarm_Code
        '
        Me.Alarm_Code.Text = "Alarm Code"
        Me.Alarm_Code.Width = 100
        '
        'Priority
        '
        Me.Priority.Text = "Priority"
        Me.Priority.Width = 56
        '
        'cmsLvAlarms
        '
        Me.cmsLvAlarms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiLvAlarmAcknowledge})
        Me.cmsLvAlarms.Name = "cmsLvAlarms"
        Me.cmsLvAlarms.Size = New System.Drawing.Size(147, 26)
        '
        'tsmiLvAlarmAcknowledge
        '
        Me.tsmiLvAlarmAcknowledge.Name = "tsmiLvAlarmAcknowledge"
        Me.tsmiLvAlarmAcknowledge.Size = New System.Drawing.Size(146, 22)
        Me.tsmiLvAlarmAcknowledge.Text = "Acknowledge"
        '
        'btnAcknowledge
        '
        Me.btnAcknowledge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAcknowledge.Location = New System.Drawing.Point(857, 748)
        Me.btnAcknowledge.Margin = New System.Windows.Forms.Padding(3, 3, 10, 5)
        Me.btnAcknowledge.Name = "btnAcknowledge"
        Me.btnAcknowledge.Size = New System.Drawing.Size(103, 21)
        Me.btnAcknowledge.TabIndex = 1
        Me.btnAcknowledge.Text = "Acknowledge"
        Me.btnAcknowledge.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ContextMenuStrip = Me.cmsKPI
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "# Rooms Offline:"
        '
        'cmsKPI
        '
        Me.cmsKPI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddKPIToolStripMenuItem, Me.RemoveKPIToolStripMenuItem})
        Me.cmsKPI.Name = "cmsKPI"
        Me.cmsKPI.Size = New System.Drawing.Size(138, 48)
        '
        'AddKPIToolStripMenuItem
        '
        Me.AddKPIToolStripMenuItem.Name = "AddKPIToolStripMenuItem"
        Me.AddKPIToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AddKPIToolStripMenuItem.Text = "Add KPI"
        '
        'RemoveKPIToolStripMenuItem
        '
        Me.RemoveKPIToolStripMenuItem.Name = "RemoveKPIToolStripMenuItem"
        Me.RemoveKPIToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.RemoveKPIToolStripMenuItem.Text = "Remove KPI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ContextMenuStrip = Me.cmsKPI
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "# Alarms:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ContextMenuStrip = Me.cmsKPI
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "# Alarms Ack:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ContextMenuStrip = Me.cmsKPI
        Me.Label5.Location = New System.Drawing.Point(6, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "# Warnings:"
        '
        'lblRoomsOffline
        '
        Me.lblRoomsOffline.AutoSize = True
        Me.lblRoomsOffline.ContextMenuStrip = Me.cmsKPI
        Me.lblRoomsOffline.Location = New System.Drawing.Point(98, 29)
        Me.lblRoomsOffline.Name = "lblRoomsOffline"
        Me.lblRoomsOffline.Size = New System.Drawing.Size(13, 13)
        Me.lblRoomsOffline.TabIndex = 8
        Me.lblRoomsOffline.Text = "0"
        '
        'keyPointsOfInterest
        '
        Me.keyPointsOfInterest.AutoSize = True
        Me.keyPointsOfInterest.Controls.Add(Me.btnViewTVS)
        Me.keyPointsOfInterest.Controls.Add(Me.pKPIToWatch)
        Me.keyPointsOfInterest.Controls.Add(Me.btnViewWarnings)
        Me.keyPointsOfInterest.Controls.Add(Me.btnViewAck)
        Me.keyPointsOfInterest.Controls.Add(Me.btnViewAlarms)
        Me.keyPointsOfInterest.Controls.Add(Me.btnViewOffline)
        Me.keyPointsOfInterest.Controls.Add(Me.lblTvOn)
        Me.keyPointsOfInterest.Controls.Add(Me.Label1)
        Me.keyPointsOfInterest.Controls.Add(Me.lblWarnings)
        Me.keyPointsOfInterest.Controls.Add(Me.lblAlarmsAckn)
        Me.keyPointsOfInterest.Controls.Add(Me.lblAlarms)
        Me.keyPointsOfInterest.Controls.Add(Me.Label5)
        Me.keyPointsOfInterest.Controls.Add(Me.Label3)
        Me.keyPointsOfInterest.Controls.Add(Me.lblRoomsOffline)
        Me.keyPointsOfInterest.Controls.Add(Me.Label2)
        Me.keyPointsOfInterest.Controls.Add(Me.Label4)
        Me.keyPointsOfInterest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.keyPointsOfInterest.Location = New System.Drawing.Point(10, 34)
        Me.keyPointsOfInterest.Margin = New System.Windows.Forms.Padding(10, 3, 3, 5)
        Me.keyPointsOfInterest.Name = "keyPointsOfInterest"
        Me.keyPointsOfInterest.Size = New System.Drawing.Size(201, 222)
        Me.keyPointsOfInterest.TabIndex = 8
        Me.keyPointsOfInterest.TabStop = False
        Me.keyPointsOfInterest.Text = "Key Points of Interest"
        '
        'btnViewTVS
        '
        Me.btnViewTVS.ContextMenuStrip = Me.cmsKPI
        Me.btnViewTVS.Location = New System.Drawing.Point(127, 114)
        Me.btnViewTVS.Name = "btnViewTVS"
        Me.btnViewTVS.Size = New System.Drawing.Size(24, 19)
        Me.btnViewTVS.TabIndex = 17
        Me.btnViewTVS.Text = "..."
        Me.btnViewTVS.UseVisualStyleBackColor = True
        '
        'pKPIToWatch
        '
        Me.pKPIToWatch.Controls.Add(Me.lblNumber)
        Me.pKPIToWatch.Controls.Add(Me.btnKPIDetail)
        Me.pKPIToWatch.Controls.Add(Me.lblStatToWatch)
        Me.pKPIToWatch.Location = New System.Drawing.Point(34, 164)
        Me.pKPIToWatch.Name = "pKPIToWatch"
        Me.pKPIToWatch.Size = New System.Drawing.Size(142, 22)
        Me.pKPIToWatch.TabIndex = 13
        Me.pKPIToWatch.Visible = False
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(89, 3)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(14, 13)
        Me.lblNumber.TabIndex = 14
        Me.lblNumber.Text = "#"
        '
        'btnKPIDetail
        '
        Me.btnKPIDetail.Location = New System.Drawing.Point(114, 0)
        Me.btnKPIDetail.Name = "btnKPIDetail"
        Me.btnKPIDetail.Size = New System.Drawing.Size(25, 19)
        Me.btnKPIDetail.TabIndex = 13
        Me.btnKPIDetail.Text = "..."
        Me.btnKPIDetail.UseVisualStyleBackColor = True
        '
        'lblStatToWatch
        '
        Me.lblStatToWatch.AutoSize = True
        Me.lblStatToWatch.Location = New System.Drawing.Point(3, 3)
        Me.lblStatToWatch.Name = "lblStatToWatch"
        Me.lblStatToWatch.Size = New System.Drawing.Size(71, 13)
        Me.lblStatToWatch.TabIndex = 13
        Me.lblStatToWatch.Text = "StatToWatch"
        '
        'btnViewWarnings
        '
        Me.btnViewWarnings.ContextMenuStrip = Me.cmsKPI
        Me.btnViewWarnings.Location = New System.Drawing.Point(127, 92)
        Me.btnViewWarnings.Name = "btnViewWarnings"
        Me.btnViewWarnings.Size = New System.Drawing.Size(24, 19)
        Me.btnViewWarnings.TabIndex = 16
        Me.btnViewWarnings.Text = "..."
        Me.btnViewWarnings.UseVisualStyleBackColor = True
        '
        'btnViewAck
        '
        Me.btnViewAck.ContextMenuStrip = Me.cmsKPI
        Me.btnViewAck.Location = New System.Drawing.Point(127, 70)
        Me.btnViewAck.Name = "btnViewAck"
        Me.btnViewAck.Size = New System.Drawing.Size(24, 19)
        Me.btnViewAck.TabIndex = 15
        Me.btnViewAck.Text = "..."
        Me.btnViewAck.UseVisualStyleBackColor = True
        '
        'btnViewAlarms
        '
        Me.btnViewAlarms.ContextMenuStrip = Me.cmsKPI
        Me.btnViewAlarms.Location = New System.Drawing.Point(127, 48)
        Me.btnViewAlarms.Name = "btnViewAlarms"
        Me.btnViewAlarms.Size = New System.Drawing.Size(24, 19)
        Me.btnViewAlarms.TabIndex = 14
        Me.btnViewAlarms.Text = "..."
        Me.btnViewAlarms.UseVisualStyleBackColor = True
        '
        'btnViewOffline
        '
        Me.btnViewOffline.ContextMenuStrip = Me.cmsKPI
        Me.btnViewOffline.Location = New System.Drawing.Point(127, 26)
        Me.btnViewOffline.Name = "btnViewOffline"
        Me.btnViewOffline.Size = New System.Drawing.Size(24, 19)
        Me.btnViewOffline.TabIndex = 12
        Me.btnViewOffline.Text = "..."
        Me.btnViewOffline.UseVisualStyleBackColor = True
        '
        'lblTvOn
        '
        Me.lblTvOn.AutoSize = True
        Me.lblTvOn.ContextMenuStrip = Me.cmsKPI
        Me.lblTvOn.Location = New System.Drawing.Point(98, 118)
        Me.lblTvOn.Name = "lblTvOn"
        Me.lblTvOn.Size = New System.Drawing.Size(13, 13)
        Me.lblTvOn.TabIndex = 13
        Me.lblTvOn.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ContextMenuStrip = Me.cmsKPI
        Me.Label1.Location = New System.Drawing.Point(6, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "# T.V.s On:"
        '
        'lblWarnings
        '
        Me.lblWarnings.AutoSize = True
        Me.lblWarnings.ContextMenuStrip = Me.cmsKPI
        Me.lblWarnings.Location = New System.Drawing.Point(98, 95)
        Me.lblWarnings.Name = "lblWarnings"
        Me.lblWarnings.Size = New System.Drawing.Size(13, 13)
        Me.lblWarnings.TabIndex = 11
        Me.lblWarnings.Text = "0"
        '
        'lblAlarmsAckn
        '
        Me.lblAlarmsAckn.AutoSize = True
        Me.lblAlarmsAckn.ContextMenuStrip = Me.cmsKPI
        Me.lblAlarmsAckn.Location = New System.Drawing.Point(98, 73)
        Me.lblAlarmsAckn.Name = "lblAlarmsAckn"
        Me.lblAlarmsAckn.Size = New System.Drawing.Size(13, 13)
        Me.lblAlarmsAckn.TabIndex = 10
        Me.lblAlarmsAckn.Text = "0"
        '
        'lblAlarms
        '
        Me.lblAlarms.AutoSize = True
        Me.lblAlarms.ContextMenuStrip = Me.cmsKPI
        Me.lblAlarms.Location = New System.Drawing.Point(98, 51)
        Me.lblAlarms.Name = "lblAlarms"
        Me.lblAlarms.Size = New System.Drawing.Size(13, 13)
        Me.lblAlarms.TabIndex = 9
        Me.lblAlarms.Text = "0"
        '
        'details
        '
        Me.details.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.SetColumnSpan(Me.details, 3)
        Me.details.Controls.Add(Me.lblDeviceName)
        Me.details.Controls.Add(Me.Label12)
        Me.details.Controls.Add(Me.lblSolution)
        Me.details.Controls.Add(Me.lblDescription)
        Me.details.Controls.Add(Me.lblPriority)
        Me.details.Controls.Add(Me.lblAlarmCode)
        Me.details.Controls.Add(Me.lblID)
        Me.details.Controls.Add(Me.lblTimeStamp)
        Me.details.Controls.Add(Me.Label11)
        Me.details.Controls.Add(Me.Label10)
        Me.details.Controls.Add(Me.Label9)
        Me.details.Controls.Add(Me.Label8)
        Me.details.Controls.Add(Me.Label7)
        Me.details.Controls.Add(Me.Label6)
        Me.details.Controls.Add(Me.ShapeContainer1)
        Me.details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.details.Location = New System.Drawing.Point(217, 34)
        Me.details.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.details.Name = "details"
        Me.details.Size = New System.Drawing.Size(847, 222)
        Me.details.TabIndex = 9
        Me.details.TabStop = False
        Me.details.Text = "Alarm Detail"
        '
        'lblDeviceName
        '
        Me.lblDeviceName.AutoSize = True
        Me.lblDeviceName.Location = New System.Drawing.Point(109, 73)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(0, 13)
        Me.lblDeviceName.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Device Name: "
        '
        'lblSolution
        '
        Me.lblSolution.AutoSize = True
        Me.lblSolution.Location = New System.Drawing.Point(256, 145)
        Me.lblSolution.Name = "lblSolution"
        Me.lblSolution.Size = New System.Drawing.Size(0, 13)
        Me.lblSolution.TabIndex = 19
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(256, 51)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(0, 13)
        Me.lblDescription.TabIndex = 18
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Location = New System.Drawing.Point(109, 117)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(0, 13)
        Me.lblPriority.TabIndex = 17
        '
        'lblAlarmCode
        '
        Me.lblAlarmCode.AutoSize = True
        Me.lblAlarmCode.Location = New System.Drawing.Point(109, 95)
        Me.lblAlarmCode.Name = "lblAlarmCode"
        Me.lblAlarmCode.Size = New System.Drawing.Size(0, 13)
        Me.lblAlarmCode.TabIndex = 16
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(109, 51)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 15
        '
        'lblTimeStamp
        '
        Me.lblTimeStamp.AutoSize = True
        Me.lblTimeStamp.Location = New System.Drawing.Point(109, 29)
        Me.lblTimeStamp.Name = "lblTimeStamp"
        Me.lblTimeStamp.Size = New System.Drawing.Size(0, 13)
        Me.lblTimeStamp.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(255, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Suggested Solution:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Description:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Priority:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Alarm Code:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Room I.D:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Time/Date:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(841, 203)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 238
        Me.LineShape1.X2 = 237
        Me.LineShape1.Y1 = -4
        Me.LineShape1.Y2 = 205
        '
        'tmrAlarm
        '
        Me.tmrAlarm.Enabled = True
        Me.tmrAlarm.Interval = 5000
        '
        'btnReports
        '
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReports.Location = New System.Drawing.Point(973, 748)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(3, 3, 10, 5)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(84, 21)
        Me.btnReports.TabIndex = 10
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.05855!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.94145!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStripContainer1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.keyPointsOfInterest, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReports, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.details, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAcknowledge, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lvAlarms, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1067, 794)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'ToolStripContainer1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ToolStripContainer1, 4)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1061, 0)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1061, 25)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1061, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SQLServerConfigurationToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'SQLServerConfigurationToolStripMenuItem
        '
        Me.SQLServerConfigurationToolStripMenuItem.Name = "SQLServerConfigurationToolStripMenuItem"
        Me.SQLServerConfigurationToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SQLServerConfigurationToolStripMenuItem.Text = "SQL Server Configuration"
        '
        'StatusStrip1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.StatusStrip1, 4)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 774)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1067, 20)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'NotifyIconEnergize
        '
        Me.NotifyIconEnergize.ContextMenuStrip = Me.cmsNotifyIcon
        Me.NotifyIconEnergize.Icon = CType(resources.GetObject("NotifyIconEnergize.Icon"), System.Drawing.Icon)
        Me.NotifyIconEnergize.Text = "Energize"
        Me.NotifyIconEnergize.Visible = True
        '
        'cmsNotifyIcon
        '
        Me.cmsNotifyIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlarmsToolStripMenuItem, Me.ToolStripSeparator1, Me.AcknowledgedAlarmsToolStripMenuItem, Me.ToolStripSeparator2, Me.WarningsToolStripMenuItem})
        Me.cmsNotifyIcon.Name = "cmsNotifyIcon"
        Me.cmsNotifyIcon.Size = New System.Drawing.Size(194, 82)
        '
        'AlarmsToolStripMenuItem
        '
        Me.AlarmsToolStripMenuItem.Name = "AlarmsToolStripMenuItem"
        Me.AlarmsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AlarmsToolStripMenuItem.Text = "Alarms "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'AcknowledgedAlarmsToolStripMenuItem
        '
        Me.AcknowledgedAlarmsToolStripMenuItem.Name = "AcknowledgedAlarmsToolStripMenuItem"
        Me.AcknowledgedAlarmsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AcknowledgedAlarmsToolStripMenuItem.Text = "Acknowledged Alarms"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'WarningsToolStripMenuItem
        '
        Me.WarningsToolStripMenuItem.Name = "WarningsToolStripMenuItem"
        Me.WarningsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.WarningsToolStripMenuItem.Text = "Warnings"
        '
        'Energize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1067, 794)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Energize"
        Me.Text = "Energize"
        Me.cmsLvAlarms.ResumeLayout(False)
        Me.cmsKPI.ResumeLayout(False)
        Me.keyPointsOfInterest.ResumeLayout(False)
        Me.keyPointsOfInterest.PerformLayout()
        Me.pKPIToWatch.ResumeLayout(False)
        Me.pKPIToWatch.PerformLayout()
        Me.details.ResumeLayout(False)
        Me.details.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.cmsNotifyIcon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvAlarms As System.Windows.Forms.ListView
    Friend WithEvents Time_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents Room_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents Alarm_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents Priority As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAcknowledge As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblRoomsOffline As System.Windows.Forms.Label
    Friend WithEvents keyPointsOfInterest As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWarnings As System.Windows.Forms.Label
    Friend WithEvents lblAlarmsAckn As System.Windows.Forms.Label
    Friend WithEvents lblAlarms As System.Windows.Forms.Label
    Friend WithEvents lblTvOn As System.Windows.Forms.Label
    Friend WithEvents details As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSolution As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents lblAlarmCode As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblTimeStamp As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents tmrAlarm As System.Windows.Forms.Timer
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblDeviceName As System.Windows.Forms.Label
    Friend WithEvents btnViewTVS As System.Windows.Forms.Button
    Friend WithEvents btnViewWarnings As System.Windows.Forms.Button
    Friend WithEvents btnViewAck As System.Windows.Forms.Button
    Friend WithEvents btnViewAlarms As System.Windows.Forms.Button
    Friend WithEvents btnViewOffline As System.Windows.Forms.Button
    Friend WithEvents cmsKPI As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddKPIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveKPIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pKPIToWatch As System.Windows.Forms.Panel
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents btnKPIDetail As System.Windows.Forms.Button
    Friend WithEvents lblStatToWatch As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsLvAlarms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiLvAlarmAcknowledge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents NotifyIconEnergize As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsNotifyIcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AlarmsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcknowledgedAlarmsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WarningsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SQLServerConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
