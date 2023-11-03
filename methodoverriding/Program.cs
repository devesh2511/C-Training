// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;

namespace testing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Parent p = new();
            p.Property();

            //property overriding
            Parent c = new Child();
            c.Property();

        }
    }

    public class Parent
    {
        public virtual void Property() => Console.WriteLine("my prop");
    }

    public class Child : Parent
    {
        public override void Property() => Console.WriteLine("my additional prop");
    }
}

