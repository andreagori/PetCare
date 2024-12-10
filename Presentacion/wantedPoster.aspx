<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="wantedPoster.aspx.cs" Inherits="Presentacion.wantedPoster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/wantedPoster.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="wanted">
        <div class="wanted-Title">
            <h1>
                <span class="highlight-yellow">Cartel</span><br>
                <span class="highlight-blue">de búsqueda</span>
            </h1>
        </div> 
    
        <div class="poster">
            <h1 class="poster-header">¡SE BUSCA!</h1>
            <asp:Label ID="petName" CssClass="posterName" runat="server" Visible="true">Nombre de la Mascota</asp:Label>
            <h3 class="poster-reward">INFORMACIÓN</h3>
            <div class="poster-details">
                <section class="poster-section">
                    <h4>Datos de la mascota</h4>
                    <asp:Label id="petData" runat="server"></asp:Label>
                </section>
                <section class="poster-section">
                    <h4>Datos del dueño</h4>
                    <asp:Label id="ownerData" runat="server"></asp:Label>
                </section>
            </div>
        </div>
        <asp:Button class="posterButton" runat="server" Text="Exportar" OnClick="ExportToPdf" />
    </main>
    <footer class="Footer2" />
</asp:Content>