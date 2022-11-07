using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TestM320
{
    public class Person:ILebenserwartung
    {
        //Membervariablen
        public Familie _familie; //Referenz
        public string _vorname;
        public string _FamilienNachname;
        public byte _sehstraerke;
        public string _augenfarbe;
        public byte _hoervermoegen;
        public float _groesse;
        public bool _geschlecht;
        public static Random random = new Random();


        //Vorname Array Männlich
        string[] MännlichVornameArray = new string[] { "Lucas", "Joel", "Dines", "Gianmarco", "Duarte","Markus", "Edwin", "Manuel", "Felix", "Malix", "David", "Karsten", "Patrick", "Tomas"};
        //Vorname Array Weiblich
        string[] WeiblichVornameArray = new string[] {  "Valentina", "Sara", "Aline", "Susanne", "Malix", "Maria", "Vemy", "Lina", "Leonie"};


        //Konstruktor
        public Person(Familie familie)
        {
            _familie = familie;
            _FamilienNachname = _familie.getFamilienNachname();
            RandomStats();
        }
        public void RandomStats()
        {
            //Hier wird ein Random Wert für die Sehstärke generiert
            
            byte Sehstaerkevalue = Convert.ToByte(random.Next(0, 100));
            setSehstaerke(Sehstaerkevalue);

            //Augenfarbe
            //Die 1 Steht für Braun die 2 Für Blau der Code von Zeile 71 bis 83 erstellt eine Random Zahl zwischen 1 und 2 welche für Braun und Blau stehen so generieren wir Random eine Augenfarbe
            string Augenfarbe = "";
            byte Augenvalue = Convert.ToByte(random.Next(0, 2));

            if (Augenvalue == 1)
            {
                Augenfarbe = "Braun";
            }
            else
            {
                Augenfarbe = "Blau";
            }

            setAugenfarbe(Augenfarbe);

            //Hoervermoegen
            byte hoervermoegenvalue = Convert.ToByte(random.Next(0, 100));

            setHoervermoegen(hoervermoegenvalue);

            //Groesse
            float groessevalue = Convert.ToSingle(random.Next(130, 210));

            setGroesse(groessevalue);

            //Geschlecht
            byte Geschlechtvalue = Convert.ToByte(random.Next(0, 2));

            if (Geschlechtvalue == 1)
            {
                setGeschlecht(true);
            }
            else
            {
                setGeschlecht(false);
            }

            //Vorname
            if (getGeschlecht() == true)
            {
                int MännlichVornamevalue = random.Next(0, MännlichVornameArray.Length-1);
                  setVorname(MännlichVornameArray[MännlichVornamevalue]);
            }
            else if (getGeschlecht() == false)
            {
                int WeiblichVornamevalue = random.Next(0, WeiblichVornameArray.Length-1);
                  setVorname(WeiblichVornameArray[WeiblichVornamevalue]);
            }
        }
        // Get und Set Vorname
        public string getVorname()
        {
            return _vorname;
        }

        public void setVorname(string value)
        {
            _vorname = value;
        }
        // Get und Set Sehstärke
        public byte getSehstaerke()
        {
            return _sehstraerke;
        }

        public void setSehstaerke(byte value)
        {
            _sehstraerke = value;
        }
        // Get und Set Augenfarbe
        public string getAugenfarbe()
        {
            return _augenfarbe;
        }

        public void setAugenfarbe(string value)
        {
            _augenfarbe = value;
        }
        // Get und Set Hörvermögen
        public byte getHoervermoegen()
        {
            return _hoervermoegen;
        }
        public void setHoervermoegen(byte value)
        {
            _hoervermoegen = value;
        }
        // Get und Set Grösse
        public float getGroesse()
        {
            return _groesse;
        }
        public void setGroesse(float value)
        {
            _groesse = value;
        }
        // Get und Set Geschlecht
        public bool getGeschlecht()
        {
            return _geschlecht;
        }

        public void setGeschlecht(bool value)
        {
            _geschlecht = value;
        }

        //Interface
        public void LebenserwartungMenschen()
        {
            int Lebenszeit = random.Next(50, 80);
        }

        //Datenausgabe
        public virtual void Datenausgabe()
        {
          string output = $"Voller Name: {getVorname()} {_familie.getFamilienNachname()}, {getGroesse()}cm, {_augenfarbe} Augen, ";
          output += getGeschlecht() == false ? "weiblich" : "männlich";
          Console.WriteLine(output);
        }
    }
}
