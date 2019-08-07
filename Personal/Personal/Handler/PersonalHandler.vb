Imports System.Data.SqlClient

Public Class PersonalHandler
    Public Sub New()

    End Sub

    Public Sub New(ByRef model As PersonalModel)
        _model = model
    End Sub
    Dim _model As New PersonalModel
    Public Function PersonalListGet() As DataTable
        Dim dt As New DataTable
        Using plg As New SqlDataAdapter("dbo.PersonalListGet", Connection.getConnection())
            plg.SelectCommand.CommandType = CommandType.StoredProcedure
            plg.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function PersonalRecycle() As DataTable
        Dim dt As New DataTable
        Using plg As New SqlDataAdapter("dbo.PersonalRecycle", Connection.getConnection())
            plg.SelectCommand.CommandType = CommandType.StoredProcedure
            plg.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function PersonalSet() As Integer
        Dim recordID As Integer
        Using ps As New SqlCommand("dbo.PersonalSet", Connection.getConnection())
            ps.CommandType = CommandType.StoredProcedure
            ps.Parameters.AddWithValue("@PersonalID", _model.PersonalID)
            ps.Parameters.AddWithValue("@FirstName", _model.FirstName)
            ps.Parameters.AddWithValue("@LastName", _model.LastName)
            ps.Parameters.AddWithValue("@FatherName", _model.FatherName)
            ps.Parameters.AddWithValue("@MilitaryUnit", _model.MilitaryUnit)
            ps.Parameters.AddWithValue("@MilitaryRank", _model.MilitaryRank)
            ps.Parameters.AddWithValue("@Diagnosis", _model.Diagnosis)
            ps.Parameters.AddWithValue("@DOB", _model.DOB)
            ps.Parameters.AddWithValue("@DOMilitary", _model.DOMilitary)
            ps.Parameters.AddWithValue("@CheckByMinistry", _model.CheckByMinistry)
            ps.Parameters.AddWithValue("@DoctorComment", _model.DoctorComment)
            ps.Connection.Open()
            recordID = ps.ExecuteScalar()
        End Using
        Return recordID
    End Function

    Public Function PersonalGet(recordID As Integer) As PersonalModel
        Dim dt As New DataTable
        Using pg As New SqlDataAdapter("dbo.PersonalGet", Connection.getConnection())
            pg.SelectCommand.CommandType = CommandType.StoredProcedure
            pg.SelectCommand.Parameters.AddWithValue("@PersonalID", recordID)
            pg.Fill(dt)
        End Using
        Dim m As New PersonalModel
        m.PersonalID = dt.Rows(0)("PersonalID")
        m.FirstName = dt.Rows(0)("FirstName").ToString()
        m.LastName = dt.Rows(0)("LastName").ToString()
        m.FatherName = dt.Rows(0)("FatherName").ToString()
        m.MilitaryUnit = dt.Rows(0)("MilitaryUnit")
        m.MilitaryRank = dt.Rows(0)("MilitaryRank").ToString()
        m.Diagnosis = dt.Rows(0)("Diagnosis").ToString()
        m.DOB = dt.Rows(0)("DOB")
        m.DOMilitary = dt.Rows(0)("DOMilitary")
        m.CheckByMinistry = dt.Rows(0)("CheckByMinistry")
        m.DoctorComment = dt.Rows(0)("DoctorComment").ToString()
        Return m

    End Function

    Public Function PersonalRemove(personalID As Integer)
        Using pr As New SqlCommand("dbo.PersonalRemove", Connection.getConnection())
            pr.CommandType = CommandType.StoredProcedure
            pr.Parameters.AddWithValue("@PersonalID", personalID)
            pr.Connection.Open()
            pr.ExecuteScalar()
        End Using
        Return personalID
    End Function

    Public Function PersonalRecover(personalID As Integer)
        Using pr As New SqlCommand("dbo.PersonalRecover", Connection.getConnection())
            pr.CommandType = CommandType.StoredProcedure
            pr.Parameters.AddWithValue("@PersonalID", personalID)
            pr.Connection.Open()
            pr.ExecuteScalar()
        End Using
        Return personalID
    End Function


    Public Function PersonalPrint(personalID As Integer) As DataSet
        Dim ds As New ds
        Using pp As New SqlDataAdapter("dbo.PersonalPrint", Connection.getConnection())
            pp.SelectCommand.CommandType = CommandType.StoredProcedure
            pp.SelectCommand.Parameters.AddWithValue("@PersonalID", personalID)
            pp.TableMappings.Add("Table", ds.dt.TableName)
            pp.Fill(ds)
        End Using
        Return ds
    End Function
End Class
