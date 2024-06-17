using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AbstractItem
{
    abstract class AbstractBaseClass
    {
        //Обычный метод передается производному классу как при наследовании от конкретного класса
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractBaseClass.SimpleMethod();");
        }
        //Виртуальный метод передается классу как при наследовании от конкретного класса
        virtual public void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass.VirtualMethod();");
        }
        //австрактный метод реализуется в производном классе
        abstract public void AbstractMethod();
    }
}
