
using System;

namespace Vjezba.Model
{
    public class Student : Osoba
    {
        private string _jmbag;
        public string JMBAG
        {
            get => _jmbag;
            set
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^\d{10}$"))
                {
                    throw new InvalidOperationException("JMBAG must be exactly 10 digits.");
                }
                _jmbag = value;
            }
        }

        public decimal Prosjek { get; set; }
        public int BrPolozeno { get; set; }
        public int ECTS { get; set; }
    }
}

