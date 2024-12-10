using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace Presentacion
{
    public partial class inside : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Owner"] == null)
            {
                Response.Redirect("~/login.aspx"); 
            }
            else
            {
                E_Owner owner = (E_Owner)Session["Owner"];
                IPerfil.Attributes["src"] = "assets/avatares/PetCare_Avatares/" + owner.ImgPerfil.ToString();
            }
        }
    }
}