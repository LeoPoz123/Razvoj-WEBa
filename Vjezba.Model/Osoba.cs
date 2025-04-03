using System;
using System.Text.RegularExpressions;

namespace Vjezba.Model{
    public class Osoba
    {
        public String Ime{ get; set; }
        public String Prezime{ get; set; }
        private String _OIB;
        public String OIB{
            get { return this._OIB; }
            set {
                String pattern = @"^\d{11}$";
                if(!Regex.IsMatch(value, pattern))
                {
                    throw new InvalidOperationException("OIB should have 11 digits");
                }
                this._OIB = value;
            }
        }
        private String _JMBG;
        public String JMBG{
            get { return this._JMBG; }
            set {
                String pattern = @"^\d{13}$";
                if(!Regex.IsMatch(value, pattern))
                {
                    throw new InvalidOperationException("JMBG should have 13 digits");
                }
                this._JMBG = value;
            }
        }

        public DateTime DatumRodjenja {
            get {
                int dan = int.Parse(JMBG.Substring(0, 2));
                int mjesec = int.Parse(JMBG.Substring(2, 2));
                int godina = int.Parse(JMBG.Substring(4, 3));
                godina += (godina < 100) ? 2000 : 1000;
                return new DateTime(godina, mjesec, dan);
            }
        }

        public Osoba()
        {

        }
    }
}

