// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Program
{

    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a + b;
        int d;
        if (a >= b)
        {
            d = a - b;
        }
        else
        {
            d = b - a;
        }
        Console.WriteLine("Addition is " + c + " and Substraction is " + d);
    }
}
