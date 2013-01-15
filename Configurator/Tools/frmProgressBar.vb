Public Class frmProgressBar
    Public Sub setMax(ByVal max As Integer)
        pbLoading.Maximum = max
    End Sub

    Public Sub incrementBar(ByVal incremental As Integer)
        pbLoading.Increment(incremental)
        If pbLoading.Value = pbLoading.Maximum Then
            Me.Close()
        End If
    End Sub

    Private Sub frmProgressBar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class