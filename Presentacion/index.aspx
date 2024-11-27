<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="startPage">
        <img src="assets/dogs.png"/>
        <h1>
            ¿Tienes una mascota, 
            cuidas una o eres responsable de su salud?
        </h1>
    </section>
    <section class="roles">
        <h1>
            ¿Te identificas con algún rol de estos? 
            ¡Ve lo que tenemos para ofrecerte!
        </h1>
        <section class="rolesRow">
            <section class="rolesItem">
                <h1>Cuidador</h1>
                <section>
                    <p>- Calendario</p>
                    <p>- Reportes</p>
                    <p>- Agenda</p>
                </section>
            </section>
        
            <section class="rolesItem" style="background-color:#fea910;">
                <h1 style="color:#fea910; border:2px solid #fea910;">Dueño</h1>
                <section>
                    <p>- Agenda</p>
                    <p>- Cartilla Medica</p>
                    <p>- Cartel búsqueda</p>
                </section>
            </section>
        
            <section class="rolesItem" style="background-color:#37b5ff;">
                <h1 style="color:#37b5ff; border:2px solid #37b5ff;" >Veterinario</h1>
                <section>
                    <p>- Cartilla Médica</p>
                    <p>- Reporte Cita</p>
                    <p>- Seguimiento</p>
                </section>
            </section>
        </section>
    </section>

    <section class="section2">
        <h1>Beneficios</h1>
        <img src="assets/banner.png"/>
    </section>

    <section class="startButtons">
        <h1>Inicia en PetCare</h1>
        <section class="ButtonsRow">
            
            <asp:Button CssClass="ButtonsRowItem" runat="server" 
                OnClick="goToLogin" Text="Iniciar sesion" style="background-color:#37b5ff;"/>
            <asp:Button CssClass="ButtonsRowItem" runat="server" 
                OnClick="goToRegister" Text="Registrarse" style="background-color:#fea910;"/>
            
        </section>
    </section>


    <h1 class="aboutUs">Sobre nosotros</h1>
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

</asp:Content>
    
