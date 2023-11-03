// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace c_training
{

    public class Ass1
    {
        public static void Main(string[] args)
        {
            // int n = Console.ReadLine();

            int a = 9;

            int[] arr = {1, 2, 3, 4, 5, 6, 7};

            Sumpair(a,arr);
    

    }

        public static void Sumpair(int a, int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == a)
                    {
                        Console.WriteLine(
                            $"{arr[i]},{arr[j]}"
                        );
                    }

                }
            }
        }
    }
}

