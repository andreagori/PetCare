using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class E_VeterinarianRegister
    {
        private int _idRegister;
        private int idVeterinarian;
        private int _idCard;
        private DateTime registrationDate;
        private bool _State;

        public E_VeterinarianRegister(int idRegister, int idVeterinarian, int idCard, DateTime registrationDate, bool state)
        {
            IdRegister = idRegister;
            this.IdVeterinarian = idVeterinarian;
            IdCard = idCard;
            this.RegistrationDate = registrationDate;
            State = state;
        }

        public int IdRegister { get => _idRegister; set => _idRegister = value; }
        public int IdVeterinarian { get => idVeterinarian; set => idVeterinarian = value; }
        public int IdCard { get => _idCard; set => _idCard = value; }
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }
        public bool State { get => _State; set => _State = value; }
    }
}
