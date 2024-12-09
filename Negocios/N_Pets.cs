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

    }
}
