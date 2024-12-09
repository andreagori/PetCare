<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Presentacion.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="Register">
        <div class="loginMain-Title">
            <h1>
                <span class="highlight-yellow">Nuevo</span><br>
                <span class="highlight-blue">Usuario</span>
            </h1>
        </div>
        <div class="loginMain-content">
            <section class="loginMain-input">
                <h3>Nombre</h3>
                <asp:TextBox ID="TBName" runat="server" placeholder="Nombre"></asp:TextBox>
                <h3>Nombre de usuario</h3>
                <asp:TextBox ID="TBUsername" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
                <h3>Correo</h3>
                <asp:TextBox ID="TBEmail" runat="server" TextMode="Email" placeholder="Correo"></asp:TextBox>
                <h3>Contraseña</h3>
                <asp:TextBox ID="TBPassword" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                <h3>Confirmar contraseña</h3>
                <asp:TextBox ID="TBConfirmPassword" runat="server" TextMode="Password" placeholder="Confirmar contraseña"></asp:TextBox>
            </section>
            <div class="register-button">
                <a href="myData.aspx" class="custom-button">Siguiente</a>
            </div>
        </div>
    </main>
    <footer class="Footer2" />
</asp:Content>
