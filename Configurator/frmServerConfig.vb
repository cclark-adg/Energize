Public Class frmServerConfig

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmServerConfig_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loadForm(ByRef Server_Address As String, ByRef Username As String, ByRef Password As String)
        tbServerName.Text = Server_Address
        tbPassword.Text = Password
        tbUsername.Text = Username

    End Sub

    Private Sub Save_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        frmMain.PASSWORD = tbPassword.Text
        frmMain.USERNAME = tbUsername.Text
        frmMain.SERVER_ADDRESS = tbServerName.Text
        frmMain.sqlCmd.Connection = frmMain.connectToDatabase()
    End Sub
End Class