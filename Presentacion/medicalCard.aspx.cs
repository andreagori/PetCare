using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class medicalCard1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["IdPet"];
            
            int idpet = int.Parse(id);
            
            E_Pet pet = new N_Owner().GetPet(1);
            nameIn.Text = pet.NamePet;
            breed.Text = pet.Breed;
            sex.Text = pet.Sex ? "female" : "male";
            day.Text = pet.BirthDay.ToString();
            weight.Text = pet.Weight.ToString();
            LoadDates();
        }
        protected void goToQuotes(object sender, EventArgs e)
        {
            Response.Redirect("~/medicalCardQuotes.aspx");
        }
        protected void LoadDates()
        {
            if (Session["IdPet"] != null)
            {
                int idPet = (int)Session["IdPet"];
                List<E_Date> Dates = new N_Date().GetDatesPet(idPet);
                RpDates.DataSource = Dates;
                RpDates.DataBind();
            }
        }
    }
}