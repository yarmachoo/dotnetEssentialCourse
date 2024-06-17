using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Enum
{
    enum EnumType
    {
        Zero, // = 0 присваивается по порядку
        One, // = 1
        one = One, //две разные константы!
        Two = 2, 
        Three, // = 3
        Four, //4
        Five = 5, 
        Six = Nine,
        Eight = 8,
        Nine, 
        Ten = 10,
        Infinite = 255
    }
}
