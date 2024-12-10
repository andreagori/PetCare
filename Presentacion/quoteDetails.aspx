<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="quoteDetails.aspx.cs" Inherits="Presentacion.quoteDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/medicalCardQuotes.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="CSS/medicalCardQuotes.css" type="text/css" />

    <main class="medical">
        <div>
            <h1>Titulo</h1>
        </div>

        <main class="medicalMain">
            <section class="quoteDetails">
                <asp:Repeater ID="RpDates" runat="server">
                    <ItemTemplate>         
                        <a>
                            <h3><strong>Título:</strong> <%# Eval("Title") %></h3>
                            <h4><strong>Inicio:</strong> <%# Eval("StartTime", "{0:yyyy/MM/dd}") %></h4>
                            <p><strong>descripcion:</strong><%# Eval("Description") %> </p>
                            <h4><strong>Finalizacion:</strong><%# Eval("EndTime", "{0:yyyy/MM/dd}") %></h4>
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
            </section>
        </main>



        <a class="medicalButton" style="background-color:#008cff;" href="addQuote.aspx">Agregar</a>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
