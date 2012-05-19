Imports Tamir.SharpSsh

Public Class SecureFileTransfer

    Private WithEvents transfer As Sftp
    Private _hostname As String
    Private _port As Integer
    Private _username As String
    Private _password As String

    Public Event onTransferStart(ByVal source As String, ByVal destination As String, ByVal transferredBytes As Integer, ByVal totalBytes As Integer, ByVal message As String)
    Public Event onTransferProgress(ByVal source As String, ByVal destination As String, ByVal transferredBytes As Integer, ByVal totalBytes As Integer, ByVal message As String)
    Public Event onTransferEnd(ByVal source As String, ByVal destination As String, ByVal transferredBytes As Integer, ByVal totalBytes As Integer, ByVal message As String)

    Public Sub New(ByVal hostname As String, ByVal port As Integer, ByVal username As String, ByVal password As String)
        Me._hostname = hostname
        Me._port = port
        Me._username = username
        Me._password = password
    End Sub

    Public Function getFile(ByVal remotePath As String, ByVal localFile As String) As Boolean
        Try
            transfer = New Sftp(Me._hostname, Me._username, Me._password)
            transfer.Connect(Me._port)
            transfer.Get(remotePath, localFile)
            transfer.Close()
            Return True
        Catch ex As Exception
            Debug.Print("Error downloading file: " & ex.ToString)
            Return False
        End Try
    End Function

    Public Function putFile(ByVal localFile As String, ByVal remotePath As String) As Boolean
        Try
            transfer = New Sftp(Me._hostname, Me._username, Me._password)
            transfer.Connect(Me._port)
            transfer.Put(localFile, remotePath)
            transfer.Close()
            Return True
        Catch ex As Exception
            Debug.Print("Error uploading file: " & ex.ToString)
            Return False
        End Try
    End Function

    Public Function getDirectoryList(ByVal remotePath As String) As ArrayList
        Dim response As New ArrayList
        Try
            transfer = New Sftp(Me._hostname, Me._username, Me._password)
            transfer.Connect(Me._port)
            response = transfer.GetFileList(remotePath)
            transfer.Close()
        Catch ex As Exception
            Debug.Print("Error getting directory list: " & ex.ToString)
        End Try
        Return response
    End Function

    Private Sub _onTransferStart(ByVal source As String, ByVal destination As String, ByVal transferredBytes As Integer, ByVal totalBytes As Integer, ByVal message As String) Handles transfer.OnTransferStart
        RaiseEvent onTransferStart(source, destination, transferredBytes, totalBytes, message)
    End Sub

    Private Sub _onTransferProgress(ByVal source As String, ByVal destination As String, ByVal transferredBytes As Integer, ByVal totalBytes As Integer, ByVal message As String) Handles transfer.OnTransferProgress
        RaiseEvent onTransferProgress(source, destination, transferredBytes, totalBytes, message)
    End Sub

    Private Sub _onTransferEnd(ByVal source As String, ByVal destination As String, ByVal transferredBytes As Integer, ByVal totalBytes As Integer, ByVal message As String) Handles transfer.OnTransferEnd
        RaiseEvent onTransferEnd(source, destination, transferredBytes, totalBytes, message)
    End Sub

End Class
