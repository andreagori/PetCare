using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addQuote1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendQuote(object sender, EventArgs e)
        {
            int id = (int)Session["IdPet"];
            string title = razon.Text;
            string description = descriptionT.Text;
            
            string sDay = day.Text;
            string sMonth = month.Text;
            string sYear = year.Text;

            string eDay = dayEnd.Text;
            string eMonth = monthEnd.Text;
            string eYear = yearEnd.Text;

            if(title!= string.Empty)
            {
                string start = sYear + "-"+ sMonth +"-"+ sDay;
                string end = eYear + "-"+ eMonth +"-"+ eDay;
                N_Date temp = new N_Date();
                temp.updateQuote(id, title, description, false, false, DateTime.Parse(start), DateTime.Parse(end));
            }
            Response.Redirect("medicalCardQuotes.aspx");
        }
    }
}