<%@ Page Title="PetCare" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Presentacion.loggin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <main class="loginMain">
            <div>
                <h1 style="color:#fea910;">Iniciar</h1>
                <h1 style="color:#38b6ff;">Sesion</h1>
            </div>
            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            <section>
                <h3>Usuario</h3>

                <asp:TextBox ID="TBEmail" runat="server" placeholder="Usuario"></asp:TextBox>

            </section>
            <section>
                <h3>Contraseña</h3>
                <asp:TextBox ID="TBPassword" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
            </section>
            <a href="index.aspx" style="background-color:#38b6ff;">Recuperar contraseña</a>
            <asp:Button onclick="btnLogin" style="background-color:#fea910;" Text="Listo" runat="server"></asp:Button>
        </main>
    <footer class="Footer2">
        
    </footer>
</asp:Content>
