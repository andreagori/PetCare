using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace Presentacion
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNext(object sender, EventArgs e)
        {
            if (checkData())
            { 
                if (TBPassword.Text == TBConfirmPassword.Text)
                {
                    E_Owner owner = new E_Owner(0, TBName.Text, TBEmail.Text, TBPassword.Text, TBCellPhone.Text, string.Empty, TBAddress.Text, false, true);
                    Session["NewOwner"] = owner;
                    Response.Redirect("~/myData.aspx");

                }
                else
                {
                    //Agregar alerta de contraseña no coinciden
                }
                
            }
            else
            {
                //Agregar alerta de llenar todos los campos
            }

        }
        protected bool checkData()
        {
            if (string.IsNullOrWhiteSpace(TBName.Text) || string.IsNullOrWhiteSpace(TBEmail.Text) || string.IsNullOrWhiteSpace(TBPassword.Text) || string.IsNullOrWhiteSpace(TBCellPhone.Text) || string.IsNullOrWhiteSpace(TBAddress.Text))
            {
                return false;
            }
            return true;
        }
    }
}