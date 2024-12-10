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
            TextBox txtStart = actStart;
            TextBox txtEnd = actEnd;

            if (txtTitle != null && txtDescription != null && txtStart != null && txtEnd != null)
            {
                string title = txtTitle.Text;
                string description = txtDescription.Text;
                string start = txtStart.Text;
                string end = txtEnd.Text;

                N_Date date = new N_Date();
                date.updateDate(id, title, description, false, false, start, end);
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