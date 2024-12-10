<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="activityDetails.aspx.cs" Inherits="Presentacion.activityDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/calendar.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="calendar">

    <div>
        <h1 style="color: #fea910;">Mi</h1>
        <h1 style="color: #38b6ff;">Calendario</h1>
    </div>

    <section class="description">
        <div>
            <asp:TextBox ID="actTitle" runat="server" Text='Titulo' />
            <asp:TextBox ID="actDescription" runat="server" Text='Descripcion' />
            <asp:TextBox ID="actStart" runat="server" Text='Fecha de inicio' />
            <asp:TextBox ID="actEnd" runat="server" Text='Fecha de finalización' />
        </div>
    </section>
    <asp:Button runat="server" OnClick="SubirActividad" Text="Agregar" />

    
</main>
<footer class="Footer2">

</footer>
</asp:Content>
