using System;
    class QuadraticEquation
    {
        static void Main()
        {
            /*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
             * and solves it (prints its real roots).*/
            //Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a
            Console.WriteLine("Welcome to the Quadratic Equation Solver!!!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("If the program breaks, try typing the number with a ' , ' \nand not with a ' . ' and backwards.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());
            double x1;
            double x2;
            double insideSqr = (b * b) - 4 * a * c;
            if (insideSqr < 0)
            {
                x1 = double.NaN;
                x2 = double.NaN;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("There are no real roots");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                double squareRoot = Math.Sqrt(insideSqr);
                x1 = (-b + squareRoot) / (2 * a);
                x2 = (-b - squareRoot) / (2 * a);
                Console.WriteLine("1st root is {0} , second root is {1}", x1, x2);
            }
        }
    }
