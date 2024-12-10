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
            SqlCommand cmd = new SqlCommand("IDM_Pets", Conexion)
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
            cmd.Parameters.AddWithValue("@Weight", pet.Weight);
            cmd.Parameters.AddWithValue("@Age", pet.Age);
            cmd.Parameters.AddWithValue("@Sex", pet.Sex);
            cmd.Parameters.AddWithValue("@ShareCode", pet.ShareCode);
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

        public E_Pet GetPetById(int idPet)
        {
            E_Pet pet = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pets WHERE IdPet = @IdPet", Conexion);
            cmd.Parameters.AddWithValue("@IdPet", idPet);

            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pet = new E_Pet
                    {
                        IdPet = (int)reader["IdPet"],
                        NamePet = reader["NamePet"].ToString(),
                        Specie = reader["Specie"].ToString(),
                        Breed = reader["Breed"].ToString(),
                        Age = (int)reader["Age"],
                        Sex = (bool)reader["Sex"],
                        Weight = (int)reader["Weight"]
                        // Agrega otros campos necesarios aquí
                    };
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los datos de la mascota", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return pet;
        }


    }

}
