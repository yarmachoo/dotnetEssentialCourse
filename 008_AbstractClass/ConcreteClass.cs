using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_AbstractClass
{
    internal class ConcreteClass:AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine(" ConcreteClass.Method()");
        }
    }
}
