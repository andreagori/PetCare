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
    public class D_Date : D_Conexion
    {
        public List<E_Date> GetOneDatePet(int idPet,string Action)
        {
            List<E_Date> dates = new List<E_Date>();
            SqlCommand cmd = new SqlCommand("GetOneDatePet", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Action", Action);
            cmd.Parameters.AddWithValue("@idPet", idPet);
            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                dates = new List<E_Date>();
                while (reader.Read())
                {
                    E_Date actualDate = new E_Date()
                    {
                        IdDate =  reader.GetInt32(0),
                        IdPet = reader.GetInt32(1),
                        Title = reader.GetString(2),
                        Description = reader.GetString(3),
                        DateType = reader.GetBoolean(4),
                        AddedBy = reader.GetBoolean(5),
                        StartTime = reader.GetDateTime(6),
                        EndTime = reader.GetDateTime(7),
                        State = reader.GetBoolean(8)


                    };
                    dates.Add(actualDate);
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

        public List<E_Date> GetAllDates(int idOwner)
        {
            List<E_Date> dates = new List<E_Date>();
            SqlCommand cmd = new SqlCommand("GetAllDates", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Action", "All");
            cmd.Parameters.AddWithValue("@idOwner", idOwner);
            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                dates = new List<E_Date>();
                while (reader.Read())
                {
                    E_Date actualDate = new E_Date()
                    {
                        NamePet = reader.GetString(0),
                        Title = reader.GetString(1),
                        Description = reader.GetString(2),
                        AddedBy = reader.GetBoolean(3),
                        StartTime = reader.GetDateTime(4),
                        EndTime = reader.GetDateTime(5),
                        DateType = reader.GetBoolean(6)


                    };
                    dates.Add(actualDate);
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
