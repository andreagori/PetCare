<%@ Page Title="" Language="C#" MasterPageFile="~/inside.Master" AutoEventWireup="true" CodeBehind="addQuote.aspx.cs" Inherits="Presentacion.addQuote1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCardData.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="quoteMain">
        <div>
            <h1 style="color:#fea910;">Agregar</h1>
            <h1 style="color:#38b6ff;">Cita médica</h1>
        </div>

        <section>
            <h3>Razon de cita</h3>
            <input type="text"/>
        </section>
    
        <div class="quoteRow">
            <h3>Veterinaria</h3>
            <h3>Hora</h3>
            <input type="text"/>
            <input type="text"/>
        </div>
    
        <div class="quoteBirthdateRow">
            <h3>Fecha de la cita</h3>
            <input type="number"/>
            <input type="number"/>
            <input type="number"/>
        </div>
        
        <section>
            <h3>Descripcion</h3>
            <input type="text"/>
        </section>

        <a class="quoteButton" href="medicalCard.aspx" style="background-color:#fea910;">Agregar cita</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
