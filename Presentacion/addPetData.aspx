<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="addPetData.aspx.cs" Inherits="Presentacion.addPetData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/addPetData.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="addPet">
        <div class="addPet-Title">
            <h1 class="highlight-yellow">Mi</h1>
            <asp:Label ID="LbSpeciePet" class="highlight-blue" runat="server"></asp:Label>
        </div>
        <section>
            <h3>Nombre</h3>
            <asp:TextBox ID="TbNamePet" type="Text" runat="server"></asp:TextBox>
        </section>
        <div class="petRow">
            <h3>Raza</h3>
            <h3>Genero</h3>
            <asp:TextBox ID="TbBreed" type="Text" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DdlSex" CssClass="dropdown-list" runat="server" OnSelectedIndexChanged="DdlSex_SelectedIndexChanged">
                <asp:ListItem Text="Selecciona" Value="" />
                <asp:ListItem Text="Macho" Value="Male"/>
                <asp:ListItem Text="Hembra" Value="Female"/>
            </asp:DropDownList>
        </div>
        <div class="petBirthdateRow">
            <h3>Fecha de nacimiento D/M/Y</h3>
            <asp:TextBox ID="TbYear" type="Number" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbMounth" type="Number" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbDay" type="Number" runat="server"></asp:TextBox>
        </div>

        <div class ="petRow">
            <h3>Edad</h3>
            <h3>Peso</h3>
            <asp:TextBox ID="TbAge" type="Number" runat="server"></asp:TextBox>
            <asp:TextBox ID="TbWeight" type="Number" runat="server"></asp:TextBox>
        </div>
        
        <section>
            <h3>Avatar</h3>
            <div id="AvatarPet" class="petAvatar">
                <img id="img1" runat="server"/>
                <img id="img2" runat="server"/>
                <img id="img3" runat="server"/>
                <img id="img4" runat="server"/>
                <img id="img5" runat="server"/>
                <img id="img6" runat="server"/>
                <img id="img7" runat="server"/>
                <img id="img8" runat="server"/>
            </div>
            <input type="hidden" id="selectedAvatar" name="selectedAvatar" />
        </section>
        <asp:Button CssClass="petButton centered-text" runat="server" Text="Siguiente" OnClick="BtnNext_OnClick" />
        <script>
            var avatares = document.getElementById("AvatarPet");
            avatares.addEventListener("click", function (e) {
                var avatar = e.target;

                if (avatar.tagName.toLowerCase() === "img") {
                    // Quitar el borde de todas las imágenes
                    var avatares = document.querySelectorAll("#AvatarPet img");
                    avatares.forEach(function (img) {
                        img.style.border = "none";
                    });

                    // Agregar borde al avatar seleccionado
                    avatar.style.border = "2px solid #fea910";

                    // Guardar la ruta completa del archivo en el campo oculto
                    var avatarPath = avatar.getAttribute("src"); // Obtener la ruta completa
                    document.getElementById("selectedAvatar").value = avatarPath;

                    console.log("Avatar seleccionado (ruta completa): " + avatarPath); // Para depuración
                }
            });
        </script>
    </main>
    <footer class="Footer2">

    </footer>
</asp:Content>
