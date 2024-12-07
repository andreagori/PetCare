using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class E_RegisterCaregiver
    {
        private int _idRegister;
        private int _idOwner;
        private int _idPet;
        private DateTime _registrationDate;
        private bool _State;

        public E_RegisterCaregiver(int idRegister, int idOwner, int idPet, DateTime registrationDate, bool state)
        {
            IdRegister = idRegister;
            IdOwner = idOwner;
            IdPet = idPet;
            RegistrationDate = registrationDate;
            State = state;
        }

        public int IdRegister { get => _idRegister; set => _idRegister = value; }
        public int IdOwner { get => _idOwner; set => _idOwner = value; }
        public int IdPet { get => _idPet; set => _idPet = value; }
        public DateTime RegistrationDate { get => _registrationDate; set => _registrationDate = value; }
        public bool State { get => _State; set => _State = value; }
    }
}
