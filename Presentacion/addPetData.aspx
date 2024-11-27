<%@ Page Title="" Language="C#" MasterPageFile="~/inside.Master" AutoEventWireup="true" CodeBehind="addPetData.aspx.cs" Inherits="Presentacion.addPetData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/addPetData.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="addPet">
        <div>
            <h1 style="color:#fea910;">Mi</h1>
            <h1 style="color:#38b6ff;">Gato</h1>
        </div>

        <section>
            <h3>Nombre</h3>
            <input type="text"/>
        </section>
    
        <div class="petRow">
            <h3>Raza</h3>
            <h3>Genero</h3>
            <input type="text"/>
            <input type="text"/>
        </div>
    
        <div class="petBirthdateRow">
            <h3>Fecha de nacimiento</h3>
            <input type="number"/>
            <input type="number"/>
            <input type="number"/>
        </div>
        
        <section>
            <h3>Peso</h3>
            <input type="number"/>
        </section>
   
        <section>
            <h3>Padecimientos</h3>
            <input type="text"/>
        </section>
        
        <section>
            <h3>Avatar</h3>
            <div class="petAvatar">
                <img src="assets/avatares/PetCare_Gatos/cat1.png"/>
                <img src="assets/avatares/PetCare_Gatos/cat2.png"/>
                <img src="assets/avatares/PetCare_Gatos/cat3.png"/>
                <img src="assets/avatares/PetCare_Gatos/cat4.png"/>
                <img src="assets/avatares/PetCare_Gatos/cat5.png"/>
                <img src="assets/avatares/PetCare_Gatos/cat6.png"/>
                <img src="assets/avatares/PetCare_Gatos/cat7.png"/>
                <img src="assets/avatares/PetCare_Gatos/cat8.png"/>
            </div>
        </section>

        <a class="petButton" href="myPets.aspx" style="background-color:#fea910;">Siguiente</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
