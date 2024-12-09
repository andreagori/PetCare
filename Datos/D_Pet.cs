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
    public class D_Pet : D_Conexion
    {
        public D_Pet() { }

        public int IDM_Pet(string action, E_Pet pet)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("IDM_Pet", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Action", action);
            cmd.Parameters.AddWithValue("@idPet", pet.IdPet);
            cmd.Parameters.AddWithValue("@idOwner", pet.IdOwner);
            cmd.Parameters.AddWithValue("@NamePet", pet.NamePet);
            cmd.Parameters.AddWithValue("@PhotoPet", pet.PhotoPet);
            cmd.Parameters.AddWithValue("@Specie", pet.Specie);
            cmd.Parameters.AddWithValue("@Breed", pet.Breed);
            cmd.Parameters.AddWithValue("@BirthDay", pet.BirthDay);
            cmd.Parameters.AddWithValue("@Age", pet.Age);
            cmd.Parameters.AddWithValue("@Sex", pet.Age);
            cmd.Parameters.AddWithValue("@State", pet.State);

            try
            {
                AbrirConexion();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al querer insertar, borrar o modificar", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return result;
        }
        public List<E_Date> Historical(int idPet)
        {
            List<E_Date> dates = new List<E_Date>();
            SqlCommand cmd = new SqlCommand("HistoricalPet", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@idPet", idPet);
            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    E_Date actualDate = new E_Date()
                    {
                        Title = reader.GetString(0),
                        Description = reader.GetString(1),
                        StartTime = reader.GetDateTime(2),


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

        public List<E_Date> GetOneDatePet(int idPet)
        {
            List<E_Date> dates = new List<E_Date>();
            SqlCommand cmd = new SqlCommand("GetOneDatePet", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@idPet", idPet);
            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                dates = new List<E_Date>();
                while (reader.Read())
                {
                    E_Date actualDate = new E_Date(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetBoolean(4),
                        reader.GetBoolean(5),
                        reader.GetDateTime(6),
                        reader.GetDateTime(7),
                        reader.GetBoolean(8)
                    );
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
