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
                    if(checkDate(sDay,sMonth,sYear))
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
                    lbError.Text = "Asegurese de usar el formato dd/mm/yyyy";
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


        protected bool checkDate(string day, string month, string year)
        {

            if (!int.TryParse(day, out int d) || !int.TryParse(month, out int m) || !int.TryParse(year, out int y))
            {
                return false;
            }


            if (m < 1 || m > 12)
            {
                return false;
            }

            if (y < 2000 || y > 2024)
            {
                return false;
            }

            int daysInMonth;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:

                    if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                    {
                        daysInMonth = 29;
                    }
                    else
                    {
                        daysInMonth = 28;
                    }
                    break;
                default:
                    return false;
            }


            if (d < 1 || d > daysInMonth)
            {
                return false;
            }

            return true;
        }
    }
}