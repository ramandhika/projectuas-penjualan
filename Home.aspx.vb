Imports System.Data.SqlClient
Partial Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Session("usr") Is Nothing Then
            Dim usr As login = Session("usr")
            lbNama.Text = usr.getNama
        End If
    End Sub
End Class
