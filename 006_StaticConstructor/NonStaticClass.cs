using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static
{
    internal class NonStaticClass
    {
        //Если класс содержит статические поля, то долден быть предоставлен слатический
        //конструктор, кот инициализирует эти поля при загрузхке класса

        private static int field;

        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
        //Единствуенное назначение статических конструктора  - присваивать начальные значения статическим переменным
        static NonStaticClass()
        {
            field = 1;

        }
        //Статические методы могут быть перегружены.
        public static void Method()
        {
            Console.WriteLine("Instance.field = {0}", field);
        }
        public static void Method(int i)
        {
            Console.WriteLine("Instance.field = {0} i = {1}", field, i);
        }
        public void NonStaticMethod()
        {
            Console.WriteLine("Instance.field = {0}", field);
        }
    }
}
