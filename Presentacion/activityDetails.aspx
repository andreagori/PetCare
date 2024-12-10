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

        <section>
            <h4>Titulo</h4>
            <asp:TextBox cssclass="inputDes" ID="actTitle" runat="server" Text='' />
        </section>

        <section>
            <h4>Descripcion</h4>
            <asp:TextBox cssclass="inputDes" ID="actDescription" runat="server" Text='' />
        </section>
        
        <section class="itemGrid">
            <h4>Dia inicial</h4>
            <h4>Mes inicial</h4>
            <h4>Año inicial</h4>
            <asp:TextBox cssclass="inputDes" ID="dayStart" runat="server" Text='' class="inputDes" />
            <asp:TextBox cssclass="inputDes" ID="monthStart" runat="server" Text='' />
            <asp:TextBox cssclass="inputDes" ID="yearStart" runat="server" Text='' />
        </section>
        
        <section class="itemGrid">
            <h4>Dia final</h4>
            <h4>Mes final</h4>
            <h4>Año final</h4>
            <asp:TextBox cssclass="inputDes" ID="dayEnd" runat="server" Text='' />
            <asp:TextBox cssclass="inputDes" ID="monthEnd" runat="server" Text='' />
            <asp:TextBox cssclass="inputDes" ID="yearEnd" runat="server" Text='' />
        </section>
            
    </section>
    <asp:Button cssclass="descButton" runat="server" OnClick="SubirActividad" Text="Agregar" />

    
</main>
<footer class="Footer2">

</footer>
</asp:Content>
