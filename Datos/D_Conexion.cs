using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Conexion
    {
        public SqlConnection Conexion;

        public D_Conexion()
        {
            Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["D_Conexion"].ConnectionString);
        }

        public void AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Broken || Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

    }
}
