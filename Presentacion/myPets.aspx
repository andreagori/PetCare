<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myPets.aspx.cs" Inherits="Presentacion.myPets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>PetCare</title>
    <link rel="stylesheet" href="CSS/myPets.css"/>
    <link rel="stylesheet" href="CSS/base.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <a href="index.aspx" style="position: absolute;"><img src="assets/buttons/returnYellow.png" /></a>
        <main class="mpPets">
            <h1>Mis mascotas</h1>
            <section>Aqui estara la lista</section>
            <button>Agregar</button>
        </main>
        <section class="bottom">
            <img src="assets/avatares/PetCare_Avatares/av1.png" /> User
        </section>
    </form>
</body>
</html>
