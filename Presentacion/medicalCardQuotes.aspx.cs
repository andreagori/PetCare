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
        }

        protected void LoadDates()
        {
            if (Session["IdPet"] != null)
            {
                int idPet = (int)Session["IdPet"];
                List<E_Date> Dates = new N_Date().GetDatesPet(idPet);
                RpDates.DataSource = Dates;
                RpVaccines.DataSource = Dates;
                RpVaccines.DataBind();
                RpDates.DataBind();
            }
        }
    }
}