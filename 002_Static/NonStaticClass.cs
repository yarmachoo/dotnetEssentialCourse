using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static
{
    internal class NonStaticClass
    {
        private int Id;
        public static int field;
        public NonStaticClass(int id)
        {
            this.Id = id;
        }
        public static void Method()
        {
            //Console.WriteLine("Instance.Id = {0}", Id);
            Console.WriteLine("Instance.field = {0}", field);
        }
    }
}
