using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_base.Method
{
    public class DerivedClass : BaseClass
    {
        public override void Method()
        {
            base.Method();
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
