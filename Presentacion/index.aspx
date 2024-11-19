﻿ <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.WebForm1" %> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>PetCare</title>
    <link rel="icon" href="assets/icons/Logo.png" type="image/png"/>

    <!-- FUENTE -->
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet"/>
    
    <!-- CSS -->
    <link rel="stylesheet" href="CSS/base.css" type="text/css"/>
    <link rel="stylesheet" href="CSS/login.css" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <section class="loginBackground">
            <main class="loginContainer">
                <img src="assets/icons/Logo.png"/>
                <div class="LsButtons">
                    <asp:HyperLink runat="server" NavigateUrl="~/login.aspx" CssClass="HyperLink">
                        Iniciar sesion
                    </asp:HyperLink>
                    
                    <asp:HyperLink runat="server" NavigateUrl="~/login.aspx" CssClass="HyperLink">
                        Registrase
                    </asp:HyperLink>
                    
                    
                </div>
            </main>
        </section>
    </form>
</body>
</html>
