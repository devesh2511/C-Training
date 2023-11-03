// See https://aka.ms/new-console-template for more information

using System;

public class Program{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0){
            Console.WriteLine("Even");
        }
        else{
            Console.WriteLine("Odd");
        }
    }
}
