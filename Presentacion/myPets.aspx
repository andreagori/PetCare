﻿<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="myPets.aspx.cs" Inherits="Presentacion.myPets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/myPets.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="myPets">
        <div>
            <h1>Mis</h1>
            <h1>Mascotas</h1>
        </div>
        
        <section class="myPetsIcons">
            <asp:Repeater ID="rpPets" runat="server">
                <ItemTemplate>
                    <a class="myPetsItem" href="myPetActions.aspx?IdPet=<%# Eval("IdPet") %>&NamePet=<%# HttpUtility.UrlEncode(Eval("NamePet").ToString()) %>">
                        <img src='<%# Eval("PhotoPet") %>'/>
                    </a>
                    <p><%# Eval("NamePet") %></p>
                </ItemTemplate>
            </asp:Repeater>
        </section>

        <a style="background-color:#fea910;" href="addPetBreed.aspx">Agregar</a>
    </main>

    <footer class="Footer2">

    </footer>
</asp:Content>
