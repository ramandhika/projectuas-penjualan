<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="insertPegawai.aspx.vb" Inherits="insertPegawai" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <h2 class="text-center mb-4 mt-4">Form Tambah Data Pegawai</h2>
    <div class="input-group row justify-content-center">
        <div class="col-7">
            <div class="form-group input-group mb-3">
                <label for="tbnama" class="input-group-text ">Kode Pegawai :</label>
                <asp:TextBox ID="tbKode" runat="server" Cssclass="form-control" placeholder="Kode Pegawai"></asp:TextBox>
            </div>
            <div class="form-group input-group mb-3">
                <label for="tbnama" class="input-group-text ">Nama Pegawai :</label>
                <asp:TextBox ID="tbNama" runat="server" Cssclass="form-control" placeholder="Nama Pegawai"></asp:TextBox>
            </div>
            <div class="form-group input-group mb-3">
                <label for="tbnama" class="input-group-text ">Username :</label>
                <asp:TextBox ID="tbUser" runat="server" Cssclass="form-control" placeholder="Username"></asp:TextBox>
            </div>
            <div class="form-group input-group mb-3">
                <label for="tbnama" class="input-group-text ">Password :</label>
                <asp:TextBox ID="tbPass" runat="server" Cssclass="form-control" placeholder="Password"></asp:TextBox>
            </div>
            <div class="d-flex justify-content-center mb-4 mt-4">
                <asp:Button ID="btSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary ms-2" /> 
                <asp:Button ID="btKembali" runat="server" Text="Kembali" CssClass="btn btn-secondary ms-3" />
                <asp:Button ID="btTampil" runat="server" Text="Tampilkan Data" CssClass="btn btn-info ms-3" />
            </div>
        </div>
        <hr />
    <asp:Label ID="lbPesan" runat="server" CssClass="text-center mt-3 mb-3 fw-bolder"></asp:Label>
        <div id="dataPegawai" runat="server">

        </div>
    </div>
        <p>
            &nbsp;
        </p>
    </form>
</asp:Content>

