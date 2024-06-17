using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static
{
    internal class NonStaticClass
    {
        //Статическое поле
        static int field;
        //Статическое свойство
        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
    }
}
