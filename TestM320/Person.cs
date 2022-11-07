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
        public string _vorname { get; set; }
        public string _nachname { get; set; }
        public byte _sehstraerke { get; set; }
        public string _augenfarbe { get; set; }
        public byte _hoervermoegen { get; set; }
        public bool _geschlecht { get; set; }

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
    }
}
