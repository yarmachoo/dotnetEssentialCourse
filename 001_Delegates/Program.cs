
//Создаем экземпляр делегата
MyDelegate myDelegate = new MyDelegate(MyClass.Method);
myDelegate.Invoke(); //Вызываем метод сообщенный с делегатом.

myDelegate();




//Класс, метод которого будет сообщен с делегатом.
static class MyClass
{
    public static void Method()
    {
        Console.WriteLine("Строку вывел метод сообщений с делегатом.");
    }
}

//На 23-й строке создаем класс-делегата с именем
//MyDelegate, метод, который будет совмещен с экземпляром 
//данного класса-делегата, не будет ничего принимать и
//не будет ничего возвращать

public delegate void MyDelegate();