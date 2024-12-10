<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="addVaccine.aspx.cs" Inherits="Presentacion.addVaccine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/addVaccine.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="vc">
        <div class="vcTitle">
            <h1 style="color:#fea910;">Agregar</h1>
            <h1 style="color:#38b6ff;">Vacuna</h1>
        </div>
        
        <asp:Label runat="server" ID="lbError" Text="" Visible="false" ForeColor="Red" />
        
        <div class="vcLabel">
            <section>
                <h3>Nombre</h3>
                <asp:TextBox cssclass="vcInput" runat="server" Text="" ID="nameT"/>
            </section>
            
            <section>
                <h3>Tipo</h3>
                <asp:TextBox cssclass="vcInput" runat="server" Text="" ID="typeT"/>
            </section>
    
    
            <div class="quoteBirthdateRow">
                <h3>Dia de aplicación</h3>
                <h3>Mes de aplicación</h3>
                <h3>Año de aplicación</h3>
                <asp:TextBox cssclass="vcInput" runat="server" Text="" ID="day"/>
                <asp:TextBox cssclass="vcInput" runat="server" Text="" ID="month"/>
                <asp:TextBox cssclass="vcInput" runat="server" Text="" ID="year"/>
            </div>
        
            <section>
                <h3>Descripcion</h3>
                <asp:TextBox cssclass="vcInput" runat="server" Text=""  ID="descriptionT"/>
            </section>
        </div>

        <asp:Button cssclass="vcSend" runat="server" onclick="sendVaccine" Text="Agregar Vacuna"/>
    </main>
    
</asp:Content>
