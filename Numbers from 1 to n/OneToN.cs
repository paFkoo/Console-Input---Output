using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads an integer number n from the console and prints 
             * all the numbers in the interval [1..n], each on a single line.*/
            Console.Write("Enter a number: ");
            int numba = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numba; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
