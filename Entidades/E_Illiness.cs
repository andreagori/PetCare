using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Illiness
    {
        private int _idIllness;
        private int _idCard;
        private string _IllinessName;
        private string _Description;
        private DateTime _DateIllness;
        private bool _State;

        public E_Illiness(int idIllness, int idCard, string illinessName, string description,DateTime dateIllness, bool state)
        {
            IdIllness = idIllness;
            IdCard = idCard;
            IllinessName = illinessName;
            Description = description;
            DateIllness = dateIllness;
            State = state;
        }
        public E_Illiness()
        {
            IdIllness = 0;
            IdCard = 0;
            IllinessName = string.Empty;
            Description = string.Empty;
            DateIllness = DateTime.Now;
            State = true;
        }

        public int IdIllness { get => _idIllness; set => _idIllness = value; }
        public int IdCard { get => _idCard; set => _idCard = value; }
        public string IllinessName { get => _IllinessName; set => _IllinessName = value; }
        public string Description { get => _Description; set => _Description = value; }
        public DateTime DateIllness { get => _DateIllness; set => _DateIllness = value; }
        public bool State { get => _State; set => _State = value; }

    }
}
