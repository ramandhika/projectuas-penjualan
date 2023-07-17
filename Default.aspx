<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Project UAS - Penjualan</title>
    <link href="assets/boostrap/bootstrap.min.css" rel="stylesheet"/>
    <style>
        .bg-green {
            background-color:#899878;
        }

        .btn-darkgreen {
            background-color:#222725;
            color: white;
        }
           
        .btn-darkgreen:hover {
            background-color:#121113;
            color: white;
        }
    </style>
</head>
<body class="bg-green">
    <form id="form1" runat="server">
        <div class="container w-25 border border-secondary rounded p-5 bg-light" style="margin-top: 150px">
           <h2 class="text-center mb-4">Login Page</h2>
           <div class="form-group">
              <label for="UserID" class="form-label">Username</label>
              <asp:TextBox ID="tbUsrid" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
           </div>
           <div class="form-group mb-3">
              <label for="pass" class="form-label">Password</label>
              <asp:TextBox ID="tbPaswd" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox>
           </div>
              <asp:Button ID="btLogin" runat="server" Text="Login" CssClass="btn btn-darkgreen w-100" />
              <asp:Label ID="lbPesan" runat="server" Text="" CssClass="my-5"></asp:Label>
         </div>
    </form>
</body>
</html>
<script src="assets/boostrap/bootstrap.bundle.min.js"></script>
<script src="assets/kit.fontawesome.icon.js"></script>
