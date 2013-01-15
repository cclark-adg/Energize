<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramLoad
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
        Me.lsvRoomsLoading = New System.Windows.Forms.ListView()
        Me.colRooms = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsvRoomsLoading
        '
        Me.lsvRoomsLoading.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRooms, Me.colStatus})
        Me.lsvRoomsLoading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lsvRoomsLoading.FullRowSelect = True
        Me.lsvRoomsLoading.Location = New System.Drawing.Point(0, 0)
        Me.lsvRoomsLoading.Name = "lsvRoomsLoading"
        Me.lsvRoomsLoading.Size = New System.Drawing.Size(284, 262)
        Me.lsvRoomsLoading.TabIndex = 0
        Me.lsvRoomsLoading.UseCompatibleStateImageBehavior = False
        Me.lsvRoomsLoading.View = System.Windows.Forms.View.Details
        '
        'colRooms
        '
        Me.colRooms.Text = "Rooms"
        Me.colRooms.Width = 140
        '
        'colStatus
        '
        Me.colStatus.Text = "Status"
        Me.colStatus.Width = 138
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(197, 268)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(116, 268)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmProgramLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 304)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lsvRoomsLoading)
        Me.Name = "frmProgramLoad"
        Me.Text = "Program Loading"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colRooms As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Public WithEvents lsvRoomsLoading As System.Windows.Forms.ListView
End Class
