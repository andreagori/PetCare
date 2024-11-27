<%@ Page Title="" Language="C#" MasterPageFile="~/inside.Master" AutoEventWireup="true" CodeBehind="addPetBreed.aspx.cs" Inherits="Presentacion.addPetBreed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/addPetBreed.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="addPetMain">
        <div>
            <h1 style="color: #38b6ff;">Escoger</h1>
            <h1 style="color: #fea910;">Raza De Animal</h1>
        </div>
        
        <a href="addPetData.aspx" class="addPetMainButton">
            <img src="assets/buttons/addCat.png"/>
        </a>
        <a href="addPetData.aspx" class="addPetMainButton">
            <img src="assets/buttons/addDog.png"/>
        </a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
