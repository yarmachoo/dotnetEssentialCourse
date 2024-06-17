using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Indexers
{
    internal class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];

        public Dictionary() 
        {
            key[0] = "яблоко"; value[0] = "apple";
            key[1] = "карандаш"; value[1] = "pencil";
            key[2] = "дом"; value[2] = "house";
            key[3] = "мама"; value[3] = "mother";
            key[4] = "любовь"; value[4] = "lovw";
        }
        public string this[string index]
        {
            get
            {
                for(int i = 0; i < key.Length; i++) 
                {
                    if (key[i] == index)
                        return value[i];
                }
                return "Данного слова нет в словаре";
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return $"{key[index]} - {value[index]}";
                }
                else 
                    return "Вы вышли за рамки доступного количества слов!";
            }
        }
    }
}
