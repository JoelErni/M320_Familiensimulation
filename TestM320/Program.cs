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
            Familie f1 = new Familie();
            Familie f2 = new Familie();
            Familie f3 = new Familie();
            Dictionary<Familie, Eltern[]> Families = new Dictionary<Familie, Eltern[]>();

            void ElternErstellung(Familie[] AlleFamilie)
            {
                string[] vornamen_m = new string[] {"Ben","Paul","Ken","Lenny","Giacomo","Felix"};
                string[] vornamen_f = new string[] { "Bernina", "Pauline", "Kristine", "Laura", "Hanna", "Manuel" };
                Random rand = new Random();

                foreach(Familie f in AlleFamilie)
                {
                    string nachname = f.getFamilienNachname();
                    Eltern[] Eltern = new Eltern[2] ;
                    for (int j = 0; j < 2; j++)
                    {
                        Familie familie = f;
                        string vorname = j == 1 ? vornamen_m[rand.Next(0, vornamen_m.Length - 1)] : vornamen_f[rand.Next(0, vornamen_f.Length - 1)];
                        float groesse = Convert.ToSingle(Convert.ToInt64(130 + Convert.ToSingle(rand.NextDouble() * 80) * 10)) / 10;
                        byte sehstaerke = Convert.ToByte(rand.Next(0, 100));
                        string augenfarbe = rand.Next(0, 2) == 1 ? "Braun" : "Blau";
                        byte hoervermoergen = Convert.ToByte(rand.Next(0, 100));
                        bool geschlecht = j == 1 ? true : false;
                        //Console.WriteLine($"Familie {familie.getFamilienNachname()}, Name: {vorname} {nachname}, Grösse: {groesse}cm, Sehstärke: {sehstaerke}%, Augenfarbe: {augenfarbe}, Hörvermögen: {hoervermoergen}%, Geschlecht: {geschlecht}");
                        Eltern[j] = new Eltern(f, vorname, nachname, sehstaerke, augenfarbe, hoervermoergen, geschlecht);
                    }
                    Families.Add(f, Eltern);
                    //Console.WriteLine("\n");
                }
            }


            ElternErstellung(new Familie[] {f1,f2,f3});
            Console.Write(Families);
            Console.ReadLine();
        }
    }
}