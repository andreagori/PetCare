﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Entidades;

namespace Presentacion
{
    public partial class myPetActions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["IdPet"];
            string name = Request.QueryString["NamePet"];
            Session["SourcePage"] = "PagePet";
            if (int.TryParse(id, out int newId))  // Asegúrate de que sea un número entero
            {
                // Almacenar el IdPet en la sesión
                Session["IdPet"] = newId;
                wantedPosterLink.NavigateUrl = "wantedPoster.aspx?IdPet=" + newId + "&NamePet="+name;
                medicalCardLink.NavigateUrl = "medicalCard.aspx?IdPet=" + newId + "&NamePet="+name;
            }
            else
            {
                // Manejar el caso si no se pasa un valor válido
                Response.Write("ID de mascota no válido.");
            }
            LoadName();
        }

        private void LoadName()
        {
            string namePet = Request.QueryString["NamePet"];

            if (!string.IsNullOrEmpty(namePet))
            {
                LbNamePet.Text = namePet;
            }
            else
            {
                LbNamePet.Text = "Nombre no disponible";
            }
        }
    }
}