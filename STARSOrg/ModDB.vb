﻿Imports System.Data.SqlClient
Module ModDB
    'Connection string for LocalDb
    Public Const gstrConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Oliver\Desktop\FIU\Windows\STARSOrgTeamProject\STARSOrg\StarsOrg.mdf;Integrated Security=True"
    'Database objects
    Public objSQLConn As SqlConnection 'connection object
	Public objSQLCommand As SqlCommand ' command object
	Public objSQLDR As SqlDataReader
End Module
