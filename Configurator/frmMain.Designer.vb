﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TSTAT_20")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TSTAT", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG_01")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG_02")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG_03")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG_04")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG_05")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG_06")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG_07")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG_08")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG_08")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LG", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TV_01")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TV", New System.Windows.Forms.TreeNode() {TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SHADES")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tvMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiAddItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDeleteItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RTE_cmsTV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoadProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDefaultProgramByRoomTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadOtherProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadNewRemoteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDefaultRemoteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openProgram = New System.Windows.Forms.OpenFileDialog()
        Me.mainStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLServerConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoyaltyProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tssLbl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RE_tmrProgramLoad = New System.Windows.Forms.Timer(Me.components)
        Me.tpStateManager = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SM_tbStateName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SM_lblAnalogZero = New System.Windows.Forms.Label()
        Me.SM_lblAnalogHundred = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SM_rbSunTrackOn = New System.Windows.Forms.RadioButton()
        Me.SM_rbSunTrackOff = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SM_cbDevices = New System.Windows.Forms.ComboBox()
        Me.SM_btnNew = New System.Windows.Forms.Button()
        Me.SM_btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.SM_cbLoyaltyProgram = New System.Windows.Forms.CheckBox()
        Me.SM_gbSchedule = New System.Windows.Forms.GroupBox()
        Me.SM_lblMinutesStop = New System.Windows.Forms.Label()
        Me.SM_rbPMStop = New System.Windows.Forms.RadioButton()
        Me.SM_lblMinutesStart = New System.Windows.Forms.Label()
        Me.SM_rbPMStart = New System.Windows.Forms.RadioButton()
        Me.SM_lblHoursStop = New System.Windows.Forms.Label()
        Me.SM_lblStop = New System.Windows.Forms.Label()
        Me.SM_lblHoursStart = New System.Windows.Forms.Label()
        Me.SM_lblStart = New System.Windows.Forms.Label()
        Me.SM_rbAMStop = New System.Windows.Forms.RadioButton()
        Me.SM_rbAMStart = New System.Windows.Forms.RadioButton()
        Me.SM_udMinutesStop = New System.Windows.Forms.NumericUpDown()
        Me.SM_udHoursStop = New System.Windows.Forms.NumericUpDown()
        Me.SM_udMinutesStart = New System.Windows.Forms.NumericUpDown()
        Me.SM_udHoursStart = New System.Windows.Forms.NumericUpDown()
        Me.SM_dtpStop = New System.Windows.Forms.DateTimePicker()
        Me.SM_dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.SM_cbTriggers = New System.Windows.Forms.ComboBox()
        Me.SM_lbStates = New System.Windows.Forms.ListBox()
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
        Me.tpRoomEditor = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RE_gbRoomDetails = New System.Windows.Forms.GroupBox()
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
        Me.RE_tbByType = New System.Windows.Forms.TabPage()
        Me.RE_tvRoomsByType = New System.Windows.Forms.TreeView()
        Me.RE_btnNew = New System.Windows.Forms.Button()
        Me.RE_btnDelete = New System.Windows.Forms.Button()
        Me.RE_gbRoomStatus = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RE_rbUnoccupied = New System.Windows.Forms.RadioButton()
        Me.RE_rbOccupied = New System.Windows.Forms.RadioButton()
        Me.RE_cbRoomState = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RE_gbRoomSettings = New System.Windows.Forms.GroupBox()
        Me.RE_btnResendFirmware = New System.Windows.Forms.Button()
        Me.RE_btnBrowseFirmware = New System.Windows.Forms.Button()
        Me.RE_btnResendProgram = New System.Windows.Forms.Button()
        Me.RE_btnBrowseProgram = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RE_lblFirmwareLoaded = New System.Windows.Forms.Label()
        Me.RE_lblProgramLoaded = New System.Windows.Forms.Label()
        Me.RE_btnSave = New System.Windows.Forms.Button()
        Me.RE_gbDevices = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RE_tvDevices = New System.Windows.Forms.TreeView()
        Me.RE_cmsTVDevices = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReplaceDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpRoomType = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.RTE_gbProgramInfo = New System.Windows.Forms.GroupBox()
        Me.RTE_btnBrowseProgram = New System.Windows.Forms.Button()
        Me.RTE_tbProgramName = New System.Windows.Forms.TextBox()
        Me.RTE_lblDefaultProgram = New System.Windows.Forms.Label()
        Me.RTE_gbDevices = New System.Windows.Forms.GroupBox()
        Me.RTE_lbDeviceTypesAvailable = New System.Windows.Forms.ListBox()
        Me.RTE_tvDevicesAdded = New System.Windows.Forms.TreeView()
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
        Me.RTE_gbDefaultState = New System.Windows.Forms.GroupBox()
        Me.RTE_rbStateDisabled = New System.Windows.Forms.RadioButton()
        Me.RTE_rbStateEnabled = New System.Windows.Forms.RadioButton()
        Me.RTE_cbDefaultState = New System.Windows.Forms.ComboBox()
        Me.tpDeviceType = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AE_lbDevices = New System.Windows.Forms.ListBox()
        Me.AE_lblDevices = New System.Windows.Forms.Label()
        Me.AE_btnNew = New System.Windows.Forms.Button()
        Me.AE_btnDel = New System.Windows.Forms.Button()
        Me.AE_btnClear = New System.Windows.Forms.Button()
        Me.AE_btnSave = New System.Windows.Forms.Button()
        Me.AE_lblName = New System.Windows.Forms.Label()
        Me.AE_lbDeviceName = New System.Windows.Forms.Label()
        Me.gbAlarmSettings = New System.Windows.Forms.GroupBox()
        Me.AE_cbErrorAlarmCode = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.tpvConfigurator = New System.Windows.Forms.TabControl()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tvMenuStrip.SuspendLayout()
        Me.RTE_cmsTV.SuspendLayout()
        Me.mainStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.tpStateManager.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SM_gbSchedule.SuspendLayout()
        CType(Me.SM_udMinutesStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SM_udHoursStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SM_udMinutesStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SM_udHoursStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEventEditor.SuspendLayout()
        Me.tlpEventEditor.SuspendLayout()
        Me.tpRoomEditor.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.RE_gbRoomDetails.SuspendLayout()
        Me.RE_tcRoomViewer.SuspendLayout()
        Me.RE_tbByFloor.SuspendLayout()
        Me.RE_tbByType.SuspendLayout()
        Me.RE_gbRoomStatus.SuspendLayout()
        Me.RE_gbRoomSettings.SuspendLayout()
        Me.RE_gbDevices.SuspendLayout()
        Me.RE_cmsTVDevices.SuspendLayout()
        Me.tpRoomType.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.RTE_gbProgramInfo.SuspendLayout()
        Me.RTE_gbDevices.SuspendLayout()
        Me.RTE_gbDefaultState.SuspendLayout()
        Me.tpDeviceType.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbAlarmSettings.SuspendLayout()
        Me.AE_gbSignalType.SuspendLayout()
        Me.AE_gbAlarmType.SuspendLayout()
        Me.tpvConfigurator.SuspendLayout()
        Me.SuspendLayout()
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
        'RTE_cmsTV
        '
        Me.RTE_cmsTV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadProgramsToolStripMenuItem, Me.RemotesToolStripMenuItem})
        Me.RTE_cmsTV.Name = "RE_cmsTV"
        Me.RTE_cmsTV.Size = New System.Drawing.Size(163, 48)
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
        'mainStrip
        '
        Me.mainStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.mainStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainStrip.Name = "mainStrip"
        Me.mainStrip.Size = New System.Drawing.Size(1350, 24)
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
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseSetupToolStripMenuItem, Me.SQLServerConfigurationToolStripMenuItem, Me.LoyaltyProgramToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'DatabaseSetupToolStripMenuItem
        '
        Me.DatabaseSetupToolStripMenuItem.Name = "DatabaseSetupToolStripMenuItem"
        Me.DatabaseSetupToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DatabaseSetupToolStripMenuItem.Text = "Database Setup"
        '
        'SQLServerConfigurationToolStripMenuItem
        '
        Me.SQLServerConfigurationToolStripMenuItem.Name = "SQLServerConfigurationToolStripMenuItem"
        Me.SQLServerConfigurationToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SQLServerConfigurationToolStripMenuItem.Text = "SQL Server Settings"
        '
        'LoyaltyProgramToolStripMenuItem
        '
        Me.LoyaltyProgramToolStripMenuItem.Name = "LoyaltyProgramToolStripMenuItem"
        Me.LoyaltyProgramToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LoyaltyProgramToolStripMenuItem.Text = "Loyalty Program"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLbl_Status})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 708)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1350, 22)
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
        'tpStateManager
        '
        Me.tpStateManager.BackColor = System.Drawing.SystemColors.Control
        Me.tpStateManager.Controls.Add(Me.TableLayoutPanel4)
        Me.tpStateManager.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tpStateManager.Location = New System.Drawing.Point(4, 22)
        Me.tpStateManager.Name = "tpStateManager"
        Me.tpStateManager.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStateManager.Size = New System.Drawing.Size(1308, 642)
        Me.tpStateManager.TabIndex = 5
        Me.tpStateManager.Text = "State Manager"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.43478!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.56522!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox5, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox4, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.SM_btnNew, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.SM_btnDelete, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox6, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.SM_lbStates, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.225092!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.77491!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1302, 636)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SM_tbStateName)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Location = New System.Drawing.Point(155, 27)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(341, 129)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "State Properties"
        '
        'SM_tbStateName
        '
        Me.SM_tbStateName.Location = New System.Drawing.Point(78, 27)
        Me.SM_tbStateName.Name = "SM_tbStateName"
        Me.SM_tbStateName.Size = New System.Drawing.Size(134, 20)
        Me.SM_tbStateName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "State Name:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SM_gbTstatControls)
        Me.GroupBox4.Controls.Add(Me.SM_gbTVControls)
        Me.GroupBox4.Controls.Add(Me.SM_gbLights)
        Me.GroupBox4.Controls.Add(Me.SM_tcShades)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.SM_cbDevices)
        Me.GroupBox4.Location = New System.Drawing.Point(527, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(515, 223)
        Me.GroupBox4.TabIndex = 2
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
        Me.SM_tpSetting2.Controls.Add(Me.Label2)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Shade Percent"
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
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.SM_rbSunTrackOn)
        Me.TabPage1.Controls.Add(Me.SM_rbSunTrackOff)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(161, 175)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Setting 3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Sun Tracking"
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
        'SM_btnNew
        '
        Me.SM_btnNew.Location = New System.Drawing.Point(3, 456)
        Me.SM_btnNew.Name = "SM_btnNew"
        Me.SM_btnNew.Size = New System.Drawing.Size(67, 23)
        Me.SM_btnNew.TabIndex = 5
        Me.SM_btnNew.Text = "New"
        Me.SM_btnNew.UseVisualStyleBackColor = True
        '
        'SM_btnDelete
        '
        Me.SM_btnDelete.Location = New System.Drawing.Point(79, 456)
        Me.SM_btnDelete.Name = "SM_btnDelete"
        Me.SM_btnDelete.Size = New System.Drawing.Size(67, 23)
        Me.SM_btnDelete.TabIndex = 6
        Me.SM_btnDelete.Text = "Delete"
        Me.SM_btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.GroupBox6, 2)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.SM_gbSchedule)
        Me.GroupBox6.Controls.Add(Me.SM_cbTriggers)
        Me.GroupBox6.Location = New System.Drawing.Point(155, 266)
        Me.GroupBox6.Name = "GroupBox6"
        Me.TableLayoutPanel4.SetRowSpan(Me.GroupBox6, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(766, 298)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Triggers"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.SM_cbLoyaltyProgram)
        Me.GroupBox7.Location = New System.Drawing.Point(185, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(183, 60)
        Me.GroupBox7.TabIndex = 25
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Settings"
        '
        'SM_cbLoyaltyProgram
        '
        Me.SM_cbLoyaltyProgram.AutoSize = True
        Me.SM_cbLoyaltyProgram.Location = New System.Drawing.Point(20, 25)
        Me.SM_cbLoyaltyProgram.Name = "SM_cbLoyaltyProgram"
        Me.SM_cbLoyaltyProgram.Size = New System.Drawing.Size(123, 17)
        Me.SM_cbLoyaltyProgram.TabIndex = 0
        Me.SM_cbLoyaltyProgram.Text = "Use Loyalty Program"
        Me.SM_cbLoyaltyProgram.UseVisualStyleBackColor = True
        '
        'SM_gbSchedule
        '
        Me.SM_gbSchedule.Controls.Add(Me.SM_lblMinutesStop)
        Me.SM_gbSchedule.Controls.Add(Me.SM_rbPMStop)
        Me.SM_gbSchedule.Controls.Add(Me.SM_lblMinutesStart)
        Me.SM_gbSchedule.Controls.Add(Me.SM_rbPMStart)
        Me.SM_gbSchedule.Controls.Add(Me.SM_lblHoursStop)
        Me.SM_gbSchedule.Controls.Add(Me.SM_lblStop)
        Me.SM_gbSchedule.Controls.Add(Me.SM_lblHoursStart)
        Me.SM_gbSchedule.Controls.Add(Me.SM_lblStart)
        Me.SM_gbSchedule.Controls.Add(Me.SM_rbAMStop)
        Me.SM_gbSchedule.Controls.Add(Me.SM_rbAMStart)
        Me.SM_gbSchedule.Controls.Add(Me.SM_udMinutesStop)
        Me.SM_gbSchedule.Controls.Add(Me.SM_udHoursStop)
        Me.SM_gbSchedule.Controls.Add(Me.SM_udMinutesStart)
        Me.SM_gbSchedule.Controls.Add(Me.SM_udHoursStart)
        Me.SM_gbSchedule.Controls.Add(Me.SM_dtpStop)
        Me.SM_gbSchedule.Controls.Add(Me.SM_dtpStart)
        Me.SM_gbSchedule.Location = New System.Drawing.Point(13, 96)
        Me.SM_gbSchedule.Name = "SM_gbSchedule"
        Me.SM_gbSchedule.Size = New System.Drawing.Size(585, 164)
        Me.SM_gbSchedule.TabIndex = 24
        Me.SM_gbSchedule.TabStop = False
        Me.SM_gbSchedule.Text = "Scheduler"
        '
        'SM_lblMinutesStop
        '
        Me.SM_lblMinutesStop.AutoSize = True
        Me.SM_lblMinutesStop.Location = New System.Drawing.Point(374, 88)
        Me.SM_lblMinutesStop.Name = "SM_lblMinutesStop"
        Me.SM_lblMinutesStop.Size = New System.Drawing.Size(47, 13)
        Me.SM_lblMinutesStop.TabIndex = 23
        Me.SM_lblMinutesStop.Text = "Minutes:"
        '
        'SM_rbPMStop
        '
        Me.SM_rbPMStop.AutoSize = True
        Me.SM_rbPMStop.Location = New System.Drawing.Point(533, 87)
        Me.SM_rbPMStop.Name = "SM_rbPMStop"
        Me.SM_rbPMStop.Size = New System.Drawing.Size(41, 17)
        Me.SM_rbPMStop.TabIndex = 19
        Me.SM_rbPMStop.TabStop = True
        Me.SM_rbPMStop.Text = "PM"
        Me.SM_rbPMStop.UseVisualStyleBackColor = True
        '
        'SM_lblMinutesStart
        '
        Me.SM_lblMinutesStart.AutoSize = True
        Me.SM_lblMinutesStart.Location = New System.Drawing.Point(374, 38)
        Me.SM_lblMinutesStart.Name = "SM_lblMinutesStart"
        Me.SM_lblMinutesStart.Size = New System.Drawing.Size(47, 13)
        Me.SM_lblMinutesStart.TabIndex = 22
        Me.SM_lblMinutesStart.Text = "Minutes:"
        '
        'SM_rbPMStart
        '
        Me.SM_rbPMStart.AutoSize = True
        Me.SM_rbPMStart.Location = New System.Drawing.Point(533, 37)
        Me.SM_rbPMStart.Name = "SM_rbPMStart"
        Me.SM_rbPMStart.Size = New System.Drawing.Size(41, 17)
        Me.SM_rbPMStart.TabIndex = 17
        Me.SM_rbPMStart.TabStop = True
        Me.SM_rbPMStart.Text = "PM"
        Me.SM_rbPMStart.UseVisualStyleBackColor = True
        '
        'SM_lblHoursStop
        '
        Me.SM_lblHoursStop.AutoSize = True
        Me.SM_lblHoursStop.Location = New System.Drawing.Point(285, 88)
        Me.SM_lblHoursStop.Name = "SM_lblHoursStop"
        Me.SM_lblHoursStop.Size = New System.Drawing.Size(38, 13)
        Me.SM_lblHoursStop.TabIndex = 21
        Me.SM_lblHoursStop.Text = "Hours:"
        '
        'SM_lblStop
        '
        Me.SM_lblStop.AutoSize = True
        Me.SM_lblStop.Location = New System.Drawing.Point(23, 87)
        Me.SM_lblStop.Name = "SM_lblStop"
        Me.SM_lblStop.Size = New System.Drawing.Size(29, 13)
        Me.SM_lblStop.TabIndex = 8
        Me.SM_lblStop.Text = "Stop"
        '
        'SM_lblHoursStart
        '
        Me.SM_lblHoursStart.AutoSize = True
        Me.SM_lblHoursStart.Location = New System.Drawing.Point(285, 38)
        Me.SM_lblHoursStart.Name = "SM_lblHoursStart"
        Me.SM_lblHoursStart.Size = New System.Drawing.Size(38, 13)
        Me.SM_lblHoursStart.TabIndex = 20
        Me.SM_lblHoursStart.Text = "Hours:"
        '
        'SM_lblStart
        '
        Me.SM_lblStart.AutoSize = True
        Me.SM_lblStart.Location = New System.Drawing.Point(23, 40)
        Me.SM_lblStart.Name = "SM_lblStart"
        Me.SM_lblStart.Size = New System.Drawing.Size(29, 13)
        Me.SM_lblStart.TabIndex = 7
        Me.SM_lblStart.Text = "Start"
        '
        'SM_rbAMStop
        '
        Me.SM_rbAMStop.AutoSize = True
        Me.SM_rbAMStop.Location = New System.Drawing.Point(486, 87)
        Me.SM_rbAMStop.Name = "SM_rbAMStop"
        Me.SM_rbAMStop.Size = New System.Drawing.Size(41, 17)
        Me.SM_rbAMStop.TabIndex = 18
        Me.SM_rbAMStop.TabStop = True
        Me.SM_rbAMStop.Text = "AM"
        Me.SM_rbAMStop.UseVisualStyleBackColor = True
        '
        'SM_rbAMStart
        '
        Me.SM_rbAMStart.AutoSize = True
        Me.SM_rbAMStart.Location = New System.Drawing.Point(486, 36)
        Me.SM_rbAMStart.Name = "SM_rbAMStart"
        Me.SM_rbAMStart.Size = New System.Drawing.Size(41, 17)
        Me.SM_rbAMStart.TabIndex = 16
        Me.SM_rbAMStart.TabStop = True
        Me.SM_rbAMStart.Text = "AM"
        Me.SM_rbAMStart.UseVisualStyleBackColor = True
        '
        'SM_udMinutesStop
        '
        Me.SM_udMinutesStop.Location = New System.Drawing.Point(427, 85)
        Me.SM_udMinutesStop.Name = "SM_udMinutesStop"
        Me.SM_udMinutesStop.Size = New System.Drawing.Size(39, 20)
        Me.SM_udMinutesStop.TabIndex = 15
        '
        'SM_udHoursStop
        '
        Me.SM_udHoursStop.Location = New System.Drawing.Point(329, 85)
        Me.SM_udHoursStop.Name = "SM_udHoursStop"
        Me.SM_udHoursStop.Size = New System.Drawing.Size(39, 20)
        Me.SM_udHoursStop.TabIndex = 14
        '
        'SM_udMinutesStart
        '
        Me.SM_udMinutesStart.Location = New System.Drawing.Point(427, 36)
        Me.SM_udMinutesStart.Name = "SM_udMinutesStart"
        Me.SM_udMinutesStart.Size = New System.Drawing.Size(39, 20)
        Me.SM_udMinutesStart.TabIndex = 13
        '
        'SM_udHoursStart
        '
        Me.SM_udHoursStart.Location = New System.Drawing.Point(329, 36)
        Me.SM_udHoursStart.Name = "SM_udHoursStart"
        Me.SM_udHoursStart.Size = New System.Drawing.Size(39, 20)
        Me.SM_udHoursStart.TabIndex = 12
        '
        'SM_dtpStop
        '
        Me.SM_dtpStop.Location = New System.Drawing.Point(63, 84)
        Me.SM_dtpStop.Name = "SM_dtpStop"
        Me.SM_dtpStop.Size = New System.Drawing.Size(200, 20)
        Me.SM_dtpStop.TabIndex = 11
        '
        'SM_dtpStart
        '
        Me.SM_dtpStart.Location = New System.Drawing.Point(63, 37)
        Me.SM_dtpStart.Name = "SM_dtpStart"
        Me.SM_dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.SM_dtpStart.TabIndex = 10
        '
        'SM_cbTriggers
        '
        Me.SM_cbTriggers.FormattingEnabled = True
        Me.SM_cbTriggers.Items.AddRange(New Object() {"Scheduled", "Check-In", "Check-Out", "Check-Out Clean", "Command", "User-Defined"})
        Me.SM_cbTriggers.Location = New System.Drawing.Point(9, 40)
        Me.SM_cbTriggers.Name = "SM_cbTriggers"
        Me.SM_cbTriggers.Size = New System.Drawing.Size(121, 21)
        Me.SM_cbTriggers.TabIndex = 5
        '
        'SM_lbStates
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.SM_lbStates, 2)
        Me.SM_lbStates.FormattingEnabled = True
        Me.SM_lbStates.Location = New System.Drawing.Point(3, 27)
        Me.SM_lbStates.Name = "SM_lbStates"
        Me.TableLayoutPanel4.SetRowSpan(Me.SM_lbStates, 2)
        Me.SM_lbStates.Size = New System.Drawing.Size(143, 420)
        Me.SM_lbStates.TabIndex = 8
        '
        'tpEventEditor
        '
        Me.tpEventEditor.BackColor = System.Drawing.SystemColors.Control
        Me.tpEventEditor.Controls.Add(Me.tlpEventEditor)
        Me.tpEventEditor.Location = New System.Drawing.Point(4, 22)
        Me.tpEventEditor.Name = "tpEventEditor"
        Me.tpEventEditor.Size = New System.Drawing.Size(1308, 642)
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
        Me.tlpEventEditor.Size = New System.Drawing.Size(1308, 642)
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
        Me.EE_lbEvents.Size = New System.Drawing.Size(156, 394)
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
        Me.EE_rtbDescription.Size = New System.Drawing.Size(873, 113)
        Me.EE_rtbDescription.TabIndex = 7
        Me.EE_rtbDescription.Text = ""
        '
        'EE_rtbSolution
        '
        Me.EE_rtbSolution.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpEventEditor.SetColumnSpan(Me.EE_rtbSolution, 3)
        Me.EE_rtbSolution.Location = New System.Drawing.Point(235, 309)
        Me.EE_rtbSolution.Name = "EE_rtbSolution"
        Me.EE_rtbSolution.Size = New System.Drawing.Size(873, 113)
        Me.EE_rtbSolution.TabIndex = 8
        Me.EE_rtbSolution.Text = ""
        '
        'EE_lblSolution
        '
        Me.EE_lblSolution.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.EE_lblSolution.AutoSize = True
        Me.EE_lblSolution.Location = New System.Drawing.Point(165, 359)
        Me.EE_lblSolution.Name = "EE_lblSolution"
        Me.EE_lblSolution.Size = New System.Drawing.Size(45, 13)
        Me.EE_lblSolution.TabIndex = 9
        Me.EE_lblSolution.Text = "Solution"
        '
        'EE_tbPriority
        '
        Me.EE_tbPriority.Location = New System.Drawing.Point(905, 43)
        Me.EE_tbPriority.Name = "EE_tbPriority"
        Me.EE_tbPriority.Size = New System.Drawing.Size(100, 20)
        Me.EE_tbPriority.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(798, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 24)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Priority:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EE_btnNew
        '
        Me.EE_btnNew.Location = New System.Drawing.Point(3, 454)
        Me.EE_btnNew.Name = "EE_btnNew"
        Me.EE_btnNew.Size = New System.Drawing.Size(75, 23)
        Me.EE_btnNew.TabIndex = 12
        Me.EE_btnNew.Text = "New"
        Me.EE_btnNew.UseVisualStyleBackColor = True
        '
        'EE_btnDelete
        '
        Me.EE_btnDelete.Location = New System.Drawing.Point(84, 454)
        Me.EE_btnDelete.Name = "EE_btnDelete"
        Me.EE_btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.EE_btnDelete.TabIndex = 13
        Me.EE_btnDelete.Text = "Delete"
        Me.EE_btnDelete.UseVisualStyleBackColor = True
        '
        'EE_btnSave
        '
        Me.EE_btnSave.Location = New System.Drawing.Point(798, 454)
        Me.EE_btnSave.Name = "EE_btnSave"
        Me.EE_btnSave.Size = New System.Drawing.Size(75, 23)
        Me.EE_btnSave.TabIndex = 14
        Me.EE_btnSave.Text = "Save"
        Me.EE_btnSave.UseVisualStyleBackColor = True
        '
        'EE_btnClear
        '
        Me.EE_btnClear.Location = New System.Drawing.Point(905, 454)
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
        'tpRoomEditor
        '
        Me.tpRoomEditor.BackColor = System.Drawing.SystemColors.Control
        Me.tpRoomEditor.Controls.Add(Me.TableLayoutPanel2)
        Me.tpRoomEditor.Location = New System.Drawing.Point(4, 22)
        Me.tpRoomEditor.Name = "tpRoomEditor"
        Me.tpRoomEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRoomEditor.Size = New System.Drawing.Size(1308, 642)
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
        Me.TableLayoutPanel2.Controls.Add(Me.RE_gbRoomDetails, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_tcRoomViewer, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_btnNew, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_btnDelete, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_gbRoomStatus, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_gbRoomSettings, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_btnSave, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RE_gbDevices, 3, 1)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1302, 636)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'RE_gbRoomDetails
        '
        Me.RE_gbRoomDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_tbFloor)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_lblFloor)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_tbMAC)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_lblMAC)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_tbIpAddress)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_lblIpAddress)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_tbBuilding)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_lblBuilding)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_tbRoomType)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_lblRoomType)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_tbRoomName)
        Me.RE_gbRoomDetails.Controls.Add(Me.RE_lblRoomName)
        Me.RE_gbRoomDetails.Location = New System.Drawing.Point(195, 3)
        Me.RE_gbRoomDetails.Name = "RE_gbRoomDetails"
        Me.RE_gbRoomDetails.Size = New System.Drawing.Size(544, 219)
        Me.RE_gbRoomDetails.TabIndex = 2
        Me.RE_gbRoomDetails.TabStop = False
        Me.RE_gbRoomDetails.Text = "Room Details"
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
        Me.RE_tvRoomsByFloor.ContextMenuStrip = Me.RTE_cmsTV
        Me.RE_tvRoomsByFloor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RE_tvRoomsByFloor.Location = New System.Drawing.Point(3, 3)
        Me.RE_tvRoomsByFloor.Name = "RE_tvRoomsByFloor"
        Me.RE_tvRoomsByFloor.Size = New System.Drawing.Size(163, 569)
        Me.RE_tvRoomsByFloor.TabIndex = 0
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
        Me.RE_tvRoomsByType.ContextMenuStrip = Me.RTE_cmsTV
        Me.RE_tvRoomsByType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RE_tvRoomsByType.Location = New System.Drawing.Point(3, 3)
        Me.RE_tvRoomsByType.Name = "RE_tvRoomsByType"
        Me.RE_tvRoomsByType.Size = New System.Drawing.Size(163, 569)
        Me.RE_tvRoomsByType.TabIndex = 6
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
        'RE_gbRoomStatus
        '
        Me.RE_gbRoomStatus.Controls.Add(Me.TextBox3)
        Me.RE_gbRoomStatus.Controls.Add(Me.Label13)
        Me.RE_gbRoomStatus.Controls.Add(Me.RE_rbUnoccupied)
        Me.RE_gbRoomStatus.Controls.Add(Me.RE_rbOccupied)
        Me.RE_gbRoomStatus.Controls.Add(Me.RE_cbRoomState)
        Me.RE_gbRoomStatus.Controls.Add(Me.Label12)
        Me.RE_gbRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RE_gbRoomStatus.Location = New System.Drawing.Point(186, 228)
        Me.RE_gbRoomStatus.Name = "RE_gbRoomStatus"
        Me.RE_gbRoomStatus.Size = New System.Drawing.Size(563, 219)
        Me.RE_gbRoomStatus.TabIndex = 8
        Me.RE_gbRoomStatus.TabStop = False
        Me.RE_gbRoomStatus.Text = "Room Status"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(109, 111)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(107, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Customer ID:"
        '
        'RE_rbUnoccupied
        '
        Me.RE_rbUnoccupied.AutoSize = True
        Me.RE_rbUnoccupied.Checked = True
        Me.RE_rbUnoccupied.Location = New System.Drawing.Point(130, 83)
        Me.RE_rbUnoccupied.Name = "RE_rbUnoccupied"
        Me.RE_rbUnoccupied.Size = New System.Drawing.Size(86, 17)
        Me.RE_rbUnoccupied.TabIndex = 3
        Me.RE_rbUnoccupied.TabStop = True
        Me.RE_rbUnoccupied.Text = "Un-occupied"
        Me.RE_rbUnoccupied.UseVisualStyleBackColor = True
        '
        'RE_rbOccupied
        '
        Me.RE_rbOccupied.AutoSize = True
        Me.RE_rbOccupied.Location = New System.Drawing.Point(46, 83)
        Me.RE_rbOccupied.Name = "RE_rbOccupied"
        Me.RE_rbOccupied.Size = New System.Drawing.Size(71, 17)
        Me.RE_rbOccupied.TabIndex = 2
        Me.RE_rbOccupied.Text = "Occupied"
        Me.RE_rbOccupied.UseVisualStyleBackColor = True
        '
        'RE_cbRoomState
        '
        Me.RE_cbRoomState.FormattingEnabled = True
        Me.RE_cbRoomState.Location = New System.Drawing.Point(95, 28)
        Me.RE_cbRoomState.Name = "RE_cbRoomState"
        Me.RE_cbRoomState.Size = New System.Drawing.Size(121, 21)
        Me.RE_cbRoomState.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Room State:"
        '
        'RE_gbRoomSettings
        '
        Me.RE_gbRoomSettings.Controls.Add(Me.RE_btnResendFirmware)
        Me.RE_gbRoomSettings.Controls.Add(Me.RE_btnBrowseFirmware)
        Me.RE_gbRoomSettings.Controls.Add(Me.RE_btnResendProgram)
        Me.RE_gbRoomSettings.Controls.Add(Me.RE_btnBrowseProgram)
        Me.RE_gbRoomSettings.Controls.Add(Me.TextBox2)
        Me.RE_gbRoomSettings.Controls.Add(Me.TextBox1)
        Me.RE_gbRoomSettings.Controls.Add(Me.RE_lblFirmwareLoaded)
        Me.RE_gbRoomSettings.Controls.Add(Me.RE_lblProgramLoaded)
        Me.RE_gbRoomSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RE_gbRoomSettings.Location = New System.Drawing.Point(755, 3)
        Me.RE_gbRoomSettings.Name = "RE_gbRoomSettings"
        Me.RE_gbRoomSettings.Size = New System.Drawing.Size(544, 219)
        Me.RE_gbRoomSettings.TabIndex = 9
        Me.RE_gbRoomSettings.TabStop = False
        Me.RE_gbRoomSettings.Text = "Room Settings"
        '
        'RE_btnResendFirmware
        '
        Me.RE_btnResendFirmware.Location = New System.Drawing.Point(381, 55)
        Me.RE_btnResendFirmware.Name = "RE_btnResendFirmware"
        Me.RE_btnResendFirmware.Size = New System.Drawing.Size(77, 22)
        Me.RE_btnResendFirmware.TabIndex = 7
        Me.RE_btnResendFirmware.Text = "Resend"
        Me.RE_btnResendFirmware.UseVisualStyleBackColor = True
        '
        'RE_btnBrowseFirmware
        '
        Me.RE_btnBrowseFirmware.Location = New System.Drawing.Point(283, 55)
        Me.RE_btnBrowseFirmware.Name = "RE_btnBrowseFirmware"
        Me.RE_btnBrowseFirmware.Size = New System.Drawing.Size(77, 22)
        Me.RE_btnBrowseFirmware.TabIndex = 6
        Me.RE_btnBrowseFirmware.Text = "Browse.."
        Me.RE_btnBrowseFirmware.UseVisualStyleBackColor = True
        '
        'RE_btnResendProgram
        '
        Me.RE_btnResendProgram.Location = New System.Drawing.Point(381, 31)
        Me.RE_btnResendProgram.Name = "RE_btnResendProgram"
        Me.RE_btnResendProgram.Size = New System.Drawing.Size(77, 22)
        Me.RE_btnResendProgram.TabIndex = 5
        Me.RE_btnResendProgram.Text = "Resend"
        Me.RE_btnResendProgram.UseVisualStyleBackColor = True
        '
        'RE_btnBrowseProgram
        '
        Me.RE_btnBrowseProgram.Location = New System.Drawing.Point(283, 31)
        Me.RE_btnBrowseProgram.Name = "RE_btnBrowseProgram"
        Me.RE_btnBrowseProgram.Size = New System.Drawing.Size(77, 22)
        Me.RE_btnBrowseProgram.TabIndex = 4
        Me.RE_btnBrowseProgram.Text = "Browse.."
        Me.RE_btnBrowseProgram.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(132, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(111, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 20)
        Me.TextBox1.TabIndex = 2
        '
        'RE_lblFirmwareLoaded
        '
        Me.RE_lblFirmwareLoaded.AutoSize = True
        Me.RE_lblFirmwareLoaded.Location = New System.Drawing.Point(17, 60)
        Me.RE_lblFirmwareLoaded.Name = "RE_lblFirmwareLoaded"
        Me.RE_lblFirmwareLoaded.Size = New System.Drawing.Size(91, 13)
        Me.RE_lblFirmwareLoaded.TabIndex = 1
        Me.RE_lblFirmwareLoaded.Text = "Firmware Loaded:"
        '
        'RE_lblProgramLoaded
        '
        Me.RE_lblProgramLoaded.AutoSize = True
        Me.RE_lblProgramLoaded.Location = New System.Drawing.Point(20, 34)
        Me.RE_lblProgramLoaded.Name = "RE_lblProgramLoaded"
        Me.RE_lblProgramLoaded.Size = New System.Drawing.Size(88, 13)
        Me.RE_lblProgramLoaded.TabIndex = 0
        Me.RE_lblProgramLoaded.Text = "Program Loaded:"
        '
        'RE_btnSave
        '
        Me.RE_btnSave.Location = New System.Drawing.Point(755, 581)
        Me.RE_btnSave.Name = "RE_btnSave"
        Me.RE_btnSave.Size = New System.Drawing.Size(69, 23)
        Me.RE_btnSave.TabIndex = 3
        Me.RE_btnSave.Text = "Save"
        Me.RE_btnSave.UseVisualStyleBackColor = True
        '
        'RE_gbDevices
        '
        Me.RE_gbDevices.Controls.Add(Me.Label15)
        Me.RE_gbDevices.Controls.Add(Me.RE_tvDevices)
        Me.RE_gbDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RE_gbDevices.Location = New System.Drawing.Point(755, 228)
        Me.RE_gbDevices.Name = "RE_gbDevices"
        Me.TableLayoutPanel2.SetRowSpan(Me.RE_gbDevices, 2)
        Me.RE_gbDevices.Size = New System.Drawing.Size(544, 347)
        Me.RE_gbDevices.TabIndex = 10
        Me.RE_gbDevices.TabStop = False
        Me.RE_gbDevices.Text = "Devices"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Devices"
        '
        'RE_tvDevices
        '
        Me.RE_tvDevices.ContextMenuStrip = Me.RE_cmsTVDevices
        Me.RE_tvDevices.Location = New System.Drawing.Point(6, 43)
        Me.RE_tvDevices.Name = "RE_tvDevices"
        TreeNode1.Name = "Node4"
        TreeNode1.Text = "TSTAT_20"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "TSTAT"
        TreeNode3.Name = "Node5"
        TreeNode3.Text = "LG_01"
        TreeNode4.Name = "Node6"
        TreeNode4.Text = "LG_02"
        TreeNode5.Name = "Node7"
        TreeNode5.Text = "LG_03"
        TreeNode6.Name = "Node8"
        TreeNode6.Text = "LG_04"
        TreeNode7.Name = "Node9"
        TreeNode7.Text = "LG_05"
        TreeNode8.Name = "Node10"
        TreeNode8.Text = "LG_06"
        TreeNode9.Name = "Node11"
        TreeNode9.Text = "LG_07"
        TreeNode10.Name = "Node12"
        TreeNode10.Text = "LG_08"
        TreeNode11.Name = "Node13"
        TreeNode11.Text = "LG_08"
        TreeNode12.Name = "Node1"
        TreeNode12.Text = "LG"
        TreeNode13.Name = "Node14"
        TreeNode13.Text = "TV_01"
        TreeNode14.Name = "Node2"
        TreeNode14.Text = "TV"
        TreeNode15.Name = "Node3"
        TreeNode15.Text = "SHADES"
        Me.RE_tvDevices.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode12, TreeNode14, TreeNode15})
        Me.RE_tvDevices.Size = New System.Drawing.Size(177, 298)
        Me.RE_tvDevices.TabIndex = 0
        '
        'RE_cmsTVDevices
        '
        Me.RE_cmsTVDevices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReplaceDeviceToolStripMenuItem})
        Me.RE_cmsTVDevices.Name = "RE_cmsTVDevices"
        Me.RE_cmsTVDevices.Size = New System.Drawing.Size(154, 26)
        '
        'ReplaceDeviceToolStripMenuItem
        '
        Me.ReplaceDeviceToolStripMenuItem.Name = "ReplaceDeviceToolStripMenuItem"
        Me.ReplaceDeviceToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ReplaceDeviceToolStripMenuItem.Text = "Replace Device"
        '
        'tpRoomType
        '
        Me.tpRoomType.BackColor = System.Drawing.SystemColors.Control
        Me.tpRoomType.Controls.Add(Me.TableLayoutPanel3)
        Me.tpRoomType.Location = New System.Drawing.Point(4, 22)
        Me.tpRoomType.Name = "tpRoomType"
        Me.tpRoomType.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRoomType.Size = New System.Drawing.Size(1308, 642)
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
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_gbProgramInfo, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_gbDevices, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_lblRoomTypes, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_lbRoomTypes, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_btnNew, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_btnDelete, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_btnSave, 4, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_btnClear, 5, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.RTE_gbDefaultState, 4, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1302, 636)
        Me.TableLayoutPanel3.TabIndex = 32
        '
        'RTE_gbProgramInfo
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.RTE_gbProgramInfo, 2)
        Me.RTE_gbProgramInfo.Controls.Add(Me.RTE_btnBrowseProgram)
        Me.RTE_gbProgramInfo.Controls.Add(Me.RTE_tbProgramName)
        Me.RTE_gbProgramInfo.Controls.Add(Me.RTE_lblDefaultProgram)
        Me.RTE_gbProgramInfo.Location = New System.Drawing.Point(934, 3)
        Me.RTE_gbProgramInfo.Name = "RTE_gbProgramInfo"
        Me.TableLayoutPanel3.SetRowSpan(Me.RTE_gbProgramInfo, 2)
        Me.RTE_gbProgramInfo.Size = New System.Drawing.Size(296, 177)
        Me.RTE_gbProgramInfo.TabIndex = 31
        Me.RTE_gbProgramInfo.TabStop = False
        Me.RTE_gbProgramInfo.Text = "Program Info"
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
        'RTE_gbDevices
        '
        Me.RTE_gbDevices.Controls.Add(Me.RTE_lbDeviceTypesAvailable)
        Me.RTE_gbDevices.Controls.Add(Me.RTE_tvDevicesAdded)
        Me.RTE_gbDevices.Controls.Add(Me.RTE_btnAllDeviceAdd)
        Me.RTE_gbDevices.Controls.Add(Me.RTE_lblDevicesAdded)
        Me.RTE_gbDevices.Controls.Add(Me.RTE_btnDeviceAdd)
        Me.RTE_gbDevices.Controls.Add(Me.RTE_lblDevicesAvailable)
        Me.RTE_gbDevices.Controls.Add(Me.RTE_btnAllDeviceRemove)
        Me.RTE_gbDevices.Controls.Add(Me.RTE_btnDeviceRemove)
        Me.RTE_gbDevices.Location = New System.Drawing.Point(159, 3)
        Me.RTE_gbDevices.Name = "RTE_gbDevices"
        Me.TableLayoutPanel3.SetRowSpan(Me.RTE_gbDevices, 4)
        Me.RTE_gbDevices.Size = New System.Drawing.Size(372, 457)
        Me.RTE_gbDevices.TabIndex = 30
        Me.RTE_gbDevices.TabStop = False
        Me.RTE_gbDevices.Text = "Devices"
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
        Me.RTE_lblRoomTypes.Size = New System.Drawing.Size(67, 13)
        Me.RTE_lblRoomTypes.TabIndex = 28
        Me.RTE_lblRoomTypes.Text = "Room Types"
        '
        'RTE_lbRoomTypes
        '
        Me.RTE_lbRoomTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.RTE_lbRoomTypes, 2)
        Me.RTE_lbRoomTypes.FormattingEnabled = True
        Me.RTE_lbRoomTypes.Location = New System.Drawing.Point(8, 27)
        Me.RTE_lbRoomTypes.Name = "RTE_lbRoomTypes"
        Me.TableLayoutPanel3.SetRowSpan(Me.RTE_lbRoomTypes, 3)
        Me.RTE_lbRoomTypes.Size = New System.Drawing.Size(140, 472)
        Me.RTE_lbRoomTypes.TabIndex = 23
        '
        'RTE_btnNew
        '
        Me.RTE_btnNew.Location = New System.Drawing.Point(3, 505)
        Me.RTE_btnNew.MinimumSize = New System.Drawing.Size(72, 23)
        Me.RTE_btnNew.Name = "RTE_btnNew"
        Me.RTE_btnNew.Size = New System.Drawing.Size(72, 23)
        Me.RTE_btnNew.TabIndex = 24
        Me.RTE_btnNew.Text = "New"
        Me.RTE_btnNew.UseVisualStyleBackColor = True
        '
        'RTE_btnDelete
        '
        Me.RTE_btnDelete.Location = New System.Drawing.Point(81, 505)
        Me.RTE_btnDelete.MinimumSize = New System.Drawing.Size(72, 23)
        Me.RTE_btnDelete.Name = "RTE_btnDelete"
        Me.RTE_btnDelete.Size = New System.Drawing.Size(72, 23)
        Me.RTE_btnDelete.TabIndex = 29
        Me.RTE_btnDelete.Text = "Delete"
        Me.RTE_btnDelete.UseVisualStyleBackColor = True
        '
        'RTE_btnSave
        '
        Me.RTE_btnSave.Location = New System.Drawing.Point(934, 505)
        Me.RTE_btnSave.MinimumSize = New System.Drawing.Size(63, 23)
        Me.RTE_btnSave.Name = "RTE_btnSave"
        Me.RTE_btnSave.Size = New System.Drawing.Size(63, 23)
        Me.RTE_btnSave.TabIndex = 25
        Me.RTE_btnSave.Text = "Save"
        Me.RTE_btnSave.UseVisualStyleBackColor = True
        '
        'RTE_btnClear
        '
        Me.RTE_btnClear.Location = New System.Drawing.Point(1236, 505)
        Me.RTE_btnClear.MinimumSize = New System.Drawing.Size(63, 23)
        Me.RTE_btnClear.Name = "RTE_btnClear"
        Me.RTE_btnClear.Size = New System.Drawing.Size(63, 23)
        Me.RTE_btnClear.TabIndex = 26
        Me.RTE_btnClear.Text = "Clear"
        Me.RTE_btnClear.UseVisualStyleBackColor = True
        '
        'RTE_gbDefaultState
        '
        Me.RTE_gbDefaultState.Controls.Add(Me.RTE_rbStateDisabled)
        Me.RTE_gbDefaultState.Controls.Add(Me.RTE_rbStateEnabled)
        Me.RTE_gbDefaultState.Controls.Add(Me.RTE_cbDefaultState)
        Me.RTE_gbDefaultState.Location = New System.Drawing.Point(934, 186)
        Me.RTE_gbDefaultState.Name = "RTE_gbDefaultState"
        Me.RTE_gbDefaultState.Size = New System.Drawing.Size(296, 192)
        Me.RTE_gbDefaultState.TabIndex = 32
        Me.RTE_gbDefaultState.TabStop = False
        Me.RTE_gbDefaultState.Text = "Default State"
        '
        'RTE_rbStateDisabled
        '
        Me.RTE_rbStateDisabled.AutoSize = True
        Me.RTE_rbStateDisabled.Checked = True
        Me.RTE_rbStateDisabled.Location = New System.Drawing.Point(123, 113)
        Me.RTE_rbStateDisabled.Name = "RTE_rbStateDisabled"
        Me.RTE_rbStateDisabled.Size = New System.Drawing.Size(66, 17)
        Me.RTE_rbStateDisabled.TabIndex = 2
        Me.RTE_rbStateDisabled.TabStop = True
        Me.RTE_rbStateDisabled.Text = "Disabled"
        Me.RTE_rbStateDisabled.UseVisualStyleBackColor = True
        '
        'RTE_rbStateEnabled
        '
        Me.RTE_rbStateEnabled.AutoSize = True
        Me.RTE_rbStateEnabled.Location = New System.Drawing.Point(9, 113)
        Me.RTE_rbStateEnabled.Name = "RTE_rbStateEnabled"
        Me.RTE_rbStateEnabled.Size = New System.Drawing.Size(64, 17)
        Me.RTE_rbStateEnabled.TabIndex = 1
        Me.RTE_rbStateEnabled.Text = "Enabled"
        Me.RTE_rbStateEnabled.UseVisualStyleBackColor = True
        '
        'RTE_cbDefaultState
        '
        Me.RTE_cbDefaultState.FormattingEnabled = True
        Me.RTE_cbDefaultState.Location = New System.Drawing.Point(6, 44)
        Me.RTE_cbDefaultState.Name = "RTE_cbDefaultState"
        Me.RTE_cbDefaultState.Size = New System.Drawing.Size(150, 21)
        Me.RTE_cbDefaultState.TabIndex = 0
        '
        'tpDeviceType
        '
        Me.tpDeviceType.BackColor = System.Drawing.SystemColors.Control
        Me.tpDeviceType.Controls.Add(Me.TableLayoutPanel1)
        Me.tpDeviceType.Location = New System.Drawing.Point(4, 22)
        Me.tpDeviceType.Name = "tpDeviceType"
        Me.tpDeviceType.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDeviceType.Size = New System.Drawing.Size(1308, 642)
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
        Me.TableLayoutPanel1.Controls.Add(Me.AE_btnNew, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_btnDel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_btnClear, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_btnSave, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_lblName, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AE_lbDeviceName, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.gbAlarmSettings, 3, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.65156!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.348442!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1302, 636)
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
        Me.AE_lbDevices.Size = New System.Drawing.Size(149, 524)
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
        'AE_btnNew
        '
        Me.AE_btnNew.Location = New System.Drawing.Point(3, 585)
        Me.AE_btnNew.Name = "AE_btnNew"
        Me.AE_btnNew.Size = New System.Drawing.Size(57, 23)
        Me.AE_btnNew.TabIndex = 23
        Me.AE_btnNew.Text = "New"
        Me.AE_btnNew.UseVisualStyleBackColor = True
        '
        'AE_btnDel
        '
        Me.AE_btnDel.Location = New System.Drawing.Point(66, 585)
        Me.AE_btnDel.Name = "AE_btnDel"
        Me.AE_btnDel.Size = New System.Drawing.Size(58, 23)
        Me.AE_btnDel.TabIndex = 22
        Me.AE_btnDel.Text = "Delete"
        Me.AE_btnDel.UseVisualStyleBackColor = True
        '
        'AE_btnClear
        '
        Me.AE_btnClear.Location = New System.Drawing.Point(1231, 585)
        Me.AE_btnClear.Name = "AE_btnClear"
        Me.AE_btnClear.Size = New System.Drawing.Size(66, 23)
        Me.AE_btnClear.TabIndex = 26
        Me.AE_btnClear.Text = "Clear"
        Me.AE_btnClear.UseVisualStyleBackColor = True
        '
        'AE_btnSave
        '
        Me.AE_btnSave.Location = New System.Drawing.Point(1118, 585)
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
        Me.AE_lbDeviceName.Location = New System.Drawing.Point(297, 40)
        Me.AE_lbDeviceName.Name = "AE_lbDeviceName"
        Me.AE_lbDeviceName.Size = New System.Drawing.Size(0, 13)
        Me.AE_lbDeviceName.TabIndex = 29
        '
        'gbAlarmSettings
        '
        Me.gbAlarmSettings.Controls.Add(Me.AE_cbErrorAlarmCode)
        Me.gbAlarmSettings.Controls.Add(Me.Label14)
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
        Me.gbAlarmSettings.Location = New System.Drawing.Point(297, 63)
        Me.gbAlarmSettings.Name = "gbAlarmSettings"
        Me.gbAlarmSettings.Size = New System.Drawing.Size(609, 465)
        Me.gbAlarmSettings.TabIndex = 28
        Me.gbAlarmSettings.TabStop = False
        Me.gbAlarmSettings.Text = "Alarm Settings"
        '
        'AE_cbErrorAlarmCode
        '
        Me.AE_cbErrorAlarmCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AE_cbErrorAlarmCode.FormattingEnabled = True
        Me.AE_cbErrorAlarmCode.Location = New System.Drawing.Point(400, 134)
        Me.AE_cbErrorAlarmCode.Name = "AE_cbErrorAlarmCode"
        Me.AE_cbErrorAlarmCode.Size = New System.Drawing.Size(198, 21)
        Me.AE_cbErrorAlarmCode.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(397, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Error Alarm Code:"
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
        'tpvConfigurator
        '
        Me.tpvConfigurator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tpvConfigurator.Controls.Add(Me.tpDeviceType)
        Me.tpvConfigurator.Controls.Add(Me.tpRoomType)
        Me.tpvConfigurator.Controls.Add(Me.tpRoomEditor)
        Me.tpvConfigurator.Controls.Add(Me.tpEventEditor)
        Me.tpvConfigurator.Controls.Add(Me.tpStateManager)
        Me.tpvConfigurator.Location = New System.Drawing.Point(17, 32)
        Me.tpvConfigurator.Margin = New System.Windows.Forms.Padding(8)
        Me.tpvConfigurator.Name = "tpvConfigurator"
        Me.tpvConfigurator.SelectedIndex = 0
        Me.tpvConfigurator.Size = New System.Drawing.Size(1316, 668)
        Me.tpvConfigurator.TabIndex = 0
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicModeToolStripMenuItem, Me.FullVersionToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'BasicModeToolStripMenuItem
        '
        Me.BasicModeToolStripMenuItem.Name = "BasicModeToolStripMenuItem"
        Me.BasicModeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BasicModeToolStripMenuItem.Text = "Basic Mode"
        '
        'FullVersionToolStripMenuItem
        '
        Me.FullVersionToolStripMenuItem.Name = "FullVersionToolStripMenuItem"
        Me.FullVersionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FullVersionToolStripMenuItem.Text = "Full Version"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.mainStrip)
        Me.Controls.Add(Me.tpvConfigurator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mainStrip
        Me.Name = "frmMain"
        Me.Text = "Configurator"
        Me.tvMenuStrip.ResumeLayout(False)
        Me.RTE_cmsTV.ResumeLayout(False)
        Me.mainStrip.ResumeLayout(False)
        Me.mainStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.tpStateManager.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.SM_gbSchedule.ResumeLayout(False)
        Me.SM_gbSchedule.PerformLayout()
        CType(Me.SM_udMinutesStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SM_udHoursStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SM_udMinutesStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SM_udHoursStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEventEditor.ResumeLayout(False)
        Me.tlpEventEditor.ResumeLayout(False)
        Me.tlpEventEditor.PerformLayout()
        Me.tpRoomEditor.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.RE_gbRoomDetails.ResumeLayout(False)
        Me.RE_gbRoomDetails.PerformLayout()
        Me.RE_tcRoomViewer.ResumeLayout(False)
        Me.RE_tbByFloor.ResumeLayout(False)
        Me.RE_tbByType.ResumeLayout(False)
        Me.RE_gbRoomStatus.ResumeLayout(False)
        Me.RE_gbRoomStatus.PerformLayout()
        Me.RE_gbRoomSettings.ResumeLayout(False)
        Me.RE_gbRoomSettings.PerformLayout()
        Me.RE_gbDevices.ResumeLayout(False)
        Me.RE_gbDevices.PerformLayout()
        Me.RE_cmsTVDevices.ResumeLayout(False)
        Me.tpRoomType.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.RTE_gbProgramInfo.ResumeLayout(False)
        Me.RTE_gbProgramInfo.PerformLayout()
        Me.RTE_gbDevices.ResumeLayout(False)
        Me.RTE_gbDevices.PerformLayout()
        Me.RTE_gbDefaultState.ResumeLayout(False)
        Me.RTE_gbDefaultState.PerformLayout()
        Me.tpDeviceType.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.gbAlarmSettings.ResumeLayout(False)
        Me.gbAlarmSettings.PerformLayout()
        Me.AE_gbSignalType.ResumeLayout(False)
        Me.AE_gbSignalType.PerformLayout()
        Me.AE_gbAlarmType.ResumeLayout(False)
        Me.AE_gbAlarmType.PerformLayout()
        Me.tpvConfigurator.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents openProgram As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mainStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tvMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiAddItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDeleteItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tssLbl_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RTE_cmsTV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LoadProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDefaultProgramByRoomTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadOtherProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RE_tmrProgramLoad As System.Windows.Forms.Timer
    Friend WithEvents RemotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadNewRemoteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDefaultRemoteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SQLServerConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tpStateManager As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
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
    Friend WithEvents EE_tbAlarmCode As System.Windows.Forms.TextBox
    Friend WithEvents tpRoomEditor As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RE_gbRoomDetails As System.Windows.Forms.GroupBox
    Friend WithEvents RE_tbFloor As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblFloor As System.Windows.Forms.Label
    Friend WithEvents RE_tbMAC As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblMAC As System.Windows.Forms.Label
    Friend WithEvents RE_tbIpAddress As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblIpAddress As System.Windows.Forms.Label
    Friend WithEvents RE_tbBuilding As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblBuilding As System.Windows.Forms.Label
    Friend WithEvents RE_tbRoomType As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblRoomType As System.Windows.Forms.Label
    Friend WithEvents RE_tbRoomName As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblRoomName As System.Windows.Forms.Label
    Friend WithEvents RE_tcRoomViewer As System.Windows.Forms.TabControl
    Friend WithEvents RE_tbByFloor As System.Windows.Forms.TabPage
    Friend WithEvents RE_tvRoomsByFloor As System.Windows.Forms.TreeView
    Friend WithEvents RE_tbByType As System.Windows.Forms.TabPage
    Friend WithEvents RE_tvRoomsByType As System.Windows.Forms.TreeView
    Friend WithEvents RE_btnSave As System.Windows.Forms.Button
    Friend WithEvents RE_btnNew As System.Windows.Forms.Button
    Friend WithEvents RE_btnDelete As System.Windows.Forms.Button
    Friend WithEvents tpRoomType As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RTE_gbProgramInfo As System.Windows.Forms.GroupBox
    Friend WithEvents RTE_btnBrowseProgram As System.Windows.Forms.Button
    Friend WithEvents RTE_tbProgramName As System.Windows.Forms.TextBox
    Friend WithEvents RTE_lblDefaultProgram As System.Windows.Forms.Label
    Friend WithEvents RTE_gbDevices As System.Windows.Forms.GroupBox
    Friend WithEvents RTE_lbDeviceTypesAvailable As System.Windows.Forms.ListBox
    Friend WithEvents RTE_tvDevicesAdded As System.Windows.Forms.TreeView
    Friend WithEvents RTE_btnAllDeviceAdd As System.Windows.Forms.Button
    Friend WithEvents RTE_lblDevicesAdded As System.Windows.Forms.Label
    Friend WithEvents RTE_btnDeviceAdd As System.Windows.Forms.Button
    Friend WithEvents RTE_lblDevicesAvailable As System.Windows.Forms.Label
    Friend WithEvents RTE_btnAllDeviceRemove As System.Windows.Forms.Button
    Friend WithEvents RTE_btnDeviceRemove As System.Windows.Forms.Button
    Friend WithEvents RTE_lblRoomTypes As System.Windows.Forms.Label
    Friend WithEvents RTE_lbRoomTypes As System.Windows.Forms.ListBox
    Friend WithEvents RTE_btnNew As System.Windows.Forms.Button
    Friend WithEvents RTE_btnDelete As System.Windows.Forms.Button
    Friend WithEvents RTE_btnSave As System.Windows.Forms.Button
    Friend WithEvents RTE_btnClear As System.Windows.Forms.Button
    Friend WithEvents RTE_gbDefaultState As System.Windows.Forms.GroupBox
    Friend WithEvents tpDeviceType As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AE_lbDevices As System.Windows.Forms.ListBox
    Friend WithEvents AE_lblDevices As System.Windows.Forms.Label
    Friend WithEvents gbAlarmSettings As System.Windows.Forms.GroupBox
    Friend WithEvents AE_combWarningAlarms As System.Windows.Forms.ComboBox
    Friend WithEvents AE_lblWarningCode As System.Windows.Forms.Label
    Friend WithEvents AE_tbWarningTimeFrame As System.Windows.Forms.TextBox
    Friend WithEvents AE_tbWarningThreshold As System.Windows.Forms.TextBox
    Friend WithEvents AE_lblWarningTimeFrame As System.Windows.Forms.Label
    Friend WithEvents AE_lblWarningThreshold As System.Windows.Forms.Label
    Friend WithEvents AE_cbWarning As System.Windows.Forms.CheckBox
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
    Friend WithEvents AE_btnNew As System.Windows.Forms.Button
    Friend WithEvents AE_btnDel As System.Windows.Forms.Button
    Friend WithEvents AE_btnClear As System.Windows.Forms.Button
    Friend WithEvents AE_btnSave As System.Windows.Forms.Button
    Friend WithEvents AE_lblName As System.Windows.Forms.Label
    Friend WithEvents AE_lbDeviceName As System.Windows.Forms.Label
    Friend WithEvents tpvConfigurator As System.Windows.Forms.TabControl
    Friend WithEvents SM_cbDevices As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents SM_tbAnalogValue As System.Windows.Forms.TrackBar
    Friend WithEvents SM_rbDigitalOff As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbDigitalOn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents SM_tbStateName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SM_btnNew As System.Windows.Forms.Button
    Friend WithEvents SM_btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents SM_dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents SM_lblStop As System.Windows.Forms.Label
    Friend WithEvents SM_lblStart As System.Windows.Forms.Label
    Friend WithEvents SM_cbTriggers As System.Windows.Forms.ComboBox
    Friend WithEvents SM_udHoursStart As System.Windows.Forms.NumericUpDown
    Friend WithEvents SM_dtpStop As System.Windows.Forms.DateTimePicker
    Friend WithEvents SM_lblMinutesStop As System.Windows.Forms.Label
    Friend WithEvents SM_lblMinutesStart As System.Windows.Forms.Label
    Friend WithEvents SM_lblHoursStop As System.Windows.Forms.Label
    Friend WithEvents SM_lblHoursStart As System.Windows.Forms.Label
    Friend WithEvents SM_rbPMStop As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbAMStop As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbPMStart As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbAMStart As System.Windows.Forms.RadioButton
    Friend WithEvents SM_udMinutesStop As System.Windows.Forms.NumericUpDown
    Friend WithEvents SM_udHoursStop As System.Windows.Forms.NumericUpDown
    Friend WithEvents SM_udMinutesStart As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SM_cbAreas As System.Windows.Forms.ComboBox
    Friend WithEvents SM_lblAnalogHundred As System.Windows.Forms.Label
    Friend WithEvents SM_lblAnalogZero As System.Windows.Forms.Label
    Friend WithEvents SM_gbSchedule As System.Windows.Forms.GroupBox
    Friend WithEvents SM_rbSunTrackOn As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbShadeOpen As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbShadeClosed As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbSunTrackOff As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SM_tcShades As System.Windows.Forms.TabControl
    Friend WithEvents SM_tpSetting1 As System.Windows.Forms.TabPage
    Friend WithEvents SM_tpSetting2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LoyaltyProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents SM_cbLoyaltyProgram As System.Windows.Forms.CheckBox
    Friend WithEvents SM_gbLights As System.Windows.Forms.GroupBox
    Friend WithEvents SM_gbTVControls As System.Windows.Forms.GroupBox
    Friend WithEvents SM_rbTvOff As System.Windows.Forms.RadioButton
    Friend WithEvents SM_rbTvOn As System.Windows.Forms.RadioButton
    Friend WithEvents SM_gbTstatControls As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SM_tbTstatSlider As System.Windows.Forms.TrackBar
    Friend WithEvents SM_nudSetPoint As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SM_lbStates As System.Windows.Forms.ListBox
    Friend WithEvents RTE_rbStateDisabled As System.Windows.Forms.RadioButton
    Friend WithEvents RTE_rbStateEnabled As System.Windows.Forms.RadioButton
    Friend WithEvents RTE_cbDefaultState As System.Windows.Forms.ComboBox
    Friend WithEvents RE_gbRoomStatus As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RE_rbUnoccupied As System.Windows.Forms.RadioButton
    Friend WithEvents RE_rbOccupied As System.Windows.Forms.RadioButton
    Friend WithEvents RE_cbRoomState As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RE_gbRoomSettings As System.Windows.Forms.GroupBox
    Friend WithEvents RE_btnResendFirmware As System.Windows.Forms.Button
    Friend WithEvents RE_btnBrowseFirmware As System.Windows.Forms.Button
    Friend WithEvents RE_btnResendProgram As System.Windows.Forms.Button
    Friend WithEvents RE_btnBrowseProgram As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RE_lblFirmwareLoaded As System.Windows.Forms.Label
    Friend WithEvents RE_lblProgramLoaded As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents AE_cbErrorAlarmCode As System.Windows.Forms.ComboBox
    Friend WithEvents RE_gbDevices As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RE_tvDevices As System.Windows.Forms.TreeView
    Friend WithEvents RE_cmsTVDevices As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReplaceDeviceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullVersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
