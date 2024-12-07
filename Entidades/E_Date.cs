using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class E_Date
    {
        private int _idDate;
        private int _idPet;
        private string _Title;
        private string _Description;
        private bool _dateType;
        private bool _addedBy;
        private DateTime _StartTime;
        private DateTime _EndTime;
        private bool _State;

        public E_Date(int idDate, int idPet, string title, string description, bool dateType, bool addedBy, DateTime startTime, DateTime endTime, bool state)
        {
            IdDate = idDate;
            IdPet = idPet;
            Title = title;
            Description = description;
            DateType = dateType;
            AddedBy = addedBy;
            StartTime = startTime;
            EndTime = endTime;
            State = state;
        }

        public int IdDate { get => _idDate; set => _idDate = value; }
        public int IdPet { get => _idPet; set => _idPet = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Description { get => _Description; set => _Description = value; }
        public bool DateType { get => _dateType; set => _dateType = value; }
        public bool AddedBy { get => _addedBy; set => _addedBy = value; }
        public DateTime StartTime { get => _StartTime; set => _StartTime = value; }
        public DateTime EndTime { get => _EndTime; set => _EndTime = value; }
        public bool State { get => _State; set => _State = value; }
    }
}
