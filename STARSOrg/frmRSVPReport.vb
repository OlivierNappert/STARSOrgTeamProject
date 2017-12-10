Public Class frmRSVPReport


    Private Sub lblReport_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub frmRSVPReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EVENT_RSVPTableAdapter.Fill(Me.dataSetMembers.EVENT_RSVP)
        Me.rptEvents.RefreshReport()


    End Sub
End Class