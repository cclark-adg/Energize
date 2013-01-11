<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKPIView
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
        Me.lsvKPI = New System.Windows.Forms.ListView()
        Me.colRooms = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDevice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colError = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsvKPI
        '
        Me.lsvKPI.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRooms, Me.colDevice, Me.colError})
        Me.lsvKPI.Dock = System.Windows.Forms.DockStyle.Top
        Me.lsvKPI.FullRowSelect = True
        Me.lsvKPI.Location = New System.Drawing.Point(0, 0)
        Me.lsvKPI.Name = "lsvKPI"
        Me.lsvKPI.Size = New System.Drawing.Size(284, 262)
        Me.lsvKPI.TabIndex = 0
        Me.lsvKPI.UseCompatibleStateImageBehavior = False
        Me.lsvKPI.View = System.Windows.Forms.View.Details
        '
        'colRooms
        '
        Me.colRooms.Text = "Rooms"
        Me.colRooms.Width = 95
        '
        'colDevice
        '
        Me.colDevice.Text = "Device"
        Me.colDevice.Width = 104
        '
        'colError
        '
        Me.colError.Text = "Error Code"
        Me.colError.Width = 81
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
        'frmKPIView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 314)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lsvKPI)
        Me.Name = "frmKPIView"
        Me.Text = "frmKPIView"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvKPI As System.Windows.Forms.ListView
    Friend WithEvents colRooms As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDevice As System.Windows.Forms.ColumnHeader
    Friend WithEvents colError As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
