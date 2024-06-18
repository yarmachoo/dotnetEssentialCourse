//let - представляет новый локальный идентификатор, на который можно ссылаться в остальной части запроса.
//Его можно представить, как локальную переменную видимую только внутри выражения запроса.

var query = from x in Enumerable.Range(0, 10)
            let innerRange = Enumerable.Range(0, 10)
            from y in innerRange
            select new { X = x, Y = y, Product = x * y };

foreach (var item in query)
    Console.WriteLine($"{item.X} * {item.Y} = {item.Product}");