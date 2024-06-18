public class Employee
{
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? Nationality { get; set; }
}


class Program
{
    public static void Main()
    {
        var employees = new List<Employee>()
        {
            new Employee() { LastName = "Andreev", FirstName = "Andrew", Nationality = "Russian"},
            new Employee() { LastName = "Ivanov", FirstName = "Ivan", Nationality = "Ukranian"},
            new Employee() { LastName = "Andreev", FirstName = "Ivan", Nationality = "American"},
            new Employee() { LastName = "Petrov", FirstName = "Petr", Nationality = "Russian"},
            new Employee() { LastName = "Andreev", FirstName = "Sergey", Nationality = "Ukranian"},
            new Employee() { LastName = "Petrov", FirstName = "Slava", Nationality = "American"}
        };

        var query = from emp in employees
                    group emp by new { Nationality = emp.Nationality, LastName = emp.LastName };

        foreach (var group in query)
        {
            Console.WriteLine(group.Key);
            foreach(var emp in group)
                Console.WriteLine($"{emp.FirstName}");
        }
    }
}