<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="addToCalendar.aspx.cs" Inherits="Presentacion.addToCalendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCardData.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="quoteMain">
        <div>
            <h1 style="color:#fea910;">Agregar</h1>
            <h1 style="color:#38b6ff;">al calendario</h1>
        </div>

        <section>
            <h3>Actividad / Tarea</h3>
            <input type="text"/>
        </section>

        <div class="quoteRow">
            <h3>Fecha</h3>
            <h3>Hora</h3>
            <input type="date"/>
            <input type="datetime"/>
        </div>
    
        <div class="description">
            <h3>Descripcion</h3>
            <input type="text"/>
        </div>

        <a class="quoteButton" href="calendar.aspx" style="background-color:#fea910;">Agregar cita</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
