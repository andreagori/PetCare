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
    public partial class myData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreateUser(Object sender, EventArgs e)
        {
            // Verifica que el usuario haya seleccionado un rol válido.
            if (string.IsNullOrEmpty(ddlRoles.SelectedValue))
            {
                Response.Write("<script>alert('Por favor, selecciona un rol válido.');</script>");
                return; 
            }

            E_Owner owner = (E_Owner)Session["NewOwner"];
            owner.ImgPerfil = "Img";
            string selectedRole = ddlRoles.SelectedValue;
            if (selectedRole == "Owner")
            {
                owner.UserType = true;
            }
            if (selectedRole == "Caregiver")
            {
                owner.UserType = false;
            }

            string selectedAvatar = Request.Form["selectedAvatar"];
            if (!string.IsNullOrEmpty(selectedAvatar))
            {
                owner.ImgPerfil = selectedAvatar;
            }

            string message = new N_Owner().Insert(owner);
            Session["NewOwner"] = null;
            owner = new N_Owner().Login(owner.Email, owner.Password);
            Session["Owner"] = owner;
            Response.Redirect("myPets.aspx");

        }
    }
}