<%@ Page Title="" Language="C#" MasterPageFile="~/bienvenida.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="startPage">
        <img src="assets/dogs.png"/>
        <h1>
            ¿Tienes una mascota,cuidas una<br>
            o eres responsable de su salud?
        </h1>
    </section>
    <section class="roles">
        <h1>
            ¿Te identificas con algún rol de estos? 
            ¡Ve lo que tenemos para ofrecerte!
        </h1>
        <section class="rolesRow">
            <section class="rolesItem cuidador">
                <h1>Cuidador</h1>
                <section>
                    <p>- Reporte Cuidado</p>
                    <p>- Agenda</p>
                    <p>- Calendario</p>
                </section>
            </section>
            <section class="rolesItem dueno">
                <h1>Dueño</h1>
                <section>
                    <p>- Agenda</p>
                    <p>- Cartilla Médica</p>
                    <p>- Cartel búsqueda</p>
                </section>
            </section>
            <section class="rolesItem veterinario">
                <h1>Veterinario</h1>
                <section>
                    <p>- Cartilla Médica</p>
                    <p>- Reporte Cita</p>
                    <p>- Seguimiento</p>
                </section>
            </section>
        </section>
    </section>
    <section class="benefits">
        <h1>Beneficios</h1>
        <img src="assets/banner.png"/>
    </section>
    <section class="startButtons">
        <h1>Inicia en PetCare</h1>
        <section class="ButtonsRow">
            <asp:Button CssClass="ButtonsRowItem blueButton" runat="server" 
                OnClick="goToLogin" Text="Iniciar sesión" />
            <asp:Button CssClass="ButtonsRowItem yellowButton" runat="server" 
                OnClick="goToRegister" Text="Registrarse" />
        </section>
    </section>
    <section class="aboutUs">
        <h1>Sobre nosotros</h1>
        <footer class="Footer">
            <section>
                <h1>¿Quienes Somos?</h1>
                <p>Cuatro alumnos de 5to semestre</p>
            </section>
        
            <section>
                <h1>¿Por Qué?</h1>
                <p>
                    Desarrollar un proyecto final que involucre ambientes de 
                    programación visual y base de datos.
                </p>
            </section>
        
            <section>
                <h1>Acerca</h1>
                <p>Idea pensada como dueños de mascotas</p>
            </section>
        </footer>
    </section>
</asp:Content>
    
