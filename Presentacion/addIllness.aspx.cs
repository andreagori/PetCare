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
                    string date = d + "-" + m + "-" + y;
                    E_Illiness newIllness = new E_Illiness(0,idCard,TbIllnessName.Text,TbDescription.Text,DateTime.Parse(date),true);
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
    }
}