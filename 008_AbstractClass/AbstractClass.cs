using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_AbstractClass
{
    abstract class AbstractClass
    {
        public static AbstractClass CreateObject()
        {
            return new ConcreteClass();
        }
        public abstract void Method();
    }
}
