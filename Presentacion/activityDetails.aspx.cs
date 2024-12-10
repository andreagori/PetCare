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
            int id = (int)Session["IdPet"];
            TextBox txtTitle = actTitle;
            TextBox txtDescription = actDescription;
            string txtDStart = dayStart.Text.PadLeft(2, '0'); 
            string txtMStart = monthStart.Text.PadLeft(2,'0');
            string txtYStart = yearStart.Text;
            
            string txtDEnd = dayEnd.Text.PadLeft(2, '0');
            string txtMEnd = monthEnd.Text.PadLeft(2, '0');
            string txtYEnd = yearEnd.Text;
            

            if (txtTitle != null && txtDescription != null && txtDStart != null && txtYEnd != null)
            {
                string title = txtTitle.Text;
                string description = txtDescription.Text;
                string start = txtYStart + "-" +txtMStart + "-" + txtDStart;
                string end = txtYEnd + "-" + txtMEnd + "-" + txtDEnd;

                N_Date date = new N_Date();
                date.updateDate(id, title, description, false, false, DateTime.Parse(start), DateTime.Parse(end));
            }
            Response.Redirect("calendar.aspx");
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
    }
}