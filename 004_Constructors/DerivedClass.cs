using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Constructors
{
    public class DerivedClass : BaseClass
    {
        public int derivedField;
        //Пользовательский конструктор
        //Вызывается пользовательский конструктор базового класса
        public DerivedClass(int number1, int number2)
            :base(number1)
        {
            derivedField = number2;
        }
    }
}
