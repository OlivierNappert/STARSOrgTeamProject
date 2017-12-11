Module modGlobal
    'contains all variables, constants, procedures, and functions that need to 
    'be accessed in more than one form
    'modules are just code that can be used from any form, for a class you need to make a new object
    Public Const ACTION_NONE As Integer = 0
    Public Const ACTION_HOME As Integer = 1
    Public Const ACTION_MEMBER As Integer = 2
    Public Const ACTION_ROLE As Integer = 3
    Public Const ACTION_EVENT As Integer = 4
    Public Const ACTION_RSVP As Integer = 5
    Public Const ACTION_COURSE As Integer = 6
    Public Const ACTION_SEMESTER As Integer = 7
    Public Const ACTION_HELP As Integer = 8
    Public Const ACTION_TUTOR As Integer = 9
    Public Const ACTION_LOGOUT As Integer = 10
    Public intNextAction As Integer
    Public myDB As New CDB
    Public CurrentSemesterID As String = "fa17"
	Public strCurrUserPID As String
	Public strCurrUserUserID As String
	Public strCurrUserSecRole As String





End Module
