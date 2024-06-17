public delegate void PressKeyEventHandler();
public class KeyBoard
{
    public event PressKeyEventHandler PressKeyA = null;
    public event PressKeyEventHandler PressKeyB = null;
    public void PressKeyAEvent()
    {
        if (PressKeyA != null)
        {
            PressKeyA.Invoke();
        }
    }
    public void PressKeyBEvent()
    {
        if (PressKeyB != null)
        {
            PressKeyB.Invoke();
        }
    }
    public void Start()
    {
        bool flag = true;
        while(flag)
        {
            string s = Console.ReadLine();
            switch(s)
            {
                case "a":
                case "A":
                    PressKeyAEvent(); 
                    break;
                case "b":
                case "B":
                    PressKeyBEvent();
                    break;
                case "exit":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Нет обработчика на клавишу {0}", s);
                    break;
            }
        }
        Console.WriteLine("Exit");
    }
}
class Program
{
    static private void PressKeyA_Handler()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
        Console.WriteLine("    XX    ");
        Console.WriteLine("   X  X   ");
        Console.WriteLine("  X    X  ");
        Console.WriteLine(" XXXXXXXX ");
        Console.WriteLine("X        X");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    static private void PressKeyB_Handler()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine(" XXXXXXXX ");
        Console.WriteLine(" X       X");
        Console.WriteLine(" X       X");
        Console.WriteLine(" XXXXXXXX ");
        Console.WriteLine(" X       X");
        Console.WriteLine(" X       X");
        Console.WriteLine(" XXXXXXXX ");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    static void Main()
    {
        KeyBoard keyBoard = new KeyBoard();


        keyBoard.PressKeyA += PressKeyA_Handler;
        keyBoard.PressKeyB += PressKeyB_Handler;

        keyBoard.Start();
    }
}