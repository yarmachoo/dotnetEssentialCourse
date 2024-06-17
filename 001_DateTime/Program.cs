DateTime now = DateTime.Now;

Console.WriteLine("Текущая дата и время: {0}", now);
Console.WriteLine("Год: {0}", now.Year);
Console.WriteLine("текущее время {0}:{1}:{2}", now.Hour, now.Minute, now.Second);

Console.WriteLine("День недели {0}", now.DayOfWeek);
    Console.WriteLine("Это {0}-ый день года", now.DayOfYear);