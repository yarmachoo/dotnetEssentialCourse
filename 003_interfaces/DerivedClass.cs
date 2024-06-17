using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_interfaces
{
    internal class DerivedClass : Interface1, Interface2
    {
        //По умолчанию одноименные методы являются private
        //но явно указывать модификаторы доступа недопустимо.
        void Interface1.Method()
        {
            Console.WriteLine("Реализация Interface1.Method()");
        }
        //явное указание имени интерфейса к которому принадлежит метод
        void Interface2.Method()
        {
            Console.WriteLine("Реализация Interface2.Method()");
        }
    }
}
