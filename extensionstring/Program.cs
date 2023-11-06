// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace extensionstring
{
    public class Program
    {
        public static void Main(string[] args)
        {

        public class Student
        {
            public int Id;
            public string Name;
            List<Student> students = new List<Student>(){
            new Student(){Id=1, Name = "Dev"},
            new Student(){Id=2, Name = "Dhanish"},
            new Student(){Id=3, Name = "Bhuvan"},
            new Student(){Id=4, Name = "Chirag"},
            new Student(){Id=5, Name = "Nikhil"},
        };
        }
        public class Employee
        {
            public int Id;
            public string Name;
            public int StudId;
            List<Employee> employees = new List<Employee>(){
            new Employee(){Id=1, Name = "Jayashri", StudId=3},
            new Employee(){Id=2, Name = "Karthika",StudId=3},
            new Employee(){Id=3, Name = "Manjula", StudId=2},
            new Employee(){Id=4, Name = "Harika",StudId=1},
            new Employee(){Id=5, Name = "Joseph",StudId=2},
        };
        }

        var a = from i in students
                where i.Name.Length > 3
                select new { i.Name };
            foreach (var item in a)
            {
                Console.WriteLine(item.Name);
            }
}
    }
}


