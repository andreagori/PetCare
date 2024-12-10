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
            if (checkData())
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

                if (sDay.Length == 2 && sMonth.Length == 2 && sYear.Length == 4 && eDay.Length == 2 && eMonth.Length == 2 && eYear.Length == 4)
                { 
                    string start = sYear + "-"+ sMonth +"-"+ sDay;
                    string end = eYear + "-"+ eMonth +"-"+ eDay;
                    N_Date temp = new N_Date();
                    temp.updateQuote(id, title, description, false, false, DateTime.Parse(start), DateTime.Parse(end));
                
                    Response.Redirect("medicalCardQuotes.aspx");
                }
                else
                {
                    lberror.Text = "Asegurese de usar el formato dd/mm/yyyy";
                    lberror.Visible = true;
                }
            }
            else
            {
                lberror.Text = "Favor de llenar todos los campo";
                lberror.Visible = true;
            }
        }

        protected bool checkData()
        {
            if (string.IsNullOrEmpty(razon.Text) || string.IsNullOrEmpty(descriptionT.Text) || string.IsNullOrEmpty(day.Text) ||
                string.IsNullOrEmpty(month.Text) || string.IsNullOrEmpty(year.Text) || string.IsNullOrEmpty(dayEnd.Text) ||
                string.IsNullOrEmpty(monthEnd.Text) || string.IsNullOrEmpty(yearEnd.Text))
            {
                return false;
            }
            return true;
        }
    }
}