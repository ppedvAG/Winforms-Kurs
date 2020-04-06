using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestdatenLibrary
{
    public class Person
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtstag { get; set; }
        public int Groesse { get; set; }


        public string KompletterName
        {
            get { return Vorname + " " + Nachname; }
        }
    }


}
