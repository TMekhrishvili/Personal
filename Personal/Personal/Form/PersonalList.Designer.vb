<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonalList))
        Me.gc = New DevExpress.XtraGrid.GridControl()
        Me.gw = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PersonalID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FatherName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MilitaryUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MilitaryRank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Diagnosis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DOB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DOMilitary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CheckByMinistry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DoctorComment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsHome = New System.Windows.Forms.ToolStripButton()
        Me.tsAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsRemove = New System.Windows.Forms.ToolStripButton()
        Me.tsPrint = New System.Windows.Forms.ToolStripButton()
        Me.tsRecycle = New System.Windows.Forms.ToolStripButton()
        Me.tsRecover = New System.Windows.Forms.ToolStripButton()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 0)
        Me.gc.MainView = Me.gw
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(787, 367)
        Me.gc.TabIndex = 0
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gw})
        '
        'gw
        '
        Me.gw.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PersonalID, Me.FirstName, Me.LastName, Me.FatherName, Me.MilitaryUnit, Me.MilitaryRank, Me.Diagnosis, Me.DOB, Me.DOMilitary, Me.CheckByMinistry, Me.DoctorComment})
        Me.gw.GridControl = Me.gc
        Me.gw.Name = "gw"
        '
        'PersonalID
        '
        Me.PersonalID.Caption = "PersonalID"
        Me.PersonalID.FieldName = "PersonalID"
        Me.PersonalID.Name = "PersonalID"
        '
        'FirstName
        '
        Me.FirstName.Caption = "სახელი"
        Me.FirstName.FieldName = "FirstName"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.OptionsColumn.AllowEdit = False
        Me.FirstName.Visible = True
        Me.FirstName.VisibleIndex = 0
        Me.FirstName.Width = 76
        '
        'LastName
        '
        Me.LastName.Caption = "გვარი"
        Me.LastName.FieldName = "LastName"
        Me.LastName.Name = "LastName"
        Me.LastName.OptionsColumn.AllowEdit = False
        Me.LastName.Visible = True
        Me.LastName.VisibleIndex = 1
        Me.LastName.Width = 76
        '
        'FatherName
        '
        Me.FatherName.Caption = "მამის სახელი"
        Me.FatherName.FieldName = "FatherName"
        Me.FatherName.Name = "FatherName"
        Me.FatherName.OptionsColumn.AllowEdit = False
        Me.FatherName.Visible = True
        Me.FatherName.VisibleIndex = 2
        Me.FatherName.Width = 76
        '
        'MilitaryUnit
        '
        Me.MilitaryUnit.Caption = "სამხედრო ნაწილი"
        Me.MilitaryUnit.FieldName = "MilitaryUnit"
        Me.MilitaryUnit.Name = "MilitaryUnit"
        Me.MilitaryUnit.OptionsColumn.AllowEdit = False
        Me.MilitaryUnit.Visible = True
        Me.MilitaryUnit.VisibleIndex = 3
        Me.MilitaryUnit.Width = 70
        '
        'MilitaryRank
        '
        Me.MilitaryRank.Caption = "სამხედრო წოდება"
        Me.MilitaryRank.FieldName = "MilitaryRank"
        Me.MilitaryRank.Name = "MilitaryRank"
        Me.MilitaryRank.OptionsColumn.AllowEdit = False
        Me.MilitaryRank.Visible = True
        Me.MilitaryRank.VisibleIndex = 4
        '
        'Diagnosis
        '
        Me.Diagnosis.Caption = "დიაგნოზი"
        Me.Diagnosis.FieldName = "Diagnosis"
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.OptionsColumn.AllowEdit = False
        Me.Diagnosis.Visible = True
        Me.Diagnosis.VisibleIndex = 5
        '
        'DOB
        '
        Me.DOB.Caption = "დაბადების თარიღი"
        Me.DOB.FieldName = "DOB"
        Me.DOB.Name = "DOB"
        Me.DOB.OptionsColumn.AllowEdit = False
        Me.DOB.Visible = True
        Me.DOB.VisibleIndex = 6
        '
        'DOMilitary
        '
        Me.DOMilitary.Caption = "გაწვევის თარიღი"
        Me.DOMilitary.FieldName = "DOMilitary"
        Me.DOMilitary.Name = "DOMilitary"
        Me.DOMilitary.OptionsColumn.AllowEdit = False
        Me.DOMilitary.Visible = True
        Me.DOMilitary.VisibleIndex = 7
        '
        'CheckByMinistry
        '
        Me.CheckByMinistry.Caption = "შემოწმების თარიღი"
        Me.CheckByMinistry.FieldName = "CheckByMinistry"
        Me.CheckByMinistry.Name = "CheckByMinistry"
        Me.CheckByMinistry.OptionsColumn.AllowEdit = False
        Me.CheckByMinistry.Visible = True
        Me.CheckByMinistry.VisibleIndex = 8
        '
        'DoctorComment
        '
        Me.DoctorComment.Caption = "ექიმის კომენტარი"
        Me.DoctorComment.FieldName = "DoctorComment"
        Me.DoctorComment.Name = "DoctorComment"
        Me.DoctorComment.OptionsColumn.AllowEdit = False
        Me.DoctorComment.Visible = True
        Me.DoctorComment.VisibleIndex = 9
        Me.DoctorComment.Width = 96
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsHome, Me.tsAdd, Me.tsEdit, Me.tsRemove, Me.tsPrint, Me.tsRecycle, Me.tsRecover})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(787, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsHome
        '
        Me.tsHome.Image = CType(resources.GetObject("tsHome.Image"), System.Drawing.Image)
        Me.tsHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHome.Name = "tsHome"
        Me.tsHome.Size = New System.Drawing.Size(79, 22)
        Me.tsHome.Text = "მთავარი"
        '
        'tsAdd
        '
        Me.tsAdd.Image = CType(resources.GetObject("tsAdd.Image"), System.Drawing.Image)
        Me.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAdd.Name = "tsAdd"
        Me.tsAdd.Size = New System.Drawing.Size(85, 22)
        Me.tsAdd.Text = "დამატება"
        '
        'tsEdit
        '
        Me.tsEdit.Image = CType(resources.GetObject("tsEdit.Image"), System.Drawing.Image)
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(109, 22)
        Me.tsEdit.Text = "რედაქტირება"
        '
        'tsRemove
        '
        Me.tsRemove.Image = CType(resources.GetObject("tsRemove.Image"), System.Drawing.Image)
        Me.tsRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRemove.Name = "tsRemove"
        Me.tsRemove.Size = New System.Drawing.Size(68, 22)
        Me.tsRemove.Text = "წაშლა"
        '
        'tsPrint
        '
        Me.tsPrint.Image = CType(resources.GetObject("tsPrint.Image"), System.Drawing.Image)
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(69, 22)
        Me.tsPrint.Text = "ბეჭდვა"
        '
        'tsRecycle
        '
        Me.tsRecycle.Image = CType(resources.GetObject("tsRecycle.Image"), System.Drawing.Image)
        Me.tsRecycle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRecycle.Name = "tsRecycle"
        Me.tsRecycle.Size = New System.Drawing.Size(72, 22)
        Me.tsRecycle.Text = "სანაგვე"
        '
        'tsRecover
        '
        Me.tsRecover.Image = CType(resources.GetObject("tsRecover.Image"), System.Drawing.Image)
        Me.tsRecover.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRecover.Name = "tsRecover"
        Me.tsRecover.Size = New System.Drawing.Size(79, 22)
        Me.tsRecover.Text = "აღდგენა"
        '
        'frmPersonalList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 367)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gc)
        Me.Font = New System.Drawing.Font("Sylfaen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPersonalList"
        Me.Text = "პერსონალის სია"
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gw As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersonalID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FatherName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MilitaryUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MilitaryRank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diagnosis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DOB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DOMilitary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckByMinistry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DoctorComment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsAdd As ToolStripButton
    Friend WithEvents tsEdit As ToolStripButton
    Friend WithEvents tsRemove As ToolStripButton
    Friend WithEvents tsPrint As ToolStripButton
    Friend WithEvents tsRecycle As ToolStripButton
    Friend WithEvents tsHome As ToolStripButton
    Friend WithEvents tsRecover As ToolStripButton
End Class
