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

            
            <asp:Label ID="petName" runat="server" Visible="true">a</asp:Label>
            <img src="assets/dogs.png" alt="Foto de la mascota" class="posterImage" />
            
            <h3>SE DARA RECOMPENSA</h3>
            <div>
                <section>
                    <h4>Datos de la mascota</h4>
                    <asp:Label id="petData" runat="server"></asp:Label>
                </section>
                <section>
                    <h4>Datos del dueño</h4>
                    <asp:Label id="ownerData" runat="server"></asp:Label>
                </section>
            </div>
        </main>
    
        <asp:Button class="posterButton" runat="server" Text="Exportar" OnClick="ExportToPdf" />
    </div>
</asp:Content>