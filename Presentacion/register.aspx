<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Presentacion.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <main class="loginMain">
        <div>
            <h1 style="color:#fea910;">Nuevo</h1>
            <h1 style="color:#38b6ff;">Usuario</h1>
        </div>

        <section>
            <h3>Nombre</h3>
            <input type="text"/>
        </section>
        <section>
            <h3>Nombre de usuario</h3>
            <input type="text"/>
        </section>
        <section>
            <h3>Correo</h3>
            <input type="email"/>
        </section>
            
        <section>
            <h3>Contraseña</h3>
            <input type="password"/>
        </section>
        
            <section>
            <h3>Confirmar contraseña</h3>
            <input type="password"/>
        </section>

        <a href="myData.aspx" style="background-color:#fea910;">Siguiente</a>
    </main>
    <footer class="Footer2">
    
    </footer>
</asp:Content>
