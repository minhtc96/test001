using System;
class HelloWorld
{
    static void Main()
    {
        
        int n, k;
        bool check = false;
        Console.WriteLine("Nhap so phan tu n: ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n] ;
        Console.WriteLine("Nhap gia tri cho tung phan tu: ");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Nhap so k: ");
        k = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (a[i] == k)
            {
                Console.WriteLine(a[i]);
                Console.WriteLine("Vi tri cua a[{0}] la {1}", i, k);
                check = true;
            }
            
        }
        if (!check)
        {
            Console.WriteLine("Khong co gia tri nao trong mang trung voi gia tri k da cho");
        }
        Console.ReadLine();
    }
}