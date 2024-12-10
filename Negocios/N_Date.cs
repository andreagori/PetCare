using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Date
    {
        readonly D_Date ActualDate = new D_Date();

        public List<E_Date> GetDatesPet(int idPet)
        {
            return ActualDate.GetOneDatePet(idPet,"DATES");
        }

        public List<E_Date> GetActivitiesPet(int idPet)
        {
            return ActualDate.GetOneDatePet(idPet, "ACTIVITIES");
        }

        public List<E_Date> GetAllDates(int idOWner)
        {
            return ActualDate.GetAllDates(idOWner);
        }
        public void updateDate(int idPet, string title, string description,
            bool dateType, bool addedBy, string startTime, string endTime)
        {
            ActualDate.updateDate(idPet, title, description, dateType, addedBy, startTime, endTime);
        }
    }
}
