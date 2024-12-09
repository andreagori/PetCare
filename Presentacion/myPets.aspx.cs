using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class myPets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Owner"] != null)
            {
                LoadPets();
            }

            Session["SourcePage"] = "PageOwner";
        }

        private void LoadPets()
        {
            E_Owner owner = (E_Owner)Session["Owner"];
            List<E_Pet> pets = new N_Owner().GetOwnerPets(owner.IdOwner);
            rpPets.DataSource = pets;
            rpPets.DataBind();
        }
    }
}