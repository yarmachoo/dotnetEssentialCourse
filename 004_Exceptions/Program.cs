using System.Collections;
using System.Linq.Expressions;

class MyClass
{
    public void MyMethod()
    {
        Exception ex = new Exception("Мое ислючение");

        ex.HelpLink = "http://MyCompany.com";
        ex.Data.Add("Причиа исключения: ", "тестовое исключение");
        ex.Data.Add("Время возникновения исключения: ", DateTime.Now);

        throw ex;
    }
}
class Program
{
    static void Main()
    {
        try
        {
            MyClass myClass = new MyClass();
            myClass.MyMethod();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.TargetSite);
            Console.WriteLine(ex.TargetSite.DeclaringType);
            Console.WriteLine(ex.TargetSite.MemberType);
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.Source);
            Console.WriteLine(ex.HelpLink);
            Console.WriteLine(ex.StackTrace);

            foreach(DictionaryEntry de in ex.Data)
            {
                Console.WriteLine($"{de.Key} : {de.Value}");
            }
        }
    }
}