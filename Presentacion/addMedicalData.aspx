<%@ Page Title="" Language="C#" MasterPageFile="~/inside.Master" AutoEventWireup="true" CodeBehind="addMedicalData.aspx.cs" Inherits="Presentacion.addQuote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCardData.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="quoteMain">
        <div>
            <h1 style="color:#fea910;">Mi</h1>
            <h1 style="color:#38b6ff;">Cartilla Médica</h1>
        </div>

        <section>
            <h3>Nombre</h3>
            <input type="text"/>
        </section>
        
        <div class="quoteRow">
            <h3>Raza</h3>
            <h3>Genero</h3>
            <input type="text"/>
            <input type="text"/>
        </div>
        
        <div class="quoteBirthdateRow">
            <h3>Fecha de nacimiento</h3>
            <input type="number"/>
            <input type="number"/>
            <input type="number"/>
        </div>
            
        <section>
            <h3>Peso</h3>
            <input type="number"/>
        </section>
       
        <section>
            <h3>Padecimientos</h3>
            <input type="text"/>
        </section>

        <a class="quoteButton" href="medicalCard.aspx" style="background-color:#fea910;">Siguiente</a>
    </main>
    <footer class="Footer2">
    
    </footer>
</asp:Content>
