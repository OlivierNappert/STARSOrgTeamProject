Public Class frmRSVPReport


    Private Sub lblReport_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub frmRSVPReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dataSetMembers.MEMBER' table. You can move, or remove it, as needed.

        'Me.EVENT_RSVPTableAdapter.Fill(Me.DataSetEvents.EVENT_RSVP)
        Me.rptEvents.RefreshReport()
    End Sub
End Class