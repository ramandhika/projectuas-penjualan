
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("usr") Is Nothing Then
            Response.Redirect("Default.aspx")
            Exit Sub
        End If
    End Sub
End Class

