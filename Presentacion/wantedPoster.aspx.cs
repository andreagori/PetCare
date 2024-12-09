using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocios;
using Datos;
using System.Xml.Linq;

namespace Presentacion
{
    public partial class wantedPoster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadName();
        }

        private void LoadName()
        {
            string namePet = Request.QueryString["NamePet"];
            string id = Request.QueryString["IdPet"];
            int idpet = int.Parse(id);
            
            E_Owner owner = (E_Owner)Session["Owner"];
            
            // Cargar datos de mascota
            List<E_Pet> list = new N_Owner().GetOwnerPets(owner.IdOwner);
            E_Pet currentPet = new E_Pet();
            for(int i=0;i<list.Count; i++)
            {
                if(idpet == list[i].IdPet)
                {
                    currentPet = list[i];
                    break;
                }
            }

            // Modificar DOM
            if (!string.IsNullOrEmpty(namePet))
            {
                petName.Text = namePet;
                string sex = currentPet.Sex ? "Male" : "Female";
                petData.Text = namePet + " "+ currentPet.Age + " " + sex;
                ownerData.Text = owner.Name + " " + owner.CellPhone + " " + owner.Address;
            }
            else
            {
                petName.Text = "Nombre no disponible";
            }
        }
    }
}