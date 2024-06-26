﻿
Circle circle = new Circle();
IContainer<Circle> container = new Container<Circle>(circle);
Console.WriteLine(container.Figure.ToString());

public abstract class Shape { }
public class Circle : Shape { }

public interface IContainer<T>
{
    T Figure { get; set; }
}

public class Container<T> : IContainer<T>
{
    public T Figure { get; set; }
    public Container(T figure)
    {
        this.Figure = figure;
    }
}