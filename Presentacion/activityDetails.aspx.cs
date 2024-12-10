﻿using Entidades;
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
                LoadDates();
            }
        }
        private void LoadDates()
        {
            string title = Request.QueryString["Title"];
            if (Session["SourcePage"].ToString() == "PagePet")
            {
                if (Session["IdPet"] != null)
                {
                    int id = (int)Session["IdPet"];
                    List<E_Date> datesList = new N_Date().GetActivitiesPet(id);
                    for(int i=0; i < datesList.Count; i++)
                    {
                        if (datesList[i].Title == title)
                        {
                            RpDates.DataSource = new List<E_Date> { datesList[i] };
                            RpDates.DataBind();
                            break;
                        }
                    }
                }
            }

            if (Session["SourcePage"].ToString() == "PageOwner")
            {
                if (Session["Owner"] != null)
                {
                    E_Owner owner = (E_Owner)Session["Owner"];
                    List<E_Date> datesList = new N_Date().GetAllDates(owner.IdOwner);
                    for (int i = 0; i < datesList.Count; i++)
                    {
                        if (datesList[i].Title == title)
                        {
                            RpDates.DataSource = new List<E_Date> { datesList[i] };
                            RpDates.DataBind();
                            break;
                        }
                    }
                }
            }
        }

        protected void SubirActividad(object sender, EventArgs e)
        {
            int id = (int)Session["IdPet"];
            foreach (RepeaterItem item in RpDates.Items)
            {
                TextBox txtTitle = item.FindControl("actTitle") as TextBox;
                TextBox txtDescription = item.FindControl("actDescription") as TextBox;
                TextBox txtStart = item.FindControl("actStart") as TextBox;
                TextBox txtEnd = item.FindControl("actEnd") as TextBox;

                if (txtTitle != null && txtDescription != null && txtStart != null && txtEnd != null)
                {
                    string title = txtTitle.Text;
                    string description = txtDescription.Text;
                    string start = txtStart.Text;
                    string end = txtEnd.Text;

                    N_Date date = new N_Date();
                    date.updateDate(id, title, description, false, false, start, end);
                }
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
    }
}