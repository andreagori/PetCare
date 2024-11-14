<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>PetCare</title>

    <!-- FUENTE -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet">
    
    <!-- CSS -->
    <link rel="stylesheet" href="CSS/base.css" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
        <img style="position: absolute; z-index: -1; height: 100vh; width: 100vw;" src="assets/BackGround.png">
        <div class="loginSection">
            <img src="assets/images (1).jpeg">
            <div class="LsButtons">
                <button id="LoginBu">Iniciar sesion</button>
                <button id="RegisterBu">Registrarse</button>
            </div>
        </div>
    </form>
</body>
</html>
