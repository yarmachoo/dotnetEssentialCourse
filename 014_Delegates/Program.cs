Mydelegate mydelegate = null;

mydelegate = (int i) =>
{
    i--;
    Console.WriteLine($"Begin {i}");

    if (i > 0)
    {
        mydelegate.Invoke(i);
    }
    Console.WriteLine($"End {i}");
};

mydelegate(3);

public delegate void Mydelegate(int argument);