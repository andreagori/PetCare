using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Date
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
        private string _NamePet;
        private string _eventType;  // Nueva propiedad para el tipo de evento

        // Constructor con todos los parámetros
        public E_Date(int idDate, int idPet, string title, string description, bool dateType, bool addedBy, DateTime startTime, DateTime endTime, bool state, string namePet)
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
            NamePet = namePet;
            // Asignación del EventType basado en DateType
            EventType = dateType ? "Actividad" : "Cita Médica"; // Se asigna "Actividad" o "Cita Médica" según DateType
        }

        // Constructor por defecto
        public E_Date()
        {
            IdDate = 0;
            IdPet = 0;
            Title = string.Empty;
            Description = string.Empty;
            DateType = false;
            AddedBy = false;
            StartTime = DateTime.MinValue;
            EndTime = DateTime.MinValue;
            State = false;
            NamePet = string.Empty;
            EventType = "Desconocido"; // Valor por defecto si no se asigna
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
        public string NamePet { get => _NamePet; set => _NamePet = value; }
        public string EventType { get => _eventType; set => _eventType = value; }  // Propiedad para almacenar el tipo de evento
    }
}