// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace labda
{

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5, 6, 7 };

            var a = a1.Where(x => x % 2 == 0).Select(x => x);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }

}