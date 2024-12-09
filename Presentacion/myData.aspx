<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="myData.aspx.cs" Inherits="Presentacion.myData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="dataMain">
        <div>
            <h1 style="color:#fea910;">Mis</h1>
            <h1 style="color:#38b6ff;">Datos</h1>
        </div>

        <section id="birthdateSection">
            <h3>Fecha de nacimiento</h3>
            <div class="myDataRow">
                <input placeHolder="Dia" type="number"/>
                <input placeHolder="Mes" type="number"/>
                <input placeHolder="Año" type="number"/>
            </div>
        </section>
        
        <section id="rolSection">
            <h3>Rol</h3>
                <asp:DropDownList ID="ddlRoles" runat="server">
                    <asp:ListItem Text="Selecciona un rol" Value="" />
                    <asp:ListItem Text="Dueño" Value="Owner" />
                    <asp:ListItem Text="Cuidador" Value="Caregiver" />
                </asp:DropDownList>
        </section>

        <section id="ownerAvatarSection">
            <h3>Avatar</h3>
            <div id="avatares" class="ownerAvatares">
                <img src="assets/avatares/PetCare_Avatares/av1.png"/>
                <img src="assets/avatares/PetCare_Avatares/av2.png"/>
                <img src="assets/avatares/PetCare_Avatares/av3.png"/>
                <img src="assets/avatares/PetCare_Avatares/av4.png"/>
                <img src="assets/avatares/PetCare_Avatares/av5.png"/>
                <img src="assets/avatares/PetCare_Avatares/av6.png"/>
            </div>
            <input type="hidden" id="selectedAvatar" name="selectedAvatar" />
        </section>
        <script>
            var avatares = document.getElementById("avatares");
            avatares.addEventListener("click", function (e) {
                var avatar = e.target;
        
                if (avatar.tagName.toLowerCase() === "img") {
                    // Quitar el borde de todas las imágenes
                    var avatares = document.querySelectorAll("#avatares img");
                    avatares.forEach(function (img) {
                        img.style.border = "none";
                    });
        
                    // Agregar borde al avatar seleccionado
                    avatar.style.border = "2px solid #fea910";
        
                    // Guardar el nombre del archivo en el campo oculto
                    var avatarPath = avatar.getAttribute("src");
                    var avatarName = avatarPath.split("/").pop(); // Extraer solo el nombre del archivo
                    document.getElementById("selectedAvatar").value = avatarName;
        
                    console.log("Avatar seleccionado: " + avatarName); // Para depuración
                }
            });
        </script>
        <asp:Button OnClick="BtnCreateUser" style="background-color:#fea910;" Text="Crear" runat="server"></asp:Button>
    </main>
    <footer class="Footer2">
    
    </footer>
</asp:Content>
