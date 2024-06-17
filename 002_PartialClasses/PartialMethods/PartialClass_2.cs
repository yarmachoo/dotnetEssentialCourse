using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_PartialClasses.PartialMethods
{
    partial class PartialClass
    {
        partial void PartialMethod()
        {
            Console.WriteLine("PartialMethod was called!");
        }
        public void CallPartialMethod()
        {
            PartialMethod();
            MyMethod();
        }

        #region Реализация частичного метода в других частях класса не обязательна!
        #endregion
    }
}
