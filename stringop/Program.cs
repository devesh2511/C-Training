// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;

namespace testing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test = "Welcome";

            if (test.Contains("We"))
            {
                Console.WriteLine("its there");
            }
            else
            {
                Console.WriteLine("not there");
            }

            string a = test.IndexOf('e').ToString();

            Console.WriteLine(a);

        }
    }
}

