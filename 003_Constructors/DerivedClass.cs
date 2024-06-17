using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Constructors
{
    public class DerivedClass: BaseClass
    {
        public int derivedField;
        public DerivedClass(int number1, int number2)
        {
            //Вызывается конструктор по умолчанию от базового класса
            //что приводит к двойной инициализации
            baseNumber = number1; 
            derivedField = number2;
        }
    }
}
