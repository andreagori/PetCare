<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="wantedPoster.aspx.cs" Inherits="Presentacion.wantedPoster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/wantedPoster.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wanted">
        <header>
            <h1>Cartel de</h1>
            <h1>Busqueda</h1>
        </header>
    
        <main class="poster">
            <h1>!!SE BUSCA!!</h1>

            <asp:Label id="LbNamePet" runat="server">
                <p>a <%# Eval("NamePet") %></p>
                <img src="" alt="Foto de la mascota">
            </asp:Label>
            
            <h3>SE DARA RECOMPENSA</h3>
            <section>
                <h4>Datos de la mascota</h4>
                <p>Datos</p>
            </section>
            <section>
                <h4>Datos del dueño</h4>
                <p></p>
            </section>
        </main>
    
        <button>Exportar</button>
    </div>    
</asp:Content>


<script>
    const petName= document.getElementById("PNamePet");
    if(petName.textContent === ""){
        petName.style.display = 'none';
    }
</script>