<%@ Page Title="" Language="C#" MasterPageFile="~/inside.Master" AutoEventWireup="true" CodeBehind="medicalCard.aspx.cs" Inherits="Presentacion.medicalCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCard.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="history">
        <div>
            <h1>Mis</h1>
            <h1>Citas Medicas</h1>
        </div>

        <h1>Citas registradas</h1>
        <section class="historyData">
            <a>
                <h3>Rutina</h3>
                <h3>Fecha</h3>
                <p>Descripcion</p>
            </a>
        </section>

        <a style="background-color:#008cff;">Agregar</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
