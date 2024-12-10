using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class N_Vaccine
    {
        readonly D_Date ActualDate = new D_Date();

        public List<E_Vaccine> GetVaccines(int idCard)
        {
            return ActualDate.GetVaccines(idCard);
        }
    }
}
