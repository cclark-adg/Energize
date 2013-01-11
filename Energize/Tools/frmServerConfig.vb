Public Class frmServerConfig

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    
    Public Sub loadForm(ByRef Server_Address As String, ByRef Username As String, ByRef Password As String)
        tbServerName.Text = Server_Address
        tbPassword.Text = Password
        tbUsername.Text = Username

    End Sub

    Private Sub Save_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Energize.PASSWORD = tbPassword.Text
        Energize.USERNAME = tbUsername.Text
        Energize.SERVER_ADDRESS = tbServerName.Text
    End Sub

    
End Class