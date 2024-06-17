using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static
{
    //Статический конструктор:
    //Статические конструкторы обладают след. свойствами:
    // 1. Стат конструктор не мимеет модификаторов доступа и не принимает параметров;
    // 2. Стат контруктор вызывается автоматически для инициализации класса перед созданием первого экземпляра
    // или ссылкой на какие либо статические члены.
    // 3. Стат конструктор нельзя вызвать напрямую
    // 4. Пользователь не управляет тем, когда стат конструктор выполняется в программе
    // 5. Типичным использованием статических конструкторов является случай когда
    // класс использует файлжурнала и конструктор применяется дл добавления записей в этот файл
    internal class NonStaticClass
    {
        static readonly long readonlyFfield = 2;

        //Статический конструктор
        static NonStaticClass()
        {
            readonlyFfield = 1;
        }
        public static long ReadonlyField
        {
            get { return NonStaticClass.readonlyFfield; }
        }
    }
}
