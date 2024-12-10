<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="addIllness.aspx.cs" Inherits="Presentacion.addIllness" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/addIlliness.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="addIlliness">
        <header class="aiTitle">
            <h1>Agregar</h1>
            <h1>Padecimiento</h1>
        </header>

        <main class="aiMain">
            <section>
                <h3>Nombre</h3>
                <asp:TextBox ID="TbIllnessName" runat="server" cssclass="aiGridInput"></asp:TextBox>
            </section>

            <section>
                <h3>Descripcion</h3>
                <asp:TextBox ID="TbDescription" runat="server" cssclass="aiGridInput"></asp:TextBox>
            </section>

            <div class="aiGrid">
                <h3>dia</h3>
                <h3>Mes</h3>
                <h3>Año</h3>
                <asp:TextBox ID="TbDay" runat="server" cssclass="aiGridInput"></asp:TextBox>
                <asp:TextBox ID="TbMonth" runat="server" cssclass="aiGridInput"></asp:TextBox>
                <asp:TextBox ID="TbYear" runat="server" cssclass="aiGridInput"></asp:TextBox>
            </div>

            
            
        </main>
        <asp:Button cssclass="aiGridButton" ID="btnAddIllness" runat="server" Text="Agregar" OnClick="BtAddIllness_OnClick" />
    </div>

</asp:Content>
