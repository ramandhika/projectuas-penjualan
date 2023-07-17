Imports System.Data.SqlClient
Partial Class _Default
    Inherits System.Web.UI.Page

    'Deklarasi Koneksi
    Dim cn As SqlConnection = Nothing
    Dim cnsql As String = ConfigurationManager.ConnectionStrings("consql").ConnectionString

    Protected Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        cn = New SqlConnection(cnsql)
        Try
            cn.Open()
            Dim sql As String = "SELECT * FROM Pegawai WHERE Username='" & tbUsrid.Text & "' AND Password='" & tbPaswd.Text & "'"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                Dim usr As login = New login
                usr.setPengguna(reader.GetString(1), reader.GetString(2), reader.GetString(3))

                'Session data kelas Pengguna (User)
                Session("usr") = usr

                'Lompat ke halaman Home
                Response.Redirect("Home.aspx")

            Else
                lbPesan.Text = "<div class='alert alert-danger' role='alert'>Username ID dan Password tidak ditemukan</div>"
            End If
            reader.Close()
        Catch ex As Exception
            lbPesan.Text = "<div class='alert alert-danger' role='alert'>Error : " & ex.Message & "</div>"
        Finally
            cn.Close()
            cn = Nothing
        End Try
    End Sub
End Class
