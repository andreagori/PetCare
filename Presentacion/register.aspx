<%@ Page Title="" Language="C#" MasterPageFile="~/bienvenida.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Presentacion.register" %>
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
                <h3>Correo</h3>
                <asp:TextBox ID="TBEmail" runat="server" TextMode="Email" placeholder="Correo"></asp:TextBox>
                <h3>Celular</h3>
                <asp:TextBox ID="TBCellPhone" runat="server" TextMode="Number" placeholder="Celular"></asp:TextBox>
                <h3>Contraseña</h3>
                <asp:TextBox ID="TBPassword" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                <h3>Confirmar contraseña</h3>
                <asp:TextBox ID="TBConfirmPassword" runat="server" TextMode="Password" placeholder="Confirmar contraseña"></asp:TextBox>
                <h3>Direccion</h3>
                <asp:TextBox ID="TBAddress" runat="server" placeholder="Direccion"></asp:TextBox>
            </section>
            <div class="register-button">
                <asp:Button href="myData.aspx" class="custom-button" runat="server" Text="Siguiente" OnClick="BtnNext"></asp:Button>
            </div>
        </div>
    </main>
    <footer class="Footer2" />
</asp:Content>
