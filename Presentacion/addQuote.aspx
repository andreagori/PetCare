<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="addQuote.aspx.cs" Inherits="Presentacion.addQuote1" %>
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
            <asp:TextBox runat="server" Text="Razon" ID="razon"/>
        </section>

    
        <div class="quoteBirthdateRow">
            <h3>Fecha inicio</h3>
            <asp:TextBox runat="server" Text="day" ID="day"/>
            <asp:TextBox runat="server" Text="month" ID="month"/>
            <asp:TextBox runat="server" Text="year" ID="year"/>
        </div>
        
        <div class="quoteBirthdateRow">
            <h3>Fecha inicio</h3>
            <asp:TextBox runat="server" Text="day" ID="dayEnd"/>
            <asp:TextBox runat="server" Text="month" ID="monthEnd"/>
            <asp:TextBox runat="server" Text="year" ID="yearEnd"/>
        </div>
        
        <section>
            <h3>Descripcion</h3>
            <asp:TextBox runat="server" Text="Razon" ID="descriptionT"/>
        </section>

        <asp:Button runat="server" onclick="sendQuote" Text="Agregar"/>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
