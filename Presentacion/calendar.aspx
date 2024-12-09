<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="calendar.aspx.cs" Inherits="Presentacion.calendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/calendar.css" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="calendar">
        
        <div>
            <h1 style="color: #fea910;">Mi</h1>
            <h1 style="color: #38b6ff;">Calendario</h1>
        </div>

        <section class="description">
            <div>
                <asp:Repeater ID="RpDates" runat="server"  OnItemDataBound="RpDates_ItemDataBound">
                    <ItemTemplate>
                        <asp:Label ID="LbNamePet" runat="server"><strong>Name:</strong><p id="petName"> <%# Eval("NamePet") %> </p></asp:Label>
                        <p><strong>Título:</strong> <%# Eval("Title") %></p>
                        <p><strong>Descripción:</strong> <%# Eval("Description") %></p>
                        <p><strong>Inicio:</strong> <%# Eval("StartTime", "{0:yyyy/MM/dd}") %></p>
                        <p><strong>Finalizacion</strong><%# Eval("StartTime", "{0:yyyy/MM/dd}") %></p>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </section>
        <script>
            const petName = document.getElementById("petName");
            if(petName.textContent === ""){
                petName.style.display = 'none';
            }
        </script>
        <a class="calendarButton" style="background-color:#008cff;" href="addToCalendar.aspx">Agregar</a>
        
        <div id="overlay" class="overlay">
            <div class="modal">
                <h2>Ventana Emergente</h2>
                <p>Este es el contenido de la ventana emergente.</p>
                <button id="closeButton">close</button>
            </div>
        </div>
    </main>
    
    <footer class="Footer2">

    </footer>
    <script>
        let state = false
        const button = document.getElementById("show");
        const buttonClose = document.getElementById("closeButton");
        button.onclick = (event) => { 
            event.preventDefault();
            showModal();
        };
        
        buttonClose.onclick = (event) => { 
            event.preventDefault();
            showModal();
        };
        console.log(state);
        
        function showModal(){
            console.log("Entro con " + state);
            if(!state){
                document.getElementById('overlay').style.display = 'flex';
                state=!state;
            }
            else{
                document.getElementById('overlay').style.display = 'none';    
                state=!state;
            }
        }
    </script>
</asp:Content>
