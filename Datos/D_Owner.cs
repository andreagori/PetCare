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
            SqlCommand cmd = new SqlCommand("IDM_Owner", Conexion)
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
                throw new Exception("Error al querer insertar, borrar o modificar", e);
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
            List<E_Pet> pets = null;
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
                        IdPet = reader.GetInt32(0),
                        IdOwner = reader.GetInt32(1),
                        NamePet = reader.GetString(2),
                        PhotoPet = reader.GetString(3),
                        Specie = reader.GetString(4),
                        Breed = reader.GetString(5),
                        BirthDay = reader.GetDateTime(6),
                        Age = reader.GetInt32(7),
                        Sex = reader.GetBoolean(8),
                        State = reader.GetBoolean(9)

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

        public E_Owner LoginAndGetOwner()
        {
            E_Owner owner = null;
            SqlCommand cmd = new SqlCommand("LoginAndGetOwner", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Rol", "OWNER");
            cmd.Parameters.AddWithValue("@Email", owner.Email);
            cmd.Parameters.AddWithValue("@Password", owner.Password);

            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                owner = new E_Owner
                {
                    IdOwner = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Email = reader.GetString(2),
                    Password = reader.GetString(3),
                    CellPhone = reader.GetString(4),
                    ImgPerfil = reader.GetString(5),
                    Address = reader.GetString(6),
                    UserType = reader.GetBoolean(7),
                    State = reader.GetBoolean(8)
                };

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
            E_Pet pet = null;
            SqlCommand cmd = new SqlCommand("GetDataPet", Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@idPet", idPet);
            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                pet = new E_Pet
                {
                    IdPet = reader.GetInt32(0),
                    IdOwner = reader.GetInt32(1),
                    NamePet = reader.GetString(2),
                    PhotoPet = reader.GetString(3),
                    Specie = reader.GetString(4),
                    Breed = reader.GetString(5),
                    BirthDay = reader.GetDateTime(6),
                    Age = reader.GetInt32(7),
                    Sex = reader.GetBoolean(8),
                    State = reader.GetBoolean(9)
                };
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
