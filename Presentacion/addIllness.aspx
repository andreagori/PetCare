<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="addIllness.aspx.cs" Inherits="Presentacion.addIllness" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/addIlliness.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="addIllness">
        <header class="aiTitle">
            <h1>Agregar</h1>
            <h1>Padecimiento</h1>
        </header>

        <main class="aiMain">
            <section>
                <h3>Nombre</h3>
                <asp:TextBox ID="TbIllnessName" runat="server"></asp:TextBox>
            </section>

            <section>
                <h3>Descripcion</h3>
                <asp:TextBox ID="TbDescription" runat="server"></asp:TextBox>
            </section>

            <section>
                <h3>dia</h3>
                <asp:TextBox ID="TbDay" runat="server"></asp:TextBox>
                <h3>Mes</h3>
                <asp:TextBox ID="TbMonth" runat="server"></asp:TextBox>
                <h3>Año</h3>
                <asp:TextBox ID="TbYear" runat="server"></asp:TextBox>
            </section>



            <section>
                <asp:Button ID="btnAddIllness" runat="server" Text="Agregar" OnClick="BtAddIllness_OnClick"/>
            </section>
        </main>
    </div>

</asp:Content>
