﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class medicalCard1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void goToQuotes(object sender, EventArgs e)
        {
            Response.Redirect("~/medicalCardQuotes.aspx");
        }
    }
}