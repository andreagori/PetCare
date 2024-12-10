<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="userInfo.aspx.cs" Inherits="Presentacion.userInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/userInfo.css" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="userInfo">
        <header>
            <asp:Label runat="server" ID="userName">A</asp:Label>
            <img src="" id="userImage" runat="server" />
        </header>

        <asp:Label runat="server" ID="correo"></asp:Label>
        <br />
        <asp:Label runat="server" ID="celular"></asp:Label>
        <br />
        <asp:Label runat="server" ID="direccion"></asp:Label>
    </main>
</asp:Content>
