Imports System.Data.SqlClient
Public Class CDB
    Public Function OpenDB() As Boolean
        objSQLCommand = New SqlCommand 'instantiate the command object 
        Dim blnResult As Boolean = False
        If objSQLConn Is Nothing Then
            Try
                objSQLConn = New SqlConnection(gstConn)
                objSQLConn.Open()
                blnResult = True

            Catch exOpenConnError As Exception
                MessageBox.Show(exOpenConnError.ToString, "Connectino Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnResult = False 'should error log this better
            End Try
            Return blnResult

        Else ' we have a connection object so let's check its state
            If objSQLConn.State = ConnectionState.Open Then
                Return True
            Else

                Return False

            End If

        End If
        Return blnResult
    End Function

    Public Sub CloseDB()
        Try
            objSQLConn.Close()
        Catch ex As Exception
            MessageBox.Show("error attempting to close db: " & ex.ToString, "DataBase error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetDataReaderBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataReader
        If Not OpenDB() Then
            'error log this better
            Return Nothing

        End If
        Dim sqlComm As New SqlCommand(strSP, objSQLConn) 'command object needs the command and the connection
        sqlComm.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                sqlComm.Parameters.Add(p)
            Next
        End If
        Try
            Return sqlComm.ExecuteReader ' ask for a sql data reader to be returned
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return Nothing
    End Function

    Friend Function GetSingleValueFromSP(strSP As String, ByRef params As ArrayList) As String
        Dim dr As SqlDataReader = GetDataReaderBySP(strSP, params)
        Dim strResult As String
        If Not dr Is Nothing Then
            If dr.Read() Then
                strResult = dr.GetValue(0).ToString
                dr.Close()
                Return strResult
            Else
                dr.Close()
                Return -1 'no Data
            End If
        End If
        Return -2 'failed to connect to db
    End Function

    Public Function GetDataAdapterBySp(ByVal strSP As String, ByRef params As ArrayList) As SqlDataAdapter
        If Not OpenDB() Then
            'error log this better
            Return Nothing
        End If
        Dim sqlComm As New SqlCommand(strSP, objSQLConn) 'command object needs the command and the connection
        Dim sqlDA As SqlDataAdapter
        sqlComm.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                sqlComm.Parameters.Add(p)
            Next
        End If
        Try
            sqlDA = New SqlDataAdapter(sqlComm)
            Return sqlDA

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return Nothing
    End Function
    Public Function ExecSP(ByVal strSP As String, ByRef params As ArrayList) As Integer
        If Not OpenDB() Then
            Return -1
        End If
        Dim sqlComm As New SqlCommand(strSP, objSQLConn)
        sqlComm.CommandType = CommandType.StoredProcedure
        Try
            If Not params Is Nothing Then
                For Each p As SqlParameter In params
                    sqlComm.Parameters.Add(p)
                Next
            End If
            Return sqlComm.ExecuteNonQuery
        Catch ex As Exception
            Return -1
        End Try

        Return 0
    End Function
End Class
