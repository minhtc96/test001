using System;

public class Studen
{
    private int id;
    public string name;
    public int age;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Display()
    {
        Console.WriteLine($" Name: {name}");
        Console.WriteLine($" Id: {id}");
    }

}

class Program
{
    static void Main()
    {
        Studen S1 = new Studen();
        S1.Id = 1;
        S1.Name = "HEHE";
        S1.Display();
        Console.ReadLine();
    }
}
