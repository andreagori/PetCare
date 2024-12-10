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
    public class D_Owner : D_Conexion
    {
        public D_Owner() { }

        public int IDM_Owner(string action, E_Owner owner)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("IDM_Owners", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Action", action);
            cmd.Parameters.AddWithValue("@idOwner", owner.IdOwner);
            cmd.Parameters.AddWithValue("@Name", owner.Name);
            cmd.Parameters.AddWithValue("@Email", owner.Email);
            cmd.Parameters.AddWithValue("@Password", owner.Password);
            cmd.Parameters.AddWithValue("@CellPhone", owner.CellPhone);
            cmd.Parameters.AddWithValue("@ImgPerfil", owner.ImgPerfil);
            cmd.Parameters.AddWithValue("@Address", owner.Address);
            cmd.Parameters.AddWithValue("@userType", owner.UserType);
            cmd.Parameters.AddWithValue("@State", owner.State);

            try
            {
                AbrirConexion();
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                if (e.Message.Contains("El correo ya esta registrado en otro usuario"))
                {
                    throw new Exception("El correo ingresado ya está asociado a otra cuenta. Por favor, utiliza otro correo.");
                }

                if (e.Message.Contains("El celular ya esta registrado en otro usuario."))
                {
                    throw new Exception("El celular ingresado ya está asociado a otra cuenta. Por favor, utiliza otro celular.");
                }
                else
                {
                    throw new Exception("Error al querer insertar, borrar o modificar", e);
                }
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return result;
        }

        public List<E_Pet> GetOwnerPets(int idOwner)
        {
            List<E_Pet> pets = new List<E_Pet>();
            SqlCommand cmd = new SqlCommand("GetOwnerPets", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@idOwner", idOwner);

            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    E_Pet actualPet = new E_Pet
                    {
                        IdPet = reader.IsDBNull(0) ? 0 : reader.GetInt32(0) ,
                        //IdOwner = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                        NamePet = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        PhotoPet = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        //Specie = reader.IsDBNull(4) ? "Indefinida" : reader.GetString(3),
                        //Breed = reader.IsDBNull(5) ? "Indefinida" : reader.GetString(4),
                        //Weight = reader.IsDBNull(5) ? 1 : reader.GetFloat(5),
                        //BirthDay = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6),
                        //Age = reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                        //Sex = reader.IsDBNull(8) ? false : reader.GetBoolean(8),
                        //State = reader.IsDBNull(9) ? false : reader.GetBoolean(9)

                    };

                    pets.Add(actualPet);
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

            return pets;
        }

        public E_Owner LoginAndGetOwner(string Email, string Password)
        {
            E_Owner owner = null;
            SqlCommand cmd = new SqlCommand("LoginUsers", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Rol", "Owner");
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);

            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();

                // Verificamos si hay al menos una fila
                if (reader.Read())
                {
                    owner = new E_Owner
                    {
                        // Usamos IsDBNull para verificar si el valor es null antes de intentar leerlo
                        IdOwner = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),  // Si es NULL, se asigna 0
                        Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1), // Si es NULL, se asigna una cadena vacía
                        Email = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Password = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        CellPhone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        ImgPerfil = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Address = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        UserType = reader.IsDBNull(7) ? false : reader.GetBoolean(7),
                        State = reader.IsDBNull(8) ? false : reader.GetBoolean(8)
                    };
                }
                else
                {
                    // Si no se encuentran resultados, podemos devolver null o manejarlo según sea necesario
                    owner = null;
                }
                reader.Close();
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
            return owner;
        }


        public E_Pet GetPet(int idPet)
        {
            E_Pet pet = new E_Pet();
            SqlCommand cmd = new SqlCommand("GetDataPet", Conexion)
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
                    pet = new E_Pet
                    {
                        IdPet = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        IdOwner = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                        NamePet = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        PhotoPet = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Specie = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        Breed = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        BirthDay = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6),
                        Weight = reader.IsDBNull(7) ? 1 : reader.GetInt32(7),
                        Age = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                        Sex = reader.IsDBNull(9) ? false : reader.GetBoolean(9),
                        State = reader.IsDBNull(10) ? false : reader.GetBoolean(10)
                    };
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
            return pet;
        }
    }
}
