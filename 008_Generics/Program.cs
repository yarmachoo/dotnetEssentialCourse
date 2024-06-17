
Shape shape = new Circle();//предварительный апкаст
IContainer<Circle> container = new Container<Shape>(shape);//даунаст
Console.WriteLine(container.ToString());

public abstract class Shape { }
public class Circle : Shape { }

public interface IContainer<in T>
{
    T Figure { set; }
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
        set { figure = value; }
    }
    public override string ToString()
    {
        return figure.GetType().ToString();
    }
}