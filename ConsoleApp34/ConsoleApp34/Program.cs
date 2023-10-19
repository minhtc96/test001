using System;

 class Student
   {
    public int Id;
    public int Mark1;
    public int Mark2;
    public int Mark3;
    public int Age;
    public string Gender;
    public string Class;
    public string dateOfBirth;

    public int mark_AVG()
    {
       return (this.Mark1 + this.Mark1 + this.Mark3) / 3;
    }

   }
   

    





class TestStudent : Student
{
    public void stundentInfo(int id, int age, string gender, string Class, string dateofBirth)
    {
        this.Id = id;
        this.Age = age;
        this.Gender = gender;
        this.Class = Class;
        this.dateOfBirth = dateofBirth;
    }


}


class Program
{
    public static void Main()
    {
        bool check = false;
        int option;

        do {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("================================================================");
            Console.WriteLine("1. Input information");
            Console.WriteLine("2. Sorting student");
            Console.WriteLine("3. Display all the student list");
            Console.WriteLine("4. Search student by name");
            Console.WriteLine("5. Delete student by id student");
            Console.WriteLine("6. Exit program");
            Console.WriteLine("================================================================");


            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        check = true;
                        Console.WriteLine("Input student information");






                        break;
                    }
                case 2:
                    {
                        if (check == false)
                        {
                            Console.WriteLine("Please input student information");
                            break;
                        }
                            Console.WriteLine("2. Sorting student");
                        





                        break;
                    }
                case 3:
                    {
                        if (check == false)
                        {
                            Console.WriteLine("Please input student information");
                            break;
                        }
                        Console.WriteLine("3. Display all the student list");





                        break;
                    }
                case 4:
                    {
                        if (check == false)
                        {
                            Console.WriteLine("Please input student information");
                            break;
                        }
                        Console.WriteLine("4. Search student by name");




                        break;
                    }
                case 5:
                    {
                        if (check == false)
                        {
                            Console.WriteLine("Please input student information");
                            break;
                        }
                        Console.WriteLine("5. Delete student by id student");




                            break;
                    }
                case 6:
                    {
                        Console.WriteLine("6. Exit program");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
        }while( option > 0 && option < 6)
        


    }
}