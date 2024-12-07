using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class E_Pet
    {
        private int _idPet;
        private int _idOwner;
        private string _NamePet;
        private string _PhotoPet;
        private string _Specie;
        private string _Breed;
        private DateTime _BirthDay;
        private int _Age;
        private bool _Sex;
        private bool _State;



        public E_Pet()
        {
            IdPet = 0;
            IdOwner = 0;
            NamePet = string.Empty;
            PhotoPet = string.Empty;
            Specie = string.Empty;
            Breed = string.Empty;
            BirthDay = DateTime.Now;
            Age = 0;
            Sex = false;
            State = true;
        }
        public E_Pet(int idPet, int idOwner, string namePet, string photoPet, string specie, string breed, DateTime birthDay, int age, bool sex, bool state)
        {
            IdPet = idPet;
            IdOwner = idOwner;
            NamePet = namePet;
            PhotoPet = photoPet;
            Specie = specie;
            Breed = breed;
            BirthDay = birthDay;
            Age = age;
            Sex = sex;
            State = state;
        }

        public int IdPet { get => _idPet; set => _idPet = value; }
        public int IdOwner { get => _idOwner; set => _idOwner = value; }
        public string NamePet { get => _NamePet; set => _NamePet = value; }
        public string PhotoPet { get => _PhotoPet; set => _PhotoPet = value; }
        public string Specie { get => _Specie; set => _Specie = value; }
        public string Breed { get => _Breed; set => _Breed = value; }
        public DateTime BirthDay { get => _BirthDay; set => _BirthDay = value; }
        public int Age { get => _Age; set => _Age = value; }
        public bool Sex { get => _Sex; set => _Sex = value; }
        public bool State { get => _State; set => _State = value; }
    }
}
