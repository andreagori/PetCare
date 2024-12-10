using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocios;
namespace Presentacion
{
    public partial class addIllness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtAddIllness_OnClick(object sender, EventArgs e)
        {
            if(checkData())
            {
                int idPet = (int)Session["IdPet"];
                int idCard = new N_Card().GetCard(idPet);
                string d = TbDay.Text.PadLeft(2,'0');
                string m = TbMonth.Text.PadLeft(2, '0');
                string y = TbYear.Text;
                if (y.Length == 4 && m.Length == 2 && m.Length == 2)
                {
                    if (checkDate(d, m, y))
                    {
                        string date = d + "-" + m + "-" + y;
                        E_Illiness newIllness = new E_Illiness(0, idCard, TbIllnessName.Text, TbDescription.Text, DateTime.Parse(date), true);
                        new N_Illness().Insert(newIllness);
                        Response.Redirect("~/myPets.aspx");
                    }
                    else
                    {
                        LbMessage.Text = "Fecha escrita en el formato incorrecto";
                        LbMessage.Visible = true;
                    }
                }
                else
                {
                    LbMessage.Text = "Fecha no valida(2000 - 2024)";
                    LbMessage.Visible = true;
                }
            }
            else
            {
                LbMessage.Text = "Por favor llene todos los campos";
                LbMessage.Visible = true;
            }
        }

        protected bool checkData()
        {
            if(string.IsNullOrEmpty(TbIllnessName.Text) || string.IsNullOrEmpty(TbDescription.Text) || string.IsNullOrEmpty(TbDay.Text)
                || string.IsNullOrEmpty(TbMonth.Text) || string.IsNullOrEmpty(TbYear.Text))
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