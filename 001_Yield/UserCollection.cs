using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _001_Yield
{
    public class UserCollection
    {
        public static IEnumerable Power()
        {
            yield return "Hello woorld!";
        }
    }
}
