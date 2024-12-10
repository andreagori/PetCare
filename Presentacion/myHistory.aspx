<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="myHistory.aspx.cs" Inherits="Presentacion.myHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/myHistory.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="history">
        <div>
            <h1>Mi</h1>
            <h1>Historial</h1>
        </div>

        <section class="historyData">
            <asp:Repeater ID="rpHistory" runat="server">
                <ItemTemplate>
                    <div class="hItem">
                        <p><strong>Título:</strong> <%# Eval("Title") %></p>
                        <p><strong>Descripción:</strong> <%# Eval("Description") %></p>
                        <p><strong>Fecha:</strong> <%# Eval("StartTime", "{0:yyyy/MM/dd}") %></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </section>

        <asp:Button ID="btnExportPdf" runat="server" Text="Exportar" OnClick="ExportToPdf" />
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
