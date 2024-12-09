using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class E_Card
    {
        private int _idCard;
        private int _idPet;
        private DateTime _dateCreation;
        private string _Diagnose;
        private string _Medication;

        public E_Card(int idCard, int idPet, DateTime dateCreation, string diagnose, string medication)
        {
            IdCard = idCard;
            IdPet = idPet;
            DateCreation = dateCreation;
            Diagnose = diagnose;
            Medication = medication;
        }

        public int IdCard { get => _idCard; set => _idCard = value; }
        public int IdPet { get => _idPet; set => _idPet = value; }
        public DateTime DateCreation { get => _dateCreation; set => _dateCreation = value; }
        public string Diagnose { get => _Diagnose; set => _Diagnose = value; }
        public string Medication { get => _Medication; set => _Medication = value; }
    }
}
