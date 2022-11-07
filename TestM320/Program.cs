using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace TestM320
{
    internal class Program
    {
    static void Main(string[] args)
    {
      /*
       Wichtig!
       Wir hatten das Problem dass die Datenausgabe bei allen am Schluss gleich war.
       Nur wenn man alle Zeile einzeln im debug-Modus oder so durchgeht, wird die Datenausgabe richtig angezeigt.

       Wir konnten dieses Problem aber lösen. Irgend etwas mit den Randoms hat nicht funktioniert.
      (https://stackoverflow.com/questions/59811697/c-multiple-class-instances-all-doing-the-same-thing <- Dieser Link hat uns geholfen, dieses Problem zu loesen).
      Einfach zu Wild!!!
       
      */

      //erstellt die Familien
      Familie f1 = new Familie();
      Familie f2 = new Familie();
      Familie f3 = new Familie();
      Familie f4 = new Familie();

      //Gibt alle Daten von den einzelnen Familienmitglieder aus
      f1.FamilienDatenausgabe();
      f2.FamilienDatenausgabe();
      f3.FamilienDatenausgabe();
      f4.FamilienDatenausgabe();

            Console.ReadLine();
        }
    }
}