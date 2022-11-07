using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TestM320
{
    public class Familie
    {
        //MemberVariabeln
        private string _FamilienNachname;
        private Eltern elternteil1;
        private Eltern elternteil2;
        private List<Kind> kinder = new List<Kind>();
        public static Random random = new Random();


    //Familienname Array
    string[] FamilienName = new string[] { "Müller", "Schmidt", "Schneider", "Fischer", "Meyer", "Weber", "Wagner", "Becker", "Schulz", "Hoffmann", "Schäfer", "Koch", "Bauer", "Richter", "Klein", "Schröder", "Wolf", "Neumann", "Schwarz", "Zimmermann", "Krüger" };
        

        //Konstruktoren
        public Familie()
        {
          int value = random.Next(0, 20);
          setFamilienNachname(FamilienName[value]);

          //Anzahl Kinder
          byte AnzKind = Convert.ToByte(random.Next(0, 5));
       
          //Eltern
          elternteil1 = new Eltern(AnzKind, this);
          elternteil2 = new Eltern(AnzKind, this);

          //Erzeugt Kinder :)
          for(int i = 0; i < AnzKind; i++)
          {
              Kind kind = new Kind(elternteil1, elternteil2);
              kinder.Add(kind);
          }
        }
        

        //Methoden
        public string getFamilienNachname()
        {            
            return _FamilienNachname;
        }

        private void setFamilienNachname(string value)
        {
            _FamilienNachname = value;
        }

        public void FamilienDatenausgabe()
        {
          Console.WriteLine($"Familie {getFamilienNachname()}");
          elternteil1.Datenausgabe(); //Datenausgaben für die Eltern
          elternteil2.Datenausgabe();
          foreach(Kind k in kinder) //Datenausgabe für die Kinder
          {
            k.Datenausgabe();
          }
          Console.WriteLine("\n");
    }
  }
}
