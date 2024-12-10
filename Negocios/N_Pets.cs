using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Pets
    {
        readonly D_Pet ActualPet = new D_Pet();

        public List<E_Date> HistoricalPet(int idPet)
        {
            return ActualPet.Historical(idPet);
        }

        public string Insert(E_Pet pet)
        {
            int R;

            string message = "Error al registrar mascota";

            R = ActualPet.IDM_Pet("INSERT", pet);
            if (R == 0)
            {
                message = "Mascota registrado correctamente";

            }
            return message;
        }
        // for wmyHistory section.
        public E_Pet GetPetDetails(int idPet)
        {
            return ActualPet.GetPetById(idPet);
        }


    }
}
