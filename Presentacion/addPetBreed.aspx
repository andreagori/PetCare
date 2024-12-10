<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="addPetBreed.aspx.cs" Inherits="Presentacion.addPetBreed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/addPetBreed.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="addPetMain">
        <div class="addPetMain-Title">
            <h1>
                <span class="highlight-yellow">Selecciona</span><br>
                <span class="highlight-blue">la raza</span>
            </h1>
        </div> 
        <div class="addPetMain-Content">
            <asp:ImageButton ID="btnCat" runat="server" ImageUrl="assets/buttons/addCat.png" OnClick="btnCat_Click"  />
            <asp:ImageButton ID="btnDog" runat="server" ImageUrl="assets/buttons/addDog.png" OnClick="btnDog_Click" />
        </div>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
