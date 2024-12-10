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

        public int IDM_Illness(string action, E_Illiness illnes)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("IDM_Illiness", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Action", action);
            cmd.Parameters.AddWithValue("@idIlliness", illnes.IdIllness);
            cmd.Parameters.AddWithValue("@idCard", illnes.IdCard);
            cmd.Parameters.AddWithValue("@IllinessName", illnes.IllinessName);
            cmd.Parameters.AddWithValue("@Description", illnes.Description);
            cmd.Parameters.AddWithValue("@DateIlliness", illnes.DateIllness);
            cmd.Parameters.AddWithValue("@state", illnes.State);

            try
            {
                AbrirConexion();
                result = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new Exception("Error al querer insertar padecimiento");
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return result;
        }
    }
}
