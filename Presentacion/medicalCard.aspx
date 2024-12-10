<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="medicalCard.aspx.cs" Inherits="Presentacion.medicalCard1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCard.css" type="text/css"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="medicalCard">
        <div class="medicalCard-Title">
            <h1>
                <span class="highlight-yellow">Mi</span><br>
                <span class="highlight-blue">Cartilla Médica</span>
            </h1>
        </div> 

        <main class="mcMain">
            <section>
                <h3>Nombre</h3>
                <div class="rowInfo">
                    <asp:Label runat="server" ID="nameIn"></asp:Label>
                </div>
            </section> 
            <section class="mcMainGrid">
                <div class="mcMainGridItem">
                    <h3>Raza</h3>
                    <div class="rowInfo">
                        <asp:Label runat="server" ID="breed"></asp:Label>
                    </div>
                </div>
                <div class="mcMainGridItem">
                    <h3>Género</h3>
                    <div class="rowInfo">
                        <asp:Label runat="server" ID="sex"></asp:Label>
                    </div>
                </div>
            </section>
            <section class="mcMainBirth">
                <h3>Fecha de nacimiento</h3>
                <div class="rowInfo">
                    <asp:Label runat="server" ID="day"></asp:Label>
                </div>
            </section>      
            <section>
                <h3>Peso</h3>
                <div class="rowInfo">
                    <asp:Label runat="server" ID="weight"></asp:Label>
                </div>
            </section>
            <section>
                <h1>Lista de padecimientos</h1>
                <div class="medicalList">
                    <asp:Repeater ID="RpIllness" runat="server">
                        <ItemTemplate>         
                            <a href="#">
                                <h3><strong>Padecimiento:</strong> <%# Eval("IllinessName") %></h3>
                                <p><strong>Descripción:</strong> <%# Eval("Description") %> </p>
                                <h4><strong>Fecha:</strong> <%# Eval("DateIllness", "{0:yyyy/MM/dd}") %></h4>
                            </a>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </section>
            <a href="addIllness.aspx"> Agregar padecimiento </a>
        </main>
        <a class="medicalButton" href="medicalCardQuotes.aspx">Citas médicas</a>
    </div>
    <footer class="Footer2" />
</asp:Content>
