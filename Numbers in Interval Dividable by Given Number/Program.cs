using System;
    class Program
    {
        static void Main()
        {
            /*Write a program that reads two positive integer numbers and prints how many 
             * numbers p exist between them such that the reminder of the division by 5 is 0.*/
            Console.Write("Enter first positive integer: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second positive integer(must be bigger than the first number): ");
            int lastNumber = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                if (i % 5 ==0)
                {
                    p++;
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine("\nThere are {0} numbers between {1} and {2}, that the reminder of their division by 5 is 0"
                            , p, firstNumber, lastNumber);
        }
    }
