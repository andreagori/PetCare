using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class D_Illiness : D_Conexion
    {
        public List<E_Illiness> GetIllinesPet(int idCard)
        {
            List<E_Illiness> dates = new List<E_Illiness>();
            SqlCommand cmd = new SqlCommand("GetCardIlliness", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@idCard", idCard);
            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    E_Illiness actill= new E_Illiness {
                        IdIllness = reader.GetInt32(1),
                        IllinessName = reader.GetString(2),
                        Description = reader.GetString(3),
                        DateIllness = reader.GetDateTime(4),
                    };
                    dates.Add(actill);

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
            return dates;
        }
    }
}
