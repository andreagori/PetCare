using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocios
{
    public class N_Owner
    {
        readonly D_Owner ActualOwner = new D_Owner();

        public string Insert(E_Owner owner)
        {
            int R;

            string message = "Error al registrar usuario";

            R = ActualOwner.IDM_Owner("INSERT", owner);
            if (R == 0)
            {
                message = "Usuario registrado correctamente";

            }
            return message;
        }

        public string Update(E_Owner owner)
        {
            int R;
            string message = "Error al actualizar usuario";
            R = ActualOwner.IDM_Owner("UPDATE", owner);
            if (R == 0)
            {
                message = "Usuario actualizado correctamente";
            }
            return message;
        }

        public string Delete(E_Owner owner)
        {
            int R;
            string message = "Error al eliminar usuario";
            R = ActualOwner.IDM_Owner("DELETE", owner);
            if (R == 0)
            {
                message = "Usuario eliminado correctamente";
            } 
            return message;
        }

        public E_Owner Login (String Email, String Password)
        {
            if(string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                throw new ArgumentException("El email y la contraseña son obligatorios");
            }

            E_Owner owner = ActualOwner.LoginAndGetOwner(Email, Password);
            if (owner == null)
            {
                throw new ArgumentException("El email o la contraseña son incorrectos");
            }

            return owner;
        }

        public List<E_Pet> GetOwnerPets(int idOwner)
        {
            return ActualOwner.GetOwnerPets(idOwner);
        }

        public E_Pet GetPet(int idPet)
        {
            return ActualOwner.GetPet(idPet);
        }
    }
}
