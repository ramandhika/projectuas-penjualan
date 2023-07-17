Imports System.Data.SqlClient
Partial Class insertProduk
    Inherits System.Web.UI.Page

    'Deklarasi Koneksi
    Dim cn As SqlConnection = Nothing
    Dim cnsql As String = ConfigurationManager.ConnectionStrings("consql").ConnectionString
    Private Sub TampilData()
        cn = New SqlConnection(cnsql)
        Try
            cn.Open()
            Dim sql As String = "SELECT * FROM Produk"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim data As SqlDataReader = cmd.ExecuteReader
            Dim tmp As String = "<table class='table table-striped mt-3' style='width: 1100px;'>"
            tmp = tmp & "<tr class='text-center'><th>Kode</th>"
            tmp = tmp & "<th class='text-start'>Nama Produk</th>"
            tmp = tmp & "<th>Harga</th>"
            tmp = tmp & "<th>Stok</th>"
            tmp = tmp & "<th>Diskon</th>"
            tmp = tmp & "<th colspan=2 class='text-center w-25'>Aksi</th></tr>"

            If data.HasRows Then
                While (data.Read)
                    tmp = tmp & "<tr>"
                    tmp = tmp & "<td class='text-center'>" & data.GetString(0) & "</td>"
                    tmp = tmp & "<td>" & data.GetString(1) & "</td>"
                    tmp = tmp & "<td class='text-center'>" & data.GetInt32(2) & "</td>"
                    tmp = tmp & "<td class='text-center'>" & data.GetInt32(4) & "</td>"
                    tmp = tmp & "<td class='text-center'>" & data.GetInt32(3) & "%" & "</td>"
                    tmp = tmp & "<td align='center'><a href=editProduk.aspx?kode=" & data.GetString(0) & " class='btn btn-sm btn-warning fw-bold'><i class='fa-regular fa-pen-to-square'></i> EDIT</a></td>"
                    tmp = tmp & "<td align='center'><a href=deleteProduk.aspx?kode=" & data.GetString(0) & " class='btn btn-sm btn-danger fw-bold'><i class='fa-regular fa-trash-can'></i> HAPUS</a></td>"
                    tmp = tmp & "</tr>"
                End While
                tmp = tmp & "</table>"
                dataProduk.InnerHtml = tmp
            End If
        Catch ex As Exception
            Response.Write("Ada Kesalahan akses database :" & ex.Message)
        Finally
            cn.Close()
            cn = Nothing
        End Try
    End Sub
    Protected Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        cn = New SqlConnection(cnsql)

        Try
            cn.Open()
            Dim diskon As Integer = 0
            If Not String.IsNullOrEmpty(tbDiskon.Text) Then
                Integer.TryParse(tbDiskon.Text, diskon)
            End If
            Dim finalHarga As Integer = tbHarga.Text * (100 - diskon) / 100
            Dim sql As String = "INSERT INTO Produk(Kode,NamaProduk,Harga,Diskon,Stok)"
            sql = sql & " VALUES ('" & tbKode.Text & "','" & tbNama.Text & "','" & finalHarga & "','" & tbDiskon.Text & "','" & tbStok.Text & "') "

            'buat obyek command untuk mengeksekusi perintah sql
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim jmlrec As Integer = cmd.ExecuteNonQuery
            If jmlrec > 0 Then
                lbPesan.Text = "<div class='alert alert-success' role='alert'>Input Data Produk Berhasil!</div>"
                Response.AddHeader("REFRESH", "2;URL=insertProduk.aspx")
            Else
                lbPesan.Text = "<div class='alert alert-danger' role='alert'>Input Data Produk Gagal!</div>"
            End If
        Catch ex As Exception
            lbPesan.Text = "<div class='alert alert-danger' role='alert'>Koneksi Mati!</div>"
        Finally
            cn.Close()
            cn = Nothing
            tbNama.Text = ""
            tbKode.Text = ""
            tbStok.Text = ""
            tbHarga.Text = ""
            tbDiskon.Text = ""
        End Try
    End Sub

    Protected Sub btKembali_Click(sender As Object, e As EventArgs) Handles btKembali.Click
        Response.Redirect("home.aspx")
    End Sub

    Protected Sub btTampil_Click(sender As Object, e As EventArgs) Handles btTampil.Click
        TampilData()
    End Sub
End Class
