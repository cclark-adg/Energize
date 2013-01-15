<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcel_Room_Loader
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
        Me.openProgram = New System.Windows.Forms.OpenFileDialog()
        Me.RL_Flags.SuspendLayout()
        Me.SuspendLayout()
        '
        'RL_Flags
        '
        Me.RL_Flags.Controls.Add(Me.RL_cbLoadDefaultProgram)
        Me.RL_Flags.Controls.Add(Me.RL_cbLoadProcessorSettings)
        Me.RL_Flags.Controls.Add(Me.RL_cbLoadDevicesPerRoom)
        Me.RL_Flags.Location = New System.Drawing.Point(531, 144)
        Me.RL_Flags.Name = "RL_Flags"
        Me.RL_Flags.Size = New System.Drawing.Size(293, 131)
        Me.RL_Flags.TabIndex = 15
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
        Me.RL_btnLoad.Location = New System.Drawing.Point(749, 688)
        Me.RL_btnLoad.Name = "RL_btnLoad"
        Me.RL_btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.RL_btnLoad.TabIndex = 14
        Me.RL_btnLoad.Text = "Load Room(s)"
        Me.RL_btnLoad.UseVisualStyleBackColor = True
        '
        'RL_lsvRooms
        '
        Me.RL_lsvRooms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBuilding, Me.colFloor, Me.colRoom, Me.colType, Me.colIP})
        Me.RL_lsvRooms.GridLines = True
        Me.RL_lsvRooms.Location = New System.Drawing.Point(12, 12)
        Me.RL_lsvRooms.Name = "RL_lsvRooms"
        Me.RL_lsvRooms.Size = New System.Drawing.Size(479, 670)
        Me.RL_lsvRooms.TabIndex = 13
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
        Me.RL_btnBrowseExcel.Location = New System.Drawing.Point(416, 688)
        Me.RL_btnBrowseExcel.Name = "RL_btnBrowseExcel"
        Me.RL_btnBrowseExcel.Size = New System.Drawing.Size(75, 23)
        Me.RL_btnBrowseExcel.TabIndex = 12
        Me.RL_btnBrowseExcel.Text = "Browse"
        Me.RL_btnBrowseExcel.UseVisualStyleBackColor = True
        '
        'frmExcel_Room_Loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 723)
        Me.Controls.Add(Me.RL_Flags)
        Me.Controls.Add(Me.RL_btnLoad)
        Me.Controls.Add(Me.RL_lsvRooms)
        Me.Controls.Add(Me.RL_btnBrowseExcel)
        Me.Name = "frmExcel_Room_Loader"
        Me.Text = "Database Setup"
        Me.RL_Flags.ResumeLayout(False)
        Me.RL_Flags.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RL_Flags As System.Windows.Forms.GroupBox
    Friend WithEvents RL_cbLoadDefaultProgram As System.Windows.Forms.CheckBox
    Friend WithEvents RL_cbLoadProcessorSettings As System.Windows.Forms.CheckBox
    Friend WithEvents RL_cbLoadDevicesPerRoom As System.Windows.Forms.CheckBox
    Friend WithEvents RL_btnLoad As System.Windows.Forms.Button
    Friend WithEvents RL_lsvRooms As System.Windows.Forms.ListView
    Friend WithEvents colBuilding As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFloor As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRoom As System.Windows.Forms.ColumnHeader
    Friend WithEvents colType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents RL_btnBrowseExcel As System.Windows.Forms.Button
    Friend WithEvents openProgram As System.Windows.Forms.OpenFileDialog
End Class
