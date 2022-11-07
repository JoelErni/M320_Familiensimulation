using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestM320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Joe", "Ben", "Paul", "John", "Cock", "Lenny", "Carina", "Klara" };
            int AnzKinder = 10;
            List<Kind> KindList = new List<Kind>();

            for(int i = 0; i < AnzKinder; i++)
            {
                Random rand = new Random();
                int length = names.Length;
                KindList.Add(new Kind(names[rand.Next(0,length)], rand.Next(0, 18)));
            }

            foreach(Kind k in KindList)
            {
                Console.WriteLine($"{k._fullname} ist {k._age} jahre alt");
            }
            Console.ReadLine();
        }
    }
}
