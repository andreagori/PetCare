using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class E_Vaccine
    {
        private int _idVaccine;
        private int _idCard;
        private string _Name;
        private string _Type;
        private string _Description;
        private DateTime _dateAplication;
        private bool _State;

        public E_Vaccine(int idVaccine, int idCard, string name, string type, string description, DateTime dateAplication, bool state)
        {
            IdVaccine = idVaccine;
            IdCard = idCard;
            Name = name;
            Type = type;
            Description = description;
            DateAplication = dateAplication;
            State = state;
        }

        public int IdVaccine { get => _idVaccine; set => _idVaccine = value; }
        public int IdCard { get => _idCard; set => _idCard = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Type { get => _Type; set => _Type = value; }
        public string Description { get => _Description; set => _Description = value; }
        public DateTime DateAplication { get => _dateAplication; set => _dateAplication = value; }
        public bool State { get => _State; set => _State = value; }
    }
}
