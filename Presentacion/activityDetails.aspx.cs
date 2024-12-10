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
    public partial class activityDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void SubirActividad(object sender, EventArgs e)
        {
            if (checkData())
            {
                int id = (int)Session["IdPet"];
                TextBox txtTitle = actTitle;
                TextBox txtDescription = actDescription;
                string txtDStart = dayStart.Text.PadLeft(2, '0'); 
                string txtMStart = monthStart.Text.PadLeft(2,'0');
                string txtYStart = yearStart.Text;
                
                string txtDEnd = dayEnd.Text.PadLeft(2, '0');
                string txtMEnd = monthEnd.Text.PadLeft(2, '0');
                string txtYEnd = yearEnd.Text;
                

                if (txtDStart.Length == 2 && txtMStart.Length == 2 && txtYStart.Length == 4 && txtDEnd.Length == 2 && txtMEnd.Length == 2 && txtYEnd.Length ==4)
                {
                    if(checkDate(txtDStart,txtMStart,txtYStart) && checkDate(txtDEnd, txtMEnd, txtYEnd))
                    { 
                        string title = txtTitle.Text;
                        string description = txtDescription.Text;
                        string start = txtYStart + "-" +txtMStart + "-" + txtDStart;
                        string end = txtYEnd + "-" + txtMEnd + "-" + txtDEnd;

                        N_Date date = new N_Date();
                        date.updateDate(id, title, description, false, false, DateTime.Parse(start), DateTime.Parse(end));
                        Response.Redirect("calendar.aspx");
                    }
                    else
                    {
                        lbError.Text = "Fecha no valida(2000 - 2030)";
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
        protected void RpDates_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var lbNamePet = (Label)e.Item.FindControl("LbNamePet");

                if (Session["SourcePage"] != null && Session["SourcePage"].ToString() == "PagePet")
                {
                    lbNamePet.Visible = false;
                }
                else
                {
                    lbNamePet.Visible = true;
                }
            }
        }

        protected bool checkData()
        {
            if (string.IsNullOrEmpty(actTitle.Text) || string.IsNullOrEmpty(actDescription.Text) || string.IsNullOrEmpty(dayStart.Text) ||
                string.IsNullOrEmpty(monthStart.Text) || string.IsNullOrEmpty(yearStart.Text) || string.IsNullOrEmpty(dayEnd.Text) ||
                string.IsNullOrEmpty(monthEnd.Text) || string.IsNullOrEmpty(yearEnd.Text))
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

            if (y < 2000 || y > 2030)
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