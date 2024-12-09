<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="addPetBreed.aspx.cs" Inherits="Presentacion.addPetBreed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/addPetBreed.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="addPetMain">
        <div>
            <h1 style="color: #38b6ff;">Escoger</h1>
            <h1 style="color: #fea910;">Raza De Animal</h1>
        </div>
        
        <asp:ImageButton ID="btnCat" runat="server" ImageUrl="assets/buttons/addCat.png" OnClick="btnCat_Click"  />
        <asp:ImageButton ID="btnDog" runat="server" ImageUrl="assets/buttons/addDog.png" OnClick="btnDog_Click" />

    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
