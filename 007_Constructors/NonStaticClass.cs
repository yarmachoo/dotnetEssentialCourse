using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static
{
    internal class NonStaticClass
    {
        
        //Единствуенное назначение статических конструктора  - присваивать начальные значения статическим переменным
        static NonStaticClass()
        {
            Console.WriteLine("Static constructor");

        }
        public NonStaticClass()
        {
            Console.WriteLine("NonStatic constructor");

        }
        
        public static void StaticMethod()
        {
            Console.WriteLine("Static method");
        }
        public void NonStaticMethod()
        {
            Console.WriteLine("NoStatic method");
        }
    }
}
