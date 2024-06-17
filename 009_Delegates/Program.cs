
using System.Threading.Channels;

MyDelegate myDelegate;

myDelegate = delegate { Console.WriteLine("hello1"); };

myDelegate += () => { Console.WriteLine("Hello2"); };

myDelegate += () => Console.WriteLine("Hello3");

myDelegate();

public delegate void MyDelegate();

