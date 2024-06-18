

//let - представляет новый локальный идентификатор, на который можно ссылаться в остальной части запроса.
//Его можно представить, как локальную переменную видимую только внутри выражения запроса.

public class Employee
{
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
}


class Program
{
    public static void Main()
    {
        var employees = new List<Employee>()
        {
            new Employee() { LastName = "Ivanov", FirstName = "Ivan"},
            new Employee() { LastName = "Andreev", FirstName = "Andrew"},
            new Employee() { LastName = "Petrov", FirstName = "Petr"}
        };

        var query = from emp in employees
                    let fullName = $"{emp.LastName} {emp.FirstName}" //let - новый локальный идентификатор
                    orderby fullName descending
                    select fullName;

        foreach (var person in query)
            Console.WriteLine($"{person}");
    }
}