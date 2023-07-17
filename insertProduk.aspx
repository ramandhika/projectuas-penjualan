<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="insertProduk.aspx.vb" Inherits="insertProduk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <h2 class="text-center mb-4 mt-4">Form Tambah Data Produk</h2>
    <div class="input-group row justify-content-center">
        <div class="col-7">
            <div class="form-group input-group mb-3">
                <label for="tbnama" class="input-group-text ">Kode Produk :</label>
                <asp:TextBox ID="tbKode" runat="server" Cssclass="form-control" placeholder="Kode Produk"></asp:TextBox>
            </div>
            <div class="form-group input-group mb-3">
                <label for="tbnama" class="input-group-text ">Nama Produk :</label>
                <asp:TextBox ID="tbNama" runat="server" Cssclass="form-control" placeholder="Nama Produk"></asp:TextBox>
            </div>
            <div class="form-group input-group mb-3">
                <label for="tbHarga" class="input-group-text ">Harga Produk :</label>
                <asp:TextBox ID="tbHarga" runat="server" Cssclass="form-control" placeholder="Harga Produk" TextMode="Number"></asp:TextBox>
            </div>
            <div class="form-group input-group mb-3">
                <label for="tbStok" class="input-group-text ">Stok Produk :</label>
                <asp:TextBox ID="tbStok" runat="server" Cssclass="form-control" placeholder="Stok Produk" TextMode="Number"></asp:TextBox>
            </div>
            <div class="form-group input-group mb-3">
                <label for="tbDiskon" class="input-group-text ">Diskon :</label>
                <asp:TextBox ID="tbDiskon" runat="server" Cssclass="form-control" placeholder="Diskon Produk *opsional" TextMode="Number"></asp:TextBox>
            </div>
            <div class="d-flex justify-content-center mb-4 mt-4">
                <asp:Button ID="btSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary ms-2" /> 
                <asp:Button ID="btKembali" runat="server" Text="Kembali" CssClass="btn btn-secondary ms-3" />
                <asp:Button ID="btTampil" runat="server" Text="Tampilkan Data" CssClass="btn btn-info ms-3" />
            </div>
        </div>
        <hr />
    <asp:Label ID="lbPesan" runat="server" CssClass="text-center mt-3 mb-3 fw-bolder"></asp:Label>
        <div id="dataProduk" runat="server">

        </div>
    </div>
        <p>
            &nbsp;
        </p>
    </form>
</asp:Content>

