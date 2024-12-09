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
                <ItemTemplate class="rowInfo" runat="server">
                    <asp:Label runat="server" ID="nameIn"></asp:Label>
                </ItemTemplate>
            </section>
            
            <section class="mcMainGrid">
                <div>
                    <h3>Raza</h3>
                    <ItemTemplate class="rowInfo">
                        <asp:Label runat="server" ID="breed"></asp:Label>
                    </ItemTemplate>
                </div>
                
                <div>
                    <h3>Genero</h3>
                    <ItemTemplate class="rowInfo">
                        <asp:Label runat="server" ID="sex"></asp:Label>
                    </ItemTemplate>
                </div>
            </section>

            <section class="mcMainBirth">
                <h3>Fecha de nacimiento</h3>
                <ItemTemplate class="rowInfo">
                    <asp:Label runat="server" ID="day"></asp:Label>
                </ItemTemplate>
            </section>
            
            <section>
                <h3>Peso</h3>
                <ItemTemplate class="rowInfo">
                    <asp:Label runat="server" ID="weight"></asp:Label>
                </ItemTemplate>
            </section>

            <section>
                <h3>padecimientos</h3>
                <ItemTemplate class="row">
                    <asp:Label runat="server" ID="illiness"></asp:Label>
                </ItemTemplate>
            </section>
        </main>

        <a class="medicalButton" href="medicalCardQuotes.aspx">Citas medicas</a>
    </div>
</asp:Content>
