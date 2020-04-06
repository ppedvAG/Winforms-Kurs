using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestdatenLibrary
{
    public class PersonListe
    {
        private List<Person> peopleListe;

        public PersonListe()
        {
            peopleListe = new List<Person>();

            Init();
        }

        private void Init()
        {
            //Variante 1
            Person person1 = new Person();
            person1.Id = 1;
            person1.Vorname = "Max";
            person1.Nachname = "Mustermann";
            person1.Groesse = 180;
            person1.Geburtstag = DateTime.Now;
            peopleListe.Add(person1);

            //Variante 2
            peopleListe.Add(new Person { Id = 2, Vorname = "Anna", Nachname = "Muster", Geburtstag = DateTime.Now, Groesse = 175 });
            peopleListe.Add(new Person { Id = 3, Vorname = "Anton", Nachname = "Müller", Geburtstag = DateTime.Now, Groesse = 190 });
        }

        public IList<Person> PersonenListe
        {
            get
            {
                return peopleListe;
            }
        }
    }
}
