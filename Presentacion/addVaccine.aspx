<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="addVaccine.aspx.cs" Inherits="Presentacion.addVaccine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="quoteMain">
        <div>
            <h1 style="color:#fea910;">Agregar</h1>
            <h1 style="color:#38b6ff;">Cita médica</h1>
        </div>

        <section>
            <h3>Nombre</h3>
            <asp:TextBox runat="server" Text="Nombre" ID="nameT"/>
        </section>
        
        <section>
            <h3>Tipo</h3>
            <asp:TextBox runat="server" Text="Nombre" ID="typeT"/>
        </section>


        <div class="quoteBirthdateRow">
            <h3>Fecha inicio</h3>
            <asp:TextBox runat="server" Text="day" ID="day"/>
            <asp:TextBox runat="server" Text="month" ID="month"/>
            <asp:TextBox runat="server" Text="year" ID="year"/>
        </div>
    
        <section>
            <h3>Descripcion</h3>
            <asp:TextBox runat="server" Text="Razon" ID="descriptionT"/>
        </section>

        <asp:Button runat="server" onclick="sendVaccine" Text="Agregar Vacuna"/>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
