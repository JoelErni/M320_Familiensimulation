using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestM320
{
    internal class Kind
    {
        public string _fullname { get; set; }
        public int _age { get; set; }

        public Kind(string fullname, int age)
        {
            _fullname = fullname;
            _age = age;
        }
    }
}
