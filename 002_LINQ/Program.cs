public class Employee
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public decimal Salary { get; set; }
    public DateTime StartDate { get; set; }
}
class Program
{
    static void Main()
    {
        var employees = new List<Employee>()
        {
            new Employee
            {
                FirstName = "Ivan",
                LastName = "Ivanov",
                Salary = 94000,
                StartDate = DateTime.Parse("1/4/1992")
            },
            new Employee
            {
                FirstName = "Petr",
                LastName = "Petrov",
                Salary = 123000,
                StartDate = DateTime.Parse("12/3/1985")
            },
            new Employee
            {
                FirstName = "Andrew",
                LastName = "Andreev",
                Salary = 1000000,
                StartDate = DateTime.Parse("1/12/2005")
            }
        };

        //Выражение запроса LINQ.
        //(Использование вызовов расширяющих методов)
        var query = //query = переменная запроса
                    employees
                    .Where(emp => emp.Salary > 100000)
                    .OrderBy(emp => emp.LastName)
                    .OrderBy(emp => emp.FirstName)
                    .Select(emp => new
                    {
                        LastName = emp.LastName,
                        FirstName = emp.FirstName,
                    });

        Console.WriteLine("Высокооплачиваемые сотрудники:");

        foreach (var item in query)
            Console.WriteLine($"{item.LastName} {item.FirstName}");
    }
}