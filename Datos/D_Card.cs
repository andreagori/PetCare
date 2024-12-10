using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Card : D_Conexion
    {
        public int GetCard(int idPet)
        {
            int actCard = 0;
            SqlCommand cmd = new SqlCommand("GetIdCard", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@idPet", idPet);
            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    actCard = reader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al querer obtener los datos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return actCard;

        }
    }
}
