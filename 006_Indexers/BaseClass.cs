using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Indexers
{
    internal class BaseClass
    {
        private string[] baseArray = null;
        public BaseClass()
        {
            baseArray = new string[3];
            baseArray[0] = "ноль";
            baseArray[1] = "один";
            baseArray[2] = "два";
        }
        public virtual string this[int index]
        {
            get { return baseArray[index]; }
        }
    }
}
