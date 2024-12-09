using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocios;
namespace Presentacion
{
    public partial class myHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadHistorical();
        }

        private void LoadHistorical()
        {
            if (Session["IdPet"] != null)
            {
                int idPet = (int)Session["IdPet"];
                List<E_Date> list = new N_Pets().HistoricalPet(idPet);
                if (list != null && list.Count > 0)
                {
                    rpHistory.DataSource = list;
                    rpHistory.DataBind();
                }
                //else
                //{
                //    Response.Write("No hay datos para mostrar.");
                //}

            }
            //else
            //{
            //    Response.Write("No se encontró el IdPet en la sesión.");
            //}
        }
    }
}