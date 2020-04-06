using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestdatenLibrary
{
    public class PropertySample
    {
        //CTOR + Tab + Tab = generierter Konstruktor
        private string vorname;
        public PropertySample()
        {

        }

        public int ID { get; set; }

        #region Alt
        public string GetVorname()
        {
            // Logik...
            return this.vorname;
        }

        public void SetVorname(string vorname)
        {
            // Logik...
            this.vorname = vorname;
        }
        #endregion


        #region Property sind neu
        public string Vorname
        {
            get
            {
                return this.vorname;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("Vorname ist leer");

                this.vorname = value;
            }
        }

        //Auto Property
        public string Lastname { get; set; }
        #endregion
    }
}
