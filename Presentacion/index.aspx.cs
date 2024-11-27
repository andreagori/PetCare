using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goToLogin(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
        
        protected void goToRegister(object sender, EventArgs e)
        {
            Response.Redirect("~/register.aspx");
        }
    }
}