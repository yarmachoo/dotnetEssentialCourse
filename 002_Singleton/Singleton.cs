using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Singleton
{
    class Singleton
    {
        private static Singleton instance = null;
        //Конструтктор protected!
        protected Singleton()
        {
            
        }
        //Фабричный метод
        public static Singleton Instance()
        {
            //Если объект еще не создан
            if (instance == null)
            {
                //То: создаем новый экземпляр
                instance = new Singleton();
            }
            //Возвращаем ссылку на созданный (существующий) объект
            return instance;
        }
    }
}
