using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static
{
    internal class NonStaticClass
    {
        //Константы не могут быть статическими 

        //Поле не может быть объявлено как static const, поле const 
        // по своему поведению уже является статическим.
        //Поле const относится к типу а не к экземплярам типа.
        //Поэтому к полям const можно обращаться с использованием той же
        // нотации ИмяКласса.ИмяЧлена,
        //сто и в используемой для статических полей
        public const float e = 2.71828f; 
    }
}
