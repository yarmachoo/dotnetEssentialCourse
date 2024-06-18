using System.Collections;

//Гетерогенная коллекция
ArrayList nums = new ArrayList();
nums.Add(1);
nums.Add(2);

//ЯВНОЕ указание типа Int32 переменной диапазона - num.
//(VAR - невозможно использовать т.к. IEnumerable не параметризированный)
var query = from int num in nums
            select num * 2;

foreach(var item in query)
    Console.WriteLine(item);