using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public class N_Illness
    {
        readonly D_Illiness actualIllness = new D_Illiness();
        public List<E_Illiness> GetIllinesPet(int idCard)
        {
            return actualIllness.GetIllinesPet(idCard);
        }

        public string Insert(E_Illiness newIllness)
        {
            int R;

            string message = "Error al agregar padecimiento";

            R = actualIllness.IDM_Illness("INSERT", newIllness);
            if (R == 0)
            {
                message = "Padecimiento registrado correctamente";

            }
            return message;
        }
    }
}
