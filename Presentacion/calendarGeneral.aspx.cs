using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using Entidades;
using System.Web.UI.HtmlControls;

namespace Presentacion
{
    public partial class calendarGeneral : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDates();
            
        }

        private void LoadDates()
        {
            if (Session["SourcePage"].ToString() == "PagePet")
            {
                if (Session["IdPet"] != null)
                {
                    int id = (int)Session["IdPet"];
                    N_Date dates = new N_Date();
                    List<E_Date> datesList = new N_Date().GetActivitiesPet(id);
                    RpDatesGeneral.DataSource = datesList;
                    RpDatesGeneral.DataBind();
                }
            }

            if (Session["SourcePage"].ToString() == "PageOwner")
            {
                if (Session["Owner"] != null)
                {
                    E_Owner owner = (E_Owner)Session["Owner"];
                    List<E_Date> datesList = new N_Date().GetAllDates(owner.IdOwner);
                    RpDatesGeneral.DataSource = datesList;
                    RpDatesGeneral.DataBind();
                }
            }
        }
    }
}