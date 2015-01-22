using System;
    class Fibonacci
    {
        static void Main()
        {
            /*Write a program that reads a number n and prints on the console the first n members of the 
             * Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/
            int previous = -1; 
            int next = 1;

            Console.Write("Enter n: ");
 
            int n = int.Parse(Console.ReadLine());
 
            for (int i = 0; i < n; i++)
            {
                int sum = next + previous; 
                previous = next;
                next = sum;

                Console.Write("{0}, ", next);
            }
        }
     }

