Imports Microsoft.VisualBasic

Public Class login
    Private Username As String
    Private Password As String
    Private Nama As String

    Public Sub New()
        Username = ""
        Password = ""
        Nama = ""
    End Sub

    Public Sub setPengguna(ByVal nma As String, ByVal usr As String, ByVal pass As String)
        Nama = nma
        Username = usr
        Password = pass
    End Sub

    Public Function getUsername() As String
        Return Username
    End Function

    Public Function getPassword() As String
        Return Password
    End Function

    Public Function getNama() As String
        Return Nama
    End Function
End Class
