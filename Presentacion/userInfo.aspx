<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="userInfo.aspx.cs" Inherits="Presentacion.userInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/userInfo.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="userInfo">
        <header>
            <img src="assets/avatares/PetCare_Avatares/av1.png" id="userImage" />
            <asp:Label runat="server" ID="userName">Adan</asp:Label>
        </header>

        <asp:Label runat="server" ID="correo" CssClass="usMail">adan@gmail.com</asp:Label>
        <br />
        <asp:Label runat="server" ID="celular">6462362914</asp:Label>
        <br />
        <asp:Label runat="server" ID="direccion">villa bonita</asp:Label>
    </main>
</asp:Content>
