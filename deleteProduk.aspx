<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deleteProduk.aspx.vb" Inherits="deleteProduk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <div class="mt-5">
        <h4 class="d-flex justify-content-center mb-4">Apakah Anda yakin akan menghapus record Produk dengan Kode : &nbsp 
        <asp:Label ID="lbKode" runat="server" Text="x"></asp:Label>
        &nbsp?<br /></h4>
        <div class="d-flex justify-content-center">
            <asp:Button ID="btYa" runat="server" Text="Ya" CssClass="btn btn-danger fw-bolder" Width="50px"></asp:Button>
            <asp:Button ID="btTidak" runat="server" Text="Tidak" CssClass="btn btn-warning mx-4 fw-bolder"></asp:Button>
        </div>
    </div>
    </form>
</asp:Content>

