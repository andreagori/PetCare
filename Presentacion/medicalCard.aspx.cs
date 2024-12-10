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
            illiness.Text = "Cositas";

            /*
            E_Owner owner = (E_Owner)Session["Owner"];
            List<E_Pet> pets = new N_Owner().GetOwnerPets(owner.IdOwner);
            for(int i = 0;i<pets.Count; i++)
            {
                string currentId = pets[i].IdPet.ToString();
                if(id == currentId)
                {
                    nameIn.Text = pets[i].NamePet;
                    breed.Text = pets[i].Breed;
                    sex.Text = pets[i].Sex? "female" : "male";
                    day.Text = pets[i].BirthDay.ToString();
                    weight.Text = 0.ToString();
                    illiness.Text = "Cositas";

                    break;
                }
            }
            */
        }
        protected void goToQuotes(object sender, EventArgs e)
        {
            Response.Redirect("~/medicalCardQuotes.aspx");
        }
    }
}