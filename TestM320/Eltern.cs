using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestM320
{
    internal class Eltern : Person
    {
        //Membervariabel
        public byte _anzahlKinder;

        //Konstruktor
        public Eltern(byte anzahlKinder, string vorname, string nachname, byte sehstaerke, string augenfarbe, byte hoervermoegen, bool geschlecht) :base(vorname, nachname, sehstaerke, augenfarbe, hoervermoegen, geschlecht)
        {
            _anzahlKinder = anzahlKinder;
        }
    }
}
