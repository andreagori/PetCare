using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Negocios
{
    public class N_Card
    {
        readonly D_Card ActualCard = new D_Card();
        public int GetCard(int idPet)
        {
            return ActualCard.GetCard(idPet);
        }
    }
}
