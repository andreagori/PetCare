<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="myPetActions.aspx.cs" Inherits="Presentacion.myPetActions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/myPetActions.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="pet">
        <div class="petName">
            <asp:Label ID="LbNamePet" runat="server" Visible="true">a</asp:Label>
        </div>
        <section class="petGrid">
            <div class="petGridItem">
                <a href="calendar.aspx" class="petLink">Calendario</a>
            </div>
            <div class="petGridItem">
                <asp:HyperLink ID="medicalCardLink" runat="server" Text="Cartilla Médica" CssClass="petLink" />
            </div>
            <div class="petGridItem">
                <asp:HyperLink ID="wantedPosterLink" runat="server" Text="Cartel de búsqueda" CssClass="petLink" />
            </div>
            <div class="petGridItem">
                <a href="myHistory.aspx?IdPet=<%# Eval("IdPet") %>" class="petLink">Historial</a>
            </div>
        </section>
    </main>
    <footer class="Footer2">
    </footer>
</asp:Content>
