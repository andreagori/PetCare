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
            if (checkData())
            {
                int id = (int)Session["IdPet"];

                int idCard = new N_Card().GetCard(id);
                string name = nameT.Text;
                string type = typeT.Text;
                string description = descriptionT.Text;

                string sDay = day.Text;
                string sMonth = month.Text;
                string sYear = year.Text;


                if (sDay.Length == 2 && sMonth.Length == 2 && sYear.Length == 4)
                {
                    string start = sYear + "-" + sMonth + "-" + sDay;
                    N_Vaccine temp = new N_Vaccine();
                    temp.insertVaccine(0, idCard, name, type, description, DateTime.Parse(start));

                    Response.Redirect("medicalCardQuotes.aspx");
                }
                else
                {
                    lbError.Text = "Por favor, coloque la fecha en el formato indicado";
                    lbError.Visible = true;
                }
            }
            else
            {
                lbError.Text = "Por favor, llene todos los campos";
                lbError.Visible = true;
            }
        }

        protected bool checkData()
        {
            if (string.IsNullOrEmpty(nameT.Text) || string.IsNullOrEmpty(typeT.Text) || string.IsNullOrEmpty(descriptionT.Text) || string.IsNullOrEmpty(day.Text) || string.IsNullOrEmpty(month.Text) || string.IsNullOrEmpty(year.Text))
            {
                return false;
            }
            return true;
        }
    }
}