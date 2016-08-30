Public Class frm_index
    Private Sub btn_dem_Click(sender As System.Object, e As System.EventArgs) Handles btn_dem.Click
        Dim f1 As New index
        pb.Visible = True
        pb.Value = pb.Minimum
        Do While pb.Value < pb.Maximum
            pb.Value += 10
            System.Threading.Thread.Sleep(1000)
        Loop
        If pb.Value = pb.Maximum Then
            pb.Visible = False
            Me.Visible = False
            f1.Visible = True
        End If
    End Sub
End Class