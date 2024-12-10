<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="userInfo.aspx.cs" Inherits="Presentacion.userInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <header>
            <asp:Label runat="server" ID="userName">A</asp:Label>
            <img src="" id="userImage" />
        </header>

        <asp:Label runat="server" ID="correo">A</asp:Label>
        <br />
        <asp:Label runat="server" ID="celular">123</asp:Label>
        <br />
        <asp:Label runat="server" ID="direccion">ASD</asp:Label>
    </main>
</asp:Content>
