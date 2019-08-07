<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport2
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport2))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrMilitaryRank = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLastName = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrFatherName = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrMilitaryUnit = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrFirstName = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDiagnosis = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDOB = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDOMilitary = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCheckByMinistry = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDoctorComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DataSet1 = New Personal.ds()
        Me.Ds1 = New Personal.ds()
        Me.Ds2 = New Personal.ds()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrMilitaryRank, Me.xrLastName, Me.xrFatherName, Me.xrMilitaryUnit, Me.xrFirstName, Me.xrDiagnosis, Me.xrDOB, Me.xrDOMilitary, Me.xrCheckByMinistry, Me.xrDoctorComment, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.HeightF = 404.8177!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrMilitaryRank
        '
        Me.xrMilitaryRank.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.MilitaryRank")})
        Me.xrMilitaryRank.LocationFloat = New DevExpress.Utils.PointFloat(147.7294!, 147.7523!)
        Me.xrMilitaryRank.Name = "xrMilitaryRank"
        Me.xrMilitaryRank.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrMilitaryRank.SizeF = New System.Drawing.SizeF(180.1509!, 23.0!)
        '
        'xrLastName
        '
        Me.xrLastName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.LastName")})
        Me.xrLastName.LocationFloat = New DevExpress.Utils.PointFloat(147.7294!, 48.54396!)
        Me.xrLastName.Name = "xrLastName"
        Me.xrLastName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLastName.SizeF = New System.Drawing.SizeF(180.1509!, 23.0!)
        '
        'xrFatherName
        '
        Me.xrFatherName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.FatherName")})
        Me.xrFatherName.LocationFloat = New DevExpress.Utils.PointFloat(147.7294!, 79.87728!)
        Me.xrFatherName.Name = "xrFatherName"
        Me.xrFatherName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrFatherName.SizeF = New System.Drawing.SizeF(180.1509!, 23.0!)
        '
        'xrMilitaryUnit
        '
        Me.xrMilitaryUnit.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.MilitaryUnit")})
        Me.xrMilitaryUnit.LocationFloat = New DevExpress.Utils.PointFloat(147.7294!, 114.3356!)
        Me.xrMilitaryUnit.Name = "xrMilitaryUnit"
        Me.xrMilitaryUnit.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrMilitaryUnit.SizeF = New System.Drawing.SizeF(180.1509!, 23.0!)
        '
        'xrFirstName
        '
        Me.xrFirstName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.FirstName")})
        Me.xrFirstName.LocationFloat = New DevExpress.Utils.PointFloat(147.7294!, 18.25229!)
        Me.xrFirstName.Name = "xrFirstName"
        Me.xrFirstName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrFirstName.SizeF = New System.Drawing.SizeF(180.1509!, 23.0!)
        '
        'xrDiagnosis
        '
        Me.xrDiagnosis.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.Diagnosis")})
        Me.xrDiagnosis.LocationFloat = New DevExpress.Utils.PointFloat(147.7294!, 183.2523!)
        Me.xrDiagnosis.Name = "xrDiagnosis"
        Me.xrDiagnosis.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrDiagnosis.SizeF = New System.Drawing.SizeF(180.1509!, 23.0!)
        '
        'xrDOB
        '
        Me.xrDOB.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.DOB")})
        Me.xrDOB.LocationFloat = New DevExpress.Utils.PointFloat(403.75!, 48.54396!)
        Me.xrDOB.Name = "xrDOB"
        Me.xrDOB.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrDOB.SizeF = New System.Drawing.SizeF(306.1926!, 23.0!)
        '
        'xrDOMilitary
        '
        Me.xrDOMilitary.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.DOMilitary")})
        Me.xrDOMilitary.LocationFloat = New DevExpress.Utils.PointFloat(403.75!, 114.3356!)
        Me.xrDOMilitary.Name = "xrDOMilitary"
        Me.xrDOMilitary.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrDOMilitary.SizeF = New System.Drawing.SizeF(306.1926!, 23.0!)
        '
        'xrCheckByMinistry
        '
        Me.xrCheckByMinistry.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.CheckByMinistry")})
        Me.xrCheckByMinistry.LocationFloat = New DevExpress.Utils.PointFloat(403.75!, 183.2523!)
        Me.xrCheckByMinistry.Name = "xrCheckByMinistry"
        Me.xrCheckByMinistry.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrCheckByMinistry.SizeF = New System.Drawing.SizeF(306.1926!, 23.0!)
        '
        'xrDoctorComment
        '
        Me.xrDoctorComment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.DoctorComment")})
        Me.xrDoctorComment.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 284.3178!)
        Me.xrDoctorComment.Name = "xrDoctorComment"
        Me.xrDoctorComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrDoctorComment.SizeF = New System.Drawing.SizeF(719.7343!, 110.4999!)
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 249.9428!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(250.2294!, 22.99998!)
        Me.XrLabel10.Text = "ექიმის კომენტარი"
        '
        'XrLabel9
        '
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(403.75!, 147.7523!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(250.2294!, 23.0!)
        Me.XrLabel9.Text = "შემოწმებულია სამინისტროს მიერ"
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(403.75!, 79.87728!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(250.2294!, 23.0!)
        Me.XrLabel8.Text = "გაწვევის თარიღი"
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(403.75!, 18.25229!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(250.2294!, 23.0!)
        Me.XrLabel7.Text = "დაბადების თარიღი"
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(9.99999!, 183.2523!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(121.0627!, 23.0!)
        Me.XrLabel6.Text = "დიაგნოზი"
        '
        'XrLabel5
        '
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(9.99999!, 147.7523!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(121.0627!, 23.0!)
        Me.XrLabel5.Text = "სამხედრო წოდება"
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(9.99999!, 114.3356!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(121.0627!, 23.0!)
        Me.XrLabel4.Text = "სამხედრო ნაწილი"
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(9.99999!, 79.87728!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(121.0627!, 23.0!)
        Me.XrLabel3.Text = "მამის სახელი"
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(9.99999!, 48.54396!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(121.0627!, 23.0!)
        Me.XrLabel2.Text = "გვარი"
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 18.25229!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(121.0627!, 23.0!)
        Me.XrLabel1.Text = "სახელი"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 43.80735!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 31.69562!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "DataSet"
        Me.Ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ds2
        '
        Me.Ds2.DataSetName = "DataSet"
        Me.Ds2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XtraReport2
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataSourceSchema = resources.GetString("$this.DataSourceSchema")
        Me.Font = New System.Drawing.Font("Sylfaen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 44, 32)
        Me.Version = "15.2"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents xrMilitaryRank As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLastName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrFatherName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrMilitaryUnit As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrFirstName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrDiagnosis As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrDOB As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrDOMilitary As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrCheckByMinistry As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrDoctorComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataSet1 As ds
    Friend WithEvents Ds1 As ds
    Friend WithEvents Ds2 As ds
End Class
