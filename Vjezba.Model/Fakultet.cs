
using System.Collections.Generic;
using System.Linq;

namespace Vjezba.Model
{
    public class Fakultet
    {
        public List<Osoba> Osobe { get; set; }

        public Fakultet()
        {
            Osobe = new List<Osoba>();
        }

        public int KolikoProfesora()
        {
            return Osobe.Count(o => o is Profesor);
        }

        public int KolikoStudenata()
        {
            return Osobe.Count(o => o is Student);
        }

        public Student DohvatiStudenta(string jmbag)
        {
            return Osobe.OfType<Student>()
                        .FirstOrDefault(s => s.JMBAG == jmbag);
        }
        public IEnumerable<Profesor> DohvatiProfesore()
        {
            return Osobe.OfType<Profesor>()
                        .OrderBy(p => p.DatumIzbora);
        }
        
    }
}
