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
      */

      //erstellt die Familien
      Familie f1 = new Familie();

      //Gibt alle Daten von den einzelnen Familienmitglieder aus
      f1.FamilienDatenausgabe();

      Console.ReadLine();
        }
    }
}