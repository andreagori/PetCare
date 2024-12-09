using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace Presentacion
{
    public partial class myPetActions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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