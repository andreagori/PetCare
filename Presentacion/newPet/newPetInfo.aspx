<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newPetInfo.aspx.cs" Inherits="Presentacion.newPetInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>PetCare</title>
<link rel="stylesheet" href="../CSS/base.css"/>
<link rel="stylesheet" href="../CSS/newPetInfo.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <a href="../index.aspx" style="position: absolute;"><img src="../assets/buttons/returnYellow.png" /></a>
        <main class="petInfoBase">
            <h1>Mi perro</h1>
            <section>
                <h3>Nombre</h3>
                <input placeholder="Nombre">
            </section>
            <section>
                <h3>Raza</h3>
                <input placeholder="Raza">
            </section>
            <section>
                <h3>Fecha de nacimiento</h3>
                <input type="date">
            </section>
            <section>
                <h3>Peso</h3>
                <input placeholder="Peso" type="number">
            </section>
            <section>
                <h3>Padecimientos</h3>
                <input placeholder="Padecimientos">
            </section>
        </main>
        <section class="bottom">
            <img src="../assets/avatares/PetCare_Avatares/av1.png" /> User
        </section>
    </form>
</body>
</html>
