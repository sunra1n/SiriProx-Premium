'WOOOOOOAAAAW
'Background Module for SiriProx 0.3 by @validati0n
'MASTER THX to @sunra1n_ for all other nice things !
'So what you get here_
'-Delay()
'-SaveTextToFile() <- by sunra1n (?)
'-isSpireInstalled()
'-myhwid


'WARNING OBFUSCATE THE COMPILED FILE VERY(!!!!) IMPORTANT TO SAVE MYSQL INFO'S
'Last 
Option Strict On
Imports System.IO
Imports System.Management
Imports MySql.Data.MySqlClient
Module background
    Public PremiumErrorCode As String = ""
    Public pudid As String = ""
    Public Function SaveTextToFile(ByVal strData As String, ByVal FullPath As String, Optional ByVal ErrInfo As String = "") As Boolean
        Dim bAns As Boolean = False, objReader As StreamWriter
        Try
            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
        Return bAns
    End Function
    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop
    End Sub

    Public ReadOnly Property myhwid As String
        Get
            Dim strProcessorId As String = String.Empty
            Dim query As New SelectQuery("Win32_processor")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject
            For Each info In search.Get()
                strProcessorId = info("processorId").ToString()
            Next
            Return strProcessorId
        End Get
    End Property
    'add your mysql server details here !
    Public ReadOnly Property getbestServerId As Integer
        Get
            Dim anzahlS1 As Integer
            Dim anzahlS2 As Integer
            Dim conn As MySqlConnection
            conn = New MySqlConnection
            conn.ConnectionString = "server=MYSQL SERVER;" _
                                             & "user id=USERNAME;" _
                                             & "password=USERPASSWORD;" _
                                             & "database=DATABASENAME"
            Try
                conn.Open()
            Catch myerror As MySqlException
                Return 0
                Exit Property
            End Try
            Dim sqls1 As String = "SELECT COUNT(*) FROM siriprox WHERE serverid =  '1'"
            Dim sqls2 As String = "SELECT COUNT(*) FROM siriprox WHERE serverid =  '2'"

            Dim myCommand As New MySqlCommand
            myCommand.Connection = conn

            myCommand.CommandText = sqls1
            anzahlS1 = CInt(myCommand.ExecuteScalar)

            myCommand.CommandText = sqls2
            anzahlS2 = CInt(myCommand.ExecuteScalar)

            If anzahlS1 > anzahlS2 Then
                Return 2
            ElseIf anzahlS1 < anzahlS2 Then
                Return 1
            Else
                Return 1
            End If
        End Get
    End Property

    Public Function SetServerIDtoUDID(ByVal serverid As Integer) As Boolean
        If pudid.Length = 40 Then
        Else
            Return False
            Exit Function
        End If
        Dim conn As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "server=MYSQL SERVER;" _
                                             & "user id=USERNAME;" _
                                             & "password=USERPASSWORD;" _
                                             & "database=DATABASENAME"
        Try
            conn.Open()
        Catch myerror As MySqlException
            Return False
            Exit Function
        End Try
        Dim myAdapter As New MySqlDataAdapter
        Dim SQLAbfrage As String = "UPDATE  `DATABASENAME`.`siriprox` SET  `ServerID` =  '" & serverid & "' WHERE `siriprox`.`udid` = '" & pudid & "'"
        Dim myCommand As New MySqlCommand
        myCommand.Connection = conn
        myCommand.CommandText = SQLAbfrage
        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader()
        If CInt(myData.HasRows) = 0 Then
            conn.Close()
            Return True
        Else
            Return False
            Exit Function
        End If
    End Function

    Public Function isSpireinstalled(ByVal iDevice As MobileDevice.iPhone) As Boolean
        If iDevice.IsJailbreak = False Then
            Return False
            Exit Function
        End If
        Dim ergebnis As Boolean
        Try
            ergebnis = iDevice.IsFile("/var/mobile/Library/Preferences/com.chpwn.spire.preferences.plist")
        Catch ex As Exception
            ergebnis = False
        End Try
        Return ergebnis
    End Function

    Public Function isPremium(ByVal iDevice As MobileDevice.iPhone) As Boolean
        PremiumErrorCode = ""
        Dim conn As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "server=MYSQL SERVER;" _
                                          & "user id=USERNAME;" _
                                          & "password=USERPASSWORD;" _
                                          & "database=DATABASENAME"

        Try
            conn.Open()
        Catch myerror As MySqlException
            Return False
            PremiumErrorCode = myerror.Message
            Exit Function
        End Try
        Dim hwidt As String = myhwid
        Dim udidt As String = iDevice.DeviceId
        pudid = udidt
        If udidt.Length < 5 Then
            PremiumErrorCode = "wrongudid"
            Return False
            Exit Function
        End If

        Dim myAdapter As New MySqlDataAdapter
        Dim SQLAbfrage As String = "SELECT * FROM siriprox WHERE udid='" & udidt & "' AND hwid='" & hwidt & "'"
        Dim myCommand As New MySqlCommand
        myCommand.Connection = conn
        myCommand.CommandText = SQLAbfrage

        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader()
        If myData.HasRows Then 'right
            Return True
        Else 'wrong
            PremiumErrorCode = "notindb"
            Return False
        End If
    End Function
End Module
