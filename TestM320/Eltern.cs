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
        public Eltern(byte anzahlKinder, Familie familie) :base(familie)
        {
            _anzahlKinder = anzahlKinder;
        }
    }
}
