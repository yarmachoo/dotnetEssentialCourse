MyClass my = new MyClass();

my[0] = 1;
my[1] = 2;
my[2] = 3;
my[3] = 4;

for(int i = 0; i<4; i++)
{
    Console.WriteLine(my[i]);
}

class MyClass
{
    private int[] array = new int[5];

    public int this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            array[index] = value;
        }
    }
}