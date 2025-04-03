
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
        public IEnumerable<Student> DohvatiStudente91()
        {
            return Osobe.OfType<Student>()
                        .Where(s => s.DatumRodjenja.Year > 1991);
        }

        public IEnumerable<Student> DohvatiStudente91NoLinq()
        {
            List<Student> studenti91 = new List<Student>();
            foreach (Osoba osoba in Osobe)
            {
                if (osoba is Student student && student.DatumRodjenja.Year > 1991)
                {
                    studenti91.Add(student);
                }
            }
            return studenti91;
        }
        public List<Student> StudentiNeTvzD()
        {
            return Osobe.OfType<Student>()
                        .Where(s => !s.JMBAG.StartsWith("0246") && s.Prezime.StartsWith("D"))
                        .ToList();
        }
        public List<Student> DohvatiStudente91List()
        {
            return Osobe.OfType<Student>()
                        .Where(s => s.DatumRodjenja.Year > 1991)
                        .ToList();
        }
        public Student NajboljiProsjek(int god)
        {
            return Osobe.OfType<Student>()
                        .Where(s => s.DatumRodjenja.Year == god)
                        .OrderByDescending(s => s.Prosjek)
                        .FirstOrDefault();
        }
        public IEnumerable<Student> StudentiGodinaOrdered(int god)
        {
            return Osobe.OfType<Student>()
                        .Where(s => s.DatumRodjenja.Year == god)
                        .OrderByDescending(s => s.Prosjek);
        }
        
    }
}
