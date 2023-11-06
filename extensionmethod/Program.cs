// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Diagnostics;

namespace extensionmethod;

public class Program
{
    public static void Main(string[] args)
    {
        int i = 100;
        Console.WriteLine(i.Add(8));
        Console.WriteLine(i.Add2(10, 1));
        Console.WriteLine(i.Substract(10));
        Console.WriteLine(i.isGreater(11));
    }
}

public static class Extension
{
    public static int Add(this int a, int b) => a + b;
    public static int Add2(this int a, int b, int c) => a + b + c;
    public static int Substract(this int a, int b) => a - b;
    public static bool isGreater(this int a, int b) => a > b;

}