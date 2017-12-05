Imports System.Data.SqlClient
Module ModDB
    'Connection string for LocalDb
    Public Const gstConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\KGARC045\SOURCE\REPOS\STARSORG\STARSDB.MDF"
    'Database objects
    Public objSQLConn As SqlConnection 'connection object
    Public objSQLCommand As SqlCommand ' command object
    Public objSQLDR As SqlDataReader
End Module
