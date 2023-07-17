Imports Microsoft.VisualBasic

Public Class trans
    Private KodeProduk As String
    Private NamaProduk As String
    Private HargaProduk As Integer
    Private DiskonProduk As Integer
    Private StokProduk As Integer

    Public Sub New()
        ' Constructor kosong
        KodeProduk = ""
        NamaProduk = ""
        HargaProduk = 0
        DiskonProduk = 0
        StokProduk = 0
    End Sub

    Public Sub setJual(ByVal kode As String, ByVal nama As String, ByVal harga As Integer, ByVal diskon As Integer, ByVal stok As Integer)
        KodeProduk = kode
        NamaProduk = nama
        HargaProduk = harga
        DiskonProduk = diskon
        StokProduk = stok
    End Sub

    Public Function getKode() As String
        Return KodeProduk
    End Function

    Public Function getNama() As String
        Return NamaProduk
    End Function

    Public Function getHarga() As Integer
        Return HargaProduk
    End Function

    Public Function getDiskon() As Integer
        Return DiskonProduk
    End Function

    Public Function getStok() As Integer
        Return StokProduk
    End Function
End Class
