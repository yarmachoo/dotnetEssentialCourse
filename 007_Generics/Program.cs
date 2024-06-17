
Circle circle = new Circle();
IContainer<Shape> container = new Container<Circle>(circle);
Console.WriteLine(container.Figure.ToString());

public abstract class Shape { }
public class Circle : Shape { }

public interface IContainer<out T>
{
    T Figure { get; }
}

public class Container<T> : IContainer<T>
{
    private T figure { get; set; }
    public Container(T figure)
    {
        this.figure = figure;
    }
    public T Figure
    {
        get { return figure; }
    }
}