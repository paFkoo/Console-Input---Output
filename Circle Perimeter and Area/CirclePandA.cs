using System;
    class CirclePandA
    {
        static void Main()
        {
            /*Write a program that reads the radius r of a circle and
              prints its perimeter and area formatted with 2 digits after the decimal point.*/
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nIf the program breaks when you enter a number of the type --> 3.14 --> \nTry entering it with a ' , ':");
            Console.ForegroundColor = ConsoleColor.White;
            
                if (radius != 0)
            {
                double pi = 3.14159;
                double d = radius * 2;
                double A = pi * (radius * radius);
                double P = pi * d;
                Console.WriteLine("The perimeter is {0:0.00}:", P);
                Console.WriteLine("The area is {0:0.00}:", A);
            }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID INPUT");
                }
        }
    }

