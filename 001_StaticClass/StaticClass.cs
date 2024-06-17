using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Статический класс в C# выражает идею паттерна Singleton

//Правила:
//1. Экземпляр статического класса нельзя создать!
//2. Static class всегда наследуется от Object
//( попытка наследования от чего-то другого приводит к ошибке компиляции)
//3. Static class не реализует интерфейсы.  Попытка наследования
//от интерфейса приводит к ошибке куровня компиляции) 
///4. Содержит только статические члены (наличие в нем нестатического члена 
///приводит к ошибке компилляции
///5. Статический класс не дает содержать конструктора экземпляра
///6. Статический класс закрыт для наследования от него.
///Попытка наследования от статического класса приводит к ошибке уровня компиляции
namespace _001_StaticClass
{
    static class StaticClass
    {
        //Конструктор экземпляра не доступен!
        //public StaticClass()
        //{

        //}
        static StaticClass()
        {
            Console.WriteLine("Static constructor");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static method");
        }
        //Нестатический метод недоступен!
        //public void NonStaticMethod()
        //{
        //    Console.WriteLine("Static method");
        //}
    }
}
