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
    }
}
