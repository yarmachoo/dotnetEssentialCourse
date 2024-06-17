using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Indexers
{
    internal class DerivedClass:BaseClass
    {
        private string[] derivedArray = null;
        public DerivedClass()
        {
            derivedArray = new string[3];
            derivedArray[0] = "zero";
            derivedArray[1] = "one";
            derivedArray[2] = "two";
        }
        public override string this[int index]
        {
            get { return base[index] + " - " + derivedArray[index]; }
        }
    }
}
