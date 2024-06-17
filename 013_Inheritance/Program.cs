
Container container = new Container();
container.field = new Der1();
Console.WriteLine(container.field.GetHashCode());
container.field = new Der2();
Console.WriteLine(container.field.GetHashCode());
class BaseClass
{ }
class Der1: BaseClass
{

}
class Der2: BaseClass
{

}
class Container
{
    public BaseClass field;
}
