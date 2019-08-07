Public Class AddForm
    Dim m As New PersonalModel
    Dim h As New PersonalHandler

    Public Property PersonalID As Integer
    Public Property FirstName() As String
        Get
            Return txtFirstName.Text
        End Get
        Set(value As String)
            txtFirstName.Text = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return txtLastName.Text
        End Get
        Set(value As String)
            txtLastName.Text = value
        End Set
    End Property

    Public Property FatherName() As String
        Get
            Return txtFatherName.Text
        End Get
        Set(value As String)
            txtFatherName.Text = value
        End Set
    End Property

    Public Property MilitaryUnit() As String
        Get

            Return txtMilitaryUnit.Text
        End Get
        Set(value As String)
            txtMilitaryUnit.Text = value
        End Set
    End Property
    Public Property MilitaryRank() As String
        Get
            Return txtMilitaryRank.Text
        End Get
        Set(value As String)
            txtMilitaryRank.Text = value
        End Set
    End Property

    Public Property Diagnosis() As String
        Get
            Return txtDiagnosis.Text
        End Get
        Set(value As String)
            txtDiagnosis.Text = value
        End Set
    End Property

    Public Property DOB() As DateTime
        Get
            Return dtpDOB.Value
        End Get
        Set(value As DateTime)
            dtpDOB.Value = value
        End Set
    End Property

    Public Property DOMilitary() As DateTime
        Get
            Return dtpDOMilitary.Value
        End Get
        Set(value As DateTime)
            dtpDOMilitary.Value = value
        End Set
    End Property

    Public Property CheckByMinistry() As DateTime
        Get
            Return dtpCheckByMinistry.Value
        End Get
        Set(value As DateTime)
            dtpCheckByMinistry.Value = value
        End Set
    End Property

    Public Property DoctorComment() As String
        Get
            Return txtDoctorComment.Text
        End Get
        Set(value As String)
            txtDoctorComment.Text = value
        End Set
    End Property
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        m.FirstName = FirstName
        m.LastName = LastName
        m.FatherName = FatherName
        m.MilitaryUnit = MilitaryUnit
        m.MilitaryRank = MilitaryRank
        m.Diagnosis = Diagnosis
        m.DOB = DOB
        m.DOMilitary = DOMilitary
        m.CheckByMinistry = CheckByMinistry
        m.DoctorComment = DoctorComment

        Dim ph As New PersonalHandler(m)
        PersonalID = ph.PersonalSet()

        MsgBox("მონაცემი წარმატებით შეინახა", MsgBoxStyle.Information)


        Close()
    End Sub

    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PersonalID > 0 Then
            Me.Text = "პერსონალის რედაქტირება"
            m = h.PersonalGet(PersonalID)
            FirstName = m.FirstName
            LastName = m.LastName
            FatherName = m.FatherName
            MilitaryUnit = m.MilitaryUnit
            MilitaryRank = m.MilitaryRank
            Diagnosis = m.Diagnosis
            DOB = m.DOB
            DOMilitary = m.DOMilitary
            CheckByMinistry = m.CheckByMinistry
            DoctorComment = m.DoctorComment
        End If
    End Sub
End Class