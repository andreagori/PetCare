﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class addPetBreed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCat_Click(object sender, EventArgs e)
        {
            Response.Redirect("addPetData.aspx?Specie=" + "Cat");
        }
        protected void btnDog_Click(object sender, EventArgs e)
        {
            Response.Redirect("addPetData.aspx?Specie=" + "Dog");
        }
    }
}