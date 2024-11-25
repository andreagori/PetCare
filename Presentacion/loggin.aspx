<%@ Page Title="PetCare" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="loggin.aspx.cs" Inherits="Presentacion.loggin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <main class="logginMain">
            <div>
                <h1 style="color:#fea910;">Iniciar</h1>
                <h1 style="color:#38b6ff;">Sesion</h1>
            </div>

            <section>
                <h3>Usuario</h3>
                <input placeHolder="Usuario"/>
            </section>
            <section>
                <h3>Contraseña</h3>
                <input placeHolder="Contraseña" type="password"/>
            </section>
            <button style="background-color:#38b6ff;">Recuperar contraseña</button>
            <button style="background-color:#fea910;">Listo</button>
        </main>
    <footer class="Footer2">
        
    </footer>
</asp:Content>
