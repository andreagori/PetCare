<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="wantedPoster.aspx.cs" Inherits="Presentacion.wantedPoster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/wantedPoster.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wanted">
        <header>
            <h1>Cartel de</h1>
            <h1>Busqueda</h1>
        </header>
    
        <main class="poster">
            <h1>!!SE BUSCA!!</h1>

            <asp:Label id="LbNamePet" runat="server">
                <p>Nombre : <%# Eval("NamePet") %></p>
                <img src="assets/dogs.png" alt="Foto de la mascota" class="posterImage">
            </asp:Label>
            
            <h3>SE DARA RECOMPENSA</h3>
            <div>
                <section>
                    <h4>Datos de la mascota</h4>
                    <p>Mascota perdida nombre - color wero y asi</p>
                </section>
                <section>
                    <h4>Datos del dueño</h4>
                    <p>Adan gonzalez cesena - 646 236 2914, Villa bonita</p>
                </section>
            </div>
        </main>
    
        <asp:Button class="posterButton" runat="server" Text="exportar" />
    </div>
</asp:Content>