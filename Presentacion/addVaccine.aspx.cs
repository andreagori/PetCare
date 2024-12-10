using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addVaccine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void sendVaccine(object sender, EventArgs e)
        {
            int id = (int)Session["IdPet"];
            
            int idCard = new N_Card().GetCard(id);
            string name = nameT.Text;
            string type = typeT.Text;
            string description = descriptionT.Text;

            string sDay = day.Text;
            string sMonth = month.Text;
            string sYear = year.Text;


            if (name != string.Empty)
            {
                string start = sYear + "-" + sMonth + "-" + sDay;
                N_Vaccine temp = new N_Vaccine();
                temp.insertVaccine(0,idCard,name,type,description,DateTime.Parse(start));
            }
            Response.Redirect("medicalCardQuotes.aspx");
        }
    }
}