using System;

public abstract class Person
{
    public void Speak()
    {
        Console.WriteLine("Noi bang ngon ngu tieng viet");

    }
    public abstract void DoWork();
    public abstract void EnviromentWork();
}

class Developer : Person
{
    public override void DoWork()
    {
        Console.WriteLine("Lam viec rat vat va");
    }
    public override void EnviromentWork()
    {
        Console.WriteLine("Lam viec .... hai mat");
    }

}

class Developer1 : Person
{
    public override void DoWork()
    {
        Console.WriteLine("Lam viec ko vat va");
    }
    public override void EnviromentWork()
    {
        Console.WriteLine("Lam viec ez ");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Person dev = new Developer();
        Person dev1 = new Developer1();
        dev.Speak();
        dev.DoWork();
        dev.EnviromentWork();
        dev1.Speak();
        dev1.DoWork();
        dev1.EnviromentWork();
        Console.ReadLine();
    }
}