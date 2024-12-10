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
    public partial class quoteDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDates();
        }
        protected void LoadDates()
        {
            string quoteTitle = Request.QueryString["Title"];
            if (Session["IdPet"] != null)
            {
                int idPet = (int)Session["IdPet"];
                List<E_Date> Dates = new N_Date().GetDatesPet(idPet);
                for (int i = 0; i < Dates.Count; i++)
                {
                    if (Dates[i].Title == quoteTitle)
                    {
                        RpDates.DataSource = new List<E_Date> { Dates[i] };
                        RpDates.DataBind();
                        break;
                    }
                }
            }
        }
    }
}