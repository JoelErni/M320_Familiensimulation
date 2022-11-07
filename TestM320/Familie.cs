using System;
using System.Collections.Generic;
using System.Linq;
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

        //Familienname Array
        string[] FamilienName = new string[] { "Müller", "Schmidt", "Schneider", "Fischer", "Meyer", "Weber", "Wagner", "Becker", "Schulz", "Hoffmann", "Schäfer", "Koch", "Bauer", "Richter", "Klein", "Schröder", "Wolf", "Neumann", "Schwarz", "Zimmermann", "Krüger" };
        

        //Konstruktoren
        public Familie()
        {
            _FamilienNachname = getFamilienNachname();
        }
        

        //Methoden
        public string getFamilienNachname()
        {
            setFamilienNachname();
            return _FamilienNachname;
        }

        private void setFamilienNachname()
        {
            Random random = new Random();
            int value = random.Next(0, 20);
            _FamilienNachname = FamilienName[value];
        }



    }
}
