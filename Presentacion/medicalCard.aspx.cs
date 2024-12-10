using Datos;
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
                int idCard = new N_Card().GetCard(idPet);

                List<E_Illiness> illinesses = new N_Illness().GetIllinesPet(idCard);
                RpIllness.DataSource = illinesses;
                RpIllness.DataBind();

                string id = Request.QueryString["IdPet"];
                int idpet = int.Parse(id);
                E_Pet pet = new N_Owner().GetPet(idpet);
                nameIn.Text = pet.NamePet;
                breed.Text = pet.Breed;
                sex.Text = pet.Sex ? "female" : "male";
                day.Text = pet.BirthDay.ToString("d");
                weight.Text = pet.Weight.ToString();
            }
        }
    }
}