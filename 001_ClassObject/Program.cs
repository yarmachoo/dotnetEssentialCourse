﻿class MyClassA: Object
{ }

class MyClassB: object
{ }

class Program
{
    static void Main()
    {
        Object instanceA = new MyClassA();
        object instanceB = new MyClassB(); 
    }
}