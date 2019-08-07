Imports DevExpress.XtraReports.UI

Public Class frmPersonalList
    Dim m As New PersonalModel
    Dim h As New PersonalHandler


    Private Sub frmPersonalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gc.DataSource = h.PersonalListGet()
        tsRecover.Visible = False
        tsHome.Visible = False

    End Sub

    Private Sub tsAdd_Click(sender As Object, e As EventArgs) Handles tsAdd.Click
        Dim addForm As New AddForm
        addForm.ShowDialog()
        gc.DataSource = h.PersonalListGet()
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        Dim addForm As New AddForm
        addForm.PersonalID = Convert.ToInt32(gw.GetFocusedRowCellValue(PersonalID).ToString)
        addForm.ShowDialog()
        gc.DataSource = h.PersonalListGet()
    End Sub

    Private Sub tsRemove_Click(sender As Object, e As EventArgs) Handles tsRemove.Click
        Dim result As Integer = MessageBox.Show("გსურთ ჩანაწერის წაშლა?", "MedSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            h.PersonalRemove(Convert.ToInt32(gw.GetFocusedRowCellValue(PersonalID).ToString))
            gc.DataSource = h.PersonalListGet()
        End If

    End Sub

    Private Sub tsPrint_Click(sender As Object, e As EventArgs) Handles tsPrint.Click
        Dim xt As New XtraReport2
        xt.DataSource = h.PersonalPrint(Convert.ToInt32(gw.GetFocusedRowCellValue(PersonalID).ToString))
        xt.ShowRibbonPreview()

    End Sub

    Private Sub tsRecycle_Click(sender As Object, e As EventArgs) Handles tsRecycle.Click
        gc.DataSource = h.PersonalRecycle()
        tsAdd.Visible = False
        tsEdit.Visible = False
        tsRemove.Visible = False
        tsPrint.Visible = False
        tsRecover.Visible = True
        tsHome.Visible = True
        tsRecycle.Visible = False
    End Sub

    Private Sub tsHome_Click(sender As Object, e As EventArgs) Handles tsHome.Click
        gc.DataSource = h.PersonalListGet()
        tsAdd.Visible = True
        tsEdit.Visible = True
        tsRemove.Visible = True
        tsPrint.Visible = True
        tsRecover.Visible = False
        tsHome.Visible = False
        tsRecycle.Visible = True
    End Sub


    Private Sub tsRecover_Click(sender As Object, e As EventArgs) Handles tsRecover.Click

        h.PersonalRecover(Convert.ToInt32(gw.GetFocusedRowCellValue(PersonalID).ToString))
        gc.DataSource = h.PersonalRecycle()
    End Sub
End Class

