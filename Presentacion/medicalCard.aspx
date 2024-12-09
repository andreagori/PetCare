<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="medicalCard.aspx.cs" Inherits="Presentacion.medicalCard1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCard.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="medicalCard">
        <header class="mcTitle">
            <h1>Mi</h1>
            <h1>Cartilla Medica</h1>
        </header>
    
        <main class="mcMain">
            <section>
                <h3>Nombre</h3>
                <ItemTemplate class="rowInfo">
                    <input placeholder="Thomas" type="text">
                </ItemTemplate>
            </section>
            
            <section class="mcMainGrid">
                <div>
                    <h3>Raza</h3>
                    <ItemTemplate class="rowInfo">
                        <input placeholder="Golden" type="text">
                    </ItemTemplate>
                </div>
                
                <div>
                    <h3>Genero</h3>
                    <ItemTemplate class="rowInfo">
                        <input placeholder="Macho" type="text">
                    </ItemTemplate>
                </div>
            </section>

            <section class="mcMainBirth">
                <h3>Fecha de nacimiento</h3>
                <ItemTemplate class="rowInfo">
                    <input placeholder="18" type="number">
                </ItemTemplate>
                <ItemTemplate class="rowInfo">
                    <input  placeholder="10" type="number">
                </ItemTemplate>
                <ItemTemplate class="rowInfo">
                    <input placeholder="2004" type="number">
                </ItemTemplate>
            </section>
            
            <section>
                <h3>Peso</h3>
                <ItemTemplate class="rowInfo">
                    <input placeholder="52" type="number">
                </ItemTemplate>
            </section>

            <section>
                <h3>padecimientos</h3>
                <ItemTemplate class="row">
                    <input type="text" placeholder="Cadena de testo">
                </ItemTemplate>
            </section>
        </main>

        <a class="medicalButton" href="medicalCardQuotes.aspx">Citas medicas</a>
    </div>
</asp:Content>
