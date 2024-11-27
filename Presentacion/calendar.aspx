<%@ Page Title="" Language="C#" MasterPageFile="~/inside.Master" AutoEventWireup="true" CodeBehind="calendar.aspx.cs" Inherits="Presentacion.calendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/calendar.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="calendar">
        <div>
            <h1>Mi</h1>
            <h1>Calendario</h1>
        </div>


        <section >
            <a>Agregar mascota</a>
        </section>

        <section>
            <div class="DateTitle">
                <h3>Actividades programadas</h3>
                <h4>Fecha seleccionada</h4>
            </div>
            <input placeholder="Actividad" />
        </section>

        <a style="background-color:#008cff;">Agregar</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
