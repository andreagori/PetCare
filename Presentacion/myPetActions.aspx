<%@ Page Title="" Language="C#" MasterPageFile="~/inside.Master" AutoEventWireup="true" CodeBehind="myPetActions.aspx.cs" Inherits="Presentacion.myPetActions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/myPetActions.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="pet">
        <h1>Thomas</h1>

        <section class="petGrid">
            <a>Mi info</a>
            <a>Cartel De Busqueda</a>
            <a href="medicalCard.aspx">Cartilla Medica</a>
            <a href="calendar.aspx">Calendario</a>
            <a href="myHistory.aspx">Historial</a>
            <a>Agregar Miembro</a>
        </section>
    </main>
    <footer class="Footer2">
    </footer>
</asp:Content>
