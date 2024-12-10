<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="medicalCard.aspx.cs" Inherits="Presentacion.medicalCard1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCard.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="medicalCard">
        <header class="mcTitle">
            <h1>Mi</h1>
            <h1>Cartilla Medica</h1>
        </header>
    
        <main class="mcMain">
            <section>
                <h3>Nombre</h3>
                <ItemTemplate class="rowInfo" runat="server">
                    <asp:Label runat="server" ID="nameIn"></asp:Label>
                </ItemTemplate>
            </section>
            
            <section class="mcMainGrid">
                <div>
                    <h3>Raza</h3>
                    <ItemTemplate class="rowInfo">
                        <asp:Label runat="server" ID="breed"></asp:Label>
                    </ItemTemplate>
                </div>
                
                <div>
                    <h3>Genero</h3>
                    <ItemTemplate class="rowInfo">
                        <asp:Label runat="server" ID="sex"></asp:Label>
                    </ItemTemplate>
                </div>
            </section>

            <section class="mcMainBirth">
                <h3>Fecha de nacimiento</h3>
                <ItemTemplate class="rowInfo">
                    <asp:Label runat="server" ID="day"></asp:Label>
                </ItemTemplate>
            </section>
            
            <section>
                <h3>Peso</h3>
                <ItemTemplate class="rowInfo">
                    <asp:Label runat="server" ID="weight"></asp:Label>
                </ItemTemplate>
            </section>

            <section>
                <h1>Padecimientos</h1>
                <div class="medicalList">
                <asp:Repeater ID="RpIllness" runat="server">
                    <ItemTemplate>         
                        <a>
                            <h3><strong>Padecimiento:</strong> <%# Eval("IllinessName") %></h3>
                            <p><strong>descripcion:</strong><%# Eval("Description") %> </p>
                            <h4><strong>Fecha:</strong> <%# Eval("DateIllness", "{0:yyyy/MM/dd}") %></h4>
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
                </div>
            </section>
            <a href="addIllness.aspx"> Agregar padecimiento </a>
        </main>

        <a class="medicalButton" href="medicalCardQuotes.aspx">Citas medicas</a>
    </div>
</asp:Content>
