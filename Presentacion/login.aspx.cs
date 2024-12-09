using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocios;
using Datos;

namespace Presentacion
{
    public partial class loggin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Owner"] != null)
            {
                Response.Redirect("~/myPets.aspx");
            }
        }

        protected void btnLogin(object sender, EventArgs e)
        {
            try
            {
                E_Owner owner = new E_Owner();
                N_Owner n_Owner = new N_Owner();
                owner = n_Owner.Login(TBEmail.Text, TBPassword.Text);

                if (owner != null)
                {
                    Session["Owner"] = owner;
                    Response.Redirect("~/myPets.aspx");
                }
            }
            catch (ArgumentException ex)
            {
                lblErrorMessage.Text = ex.Message;
                lblErrorMessage.Visible = true;
            }
        }

        protected void goToIndex(object sender, EventArgs e)
        {
            Response.Redirect("~/index.aspx");
        }
    }
}