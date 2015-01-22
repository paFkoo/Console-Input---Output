using System;
    class NumberCompare
    {
        static void Main()
        {
            /*Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/
            Console.WriteLine("Enter the first number: ");
            double firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double secondValue = double.Parse(Console.ReadLine());
            switch (firstValue.CompareTo(secondValue))
            {
                case 1:
                    Console.WriteLine("{0} is bigger than {1}", firstValue, secondValue);
                    break;
                case -1:
                    Console.WriteLine("{0} is smaller  than {1}", firstValue, secondValue);
                    break;
                default:
                    Console.WriteLine("{0} is equal to {1}", firstValue, secondValue);
                    break;
            }
        }
    }
