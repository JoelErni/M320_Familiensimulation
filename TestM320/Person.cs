using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestM320
{
    internal class Person
    {
        //Membervariablen
        public Familie _familie; //Referenz
        public string _vorname;
        public string _nachname;
        public byte _sehstraerke;
        public string _augenfarbe;
        public byte _hoervermoegen;
        public bool _geschlecht;

        //Vorname Array
        string[] Vorname = new string[] { "Lucas", "Joel", "Dines", "Gianmarco", "Duarte", "Valentina", "Sara", "Aline", "Susanne", "Markus", "Edwin", "Manuel", "Felix", "Malix", "David", "Karsten", "Maria", "Patrick", "Vemy", "Lina", "Tomas", "Leonie", }
        //Konstruktor
        public Person(string vorname, string nachname, byte sehstaerke, string augenfarbe, byte hoervermoegen, bool geschlecht)
        {
            _vorname = vorname;
            _nachname = nachname;
            _sehstraerke = sehstaerke;
            _augenfarbe = augenfarbe;
            _hoervermoegen = hoervermoegen;
            _geschlecht = geschlecht;
        }

        public string getVorname()
        {

        }

        public void setVorname()
    }
}
