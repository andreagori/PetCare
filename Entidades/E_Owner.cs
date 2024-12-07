using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class E_Owner
    {
        private int _idOwner;
        private string _Name;
        private string _Email;
        private string _Password;
        private string _CellPhone;
        private string _ImgPerfil;
        private string _Address;
        private bool _userType;
        private bool _State;


        public E_Owner()
        {
            IdOwner = 0;
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            CellPhone = string.Empty;
            ImgPerfil = string.Empty;
            Address = string.Empty;
            UserType = false;
            State = false;
        }

        public E_Owner(int idOwner, string name, string email, string password, string cellPhone, string imgPerfil, string address, bool userType, bool state)
        {
            IdOwner = idOwner;
            Name = name;
            Email = email;
            Password = password;
            CellPhone = cellPhone;
            ImgPerfil = imgPerfil;
            Address = address;
            UserType = userType;
            State = state;
        }

        public int IdOwner { get => _idOwner; set => _idOwner = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string CellPhone { get => _CellPhone; set => _CellPhone = value; }
        public string ImgPerfil { get => _ImgPerfil; set => _ImgPerfil = value; }
        public string Address { get => _Address; set => _Address = value; }
        public bool UserType { get => _userType; set => _userType = value; }
        public bool State { get => _State; set => _State = value; }
    }
}
