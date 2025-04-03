

using System;

namespace Vjezba.Model
{
    public class Profesor : Osoba
    {
        public string Odjel { get; set; }
        public Zvanje Zvanje { get; set; }
        public DateTime DatumIzbora { get; set; }

        public int KolikoDoReizbora()
        {
            int godinaDoReizbora = Zvanje == Zvanje.Asistent ? 4 : 5;
            DateTime nextReizborDate = DatumIzbora.AddYears(godinaDoReizbora);
            int yearsUntilReizbor = (nextReizborDate - DateTime.Now).Days / 365;
            return yearsUntilReizbor;
        }
    }

    public enum Zvanje
    {
        Asistent,
        Predavac,
        VisiPredavac,
        ProfVisokeSkole
    }
}


