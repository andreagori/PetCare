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
            if (TBPassword.Text == TBConfirmPassword.Text)
            {
                E_Owner owner = new E_Owner(0,TBName.Text, TBEmail.Text, TBPassword.Text,TBCellPhone.Text,string.Empty,TBAddress.Text,false,true);
                Session["NewOwner"] = owner;
                Response.Redirect("~/myData.aspx");

            }
            else
            {
                //Agregar alerta de contraseña no coinciden
            }
        }
        //IdOwner = idOwner;
        //    Name = name;
        //    Email = email;
        //    Password = password;
        //    CellPhone = cellPhone;
        //    ImgPerfil = imgPerfil;
        //    Address = address;
        //    UserType = userType;
        //    State = state;
    }
}