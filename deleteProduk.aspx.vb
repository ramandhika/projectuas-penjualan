Imports System.Data.SqlClient
Partial Class deleteProduk
    Inherits System.Web.UI.Page

    'Deklarasi Koneksi
    Dim cn As SqlConnection = Nothing
    Dim cnsql As String = ConfigurationManager.ConnectionStrings("consql").ConnectionString
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbKode.Text = Request.Params("kode")
    End Sub

    Protected Sub btTidak_Click(sender As Object, e As EventArgs) Handles btTidak.Click
        Response.Redirect("insertProduk.aspx")
    End Sub

    Protected Sub btYa_Click(sender As Object, e As EventArgs) Handles btYa.Click
        cn = New SqlConnection(cnsql)
        Try
            cn.Open()
            Dim sql As String = "DELETE FROM Produk WHERE Kode='" & lbKode.Text & "' "

            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim jmlrec As Integer = cmd.ExecuteNonQuery
            Response.Redirect("insertProduk.aspx")
        Catch ex As Exception
            Response.Write("Ada Kesalahan koneksi ke database!")
        Finally
            cn.Close()
        End Try
    End Sub
End Class
