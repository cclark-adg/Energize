<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tpvConfigurator = New System.Windows.Forms.TabControl()
        Me.tpDeviceType = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AE_lbDevices = New System.Windows.Forms.ListBox()
        Me.AE_lblDevices = New System.Windows.Forms.Label()
        Me.gbAlarmSettings = New System.Windows.Forms.GroupBox()
        Me.AE_combWarningAlarms = New System.Windows.Forms.ComboBox()
        Me.AE_lblWarningCode = New System.Windows.Forms.Label()
        Me.AE_tbWarningTimeFrame = New System.Windows.Forms.TextBox()
        Me.AE_tbWarningThreshold = New System.Windows.Forms.TextBox()
        Me.AE_lblWarningTimeFrame = New System.Windows.Forms.Label()
        Me.AE_lblWarningThreshold = New System.Windows.Forms.Label()
        Me.AE_cbWarning = New System.Windows.Forms.CheckBox()
        Me.AE_gbSignalType = New System.Windows.Forms.GroupBox()
        Me.AE_rbString = New System.Windows.Forms.RadioButton()
        Me.AE_rbAnalog = New System.Windows.Forms.RadioButton()
        Me.AE_rbBinary = New System.Windows.Forms.RadioButton()
        Me.lblTimeFrame = New System.Windows.Forms.Label()
        Me.AE_cbEnabled = New System.Windows.Forms.CheckBox()
        Me.AE_tbThreshold = New System.Windows.Forms.TextBox()
        Me.AE_gbAlarmType = New System.Windows.Forms.GroupBox()
        Me.AE_rbEnhanced = New System.Windows.Forms.RadioButton()
        Me.AE_rbBasic = New System.Windows.Forms.RadioButton()
        Me.AE_tbTimeFrame = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AE_btnNew = New System.Windows.Forms.Button()
        Me.AE_btnDel = New System.Windows.Forms.Button()
        Me.AE_btnClear = New System.Windows.Forms.Button()
        Me.AE_btnSave = New System.Windows.Forms.Button()
        Me.AE_lblName = New System.Windows.Forms.Label()
        Me.AE_lbDeviceName = New System.Windows.Forms.Label()
        Me.tpRoomType = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RTE_btnBrowseProgram = New System.Windows.Forms.Button()
        Me.RTE_tbProgramName = New System.Windows.Forms.TextBox()
        Me.RTE_lblDefaultProgram = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RTE_lbDeviceTypesAvailable = New System.Windows.Forms.ListBox()
        Me.RTE_tvDevicesAdded = New System.Windows.Forms.TreeView()
        Me.tvMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiAddItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDeleteItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RTE_btnAllDeviceAdd = New System.Windows.Forms.Button()
        Me.RTE_lblDevicesAdded = New System.Windows.Forms.Label()
        Me.RTE_btnDeviceAdd = New System.Windows.Forms.Button()
        Me.RTE_lblDevicesAvailable = New System.Windows.Forms.Label()
        Me.RTE_btnAllDeviceRemove = New System.Windows.Forms.Button()
        Me.RTE_btnDeviceRemove = New System.Windows.Forms.Button()
        Me.RTE_lblRoomTypes = New System.Windows.Forms.Label()
        Me.RTE_lbRoomTypes = New System.Windows.Forms.ListBox()
        Me.RTE_btnNew = New System.Windows.Forms.Button()
        Me.RTE_btnDelete = New System.Windows.Forms.Button()
        Me.RTE_btnSave = New System.Windows.Forms.Button()
        Me.RTE_btnClear = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tpRoomLoader = New System.Windows.Forms.TabPage()
        Me.RL_Flags = New System.Windows.Forms.GroupBox()
        Me.RL_cbLoadDefaultProgram = New System.Windows.Forms.CheckBox()
        Me.RL_cbLoadProcessorSettings = New System.Windows.Forms.CheckBox()
        Me.RL_cbLoadDevicesPerRoom = New System.Windows.Forms.CheckBox()
        Me.RL_btnLoad = New System.Windows.Forms.Button()
        Me.RL_lsvRooms = New System.Windows.Forms.ListView()
        Me.colBuilding = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFloor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RL_btnBrowseExcel = New System.Windows.Forms.Button()
        Me.tpRoomEditor = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbRoomDetails = New System.Windows.Forms.GroupBox()
        Me.RE_tbSTBip = New System.Windows.Forms.TextBox()
        Me.RE_lblSTBAddress = New System.Windows.Forms.Label()
        Me.RE_tbFloor = New System.Windows.Forms.TextBox()
        Me.RE_lblFloor = New System.Windows.Forms.Label()
        Me.RE_tbMAC = New System.Windows.Forms.TextBox()
        Me.RE_lblMAC = New System.Windows.Forms.Label()
        Me.RE_tbIpAddress = New System.Windows.Forms.TextBox()
        Me.RE_lblIpAddress = New System.Windows.Forms.Label()
        Me.RE_tbBuilding = New System.Windows.Forms.TextBox()
        Me.RE_lblBuilding = New System.Windows.Forms.Label()
        Me.RE_tbRoomType = New System.Windows.Forms.TextBox()
        Me.RE_lblRoomType = New System.Windows.Forms.Label()
        Me.RE_tbRoomName = New System.Windows.Forms.TextBox()
        Me.RE_lblRoomName = New System.Windows.Forms.Label()
        Me.RE_tcRoomViewer = New System.Windows.Forms.TabControl()
        Me.RE_tbByFloor = New System.Windows.Forms.TabPage()
        Me.RE_tvRoomsByFloor = New System.Windows.Forms.TreeView()
        Me.RE_cmsTV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoadProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDefaultProgramByRoomTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadOtherProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadNewRemoteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDefaultRemoteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RE_tbByType = New System.Windows.Forms.TabPage()
        Me.RE_tvRoomsByType = New System.Windows.Forms.TreeView()
        Me.RE_btnSendProgram = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RE_btnNew = New System.Windows.Forms.Button()
        Me.RE_btnDelete = New System.Windows.Forms.Button()
        Me.tpEventEditor = New System.Windows.Forms.TabPage()
        Me.tlpEventEditor = New System.Windows.Forms.TableLayoutPanel()
        Me.EE_lblEvents = New System.Windows.Forms.Label()
        Me.EE_lbEvents = New System.Windows.Forms.ListBox()
        Me.EE_lblAlarmCodeDisplay = New System.Windows.Forms.Label()
        Me.EE_lblDesription = New System.Windows.Forms.Label()
        Me.EE_rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.EE_rtbSolution = New System.Windows.Forms.RichTextBox()
        Me.EE_lblSolution = New System.Windows.Forms.Label()
        Me.EE_tbPriority = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EE_btnNew = New System.Windows.Forms.Button()
        Me.EE_btnDelete = New System.Windows.Forms.Button()
        Me.EE_btnSave = New System.Windows.Forms.Button()
        Me.EE_btnClear = New System.Windows.Forms.Button()
        Me.EE_tbAlarmCode = New System.Windows.Forms.TextBox()
        Me.tpStateManager = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.openProgram = New System.Windows.Forms.OpenFileDialog()
        Me.mainStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLServerConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tssLbl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RE_tmrProgramLoad = New System.Windows.Forms.Timer(Me.components)
        Me.tpvConfigurator.SuspendLayout()
        Me.tpDeviceType.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbAlarmSettings.SuspendLayout()
        Me.AE_gbSignalType.SuspendLayout()
        Me.AE_gbAlarmType.SuspendLayout()
        Me.tpRoomType.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tvMenuStrip.SuspendLayout()
        Me.tpRoomLoader.SuspendLayout()
        Me.RL_Flags.SuspendLayout()
        Me.tpRoomEditor.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.gbRoomDetails.SuspendLayout()
        Me.RE_tcRoomViewer.SuspendLayout()
        Me.RE_tbByFloor.SuspendLayout()
        Me.RE_cmsTV.SuspendLayout()
        Me.RE_tbByType.SuspendLayout()
        Me.tpEventEditor.SuspendLayout()
        Me.tlpEventEditor.SuspendLayout()
        Me.tpStateManager.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.mainStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpvConfigurator
        '
        Me.tpvConfigurator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tpvConfigurator.Controls.Add(Me.tpDeviceType)
        Me.tpvConfigurator.Controls.Add(Me.tpRoomType)
        Me.tpvConfigurator.Controls.Add(Me.tpRoomLoader)
        Me.tpvConfigurator.Controls.Add(Me.tpRoomEditor)
        Me.tpvConfigurator.Controls.Add(Me.tpEventEditor)
        Me.tpvConfigurator.Controls.Add(Me.tpStateManager)
        Me.tpvConfigurator.Location = New System.Drawing.Point(17, 32)
        Me.tpvConfigurator.Margin = New System.Windows.Forms.Padding(8)
        Me.tpvConfigurator.Name = "tpvConfigurator"
        Me.tpvConfigurator.SelectedIndex = 0
        Me.tpvConfigurator.Size = New System.Drawing.Size(944, 679)
        Me.tpvConfigurator.TabIndex = 0
        '
        'tpDeviceType
        '
        Me.tpDeviceType.BackColor = System.Drawing.SystemColors.Control
        Me.tpDeviceType.Controls.Add(Me.TableLayoutPanel1)
        Me.tpDeviceType.Location = New System.Drawing.Point(4, 22)
        Me.tpDeviceType.Name = "tpDeviceType"
        Me.tpDeviceType.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDeviceType.Size = New System.Drawing.Size(936, 653)
        Me.tpDeviceType.TabIndex = 2
        Me.tpDeviceType.Text = "Alarm Editor"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.96296!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.49573!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.58496!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.AE_lbDevices, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_lblDevices, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.gbAlarmSettings, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_btnNew, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_btnDel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_btnClear, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_btnSave, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_lblName, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_lbDeviceName, 3, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.65156!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.348442!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(930, 647)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'AE_lbDevices
        '
        Me.AE_lbDevices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.AE_lbDevices, 2)
        Me.AE_lbDevices.FormattingEnabled = True
        Me.AE_lbDevices.Location = New System.Drawing.Point(3, 43)
        Me.AE_lbDevices.Name = "AE_lbDevices"
        Me.TableLayoutPanel1.SetRowSpan(Me.AE_lbDevices, 2)
        Me.AE_lbDevices.Size = New System.Drawing.Size(149, 537)
        Me.AE_lbDevices.TabIndex = 29
        '
        'AE_lblDevices
        '
        Me.AE_lblDevices.AutoSize = True
        Me.AE_lblDevices.Location = New System.Drawing.Point(3, 20)
        Me.AE_lblDevices.Name = "AE_lblDevices"
        Me.AE_lblDevices.Size = New System.Drawing.Size(46, 13)
        Me.AE_lblDevices.TabIndex = 24
        Me.AE_lblDevices.Text = "Devices"
        Me.AE_lblDevices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbAlarmSettings
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.gbAlarmSettings, 4)
        Me.gbAlarmSettings.Controls.Add(Me.AE_combWarningAlarms)
        Me.gbAlarmSettings.Controls.Add(Me.AE_lblWarningCode)
        Me.gbAlarmSettings.Controls.Add(Me.AE_tbWarningTimeFrame)
        Me.gbAlarmSettings.Controls.Add(Me.AE_tbWarningThreshold)
        Me.gbAlarmSettings.Controls.Add(Me.AE_lblWarningTimeFrame)
        Me.gbAlarmSettings.Controls.Add(Me.AE_lblWarningThreshold)
        Me.gbAlarmSettings.Controls.Add(Me.AE_cbWarning)
        Me.gbAlarmSettings.Controls.Add(Me.AE_gbSignalType)
        Me.gbAlarmSettings.Controls.Add(Me.lblTimeFrame)
        Me.gbAlarmSettings.Controls.Add(Me.AE_cbEnabled)
        Me.gbAlarmSettings.Controls.Add(Me.AE_tbThreshold)
        Me.gbAlarmSettings.Controls.Add(Me.AE_gbAlarmType)
        Me.gbAlarmSettings.Controls.Add(Me.AE_tbTimeFrame)
        Me.gbAlarmSettings.Controls.Add(Me.Label5)
        Me.gbAlarmSettings.Location = New System.Drawing.Point(158, 63)
        Me.gbAlarmSettings.Name = "gbAlarmSettings"
        Me.gbAlarmSettings.Size = New System.Drawing.Size(561, 465)
        Me.gbAlarmSettings.TabIndex = 28
        Me.gbAlarmSettings.TabStop = False
        Me.gbAlarmSettings.Text = "Alarm Settings"
        '
        'AE_combWarningAlarms
        '
        Me.AE_combWarningAlarms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AE_combWarningAlarms.FormattingEnabled = True
        Me.AE_combWarningAlarms.Location = New System.Drawing.Point(156, 359)
        Me.AE_combWarningAlarms.Name = "AE_combWarningAlarms"
        Me.AE_combWarningAlarms.Size = New System.Drawing.Size(121, 21)
        Me.AE_combWarningAlarms.TabIndex = 25
        Me.AE_combWarningAlarms.Visible = False
        '
        'AE_lblWarningCode
        '
        Me.AE_lblWarningCode.AutoSize = True
        Me.AE_lblWarningCode.Location = New System.Drawing.Point(43, 361)
        Me.AE_lblWarningCode.Name = "AE_lblWarningCode"
        Me.AE_lblWarningCode.Size = New System.Drawing.Size(107, 13)
        Me.AE_lblWarningCode.TabIndex = 23
        Me.AE_lblWarningCode.Text = "Warning Alarm Code:"
        Me.AE_lblWarningCode.Visible = False
        '
        'AE_tbWarningTimeFrame
        '
        Me.AE_tbWarningTimeFrame.Location = New System.Drawing.Point(156, 333)
        Me.AE_tbWarningTimeFrame.Name = "AE_tbWarningTimeFrame"
        Me.AE_tbWarningTimeFrame.Size = New System.Drawing.Size(121, 20)
        Me.AE_tbWarningTimeFrame.TabIndex = 22
        Me.AE_tbWarningTimeFrame.Visible = False
        '
        'AE_tbWarningThreshold
        '
        Me.AE_tbWarningThreshold.Location = New System.Drawing.Point(156, 309)
        Me.AE_tbWarningThreshold.Name = "AE_tbWarningThreshold"
        Me.AE_tbWarningThreshold.Size = New System.Drawing.Size(121, 20)
        Me.AE_tbWarningThreshold.TabIndex = 21
        Me.AE_tbWarningThreshold.Visible = False
        '
        'AE_lblWarningTimeFrame
        '
        Me.AE_lblWarningTimeFrame.AutoSize = True
        Me.AE_lblWarningTimeFrame.Location = New System.Drawing.Point(42, 336)
        Me.AE_lblWarningTimeFrame.Name = "AE_lblWarningTimeFrame"
        Me.AE_lblWarningTimeFrame.Size = New System.Drawing.Size(108, 13)
        Me.AE_lblWarningTimeFrame.TabIndex = 20
        Me.AE_lblWarningTimeFrame.Text = "Warning Time Frame:"
        Me.AE_lblWarningTimeFrame.Visible = False
        '
        'AE_lblWarningThreshold
        '
        Me.AE_lblWarningThreshold.AutoSize = True
        Me.AE_lblWarningThreshold.Location = New System.Drawing.Point(50, 312)
        Me.AE_lblWarningThreshold.Name = "AE_lblWarningThreshold"
        Me.AE_lblWarningThreshold.Size = New System.Drawing.Size(100, 13)
        Me.AE_lblWarningThreshold.TabIndex = 19
        Me.AE_lblWarningThreshold.Text = "Warning Threshold:"
        Me.AE_lblWarningThreshold.Visible = False
        '
        'AE_cbWarning
        '
        Me.AE_cbWarning.AutoSize = True
        Me.AE_cbWarning.Location = New System.Drawing.Point(105, 275)
        Me.AE_cbWarning.Name = "AE_cbWarning"
        Me.AE_cbWarning.Size = New System.Drawing.Size(108, 17)
        Me.AE_cbWarning.TabIndex = 18
        Me.AE_cbWarning.Text = "Warning Enabled"
        Me.AE_cbWarning.UseVisualStyleBackColor = True
        '
        'AE_gbSignalType
        '
        Me.AE_gbSignalType.Controls.Add(Me.AE_rbString)
        Me.AE_gbSignalType.Controls.Add(Me.AE_rbAnalog)
        Me.AE_gbSignalType.Controls.Add(Me.AE_rbBinary)
        Me.AE_gbSignalType.Location = New System.Drawing.Point(255, 113)
        Me.AE_gbSignalType.Name = "AE_gbSignalType"
        Me.AE_gbSignalType.Size = New System.Drawing.Size(89, 99)
        Me.AE_gbSignalType.TabIndex = 15
        Me.AE_gbSignalType.TabStop = False
        Me.AE_gbSignalType.Text = "Signal Type"
        '
        'AE_rbString
        '
        Me.AE_rbString.AutoSize = True
        Me.AE_rbString.Location = New System.Drawing.Point(6, 67)
        Me.AE_rbString.Name = "AE_rbString"
        Me.AE_rbString.Size = New System.Drawing.Size(52, 17)
        Me.AE_rbString.TabIndex = 2
        Me.AE_rbString.TabStop = True
        Me.AE_rbString.Text = "String"
        Me.AE_rbString.UseVisualStyleBackColor = True
        '
        'AE_rbAnalog
        '
        Me.AE_rbAnalog.AutoSize = True
        Me.AE_rbAnalog.Location = New System.Drawing.Point(6, 44)
        Me.AE_rbAnalog.Name = "AE_rbAnalog"
        Me.AE_rbAnalog.Size = New System.Drawing.Size(58, 17)
        Me.AE_rbAnalog.TabIndex = 1
        Me.AE_rbAnalog.TabStop = True
        Me.AE_rbAnalog.Text = "Analog"
        Me.AE_rbAnalog.UseVisualStyleBackColor = True
        '
        'AE_rbBinary
        '
        Me.AE_rbBinary.AutoSize = True
        Me.AE_rbBinary.Location = New System.Drawing.Point(6, 21)
        Me.AE_rbBinary.Name = "AE_rbBinary"
        Me.AE_rbBinary.Size = New System.Drawing.Size(54, 17)
        Me.AE_rbBinary.TabIndex = 0
        Me.AE_rbBinary.TabStop = True
        Me.AE_rbBinary.Text = "Digital"
        Me.AE_rbBinary.UseVisualStyleBackColor = True
        '
        'lblTimeFrame
        '
        Me.lblTimeFrame.AutoSize = True
        Me.lblTimeFrame.Location = New System.Drawing.Point(22, 184)
        Me.lblTimeFrame.Name = "lblTimeFrame"
        Me.lblTimeFrame.Size = New System.Drawing.Size(65, 13)
        Me.lblTimeFrame.TabIndex = 7
        Me.lblTimeFrame.Text = "Time Frame:"
        '
        'AE_cbEnabled
        '
        Me.AE_cbEnabled.AutoSize = True
        Me.AE_cbEnabled.Enabled = False
        Me.AE_cbEnabled.Location = New System.Drawing.Point(93, 113)
        Me.AE_cbEnabled.Name = "AE_cbEnabled"
        Me.AE_cbEnabled.Size = New System.Drawing.Size(65, 17)
        Me.AE_cbEnabled.TabIndex = 9
        Me.AE_cbEnabled.Text = "Enabled"
        Me.AE_cbEnabled.UseVisualStyleBackColor = True
        '
        'AE_tbThreshold
        '
        Me.AE_tbThreshold.Location = New System.Drawing.Point(93, 152)
        Me.AE_tbThreshold.Name = "AE_tbThreshold"
        Me.AE_tbThreshold.Size = New System.Drawing.Size(100, 20)
        Me.AE_tbThreshold.TabIndex = 17
        '
        'AE_gbAlarmType
        '
        Me.AE_gbAlarmType.Controls.Add(Me.AE_rbEnhanced)
        Me.AE_gbAlarmType.Controls.Add(Me.AE_rbBasic)
        Me.AE_gbAlarmType.Location = New System.Drawing.Point(93, 31)
        Me.AE_gbAlarmType.Name = "AE_gbAlarmType"
        Me.AE_gbAlarmType.Size = New System.Drawing.Size(200, 49)
        Me.AE_gbAlarmType.TabIndex = 4
        Me.AE_gbAlarmType.TabStop = False
        Me.AE_gbAlarmType.Text = "Type of Alarm"
        '
        'AE_rbEnhanced
        '
        Me.AE_rbEnhanced.AutoSize = True
        Me.AE_rbEnhanced.Location = New System.Drawing.Point(102, 19)
        Me.AE_rbEnhanced.Name = "AE_rbEnhanced"
        Me.AE_rbEnhanced.Size = New System.Drawing.Size(74, 17)
        Me.AE_rbEnhanced.TabIndex = 1
        Me.AE_rbEnhanced.TabStop = True
        Me.AE_rbEnhanced.Text = "Enhanced"
        Me.AE_rbEnhanced.UseVisualStyleBackColor = True
        '
        'AE_rbBasic
        '
        Me.AE_rbBasic.AutoSize = True
        Me.AE_rbBasic.Location = New System.Drawing.Point(28, 19)
        Me.AE_rbBasic.Name = "AE_rbBasic"
        Me.AE_rbBasic.Size = New System.Drawing.Size(51, 17)
        Me.AE_rbBasic.TabIndex = 0
        Me.AE_rbBasic.TabStop = True
        Me.AE_rbBasic.Text = "Basic"
        Me.AE_rbBasic.UseVisualStyleBackColor = True
        '
        'AE_tbTimeFrame
        '
        Me.AE_tbTimeFrame.Location = New System.Drawing.Point(93, 181)
        Me.AE_tbTimeFrame.Name = "AE_tbTimeFrame"
        Me.AE_tbTimeFrame.Size = New System.Drawing.Size(100, 20)
        Me.AE_tbTimeFrame.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Threshold:"
        '
        'AE_btnNew
        '
        Me.AE_btnNew.Location = New System.Drawing.Point(3, 595)
        Me.AE_btnNew.Name = "AE_btnNew"
        Me.AE_btnNew.Size = New System.Drawing.Size(57, 23)
        Me.AE_btnNew.TabIndex = 23
        Me.AE_btnNew.Text = "New"
        Me.AE_btnNew.UseVisualStyleBackColor = True
        '
        'AE_btnDel
        '
        Me.AE_btnDel.Location = New System.Drawing.Point(66, 595)
        Me.AE_btnDel.Name = "AE_btnDel"
        Me.AE_btnDel.Size = New System.Drawing.Size(58, 23)
        Me.AE_btnDel.TabIndex = 22
        Me.AE_btnDel.Text = "Delete"
        Me.AE_btnDel.UseVisualStyleBackColor = True
        '
        'AE_btnClear
        '
        Me.AE_btnClear.Location = New System.Drawing.Point(860, 595)
        Me.AE_btnClear.Name = "AE_btnClear"
        Me.AE_btnClear.Size = New System.Drawing.Size(66, 23)
        Me.AE_btnClear.TabIndex = 26
        Me.AE_btnClear.Text = "Clear"
        Me.AE_btnClear.UseVisualStyleBackColor = True
        '
        'AE_btnSave
        '
        Me.AE_btnSave.Location = New System.Drawing.Point(786, 595)
        Me.AE_btnSave.Name = "AE_btnSave"
        Me.AE_btnSave.Size = New System.Drawing.Size(65, 23)
        Me.AE_btnSave.TabIndex = 25
        Me.AE_btnSave.Text = "Save"
        Me.AE_btnSave.UseVisualStyleBackColor = True
        '
        'AE_lblName
        '
        Me.AE_lblName.AutoSize = True
        Me.AE_lblName.Location = New System.Drawing.Point(158, 40)
        Me.AE_lblName.Name = "AE_lblName"
        Me.AE_lblName.Size = New System.Drawing.Size(75, 13)
        Me.AE_lblName.TabIndex = 19
        Me.AE_lblName.Text = "Device Name:"
        Me.AE_lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AE_lbDeviceName
        '
        Me.AE_lbDeviceName.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.AE_lbDeviceName, 2)
        Me.AE_lbDeviceName.Location = New System.Drawing.Point(249, 40)
        Me.AE_lbDeviceName.Name = "AE_lbDeviceName"
        Me.AE_lbDeviceName.Size = New System.Drawing.Size(0, 13)
        Me.AE_lbDeviceName.TabIndex = 29
        '
        'tpRoomType
        '
        Me.tpRoomType.BackColor = System.Drawing.SystemColors.Control
        Me.tpRoomType.Controls.Add(Me.TableLayoutPanel3)
        Me.tpRoomType.Location = New System.Drawing.Point(4, 22)
        Me.tpRoomType.Name = "tpRoomType"
        Me.tpRoomType.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRoomType.Size = New System.Drawing.Size(936, 653)
        Me.tpRoomType.TabIndex = 0
        Me.tpRoomType.Text = "Room Type Editor"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox2, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox1, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_lblRoomTypes, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_lbRoomTypes, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_btnNew, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_btnDelete, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_btnSave, 4, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_btnClear, 5, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox3, 4, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(930, 647)
        Me.TableLayoutPanel3.TabIndex = 32
        '
        'GroupBox2
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.GroupBox2, 2)
        Me.GroupBox2.Controls.Add(Me.RTE_btnBrowseProgram)
        Me.GroupBox2.Controls.Add(Me.RTE_tbProgramName)
        Me.GroupBox2.Controls.Add(Me.RTE_lblDefaultProgram)
        Me.GroupBox2.Location = New System.Drawing.Point(562, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.TableLayoutPanel3.SetRowSpan(Me.GroupBox2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(296, 177)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Program Info"
        '
        'RTE_btnBrowseProgram
        '
        Me.RTE_btnBrowseProgram.Location = New System.Drawing.Point(165, 48)
        Me.RTE_btnBrowseProgram.Name = "RTE_btnBrowseProgram"
        Me.RTE_btnBrowseProgram.Size = New System.Drawing.Size(75, 23)
        Me.RTE_btnBrowseProgram.TabIndex = 13
        Me.RTE_btnBrowseProgram.Text = "Browse"
        Me.RTE_btnBrowseProgram.UseVisualStyleBackColor = True
        '
        'RTE_tbProgramName
        '
        Me.RTE_tbProgramName.Location = New System.Drawing.Point(9, 50)
        Me.RTE_tbProgramName.Name = "RTE_tbProgramName"
        Me.RTE_tbProgramName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RTE_tbProgramName.Size = New System.Drawing.Size(150, 20)
        Me.RTE_tbProgramName.TabIndex = 15
        '
        'RTE_lblDefaultProgram
        '
        Me.RTE_lblDefaultProgram.AutoSize = True
        Me.RTE_lblDefaultProgram.Location = New System.Drawing.Point(6, 25)
        Me.RTE_lblDefaultProgram.Name = "RTE_lblDefaultProgram"
        Me.RTE_lblDefaultProgram.Size = New System.Drawing.Size(83, 13)
        Me.RTE_lblDefaultProgram.TabIndex = 19
        Me.RTE_lblDefaultProgram.Text = "Default Program"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RTE_lbDeviceTypesAvailable)
        Me.GroupBox1.Controls.Add(Me.RTE_tvDevicesAdded)
        Me.GroupBox1.Controls.Add(Me.RTE_btnAllDeviceAdd)
        Me.GroupBox1.Controls.Add(Me.RTE_lblDevicesAdded)
        Me.GroupBox1.Controls.Add(Me.RTE_btnDeviceAdd)
        Me.GroupBox1.Controls.Add(Me.RTE_lblDevicesAvailable)
        Me.GroupBox1.Controls.Add(Me.RTE_btnAllDeviceRemove)
        Me.GroupBox1.Controls.Add(Me.RTE_btnDeviceRemove)
        Me.GroupBox1.Location = New System.Drawing.Point(159, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.TableLayoutPanel3.SetRowSpan(Me.GroupBox1, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(372, 457)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Devices"
        '
        'RTE_lbDeviceTypesAvailable
        '
        Me.RTE_lbDeviceTypesAvailable.FormattingEnabled = True
        Me.RTE_lbDeviceTypesAvailable.Location = New System.Drawing.Point(6, 45)
        Me.RTE_lbDeviceTypesAvailable.MinimumSize = New System.Drawing.Size(100, 4)
        Me.RTE_lbDeviceTypesAvailable.Name = "RTE_lbDeviceTypesAvailable"
        Me.RTE_lbDeviceTypesAvailable.Size = New System.Drawing.Size(120, 303)
        Me.RTE_lbDeviceTypesAvailable.TabIndex = 1
        '
        'RTE_tvDevicesAdded
        '
        Me.RTE_tvDevicesAdded.ContextMenuStrip = Me.tvMenuStrip
        Me.RTE_tvDevicesAdded.Location = New System.Drawing.Point(170, 41)
        Me.RTE_tvDevicesAdded.MinimumSize = New System.Drawing.Size(90, 4)
        Me.RTE_tvDevicesAdded.Name = "RTE_tvDevicesAdded"
        Me.RTE_tvDevicesAdded.Size = New System.Drawing.Size(125, 303)
        Me.RTE_tvDevicesAdded.TabIndex = 12
        '
        'tvMenuStrip
        '
        Me.tvMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAddItem, Me.tsmiDeleteItem})
        Me.tvMenuStrip.Name = "ContextMenuStrip1"
        Me.tvMenuStrip.Size = New System.Drawing.Size(135, 48)
        '
        'tsmiAddItem
        '
        Me.tsmiAddItem.Name = "tsmiAddItem"
        Me.tsmiAddItem.Size = New System.Drawing.Size(134, 22)
        Me.tsmiAddItem.Text = "Add Item"
        '
        'tsmiDeleteItem
        '
        Me.tsmiDeleteItem.Name = "tsmiDeleteItem"
        Me.tsmiDeleteItem.Size = New System.Drawing.Size(134, 22)
        Me.tsmiDeleteItem.Text = "Delete Item"
        '
        'RTE_btnAllDeviceAdd
        '
        Me.RTE_btnAllDeviceAdd.Location = New System.Drawing.Point(132, 113)
        Me.RTE_btnAllDeviceAdd.MinimumSize = New System.Drawing.Size(27, 23)
        Me.RTE_btnAllDeviceAdd.Name = "RTE_btnAllDeviceAdd"
        Me.RTE_btnAllDeviceAdd.Size = New System.Drawing.Size(27, 23)
        Me.RTE_btnAllDeviceAdd.TabIndex = 3
        Me.RTE_btnAllDeviceAdd.Text = ">>"
        Me.RTE_btnAllDeviceAdd.UseVisualStyleBackColor = True
        '
        'RTE_lblDevicesAdded
        '
        Me.RTE_lblDevicesAdded.AutoSize = True
        Me.RTE_lblDevicesAdded.Location = New System.Drawing.Point(213, 25)
        Me.RTE_lblDevicesAdded.Name = "RTE_lblDevicesAdded"
        Me.RTE_lblDevicesAdded.Size = New System.Drawing.Size(38, 13)
        Me.RTE_lblDevicesAdded.TabIndex = 18
        Me.RTE_lblDevicesAdded.Text = "Added"
        '
        'RTE_btnDeviceAdd
        '
        Me.RTE_btnDeviceAdd.Location = New System.Drawing.Point(132, 142)
        Me.RTE_btnDeviceAdd.MinimumSize = New System.Drawing.Size(27, 23)
        Me.RTE_btnDeviceAdd.Name = "RTE_btnDeviceAdd"
        Me.RTE_btnDeviceAdd.Size = New System.Drawing.Size(27, 23)
        Me.RTE_btnDeviceAdd.TabIndex = 4
        Me.RTE_btnDeviceAdd.Text = ">"
        Me.RTE_btnDeviceAdd.UseVisualStyleBackColor = True
        '
        'RTE_lblDevicesAvailable
        '
        Me.RTE_lblDevicesAvailable.AutoSize = True
        Me.RTE_lblDevicesAvailable.Location = New System.Drawing.Point(34, 25)
        Me.RTE_lblDevicesAvailable.Name = "RTE_lblDevicesAvailable"
        Me.RTE_lblDevicesAvailable.Size = New System.Drawing.Size(50, 13)
        Me.RTE_lblDevicesAvailable.TabIndex = 17
        Me.RTE_lblDevicesAvailable.Text = "Available"
        '
        'RTE_btnAllDeviceRemove
        '
        Me.RTE_btnAllDeviceRemove.Location = New System.Drawing.Point(132, 200)
        Me.RTE_btnAllDeviceRemove.MinimumSize = New System.Drawing.Size(27, 23)
        Me.RTE_btnAllDeviceRemove.Name = "RTE_btnAllDeviceRemove"
        Me.RTE_btnAllDeviceRemove.Size = New System.Drawing.Size(27, 23)
        Me.RTE_btnAllDeviceRemove.TabIndex = 6
        Me.RTE_btnAllDeviceRemove.Text = "<<"
        Me.RTE_btnAllDeviceRemove.UseVisualStyleBackColor = True
        '
        'RTE_btnDeviceRemove
        '
        Me.RTE_btnDeviceRemove.Location = New System.Drawing.Point(132, 171)
        Me.RTE_btnDeviceRemove.MinimumSize = New System.Drawing.Size(27, 23)
        Me.RTE_btnDeviceRemove.Name = "RTE_btnDeviceRemove"
        Me.RTE_btnDeviceRemove.Size = New System.Drawing.Size(27, 23)
        Me.RTE_btnDeviceRemove.TabIndex = 5
        Me.RTE_btnDeviceRemove.Text = "<"
        Me.RTE_btnDeviceRemove.UseVisualStyleBackColor = True
        '
        'RTE_lblRoomTypes
        '
        Me.RTE_lblRoomTypes.AutoSize = True
        Me.RTE_lblRoomTypes.Location = New System.Drawing.Point(3, 0)
        Me.RTE_lblRoomTypes.Name = "RTE_lblRoomTypes"
        Me.RTE_lblRoomTypes.Size = New System.Drawing.Size(67, 8)
        Me.RTE_lblRoomTypes.TabIndex = 28
        Me.RTE_lblRoomTypes.Text = "Room Types"
        '
        'RTE_lbRoomTypes
        '
        Me.RTE_lbRoomTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.RTE_lbRoomTypes, 2)
        Me.RTE_lbRoomTypes.FormattingEnabled = True
        Me.RTE_lbRoomTypes.Location = New System.Drawing.Point(8, 11)
        Me.RTE_lbRoomTypes.Name = "RTE_lbRoomTypes"
        Me.TableLayoutPanel3.SetRowSpan(Me.RTE_lbRoomTypes, 3)
        Me.RTE_lbRoomTypes.Size = New System.Drawing.Size(140, 472)
        Me.RTE_lbRoomTypes.TabIndex = 23
        '
        'RTE_btnNew
        '
        Me.RTE_btnNew.Location = New System.Drawing.Point(3, 489)
        Me.RTE_btnNew.MinimumSize = New System.Drawing.Size(72, 23)
        Me.RTE_btnNew.Name = "RTE_btnNew"
        Me.RTE_btnNew.Size = New System.Drawing.Size(72, 23)
        Me.RTE_btnNew.TabIndex = 24
        Me.RTE_btnNew.Text = "New"
        Me.RTE_btnNew.UseVisualStyleBackColor = True
        '
        'RTE_btnDelete
        '
        Me.RTE_btnDelete.Location = New System.Drawing.Point(81, 489)
        Me.RTE_btnDelete.MinimumSize = New System.Drawing.Size(72, 23)
        Me.RTE_btnDelete.Name = "RTE_btnDelete"
        Me.RTE_btnDelete.Size = New System.Drawing.Size(72, 23)
        Me.RTE_btnDelete.TabIndex = 29
        Me.RTE_btnDelete.Text = "Delete"
        Me.RTE_btnDelete.UseVisualStyleBackColor = True
        '
        'RTE_btnSave
        '
        Me.RTE_btnSave.Location = New System.Drawing.Point(562, 489)
        Me.RTE_btnSave.MinimumSize = New System.Drawing.Size(63, 23)
        Me.RTE_btnSave.Name = "RTE_btnSave"
        Me.RTE_btnSave.Size = New System.Drawing.Size(63, 23)
        Me.RTE_btnSave.TabIndex = 25
        Me.RTE_btnSave.Text = "Save"
        Me.RTE_btnSave.UseVisualStyleBackColor = True
        '
        'RTE_btnClear
        '
        Me.RTE_btnClear.Location = New System.Drawing.Point(864, 489)
        Me.RTE_btnClear.MinimumSize = New System.Drawing.Size(63, 23)
        Me.RTE_btnClear.Name = "RTE_btnClear"
        Me.RTE_btnClear.Size = New System.Drawing.Size(63, 23)
        Me.RTE_btnClear.TabIndex = 26
        Me.RTE_btnClear.Text = "Clear"
        Me.RTE_btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(562, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 192)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Default States"
        '
        'tpRoomLoader
        '
        Me.tpRoomLoader.BackColor = System.Drawing.SystemColors.Control
        Me.tpRoomLoader.Controls.Add(Me.RL_Flags)
        Me.tpRoomLoader.Controls.Add(Me.RL_btnLoad)
        Me.tpRoomLoader.Controls.Add(Me.RL_lsvRooms)
        Me.tpRoomLoader.Controls.Add(Me.RL_btnBrowseExcel)
        Me.tpRoomLoader.Location = New System.Drawing.Point(4, 22)
        Me.tpRoomLoader.Name = "tpRoomLoader"
        Me.tpRoomLoader.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRoomLoader.Size = New System.Drawing.Size(936, 653)
        Me.tpRoomLoader.TabIndex = 1
        Me.tpRoomLoader.Text = "Excel Room Loader"
        '
        'RL_Flags
        '
        Me.RL_Flags.Controls.Add(Me.RL_cbLoadDefaultProgram)
        Me.RL_Flags.Controls.Add(Me.RL_cbLoadProcessorSettings)
        Me.RL_Flags.Controls.Add(Me.RL_cbLoadDevicesPerRoom)
        Me.RL_Flags.Location = New System.Drawing.Point(525, 159)
        Me.RL_Flags.Name = "RL_Flags"
        Me.RL_Flags.Size = New System.Drawing.Size(245, 131)
        Me.RL_Flags.TabIndex = 11
        Me.RL_Flags.TabStop = False
        Me.RL_Flags.Text = "Flags"
        '
        'RL_cbLoadDefaultProgram
        '
        Me.RL_cbLoadDefaultProgram.AutoSize = True
        Me.RL_cbLoadDefaultProgram.Location = New System.Drawing.Point(6, 19)
        Me.RL_cbLoadDefaultProgram.Name = "RL_cbLoadDefaultProgram"
        Me.RL_cbLoadDefaultProgram.Size = New System.Drawing.Size(205, 17)
        Me.RL_cbLoadDefaultProgram.TabIndex = 8
        Me.RL_cbLoadDefaultProgram.Text = "Load Default Program per Room Type"
        Me.RL_cbLoadDefaultProgram.UseVisualStyleBackColor = True
        '
        'RL_cbLoadProcessorSettings
        '
        Me.RL_cbLoadProcessorSettings.AutoSize = True
        Me.RL_cbLoadProcessorSettings.Location = New System.Drawing.Point(6, 65)
        Me.RL_cbLoadProcessorSettings.Name = "RL_cbLoadProcessorSettings"
        Me.RL_cbLoadProcessorSettings.Size = New System.Drawing.Size(191, 17)
        Me.RL_cbLoadProcessorSettings.TabIndex = 10
        Me.RL_cbLoadProcessorSettings.Text = "Load Processor Settings Per Room"
        Me.RL_cbLoadProcessorSettings.UseVisualStyleBackColor = True
        '
        'RL_cbLoadDevicesPerRoom
        '
        Me.RL_cbLoadDevicesPerRoom.AutoSize = True
        Me.RL_cbLoadDevicesPerRoom.Location = New System.Drawing.Point(6, 42)
        Me.RL_cbLoadDevicesPerRoom.Name = "RL_cbLoadDevicesPerRoom"
        Me.RL_cbLoadDevicesPerRoom.Size = New System.Drawing.Size(169, 17)
        Me.RL_cbLoadDevicesPerRoom.TabIndex = 9
        Me.RL_cbLoadDevicesPerRoom.Text = "Load Devices Per Room Type"
        Me.RL_cbLoadDevicesPerRoom.UseVisualStyleBackColor = True
        '
        'RL_btnLoad
        '
        Me.RL_btnLoad.Location = New System.Drawing.Point(695, 553)
        Me.RL_btnLoad.Name = "RL_btnLoad"
        Me.RL_btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.RL_btnLoad.TabIndex = 7
        Me.RL_btnLoad.Text = "Load Room(s)"
        Me.RL_btnLoad.UseVisualStyleBackColor = True
        '
        'RL_lsvRooms
        '
        Me.RL_lsvRooms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBuilding, Me.colFloor, Me.colRoom, Me.colType, Me.colIP})
        Me.RL_lsvRooms.GridLines = True
        Me.RL_lsvRooms.Location = New System.Drawing.Point(6, 27)
        Me.RL_lsvRooms.Name = "RL_lsvRooms"
        Me.RL_lsvRooms.Size = New System.Drawing.Size(479, 520)
        Me.RL_lsvRooms.TabIndex = 6
        Me.RL_lsvRooms.UseCompatibleStateImageBehavior = False
        Me.RL_lsvRooms.View = System.Windows.Forms.View.Details
        '
        'colBuilding
        '
        Me.colBuilding.Text = "Building"
        Me.colBuilding.Width = 78
        '
        'colFloor
        '
        Me.colFloor.Text = "Floor"
        '
        'colRoom
        '
        Me.colRoom.Text = "Room Name"
        Me.colRoom.Width = 96
        '
        'colType
        '
        Me.colType.Text = "Room Type"
        Me.colType.Width = 120
        '
        'colIP
        '
        Me.colIP.Text = "IP Address"
        Me.colIP.Width = 138
        '
        'RL_btnBrowseExcel
        '
        Me.RL_btnBrowseExcel.Location = New System.Drawing.Point(410, 553)
        Me.RL_btnBrowseExcel.Name = "RL_btnBrowseExcel"
        Me.RL_btnBrowseExcel.Size = New System.Drawing.Size(75, 23)
        Me.RL_btnBrowseExcel.TabIndex = 5
        Me.RL_btnBrowseExcel.Text = "Browse"
        Me.RL_btnBrowseExcel.UseVisualStyleBackColor = True
        '
        'tpRoomEditor
        '
        Me.tpRoomEditor.BackColor = System.Drawing.SystemColors.Control
        Me.tpRoomEditor.Controls.Add(Me.TableLayoutPanel2)
        Me.tpRoomEditor.Location = New System.Drawing.Point(4, 22)
        Me.tpRoomEditor.Name = "tpRoomEditor"
        Me.tpRoomEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRoomEditor.Size = New System.Drawing.Size(936, 653)
        Me.tpRoomEditor.TabIndex = 3
        Me.tpRoomEditor.Text = "Room Editor"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.gbRoomDetails, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_tcRoomViewer, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_btnSendProgram, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_btnNew, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_btnDelete, 1, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(930, 647)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'gbRoomDetails
        '
        Me.gbRoomDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbRoomDetails.Controls.Add(Me.RE_tbSTBip)
        Me.gbRoomDetails.Controls.Add(Me.RE_lblSTBAddress)
        Me.gbRoomDetails.Controls.Add(Me.RE_tbFloor)
        Me.gbRoomDetails.Controls.Add(Me.RE_lblFloor)
        Me.gbRoomDetails.Controls.Add(Me.RE_tbMAC)
        Me.gbRoomDetails.Controls.Add(Me.RE_lblMAC)
        Me.gbRoomDetails.Controls.Add(Me.RE_tbIpAddress)
        Me.gbRoomDetails.Controls.Add(Me.RE_lblIpAddress)
        Me.gbRoomDetails.Controls.Add(Me.RE_tbBuilding)
        Me.gbRoomDetails.Controls.Add(Me.RE_lblBuilding)
        Me.gbRoomDetails.Controls.Add(Me.RE_tbRoomType)
        Me.gbRoomDetails.Controls.Add(Me.RE_lblRoomType)
        Me.gbRoomDetails.Controls.Add(Me.RE_tbRoomName)
        Me.gbRoomDetails.Controls.Add(Me.RE_lblRoomName)
        Me.gbRoomDetails.Location = New System.Drawing.Point(186, 3)
        Me.gbRoomDetails.Name = "gbRoomDetails"
        Me.gbRoomDetails.Size = New System.Drawing.Size(544, 219)
        Me.gbRoomDetails.TabIndex = 2
        Me.gbRoomDetails.TabStop = False
        Me.gbRoomDetails.Text = "Room Details"
        '
        'RE_tbSTBip
        '
        Me.RE_tbSTBip.Location = New System.Drawing.Point(380, 83)
        Me.RE_tbSTBip.Name = "RE_tbSTBip"
        Me.RE_tbSTBip.Size = New System.Drawing.Size(100, 20)
        Me.RE_tbSTBip.TabIndex = 13
        '
        'RE_lblSTBAddress
        '
        Me.RE_lblSTBAddress.AutoSize = True
        Me.RE_lblSTBAddress.Location = New System.Drawing.Point(292, 86)
        Me.RE_lblSTBAddress.Name = "RE_lblSTBAddress"
        Me.RE_lblSTBAddress.Size = New System.Drawing.Size(82, 13)
        Me.RE_lblSTBAddress.TabIndex = 12
        Me.RE_lblSTBAddress.Text = "Set Top Box IP:"
        '
        'RE_tbFloor
        '
        Me.RE_tbFloor.Location = New System.Drawing.Point(77, 109)
        Me.RE_tbFloor.Name = "RE_tbFloor"
        Me.RE_tbFloor.Size = New System.Drawing.Size(100, 20)
        Me.RE_tbFloor.TabIndex = 11
        '
        'RE_lblFloor
        '
        Me.RE_lblFloor.AutoSize = True
        Me.RE_lblFloor.Location = New System.Drawing.Point(34, 112)
        Me.RE_lblFloor.Name = "RE_lblFloor"
        Me.RE_lblFloor.Size = New System.Drawing.Size(33, 13)
        Me.RE_lblFloor.TabIndex = 10
        Me.RE_lblFloor.Text = "Floor:"
        '
        'RE_tbMAC
        '
        Me.RE_tbMAC.Location = New System.Drawing.Point(380, 57)
        Me.RE_tbMAC.Name = "RE_tbMAC"
        Me.RE_tbMAC.Size = New System.Drawing.Size(100, 20)
        Me.RE_tbMAC.TabIndex = 9
        '
        'RE_lblMAC
        '
        Me.RE_lblMAC.AutoSize = True
        Me.RE_lblMAC.Location = New System.Drawing.Point(305, 60)
        Me.RE_lblMAC.Name = "RE_lblMAC"
        Me.RE_lblMAC.Size = New System.Drawing.Size(72, 13)
        Me.RE_lblMAC.TabIndex = 8
        Me.RE_lblMAC.Text = "Mac Address:"
        '
        'RE_tbIpAddress
        '
        Me.RE_tbIpAddress.Location = New System.Drawing.Point(380, 31)
        Me.RE_tbIpAddress.Name = "RE_tbIpAddress"
        Me.RE_tbIpAddress.Size = New System.Drawing.Size(100, 20)
        Me.RE_tbIpAddress.TabIndex = 7
        '
        'RE_lblIpAddress
        '
        Me.RE_lblIpAddress.AutoSize = True
        Me.RE_lblIpAddress.Location = New System.Drawing.Point(316, 34)
        Me.RE_lblIpAddress.Name = "RE_lblIpAddress"
        Me.RE_lblIpAddress.Size = New System.Drawing.Size(61, 13)
        Me.RE_lblIpAddress.TabIndex = 6
        Me.RE_lblIpAddress.Text = "IP Address:"
        '
        'RE_tbBuilding
        '
        Me.RE_tbBuilding.Location = New System.Drawing.Point(77, 83)
        Me.RE_tbBuilding.Name = "RE_tbBuilding"
        Me.RE_tbBuilding.Size = New System.Drawing.Size(100, 20)
        Me.RE_tbBuilding.TabIndex = 5
        '
        'RE_lblBuilding
        '
        Me.RE_lblBuilding.AutoSize = True
        Me.RE_lblBuilding.Location = New System.Drawing.Point(20, 86)
        Me.RE_lblBuilding.Name = "RE_lblBuilding"
        Me.RE_lblBuilding.Size = New System.Drawing.Size(47, 13)
        Me.RE_lblBuilding.TabIndex = 4
        Me.RE_lblBuilding.Text = "Building:"
        '
        'RE_tbRoomType
        '
        Me.RE_tbRoomType.Location = New System.Drawing.Point(77, 57)
        Me.RE_tbRoomType.Name = "RE_tbRoomType"
        Me.RE_tbRoomType.Size = New System.Drawing.Size(100, 20)
        Me.RE_tbRoomType.TabIndex = 3
        '
        'RE_lblRoomType
        '
        Me.RE_lblRoomType.AutoSize = True
        Me.RE_lblRoomType.Location = New System.Drawing.Point(6, 60)
        Me.RE_lblRoomType.Name = "RE_lblRoomType"
        Me.RE_lblRoomType.Size = New System.Drawing.Size(65, 13)
        Me.RE_lblRoomType.TabIndex = 2
        Me.RE_lblRoomType.Text = "Room Type:"
        '
        'RE_tbRoomName
        '
        Me.RE_tbRoomName.Location = New System.Drawing.Point(77, 31)
        Me.RE_tbRoomName.Name = "RE_tbRoomName"
        Me.RE_tbRoomName.Size = New System.Drawing.Size(100, 20)
        Me.RE_tbRoomName.TabIndex = 1
        '
        'RE_lblRoomName
        '
        Me.RE_lblRoomName.AutoSize = True
        Me.RE_lblRoomName.Location = New System.Drawing.Point(6, 34)
        Me.RE_lblRoomName.Name = "RE_lblRoomName"
        Me.RE_lblRoomName.Size = New System.Drawing.Size(69, 13)
        Me.RE_lblRoomName.TabIndex = 0
        Me.RE_lblRoomName.Text = "Room Name:"
        '
        'RE_tcRoomViewer
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.RE_tcRoomViewer, 2)
        Me.RE_tcRoomViewer.Controls.Add(Me.RE_tbByFloor)
        Me.RE_tcRoomViewer.Controls.Add(Me.RE_tbByType)
        Me.RE_tcRoomViewer.Location = New System.Drawing.Point(3, 3)
        Me.RE_tcRoomViewer.Name = "RE_tcRoomViewer"
        Me.TableLayoutPanel2.SetRowSpan(Me.RE_tcRoomViewer, 4)
        Me.RE_tcRoomViewer.SelectedIndex = 0
        Me.RE_tcRoomViewer.Size = New System.Drawing.Size(177, 601)
        Me.RE_tcRoomViewer.TabIndex = 5
        '
        'RE_tbByFloor
        '
        Me.RE_tbByFloor.Controls.Add(Me.RE_tvRoomsByFloor)
        Me.RE_tbByFloor.Location = New System.Drawing.Point(4, 22)
        Me.RE_tbByFloor.Name = "RE_tbByFloor"
        Me.RE_tbByFloor.Padding = New System.Windows.Forms.Padding(3)
        Me.RE_tbByFloor.Size = New System.Drawing.Size(169, 575)
        Me.RE_tbByFloor.TabIndex = 0
        Me.RE_tbByFloor.Text = "By Floor"
        Me.RE_tbByFloor.UseVisualStyleBackColor = True
        '
        'RE_tvRoomsByFloor
        '
        Me.RE_tvRoomsByFloor.ContextMenuStrip = Me.RE_cmsTV
        Me.RE_tvRoomsByFloor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RE_tvRoomsByFloor.Location = New System.Drawing.Point(3, 3)
        Me.RE_tvRoomsByFloor.Name = "RE_tvRoomsByFloor"
        Me.RE_tvRoomsByFloor.Size = New System.Drawing.Size(163, 569)
        Me.RE_tvRoomsByFloor.TabIndex = 0
        '
        'RE_cmsTV
        '
        Me.RE_cmsTV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadProgramsToolStripMenuItem, Me.RemotesToolStripMenuItem})
        Me.RE_cmsTV.Name = "RE_cmsTV"
        Me.RE_cmsTV.Size = New System.Drawing.Size(163, 48)
        '
        'LoadProgramsToolStripMenuItem
        '
        Me.LoadProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDefaultProgramByRoomTypeToolStripMenuItem, Me.LoadOtherProgramToolStripMenuItem})
        Me.LoadProgramsToolStripMenuItem.Name = "LoadProgramsToolStripMenuItem"
        Me.LoadProgramsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LoadProgramsToolStripMenuItem.Text = "Load Program(s)"
        '
        'LoadDefaultProgramByRoomTypeToolStripMenuItem
        '
        Me.LoadDefaultProgramByRoomTypeToolStripMenuItem.Name = "LoadDefaultProgramByRoomTypeToolStripMenuItem"
        Me.LoadDefaultProgramByRoomTypeToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.LoadDefaultProgramByRoomTypeToolStripMenuItem.Text = "Load Default Program By Room Type"
        '
        'LoadOtherProgramToolStripMenuItem
        '
        Me.LoadOtherProgramToolStripMenuItem.Name = "LoadOtherProgramToolStripMenuItem"
        Me.LoadOtherProgramToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.LoadOtherProgramToolStripMenuItem.Text = "Load Other Program.."
        '
        'RemotesToolStripMenuItem
        '
        Me.RemotesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadNewRemoteFileToolStripMenuItem, Me.LoadDefaultRemoteFileToolStripMenuItem})
        Me.RemotesToolStripMenuItem.Name = "RemotesToolStripMenuItem"
        Me.RemotesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RemotesToolStripMenuItem.Text = "Remote(s)"
        '
        'LoadNewRemoteFileToolStripMenuItem
        '
        Me.LoadNewRemoteFileToolStripMenuItem.Name = "LoadNewRemoteFileToolStripMenuItem"
        Me.LoadNewRemoteFileToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.LoadNewRemoteFileToolStripMenuItem.Text = "Load New Remote File"
        '
        'LoadDefaultRemoteFileToolStripMenuItem
        '
        Me.LoadDefaultRemoteFileToolStripMenuItem.Name = "LoadDefaultRemoteFileToolStripMenuItem"
        Me.LoadDefaultRemoteFileToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.LoadDefaultRemoteFileToolStripMenuItem.Text = "Load Default Remote File"
        '
        'RE_tbByType
        '
        Me.RE_tbByType.Controls.Add(Me.RE_tvRoomsByType)
        Me.RE_tbByType.Location = New System.Drawing.Point(4, 22)
        Me.RE_tbByType.Name = "RE_tbByType"
        Me.RE_tbByType.Padding = New System.Windows.Forms.Padding(3)
        Me.RE_tbByType.Size = New System.Drawing.Size(169, 575)
        Me.RE_tbByType.TabIndex = 1
        Me.RE_tbByType.Text = "By Type"
        Me.RE_tbByType.UseVisualStyleBackColor = True
        '
        'RE_tvRoomsByType
        '
        Me.RE_tvRoomsByType.ContextMenuStrip = Me.RE_cmsTV
        Me.RE_tvRoomsByType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RE_tvRoomsByType.Location = New System.Drawing.Point(3, 3)
        Me.RE_tvRoomsByType.Name = "RE_tvRoomsByType"
        Me.RE_tvRoomsByType.Size = New System.Drawing.Size(163, 569)
        Me.RE_tvRoomsByType.TabIndex = 6
        '
        'RE_btnSendProgram
        '
        Me.RE_btnSendProgram.Location = New System.Drawing.Point(186, 581)
        Me.RE_btnSendProgram.Name = "RE_btnSendProgram"
        Me.RE_btnSendProgram.Size = New System.Drawing.Size(69, 23)
        Me.RE_btnSendProgram.TabIndex = 3
        Me.RE_btnSendProgram.Text = "Send Program"
        Me.RE_btnSendProgram.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(736, 581)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RE_btnNew
        '
        Me.RE_btnNew.Location = New System.Drawing.Point(3, 610)
        Me.RE_btnNew.Name = "RE_btnNew"
        Me.RE_btnNew.Size = New System.Drawing.Size(75, 23)
        Me.RE_btnNew.TabIndex = 6
        Me.RE_btnNew.Text = "New"
        Me.RE_btnNew.UseVisualStyleBackColor = True
        '
        'RE_btnDelete
        '
        Me.RE_btnDelete.Location = New System.Drawing.Point(84, 610)
        Me.RE_btnDelete.Name = "RE_btnDelete"
        Me.RE_btnDelete.Size = New System.Drawing.Size(79, 23)
        Me.RE_btnDelete.TabIndex = 7
        Me.RE_btnDelete.Text = "Delete"
        Me.RE_btnDelete.UseVisualStyleBackColor = True
        '
        'tpEventEditor
        '
        Me.tpEventEditor.BackColor = System.Drawing.SystemColors.Control
        Me.tpEventEditor.Controls.Add(Me.tlpEventEditor)
        Me.tpEventEditor.Location = New System.Drawing.Point(4, 22)
        Me.tpEventEditor.Name = "tpEventEditor"
        Me.tpEventEditor.Size = New System.Drawing.Size(936, 653)
        Me.tpEventEditor.TabIndex = 4
        Me.tpEventEditor.Text = "Event Editor"
        '
        'tlpEventEditor
        '
        Me.tlpEventEditor.ColumnCount = 7
        Me.tlpEventEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpEventEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpEventEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpEventEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEventEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.tlpEventEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209.0!))
        Me.tlpEventEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.tlpEventEditor.Controls.Add(Me.EE_lblEvents, 0, 1)
        Me.tlpEventEditor.Controls.Add(Me.EE_lbEvents, 0, 2)
        Me.tlpEventEditor.Controls.Add(Me.EE_lblAlarmCodeDisplay, 2, 2)
        Me.tlpEventEditor.Controls.Add(Me.EE_lblDesription, 2, 3)
        Me.tlpEventEditor.Controls.Add(Me.EE_rtbDescription, 3, 3)
        Me.tlpEventEditor.Controls.Add(Me.EE_rtbSolution, 3, 4)
        Me.tlpEventEditor.Controls.Add(Me.EE_lblSolution, 2, 4)
        Me.tlpEventEditor.Controls.Add(Me.EE_tbPriority, 5, 2)
        Me.tlpEventEditor.Controls.Add(Me.Label10, 4, 2)
        Me.tlpEventEditor.Controls.Add(Me.EE_btnNew, 0, 5)
        Me.tlpEventEditor.Controls.Add(Me.EE_btnDelete, 1, 5)
        Me.tlpEventEditor.Controls.Add(Me.EE_btnSave, 4, 5)
        Me.tlpEventEditor.Controls.Add(Me.EE_btnClear, 5, 5)
        Me.tlpEventEditor.Controls.Add(Me.EE_tbAlarmCode, 3, 2)
        Me.tlpEventEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEventEditor.Location = New System.Drawing.Point(0, 0)
        Me.tlpEventEditor.Name = "tlpEventEditor"
        Me.tlpEventEditor.RowCount = 7
        Me.tlpEventEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEventEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEventEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpEventEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.tlpEventEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEventEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEventEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEventEditor.Size = New System.Drawing.Size(936, 653)
        Me.tlpEventEditor.TabIndex = 0
        '
        'EE_lblEvents
        '
        Me.EE_lblEvents.AutoSize = True
        Me.EE_lblEvents.Location = New System.Drawing.Point(3, 20)
        Me.EE_lblEvents.Name = "EE_lblEvents"
        Me.EE_lblEvents.Size = New System.Drawing.Size(40, 13)
        Me.EE_lblEvents.TabIndex = 0
        Me.EE_lblEvents.Text = "Events"
        '
        'EE_lbEvents
        '
        Me.EE_lbEvents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpEventEditor.SetColumnSpan(Me.EE_lbEvents, 2)
        Me.EE_lbEvents.FormattingEnabled = True
        Me.EE_lbEvents.Location = New System.Drawing.Point(3, 43)
        Me.EE_lbEvents.Name = "EE_lbEvents"
        Me.tlpEventEditor.SetRowSpan(Me.EE_lbEvents, 3)
        Me.EE_lbEvents.Size = New System.Drawing.Size(156, 407)
        Me.EE_lbEvents.TabIndex = 3
        '
        'EE_lblAlarmCodeDisplay
        '
        Me.EE_lblAlarmCodeDisplay.AutoSize = True
        Me.EE_lblAlarmCodeDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EE_lblAlarmCodeDisplay.Location = New System.Drawing.Point(165, 40)
        Me.EE_lblAlarmCodeDisplay.Name = "EE_lblAlarmCodeDisplay"
        Me.EE_lblAlarmCodeDisplay.Size = New System.Drawing.Size(64, 24)
        Me.EE_lblAlarmCodeDisplay.TabIndex = 4
        Me.EE_lblAlarmCodeDisplay.Text = "Alarm Code:"
        Me.EE_lblAlarmCodeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EE_lblDesription
        '
        Me.EE_lblDesription.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.EE_lblDesription.AutoSize = True
        Me.EE_lblDesription.Location = New System.Drawing.Point(165, 165)
        Me.EE_lblDesription.Name = "EE_lblDesription"
        Me.EE_lblDesription.Size = New System.Drawing.Size(63, 13)
        Me.EE_lblDesription.TabIndex = 6
        Me.EE_lblDesription.Text = "Description:"
        '
        'EE_rtbDescription
        '
        Me.EE_rtbDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpEventEditor.SetColumnSpan(Me.EE_rtbDescription, 3)
        Me.EE_rtbDescription.Location = New System.Drawing.Point(235, 115)
        Me.EE_rtbDescription.Name = "EE_rtbDescription"
        Me.EE_rtbDescription.Size = New System.Drawing.Size(501, 113)
        Me.EE_rtbDescription.TabIndex = 7
        Me.EE_rtbDescription.Text = ""
        '
        'EE_rtbSolution
        '
        Me.EE_rtbSolution.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpEventEditor.SetColumnSpan(Me.EE_rtbSolution, 3)
        Me.EE_rtbSolution.Location = New System.Drawing.Point(235, 311)
        Me.EE_rtbSolution.Name = "EE_rtbSolution"
        Me.EE_rtbSolution.Size = New System.Drawing.Size(501, 113)
        Me.EE_rtbSolution.TabIndex = 8
        Me.EE_rtbSolution.Text = ""
        '
        'EE_lblSolution
        '
        Me.EE_lblSolution.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.EE_lblSolution.AutoSize = True
        Me.EE_lblSolution.Location = New System.Drawing.Point(165, 361)
        Me.EE_lblSolution.Name = "EE_lblSolution"
        Me.EE_lblSolution.Size = New System.Drawing.Size(45, 13)
        Me.EE_lblSolution.TabIndex = 9
        Me.EE_lblSolution.Text = "Solution"
        '
        'EE_tbPriority
        '
        Me.EE_tbPriority.Location = New System.Drawing.Point(533, 43)
        Me.EE_tbPriority.Name = "EE_tbPriority"
        Me.EE_tbPriority.Size = New System.Drawing.Size(100, 20)
        Me.EE_tbPriority.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(426, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 24)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Priority:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EE_btnNew
        '
        Me.EE_btnNew.Location = New System.Drawing.Point(3, 459)
        Me.EE_btnNew.Name = "EE_btnNew"
        Me.EE_btnNew.Size = New System.Drawing.Size(75, 23)
        Me.EE_btnNew.TabIndex = 12
        Me.EE_btnNew.Text = "New"
        Me.EE_btnNew.UseVisualStyleBackColor = True
        '
        'EE_btnDelete
        '
        Me.EE_btnDelete.Location = New System.Drawing.Point(84, 459)
        Me.EE_btnDelete.Name = "EE_btnDelete"
        Me.EE_btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.EE_btnDelete.TabIndex = 13
        Me.EE_btnDelete.Text = "Delete"
        Me.EE_btnDelete.UseVisualStyleBackColor = True
        '
        'EE_btnSave
        '
        Me.EE_btnSave.Location = New System.Drawing.Point(426, 459)
        Me.EE_btnSave.Name = "EE_btnSave"
        Me.EE_btnSave.Size = New System.Drawing.Size(75, 23)
        Me.EE_btnSave.TabIndex = 14
        Me.EE_btnSave.Text = "Save"
        Me.EE_btnSave.UseVisualStyleBackColor = True
        '
        'EE_btnClear
        '
        Me.EE_btnClear.Location = New System.Drawing.Point(533, 459)
        Me.EE_btnClear.Name = "EE_btnClear"
        Me.EE_btnClear.Size = New System.Drawing.Size(75, 23)
        Me.EE_btnClear.TabIndex = 15
        Me.EE_btnClear.Text = "Clear"
        Me.EE_btnClear.UseVisualStyleBackColor = True
        '
        'EE_tbAlarmCode
        '
        Me.EE_tbAlarmCode.Location = New System.Drawing.Point(235, 43)
        Me.EE_tbAlarmCode.Name = "EE_tbAlarmCode"
        Me.EE_tbAlarmCode.Size = New System.Drawing.Size(104, 20)
        Me.EE_tbAlarmCode.TabIndex = 16
        '
        'tpStateManager
        '
        Me.tpStateManager.BackColor = System.Drawing.SystemColors.Control
        Me.tpStateManager.Controls.Add(Me.TableLayoutPanel4)
        Me.tpStateManager.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tpStateManager.Location = New System.Drawing.Point(4, 22)
        Me.tpStateManager.Name = "tpStateManager"
        Me.tpStateManager.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStateManager.Size = New System.Drawing.Size(936, 653)
        Me.tpStateManager.TabIndex = 5
        Me.tpStateManager.Text = "State Manager"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88673!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.11327!))
        Me.TableLayoutPanel4.Controls.Add(Me.ListView1, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.190476!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.80952!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(927, 644)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(3, 24)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(131, 402)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'mainStrip
        '
        Me.mainStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.mainStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainStrip.Name = "mainStrip"
        Me.mainStrip.Size = New System.Drawing.Size(978, 24)
        Me.mainStrip.TabIndex = 1
        Me.mainStrip.Text = "MenuStrip1"
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
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseSetupToolStripMenuItem, Me.SQLServerConfigurationToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'DatabaseSetupToolStripMenuItem
        '
        Me.DatabaseSetupToolStripMenuItem.Name = "DatabaseSetupToolStripMenuItem"
        Me.DatabaseSetupToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DatabaseSetupToolStripMenuItem.Text = "Database Setup"
        '
        'SQLServerConfigurationToolStripMenuItem
        '
        Me.SQLServerConfigurationToolStripMenuItem.Name = "SQLServerConfigurationToolStripMenuItem"
        Me.SQLServerConfigurationToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SQLServerConfigurationToolStripMenuItem.Text = "SQL Server Configuration"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLbl_Status})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 719)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(978, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'tssLbl_Status
        '
        Me.tssLbl_Status.Name = "tssLbl_Status"
        Me.tssLbl_Status.Size = New System.Drawing.Size(0, 17)
        '
        'RE_tmrProgramLoad
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 741)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.mainStrip)
        Me.Controls.Add(Me.tpvConfigurator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mainStrip
        Me.Name = "frmMain"
        Me.Text = "Configurator"
        Me.tpvConfigurator.ResumeLayout(False)
        Me.tpDeviceType.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gbAlarmSettings.ResumeLayout(False)
        Me.gbAlarmSettings.PerformLayout()
        Me.AE_gbSignalType.ResumeLayout(False)
        Me.AE_gbSignalType.PerformLayout()
        Me.AE_gbAlarmType.ResumeLayout(False)
        Me.AE_gbAlarmType.PerformLayout()
        Me.tpRoomType.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tvMenuStrip.ResumeLayout(False)
        Me.tpRoomLoader.ResumeLayout(False)
        Me.RL_Flags.ResumeLayout(False)
        Me.RL_Flags.PerformLayout()
        Me.tpRoomEditor.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.gbRoomDetails.ResumeLayout(False)
        Me.gbRoomDetails.PerformLayout()
        Me.RE_tcRoomViewer.ResumeLayout(False)
        Me.RE_tbByFloor.ResumeLayout(False)
        Me.RE_cmsTV.ResumeLayout(False)
        Me.RE_tbByType.ResumeLayout(False)
        Me.tpEventEditor.ResumeLayout(False)
        Me.tlpEventEditor.ResumeLayout(False)
        Me.tlpEventEditor.PerformLayout()
        Me.tpStateManager.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.mainStrip.ResumeLayout(False)
        Me.mainStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tpvConfigurator As System.Windows.Forms.TabControl
    Friend WithEvents tpRoomType As System.Windows.Forms.TabPage
    Friend WithEvents tpRoomLoader As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RTE_btnBrowseProgram As System.Windows.Forms.Button
    Friend WithEvents RTE_tbProgramName As System.Windows.Forms.TextBox
    Friend WithEvents RTE_lblDefaultProgram As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RTE_lbDeviceTypesAvailable As System.Windows.Forms.ListBox
    Friend WithEvents RTE_tvDevicesAdded As System.Windows.Forms.TreeView
    Friend WithEvents RTE_btnAllDeviceAdd As System.Windows.Forms.Button
    Friend WithEvents RTE_lblDevicesAdded As System.Windows.Forms.Label
    Friend WithEvents RTE_btnDeviceAdd As System.Windows.Forms.Button
    Friend WithEvents RTE_lblDevicesAvailable As System.Windows.Forms.Label
    Friend WithEvents RTE_btnAllDeviceRemove As System.Windows.Forms.Button
    Friend WithEvents RTE_btnDeviceRemove As System.Windows.Forms.Button
    Friend WithEvents RTE_btnDelete As System.Windows.Forms.Button
    Friend WithEvents RTE_lblRoomTypes As System.Windows.Forms.Label
    Friend WithEvents RTE_btnClear As System.Windows.Forms.Button
    Friend WithEvents RTE_btnSave As System.Windows.Forms.Button
    Friend WithEvents RTE_btnNew As System.Windows.Forms.Button
    Friend WithEvents RTE_lbRoomTypes As System.Windows.Forms.ListBox
    Friend WithEvents RL_cbLoadDefaultProgram As System.Windows.Forms.CheckBox
    Friend WithEvents RL_btnLoad As System.Windows.Forms.Button
    Friend WithEvents RL_lsvRooms As System.Windows.Forms.ListView
    Friend WithEvents colIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRoom As System.Windows.Forms.ColumnHeader
    Friend WithEvents colType As System.Windows.Forms.ColumnHeader
    Friend WithEvents RL_btnBrowseExcel As System.Windows.Forms.Button
    Friend WithEvents openProgram As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mainStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tvMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiAddItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tpDeviceType As System.Windows.Forms.TabPage
    Friend WithEvents tsmiDeleteItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AE_lblName As System.Windows.Forms.Label
    Friend WithEvents AE_btnClear As System.Windows.Forms.Button
    Friend WithEvents AE_btnSave As System.Windows.Forms.Button
    Friend WithEvents AE_lblDevices As System.Windows.Forms.Label
    Friend WithEvents AE_btnNew As System.Windows.Forms.Button
    Friend WithEvents AE_btnDel As System.Windows.Forms.Button
    Friend WithEvents AE_lbDeviceName As System.Windows.Forms.Label
    Friend WithEvents RL_cbLoadProcessorSettings As System.Windows.Forms.CheckBox
    Friend WithEvents RL_cbLoadDevicesPerRoom As System.Windows.Forms.CheckBox
    Friend WithEvents tpRoomEditor As System.Windows.Forms.TabPage
    Friend WithEvents RL_Flags As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AE_lbDevices As System.Windows.Forms.ListBox
    Friend WithEvents gbAlarmSettings As System.Windows.Forms.GroupBox
    Friend WithEvents AE_gbSignalType As System.Windows.Forms.GroupBox
    Friend WithEvents AE_rbString As System.Windows.Forms.RadioButton
    Friend WithEvents AE_rbAnalog As System.Windows.Forms.RadioButton
    Friend WithEvents AE_rbBinary As System.Windows.Forms.RadioButton
    Friend WithEvents lblTimeFrame As System.Windows.Forms.Label
    Friend WithEvents AE_cbEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents AE_tbThreshold As System.Windows.Forms.TextBox
    Friend WithEvents AE_gbAlarmType As System.Windows.Forms.GroupBox
    Friend WithEvents AE_rbEnhanced As System.Windows.Forms.RadioButton
    Friend WithEvents AE_rbBasic As System.Windows.Forms.RadioButton
    Friend WithEvents AE_tbTimeFrame As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RE_tvRoomsByFloor As System.Windows.Forms.TreeView
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tssLbl_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tpEventEditor As System.Windows.Forms.TabPage
    Friend WithEvents tlpEventEditor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EE_lblEvents As System.Windows.Forms.Label
    Friend WithEvents EE_lbEvents As System.Windows.Forms.ListBox
    Friend WithEvents EE_lblAlarmCodeDisplay As System.Windows.Forms.Label
    Friend WithEvents EE_lblDesription As System.Windows.Forms.Label
    Friend WithEvents EE_rtbDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents EE_rtbSolution As System.Windows.Forms.RichTextBox
    Friend WithEvents EE_lblSolution As System.Windows.Forms.Label
    Friend WithEvents EE_tbPriority As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents EE_btnNew As System.Windows.Forms.Button
    Friend WithEvents EE_btnDelete As System.Windows.Forms.Button
    Friend WithEvents EE_btnSave As System.Windows.Forms.Button
    Friend WithEvents EE_btnClear As System.Windows.Forms.Button
    Friend WithEvents gbRoomDetails As System.Windows.Forms.GroupBox
    Friend WithEvents RE_tbBuilding As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblBuilding As System.Windows.Forms.Label
    Friend WithEvents RE_tbRoomType As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblRoomType As System.Windows.Forms.Label
    Friend WithEvents RE_tbRoomName As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblRoomName As System.Windows.Forms.Label
    Friend WithEvents RE_tbIpAddress As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblIpAddress As System.Windows.Forms.Label
    Friend WithEvents RE_tbMAC As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblMAC As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AE_tbWarningTimeFrame As System.Windows.Forms.TextBox
    Friend WithEvents AE_tbWarningThreshold As System.Windows.Forms.TextBox
    Friend WithEvents AE_lblWarningTimeFrame As System.Windows.Forms.Label
    Friend WithEvents AE_lblWarningThreshold As System.Windows.Forms.Label
    Friend WithEvents AE_cbWarning As System.Windows.Forms.CheckBox
    Friend WithEvents AE_lblWarningCode As System.Windows.Forms.Label
    Friend WithEvents AE_combWarningAlarms As System.Windows.Forms.ComboBox
    Friend WithEvents EE_tbAlarmCode As System.Windows.Forms.TextBox
    Friend WithEvents RE_tcRoomViewer As System.Windows.Forms.TabControl
    Friend WithEvents RE_tbByFloor As System.Windows.Forms.TabPage
    Friend WithEvents RE_tbByType As System.Windows.Forms.TabPage
    Friend WithEvents RE_tvRoomsByType As System.Windows.Forms.TreeView
    Friend WithEvents colBuilding As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFloor As System.Windows.Forms.ColumnHeader
    Friend WithEvents RE_cmsTV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LoadProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDefaultProgramByRoomTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadOtherProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RE_tbFloor As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblFloor As System.Windows.Forms.Label
    Friend WithEvents RE_tmrProgramLoad As System.Windows.Forms.Timer
    Friend WithEvents RemotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RE_tbSTBip As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblSTBAddress As System.Windows.Forms.Label
    Friend WithEvents LoadNewRemoteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDefaultRemoteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RE_btnSendProgram As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RE_btnNew As System.Windows.Forms.Button
    Friend WithEvents RE_btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tpStateManager As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents SQLServerConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
