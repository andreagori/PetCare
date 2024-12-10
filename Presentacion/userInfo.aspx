<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="userInfo.aspx.cs" Inherits="Presentacion.userInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/userInfo.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="userInfo">
        <div class="userInfo-Content">
            <header class="userInfo-Title">
                <asp:Label CssClass="userInfo-Title" runat="server" ID="userName">A</asp:Label>
            </header>
            <div class="userInfo-Avatar">
                <img src="" id="userImage" runat="server" />
            </div>
            <div class="userInfo-Data">
                <asp:Label class="userInfo-Data" runat="server" ID="correo"></asp:Label>
                <br />
                <asp:Label class="userInfo-Data" runat="server" ID="celular"></asp:Label>
                <br />
                <asp:Label class="userInfo-Data" runat="server" ID="direccion"></asp:Label>
            </div>
        </div>
        <asp:Button CssClass="userInfo-Button" runat="server" OnClick="BtCloseSession_OnClick" Text="Cerrar sesion"/>
    </main>
    <footer class="Footer2" />
</asp:Content>
