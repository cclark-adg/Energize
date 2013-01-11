Public Class frmServerConfig


    Public Sub loadForm(ByRef Server_Address As String, ByRef Username As String, ByRef Password As String)
        tbServerName.Text = Server_Address
        tbPassword.Text = Password
        tbUsername.Text = Username

    End Sub

    Private Sub Save_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Energize.PASSWORD = tbPassword.Text
        Energize.USERNAME = tbUsername.Text
        Energize.SERVER_ADDRESS = tbServerName.Text
        Energize.sqlCmd.Connection = Energize.connectToDatabase()
    End Sub

    
    
End Class