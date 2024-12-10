using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class userInfo : System.Web.UI.Page
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
                userImage.Attributes["src"] = "assets/avatares/PetCare_Avatares/" + owner.ImgPerfil.ToString();

                userName.Text = owner.Name; 
                correo.Text = owner.Email;   
                celular.Text = owner.CellPhone;  
                direccion.Text = owner.Address; 
            }
        }

        protected void BtCloseSession_OnClick(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/index.aspx");
        }

    }
}