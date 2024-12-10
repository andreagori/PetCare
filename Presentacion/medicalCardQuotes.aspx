<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="medicalCardQuotes.aspx.cs" Inherits="Presentacion.medicalCard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCardQuotes.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="medical">
        <div>
            <h1>Datos medicos extra</h1>
        </div>

        <main class="medicalMain">
            <section class="medicalList">
                <h1>Citas</h1>
                <asp:Repeater ID="RpDates" runat="server">
                    <ItemTemplate>         
                        <a href="quoteDetails.aspx?Title=<%# Eval("Title") %>">
                            <h3><strong>Título:</strong> <%# Eval("Title") %></h3>
                            <h4><strong>Inicio:</strong> <%# Eval("StartTime", "{0:yyyy/MM/dd}") %></h4>
                            <p><strong>descripcion:</strong><%# Eval("Description") %> </p>
                            <h4><strong>Finalizacion:</strong><%# Eval("EndTime", "{0:yyyy/MM/dd}") %></h4>
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
            </section>
            
            <section class="medicalList">
                <h1>Vacunas</h1>
                <asp:Repeater ID="RpVaccines" runat="server">
                    <ItemTemplate>         
                        <a>
                            <h3><strong>Título:</strong> <%# Eval("Name") %></h3>
                            <h4><strong>Inicio:</strong> <%# Eval("Type") %></h4>
                            <p><strong>descripcion:</strong><%# Eval("Description") %> </p>
                            <h4><strong>Finalizacion:</strong><%# Eval("DateAplication", "{0:yyyy/MM/dd}") %></h4>
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
            </section>
        </main>

        <a href="addQuote.aspx">Agregar cita</a>
        <a href="addVaccine.aspx">Agregar Vacuna</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
