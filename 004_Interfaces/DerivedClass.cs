using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Interfaces
{
    internal class DerivedClass : BaseClass, Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Interface1.Method1();");
        }

        public void Method2()
        {
            Console.WriteLine("Interface2.Method2();");
        }
    }
}
