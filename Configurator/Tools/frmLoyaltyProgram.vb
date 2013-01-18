Public Class frmLoyaltyProgram
    Public SM_devicetypelist As List(Of String())

    Private Sub SM_cbDevices_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SM_cbDevices.SelectedIndexChanged
        'Every time a device is selected check to see if its a Analog or binary device then show the appropriate  controls for said signal type
        If SM_deviceTypeList.Item(SM_cbDevices.SelectedIndex)(4) = "Analog" Then
            SM_gbLights.Visible = False
            SM_gbTVControls.Visible = False
            If SM_deviceTypeList.Item(SM_cbDevices.SelectedIndex)(1) = "SHADES" Then
                SM_tcShades.Visible = True
                SM_gbTstatControls.Visible = False
            Else
                SM_tcShades.Visible = False
                SM_gbTstatControls.Visible = True
            End If

        ElseIf SM_deviceTypeList.Item(SM_cbDevices.SelectedIndex)(4) = "Binary" Then
            SM_tcShades.Visible = False
            SM_gbTstatControls.Visible = False
            If SM_deviceTypeList.Item(SM_cbDevices.SelectedIndex)(1) = "TV" Then
                SM_gbTVControls.Visible = True
                SM_gbLights.Visible = False
            Else
                SM_gbLights.Visible = True
                SM_gbTVControls.Visible = False
            End If

        End If
    End Sub
    'When the thermostat slider is changed update the up down box and visa versa
    Private Sub SM_tbTstatSlider_Scroll(sender As System.Object, e As System.EventArgs) Handles SM_tbTstatSlider.Scroll
        SM_nudSetPoint.Value = SM_tbTstatSlider.Value
    End Sub
    Private Sub SM_nudSetPoint_ValueChanged(sender As System.Object, e As System.EventArgs) Handles SM_nudSetPoint.ValueChanged
        SM_tbTstatSlider.Value = SM_nudSetPoint.Value
    End Sub
End Class