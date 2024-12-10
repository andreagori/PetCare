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
        readonly D_Vaccine ActualVaccine = new D_Vaccine();

        public List<E_Vaccine> GetVaccines(int idCard)
        {
            return ActualVaccine.GetVaccines(idCard);
        }
        
        public void insertVaccine(int idVaccine, int idCard, string name, 
            string type, string description, DateTime dateAplication)
        {
            ActualVaccine.insertVaccine(idVaccine, idCard, name, type, description, dateAplication);
        }
    }
}
