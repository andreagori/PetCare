using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class E_Veterinarian
    {
        private int _idVeterinarian;
        private string _Name;
        private string _Email;
        private string _Password;
        private string _CellPhone;
        private string _ImgPerfil;
        private string _LocalName;
        private string _Address;
        private bool _State;

        public E_Veterinarian(int idVeterinarian, string name, string email, string password, string cellPhone, string imgPerfil, string localName, string address, bool state)
        {
            _idVeterinarian = idVeterinarian;
            _Name = name;
            _Email = email;
            _Password = password;
            _CellPhone = cellPhone;
            _ImgPerfil = imgPerfil;
            _LocalName = localName;
            _Address = address;
            _State = state;
        }


        public int IdVeterinarian { get => _idVeterinarian; set => _idVeterinarian = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string CellPhone { get => _CellPhone; set => _CellPhone = value; }
        public string ImgPerfil { get => _ImgPerfil; set => _ImgPerfil = value; }
        public string LocalName { get => _LocalName; set => _LocalName = value; }
        public string Address { get => _Address; set => _Address = value; }
        public bool State { get => _State; set => _State = value; }
    }
}
