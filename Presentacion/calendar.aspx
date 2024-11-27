<%@ Page Title="" Language="C#" MasterPageFile="~/inside.Master" AutoEventWireup="true" CodeBehind="calendar.aspx.cs" Inherits="Presentacion.calendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/calendar.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="calendar">
        
        <div>
            <h1 style="color: #fea910;">Mi</h1>
            <h1 style="color: #38b6ff;">Calendario</h1>
        </div>


        <section class="calendarSec">
            <p>Agregar mascota</p>
        </section>

        <section class="description">
            <section class="DateTitle">
                <h3>Actividades programadas</h3>
                <h4>Fecha seleccionada</h4>
            </section>
            <div>
                <a>Actv1</a>
                <a>Actv2</a>
            </div>
        </section>

        <a class="calendarButton" style="background-color:#008cff;" href="addToCalendar.aspx">Agregar</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
