﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    public class MyCollection : IEnumerable, IEnumerator
    {
        Element[] elementsArray;
        public MyCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }
        int position = -1;

        //Реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
        //Реализация интерфеса IEnumerator
        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get
            {
                return elementsArray[position];
            }
        }
    }
}
