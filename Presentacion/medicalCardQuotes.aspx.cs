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
    public partial class medicalCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDates();
            LoadVaccines();
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
        
        protected void LoadVaccines()
        {
            if (Session["IdPet"] != null)
            {
                int id = 2;
                List<E_Vaccine> vaccines = new N_Vaccine().GetVaccines(id);
                RpVaccines.DataSource = vaccines;
                RpVaccines.DataBind();
            }
        }
    }
}