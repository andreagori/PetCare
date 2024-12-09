using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class E_Illiness
    {
        private int _idIllness;
        private int _idCard;
        private string _IllinessName;
        private string _Description;
        private bool _State;

        public E_Illiness(int idIllness, int idCard, string illinessName, string description, bool state)
        {
            IdIllness = idIllness;
            IdCard = idCard;
            IllinessName = illinessName;
            Description = description;
            State = state;
        }

        public int IdIllness { get => _idIllness; set => _idIllness = value; }
        public int IdCard { get => _idCard; set => _idCard = value; }
        public string IllinessName { get => _IllinessName; set => _IllinessName = value; }
        public string Description { get => _Description; set => _Description = value; }
        public bool State { get => _State; set => _State = value; }
    }
}
