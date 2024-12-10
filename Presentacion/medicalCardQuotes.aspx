<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="medicalCardQuotes.aspx.cs" Inherits="Presentacion.medicalCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCardQuotes.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="medical">
        <div class="medical-Title">
            <h1>
                <span class="highlight-yellow">Citas</span><br>
                <span class="highlight-blue">Médicas y Vacunas</span>
            </h1>
        </div>
        <main class="medicalMain">
            <section class="medicalListContainer">
                <h1>Citas</h1>
                <div class="medicalList">
                    <asp:Repeater ID="RpDates" runat="server">
                        <ItemTemplate>
                            <div class="hItem">
                                <p><strong>Título:</strong> <%# Eval("Title") %></p>
                                <p><strong>Inicio:</strong> <%# Eval("StartTime", "{0:yyyy/MM/dd}") %></p>
                                <p><strong>Descripción:</strong> <%# Eval("Description") %></p>
                                <p><strong>Finalización:</strong> <%# Eval("EndTime", "{0:yyyy/MM/dd}") %></p>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </section>

            <section class="medicalListContainer">
                <h1>Vacunas</h1>
                <div class="medicalList">
                    <asp:Repeater ID="RpVaccines" runat="server">
                        <ItemTemplate>
                            <div class="hItem">
                                <p><strong>Título:</strong> <%# Eval("Name") %></p>
                                <p><strong>Tipo:</strong> <%# Eval("Type") %></p>
                                <p><strong>Descripción:</strong> <%# Eval("Description") %></p>
                                <p><strong>Fecha:</strong> <%# Eval("DateAplication", "{0:yyyy/MM/dd}") %></p>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </section>
        </main>
        <div class="button-container">
            <a href="addQuote.aspx" class="medicalButton">Agregar Cita</a>
            <a href="addVaccine.aspx" class="medicalButton">Agregar Vacuna</a>
        </div>
    </main>
    <footer class="Footer2"></footer>
</asp:Content>
