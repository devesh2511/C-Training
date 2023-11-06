// See https://aka.ms/new-console-template for more information

using System;

namespace training
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // Student s1 = new Student(Dev, 1, 240, 240/3);

            List<Student> lst = new List<Student>();

            lst.Add(new Student("Dev", 1, 240));
            lst.Add(new Student("Chirag", 1, 240));
            lst.Add(new Student("Soumik", 1, 240));
            lst.Add(new Student("Promise", 1, 240));
            lst.Add(new Student("Bhuvan", 1, 240));

            foreach (Student stud in lst)
            {
                Console.WriteLine($"Name: {stud.Name}, Id: {stud.Id}, TotalMarks: {stud.Total_Marks}, AverageMarks: {stud.Avg_Marks}.");
            }

        }
    }

    public class Student
    {
       public string Name;
        public int Id;
        public int Total_Marks;
        public int Avg_Marks;


        public Student(string Name, int Id, int Total_Marks)
        {

            this.Name = Name;
            this.Id = Id;
            this.Total_Marks = Total_Marks;
            this.Avg_Marks = Total_Marks / 3;

        }
    }

}