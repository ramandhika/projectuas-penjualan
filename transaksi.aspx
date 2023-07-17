<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="transaksi.aspx.vb" Inherits="transaksi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .ukuran {
            width: 30%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <asp:Label ID="lbPesan" runat="server" CssClass="text-center mt-3 mb-3 fw-bolder"></asp:Label>
    <h2 class="my-4 text-center">Formulir Transaksi</h2>
        <div class="form-group input-group mb-3">
            <label for="tbkodepenyewa" class="input-group-text ">Kode Transaksi :</label>
            <asp:TextBox ID="tbkodepenyewa" runat="server" Cssclass="form-control" placeholder="Kode Transaksi"></asp:TextBox>
        </div>
        <div class="form-group input-group mb-3">
            <label for="tbnama" class="input-group-text ">Nama Pembeli :</label>
            <asp:TextBox ID="tbnama" runat="server" Cssclass="form-control" placeholder="Nama Pembeli"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="tbKalender" class="">Tanggal Penjualan:</label>
            <div class="row">
              <div class="col-md-6">
                <asp:TextBox ID="tbTanggal" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
              </div>
              <div class="col-md-3">
                <asp:TextBox ID="tbDiskon" runat="server" CssClass="form-control" placeholder="Diskon (Opsional)"></asp:TextBox>
              </div>
              <div class="col-md-3 mt-1">
                  <span class="fw-bolder">%</span>
              </div>
            </div>
        </div>
        <div class="form-group input-group mb-3">
            <label for="ddPegawai" class="input-group-text ">Pegawai</label>
            <asp:DropDownList ID="ddPegawai" runat="server" CssClass="form-control">
                <asp:ListItem>Daftar Pegawai</asp:ListItem>
            </asp:DropDownList>
        </div>
        <hr />
        <h3 class="mt-4 text-center">Daftar Produk</h3>
        <div class="form-group input-group">
            <asp:DropDownList ID="ddBarang" runat="server" CssClass="form-control ms-0" AutoPostBack="True">
                <asp:ListItem>Pilih Produk yang ingin dibeli</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="text-center mt-3 mb-3 fw-bolder"></asp:Label>
        <asp:Table ID="tblDatBarang" runat="server" CssClass="table table-hover table-striped mt-3">
            <asp:TableRow runat="server" TableSection="TableHeader">
                <asp:TableCell runat="server">Kode</asp:TableCell>
                <asp:TableCell runat="server">Nama Kuliah</asp:TableCell>
                <asp:TableCell runat="server">Sks</asp:TableCell>
                <asp:TableCell runat="server">Aksi</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">112233</asp:TableCell>
                <asp:TableCell runat="server">Pemrograman Web</asp:TableCell>
                <asp:TableCell runat="server">4</asp:TableCell>
                <asp:TableCell runat="server"><a href="#" class="btn btn-danger btn-sm"><i class="fa-regular fa-trash-can"></i></a></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="btSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary ms-2" />
        <asp:Button ID="btBaru" runat="server" Text="Baru" CssClass="btn btn-outline-success ms-0" />
    </form>
</asp:Content>

