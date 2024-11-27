<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="myData.aspx.cs" Inherits="Presentacion.myData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="dataMain">
        <div>
            <h1 style="color:#fea910;">Mis</h1>
            <h1 style="color:#38b6ff;">Datos</h1>
        </div>

        <section id="birthdateSection">
            <h3>Fecha de nacimiento</h3>
            <div class="myDataRow">
                <input placeHolder="Dia" type="number"/>
                <input placeHolder="Mes" type="number"/>
                <input placeHolder="Año" type="number"/>
            </div>
        </section>
        
        <section id="rolSection">
            <h3>Rol</h3>
            <input type="text"/>
        </section>
        
        <section id="ownerAvatarSection">
            <h3>Avatar</h3>
            <div id="avatares" class="ownerAvatares">
                <img src="assets/avatares/PetCare_Avatares/av1.png"/>
                <img src="assets/avatares/PetCare_Avatares/av2.png"/>
                <img src="assets/avatares/PetCare_Avatares/av3.png"/>
                <img src="assets/avatares/PetCare_Avatares/av4.png"/>
                <img src="assets/avatares/PetCare_Avatares/av5.png"/>
                <img src="assets/avatares/PetCare_Avatares/av6.png"/>
            </div>
        </section>
        
        <a href="myPets.aspx" style="background-color:#fea910;">Crear</a>
    </main>
    <footer class="Footer2">
    
    </footer>
</asp:Content>
