﻿public class Employee
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

        var query = //query = переменная запроса
                    from employee in employees //from - объявляет переменную диапазона employee
                    where employee.Salary > 100000//where - фильтр
                    orderby employee.LastName, employee.FirstName
                    select new //select  - операция проекции
                    {
                        LastName = employee.LastName,
                        FirstName = employee.FirstName,
                    };//Создание анонимного типа

        Console.WriteLine("Высокооплачиваемые сотрудники:");

        foreach(var item in  query) 
            Console.WriteLine($"{item.LastName} {item.FirstName}");
    }
}