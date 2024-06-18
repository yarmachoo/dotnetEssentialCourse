//join - операция объединения - утсанавливает соотношение данных из двух разных источников

public class EmployeeId
{
    public string? Id { get; set; }
    public string? Name { get; set; }
}
public class EmployeeNationality
{
    public string? Id { get; set; }
    public string? Nationality { get; set;}
}
class Program
{
    static void Main()
    {
        var employees = new List<EmployeeId>
        {
            new EmployeeId{Id = "111", Name = "Ivan"},
            new EmployeeId{Id = "222", Name = "Andrew"},
            new EmployeeId{Id = "333", Name = "Petr"},
            new EmployeeId{Id = "444", Name = "Alex"},
        };
        var employeesNationalities = new List<EmployeeNationality>
        {
            new EmployeeNationality{Id = "111", Nationality = "Russian"},
            new EmployeeNationality{Id = "222", Nationality = "Ukranian"},
            new EmployeeNationality{Id = "333", Nationality = "American"},
        };
        var query = from emp in employees
                    join n in employeesNationalities
                    on emp.Id equals n.Id
                    orderby n.Nationality descending //ascending - по возрастанию
                    select new
                    {
                        Id = emp.Id,
                        Name = emp.Name,
                        Nationality = n.Nationality
                    };

        foreach(var item in query)
        {
            Console.WriteLine($"{item.Id} {item.Name} {item.Nationality}");
        }
    }
}