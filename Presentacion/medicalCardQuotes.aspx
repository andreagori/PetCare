<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="medicalCardQuotes.aspx.cs" Inherits="Presentacion.medicalCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCardQuotes.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="medical">
        <div>
            <h1>Mis citas</h1>
        </div>

        <main class="medicalMain">
            <section class="medicalList">
                <a>
                    <h3 id="vaccineName">Nombre</h3>
                    <h4 id="vaccineType">tipo</h4>
                    <p id="vaccineDescription">descripcion</p>
                </a>
                <a>
                    <h3 id="vaccineName">Nombre</h3>
                    <h4 id="vaccineType">tipo</h4>
                    <p id="vaccineDescription">descripcion</p>
                </a>
                <a>
                    <h3 id="vaccineName">Nombre</h3>
                    <h4 id="vaccineType">tipo</h4>
                    <p id="vaccineDescription">descripcion</p>
                </a>
                <a>
                    <h3 id="vaccineName">Nombre</h3>
                    <h4 id="vaccineType">tipo</h4>
                    <p id="vaccineDescription">descripcion</p>
                </a>
                <a>
                    <h3 id="vaccineName">Nombre</h3>
                    <h4 id="vaccineType">tipo</h4>
                    <p id="vaccineDescription">descripcion</p>
                </a>
                <a>
                    <h3 id="vaccineName">Nombre</h3>
                    <h4 id="vaccineType">tipo</h4>
                    <p id="vaccineDescription">descripcion</p>
                </a>
                <a>
                    <h3 id="vaccineName">Nombre</h3>
                    <h4 id="vaccineType">tipo</h4>
                    <p id="vaccineDescription">descripcion</p>
                </a>
            </section>

        </main>


        <a class="medicalButton" style="background-color:#008cff;" href="addQuote.aspx">Agregar</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
