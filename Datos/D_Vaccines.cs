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
    public class D_Vaccine : D_Conexion
    {
        public List<E_Vaccine> GetVaccines(int idCard)
        {
            List<E_Vaccine> dates = new List<E_Vaccine>();
            SqlCommand cmd = new SqlCommand("GetCardVeccines", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@idCard", idCard);
            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                dates = new List<E_Vaccine>();
                while (reader.Read())
                {
                    E_Vaccine actualVaccine = new E_Vaccine()
                    {
                        IdVaccine = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Type = reader.GetString(2),
                        Description = reader.GetString(3),
                        DateAplication = reader.GetDateTime(4).ToString(),
                        State = true,

                    };
                    dates.Add(actualVaccine);
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

        public void insertVaccine(int idVaccine, int idCard, string name, string type, string description, DateTime dateAplication)
        {
            SqlCommand cmd = new SqlCommand("IDM_Vaccines", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Action", "INSERT");
            cmd.Parameters.AddWithValue("@idVaccine", 0);
            cmd.Parameters.AddWithValue("@idCard", idCard);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@dateAplication", dateAplication);
            cmd.Parameters.AddWithValue("@State", true);
            
            try
            {
                // Abrir conexión y ejecutar el comando
                AbrirConexion();
                cmd.ExecuteNonQuery(); // Usar ExecuteNonQuery para comandos que no devuelven datos
            }
            catch (Exception e)
            {
                // Manejar errores
                throw new Exception("Error al insertar datos en la base de datos", e);
            }
            finally
            {
                // Cerrar la conexión y liberar recursos
                CerrarConexion();
                cmd.Dispose();
            }
        }
    }
}
