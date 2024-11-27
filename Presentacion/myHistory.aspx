<%@ Page Title="" Language="C#" MasterPageFile="~/inside.Master" AutoEventWireup="true" CodeBehind="myHistory.aspx.cs" Inherits="Presentacion.myHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/myHistory.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="history">
        <div>
            <h1>Mi</h1>
            <h1>Historial</h1>
        </div>

        <section class="historyData">
            <p>- Paseo</p>
        </section>

        <a style="background-color:#008cff;">Agregar</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
