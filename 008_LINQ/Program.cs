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
            new Employee() { LastName = "Ivanov", FirstName = "Ivan", Nationality = "Russian"},
            new Employee() { LastName = "Andreev", FirstName = "Andrew", Nationality = "Ukranian"},
            new Employee() { LastName = "Petrov", FirstName = "Petr", Nationality = "American"}
        };

        var query = from emp in employees
                    orderby emp.Nationality ascending,
                    emp.LastName descending,
                    emp.FirstName descending
                    select emp;

        foreach (var emp in query)
            Console.WriteLine($"{emp.LastName} {emp.FirstName} {emp.Nationality}");
    }
}