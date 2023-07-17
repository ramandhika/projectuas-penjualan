Imports System.Data.SqlClient
Partial Class editPegawai
    Inherits System.Web.UI.Page

    'Deklarasi Koneksi
    Dim cn As SqlConnection = Nothing
    Dim cnsql As String = ConfigurationManager.ConnectionStrings("consql").ConnectionString

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Request.Params("kode") <> "" Then
                tbKode.Text = Request.Params("kode")
            Else
                Response.Redirect("insertPegawai.aspx")
            End If

            cn = New SqlConnection(cnsql)
            Try
                cn.Open()
                Dim sql As String = "SELECT * FROM Pegawai WHERE Kode='" & tbKode.Text & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim reader As SqlDataReader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    tbNama.Text = reader.GetString(1)
                    tbUser.Text = reader.GetString(2)
                    tbPass.Text = reader.GetString(3)
                Else
                    lbPesan.Text = "<div class='alert alert-danger' role='alert'>Tidak ditemukan record yang dicari!</div>"
                End If
                reader.Close()
            Catch ex As Exception
                lbPesan.Text = "<div class='alert alert-danger' role='alert'> Error: " & ex.Message & "</div>"
            Finally
                cn.Close()
                cn = Nothing
            End Try
        End If
    End Sub

    Protected Sub btKembali_Click(sender As Object, e As EventArgs) Handles btKembali.Click
        Response.Redirect("insertPegawai.aspx")
    End Sub

    Protected Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        cn = New SqlConnection(cnsql)
        Try
            cn.Open()
            Dim sql As String = "UPDATE Pegawai SET Nama='" & tbNama.Text & "', Username='" & tbUser.Text & "', Password='" & tbPass.Text & "' "
            sql = sql & " WHERE Kode='" & tbKode.Text & "'"

            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim jmlrec As Integer = cmd.ExecuteNonQuery
            If jmlrec > 0 Then
                lbPesan.Text = "<div class='alert alert-success' role='alert'>Update Data Pegawai Berhasil!</div>"
                Response.AddHeader("REFRESH", "2;URL=insertPegawai.aspx")
            Else
                lbPesan.Text = "<div class='alert alert-danger' role='alert'>Update Data Pegawai Gagal!</div>"
            End If
        Catch ex As Exception
            lbPesan.Text = "<div class='alert alert-danger' role='alert'> Error: " & ex.Message & "</div>"
        Finally
            cn.Close()
            cn = Nothing
        End Try
    End Sub
End Class
