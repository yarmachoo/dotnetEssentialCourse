//Использование нескольких from совпадает с вложенным оператором foreach
var query = from x in Enumerable.Range(1, 9)
            from y in  Enumerable.Range(1, 10)
            select new { X = x, Y =  y, Product = x * y };

foreach(var item in query)
    Console.WriteLine($"{item.X} * {item.Y} = {item.Product}");