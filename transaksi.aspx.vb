Imports System.Data.SqlClient
Partial Class transaksi
    Inherits System.Web.UI.Page

    ' Deklarasi Koneksi
    Dim cn As SqlConnection = Nothing
    Dim cnsql As String = ConfigurationManager.ConnectionStrings("consql").ConnectionString

    ' Deklarasi list alat untuk menampung banyak data alat
    Dim ListBarang As List(Of trans) = New List(Of trans)

    Private Sub TampilData()
        If Not IsPostBack Then
            cn = New SqlConnection(cnsql)
            cn.Open()

            ' Memuat Alat Kemah dengan ketentuan stok lebih dari 0
            Dim sql = "SELECT * FROM Produk WHERE Stok > 0"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim reader As SqlDataReader = cmd.ExecuteReader

            ddBarang.Items.Clear()
            ddBarang.Items.Add(New ListItem("Pilih Produk yang Tersedia", Nothing))

            If reader.HasRows Then
                While reader.Read
                    ddBarang.Items.Add(New ListItem(reader.GetString(0) & " | " & reader.GetString(1) & " | Rp." & reader.GetInt32(2) & " | Diskon : " & reader.GetInt32(3) & "% | " & "Jumlah Stok : " & reader.GetInt32(4) & " ", reader.GetString(0)))
                End While
            End If
            reader.Close()

            ' Memanggil semua data dari tabel pegawai
            sql = "SELECT * FROM Pegawai"
            cmd = New SqlCommand(sql, cn)
            reader = cmd.ExecuteReader

            ddPegawai.Items.Clear()
            ddPegawai.Items.Add(New ListItem("Daftar Pegawai", Nothing))

            If reader.HasRows Then
                While reader.Read
                    ddPegawai.Items.Add(New ListItem(reader.GetString(0) & " | Nama: " & reader.GetString(1), reader.GetString(0)))
                End While
            End If
            reader.Close()
            cn.Close()
            cn = Nothing
        End If
    End Sub

    Private Sub TampilMK()
        ' Hapus semua baris dari tabel
        tblDatBarang.Rows.Clear()

        ' Buat baris judul
        Dim barisjudul As TableRow = New TableRow()
        barisjudul.TableSection = TableRowSection.TableHeader

        ' Buat cell-cell baris judul
        Dim judul1 As TableCell = New TableCell
        judul1.Text = "Kode Produk"
        barisjudul.Cells.Add(judul1)

        Dim judul2 As TableCell = New TableCell
        judul2.Text = "Nama Produk"
        barisjudul.Cells.Add(judul2)

        Dim judul3 As TableCell = New TableCell
        judul3.Text = "Stok"
        barisjudul.Cells.Add(judul3)

        Dim judul4 As TableCell = New TableCell
        judul4.Text = "Diskon Awal"
        barisjudul.Cells.Add(judul4)

        Dim judul5 As TableCell = New TableCell
        judul5.Text = "Harga Produk"
        barisjudul.Cells.Add(judul5)

        Dim judul6 As TableCell = New TableCell
        judul6.Text = "Total Harga Setelah Diskon"
        barisjudul.Cells.Add(judul6)


        ' Tambahkan baris judul ke tabel induk
        tblDatBarang.Rows.Add(barisjudul)

        ' Membaca data dari session ListAlat
        ListBarang = Session("ListBarang")
        Dim totharga As Integer = 0

        ' membuat variabel diskon dan mengecek apakah tbDiskon.text terisi atau tidak
        Dim diskon As Integer = 0
        If Not String.IsNullOrEmpty(tbDiskon.Text) Then
            Integer.TryParse(tbDiskon.Text, diskon)
        End If

        For i = 0 To ListBarang.Count - 1
            Dim barisdata As TableRow = New TableRow()
            barisdata.TableSection = TableRowSection.TableBody

            ' Isikan data ke sel-sel baris
            Dim data1 As TableCell = New TableCell
            data1.Text = ListBarang.Item(i).getKode()
            barisdata.Cells.Add(data1)

            Dim data2 As TableCell = New TableCell
            data2.Text = ListBarang.Item(i).getNama()
            barisdata.Cells.Add(data2)

            Dim data3 As TableCell = New TableCell
            data3.Text = CStr(ListBarang.Item(i).getStok())
            barisdata.Cells.Add(data3)

            Dim data4 As TableCell = New TableCell
            data4.Text = CStr(ListBarang.Item(i).getDiskon()) & "%"
            barisdata.Cells.Add(data4)

            Dim data5 As TableCell = New TableCell
            data5.Text = CStr(ListBarang.Item(i).getHarga())
            barisdata.Cells.Add(data5)

            Dim data6 As TableCell = New TableCell
            data6.Text = CStr(ListBarang.Item(i).getHarga() * (100 - diskon) / 100)
            barisdata.Cells.Add(data6)

            ' Tambahkan barisdata ke tabel induk
            tblDatBarang.Rows.Add(barisdata)

            Dim finalHarga As Integer = ListBarang.Item(i).getHarga() * (100 - diskon) / 100
            totharga += finalHarga

        Next

        ' Buat baris footer
        Dim barisfooter As TableRow = New TableRow()
        barisfooter.TableSection = TableRowSection.TableFooter

        ' Buat cell footer
        Dim cf1 As TableCell = New TableCell()
        cf1.Text = "Total Harga"
        barisfooter.Cells.Add(cf1)

        Dim cf2 As TableCell = New TableCell()
        cf2.Text = ""
        barisfooter.Cells.Add(cf2)

        Dim cf3 As TableCell = New TableCell()
        cf3.Text = ""
        barisfooter.Cells.Add(cf3)

        Dim cf4 As TableCell = New TableCell()
        cf4.Text = ""
        barisfooter.Cells.Add(cf4)

        Dim cf5 As TableCell = New TableCell()
        cf5.Text = ""
        barisfooter.Cells.Add(cf5)

        Dim cf6 As TableCell = New TableCell()
        cf6.Text = CStr(totharga)
        barisfooter.Cells.Add(cf6)

        tblDatBarang.Rows.Add(barisfooter)
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Buat variabel session ListAlat
            Session("ListBarang") = ListBarang
        End If
        TampilData()
        TampilMK()
    End Sub

    Protected Sub btBaru_Click(sender As Object, e As EventArgs) Handles btBaru.Click
        ListBarang.Clear()
        Session("ListBarang") = ListBarang
        Response.Redirect("transaksi.aspx")
        TampilMK()
    End Sub

    Protected Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        cn = New SqlConnection(cnsql)
        Try
            cn.Open()
            ' Memulai isolasi transaksi
            Dim trkrs As SqlTransaction = cn.BeginTransaction
            Try
                ListBarang = Session("ListBarang")
                For i = 0 To ListBarang.Count - 1
                    ' Menghitung final harga
                    Dim diskon As Integer = 0
                    If Not String.IsNullOrEmpty(tbDiskon.Text) Then
                        Integer.TryParse(tbDiskon.Text, diskon)
                    End If

                    Dim finalHarga As Integer = ListBarang.Item(i).getHarga() * (100 - diskon) / 100

                    Dim sql As String = "INSERT INTO Transaksi (Kode, NamaPembeli, Tanggal, TotalHarga, ProdukKode, PegawaiKode) "
                    sql = sql & "VALUES (@Kode, @NamaPembeli, @Tanggal, @TotalHarga, @ProdukKode, @PegawaiKode)"

                    Dim cmd As SqlCommand = New SqlCommand(sql, cn, trkrs)
                    cmd.Parameters.AddWithValue("@Kode", tbkodepenyewa.Text)
                    cmd.Parameters.AddWithValue("@NamaPembeli", tbnama.Text)
                    cmd.Parameters.AddWithValue("@Tanggal", tbTanggal.Text)
                    cmd.Parameters.AddWithValue("@TotalHarga", finalHarga)
                    cmd.Parameters.AddWithValue("@ProdukKode", ListBarang.Item(i).getKode())
                    cmd.Parameters.AddWithValue("@PegawaiKode", ddPegawai.SelectedValue)

                    cmd.ExecuteNonQuery()

                    ' Mengurangi stok barang setelah berhasil menyimpan transaksi
                    Dim updateStokSql As String = "UPDATE Produk SET Stok = Stok - 1 WHERE Kode = @ProdukKode"
                    Dim updateStokCmd As SqlCommand = New SqlCommand(updateStokSql, cn, trkrs)
                    updateStokCmd.Parameters.AddWithValue("@ProdukKode", ListBarang.Item(i).getKode())
                    updateStokCmd.ExecuteNonQuery()
                Next
                trkrs.Commit()
                lbPesan.Text = "<div class='alert alert-success' role='alert'>Proses Simpan Transaksi Berhasil!</div>"
            Catch ex As Exception
                trkrs.Rollback()
                lbPesan.Text = "<div class='alert alert-danger' role='alert'>Proses Simpan Transaksi Gagal!</div>"
            End Try
        Catch ex As Exception
            lbPesan.Text = "<div class='alert alert-danger' role='alert'>Error: " & ex.Message & "</div>"
        Finally
            cn.Close()
            cn = Nothing
        End Try
    End Sub

    Protected Sub ddBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddBarang.SelectedIndexChanged
            cn = New SqlConnection(cnsql)
            Try
                cn.Open()
            Dim sql As String = "SELECT * FROM Produk WHERE Kode='" & ddBarang.Text & "' "
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim reader As SqlDataReader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                Dim mk As trans = New trans
                mk.setJual(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4))

                    ListBarang.Add(mk)
                    Session("ListAlat") = ListBarang
                End If
            Catch ex As Exception
            Finally
                cn.Close()
                cn = Nothing
            End Try
        TampilMK()
    End Sub
End Class
