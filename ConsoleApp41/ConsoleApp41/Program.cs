using System;
using System.Collections.Generic;


// Bai1:

public interface IStudent
{ 
    int StudID { get; set; }
    string StudName { get; set; }
    string StudGender { get; set; }
    int StudAge { get; set; }
    string StudClass { get; set; }
    public float StudAvgMark { get; }
     
       
    

    void Print();
}

public class Student : IStudent
{
    public int StudID
    { get; set;}
    public string StudName { get; set; }

    public string StudGender { get; set; }

    public int StudAge { get; set; }

    public string StudClass { get; set; }
    public float StudAvgMark { get; }

    public void Print()
    {
        Console.WriteLine($"StudName: {StudName} StudID {StudID} StudGender {StudGender} StudAge {StudAge} StudClass {StudClass}");
    }

    //public float CalAvg()
    //{
        //return StudAvgMark = (this.MarkList[0] + this.MarkList[1] + this.MarkList[2]) / 3;
    //}
    int[] MarkList = new int[3];

}

public class Program
{
    
    public static void Main()
    {
        List<Student> list = new List<Student>();
        
        Console.WriteLine();
        Console.WriteLine("Please select an option: ");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("1. Insert new student...");
        Console.WriteLine("2. Display all the student list...");
        Console.WriteLine("3. Calculator average mark....");
        Console.WriteLine("4. Find Student ID. ");
        Console.WriteLine("5. Exit. ");
        Console.WriteLine("----------------------------------------------");
        do
        {
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: {
                        IStudent st = new Student();
                        Console.WriteLine("Nhap StudID: ");
                        st.StudID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap StudName: ");
                        st.StudName = Console.ReadLine();
                        Console.WriteLine("Nhap StudGender: ");
                        st.StudGender = Console.ReadLine();
                        Console.WriteLine("Nhap StudAge: ");
                        st.StudAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap StudClass: ");
                        st.StudClass = Console.ReadLine();
                        Console.WriteLine("Insert new student:");

                        break;
                    }
                case 2: {
                        Console.WriteLine("Display all the student list: ");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Calculator avg mark: ");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Find Student ID");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Exit");
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Input Value is invalid");
                        break;
                    }
            }
        
        
                
        } while (true);







    }

}

