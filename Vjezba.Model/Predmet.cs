/*
namespace Vjezba.Model

Klasa Predmet treba imati šifru predmeta (int Sifra), broj ECTS bodova (int ECTS), naziv
predmeta (Naziv).
*/
using System;

namespace Vjezba.Model
{
    public class Predmet
    {
        public int Sifra { get; set; }
        public int ECTS { get; set; }
        public string Naziv { get; set; }
    }
}
