<%@ Page Title="PetCare" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Presentacion.loggin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="loginMain">
        <div class="loginMain-Title">
            <h1>
                <span class="highlight-yellow">Iniciar</span><br>
                <span class="highlight-blue">Sesion</span>
            </h1>
        </div>
        <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        <div class="loginMain-content">
            <section class="loginMain-input">
                <h3>Usuario</h3>
                <asp:TextBox ID="TBEmail" runat="server" placeholder="Usuario"></asp:TextBox>
                <h3>Contraseña</h3>
                <asp:TextBox ID="TBPassword" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
            </section>
            <div class="loginMain-buttons">
                <a href="index.aspx">Recuperar contraseña</a>
                <asp:Button CssClass="custom-button" onclick="btnLogin" style="background-color:#fea910;" Text="Listo" runat="server"></asp:Button>
            </div>
        </div>
    </main>
    <footer class="Footer2"/>
</asp:Content>
