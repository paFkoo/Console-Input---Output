using System;
    class SumOf5Numbers
    {
        static void Main()
        {
            /*Write a program that enters 5 numbers 
             * (given in a single line, separated by a space), calculates and prints their sum.*/
            Console.Write("Enter  5 numbers separated by  a space: ");
            string[] numbaZ = Console.ReadLine().Split(' ');

            double sum = 0;

            for (int i = 0; i < numbaZ.Length; i++)
            {
                sum += Convert.ToDouble(numbaZ[i]);
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
