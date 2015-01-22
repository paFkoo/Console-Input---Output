using System;
using System.Globalization;
    class FormatNumbers
    {
        static void Main()
        {
            /*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If the program breaks, try entering the floating point numbers with ' , ' \nand not with ' . ' and backwards.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter an integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter first floating point number: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter second floating point number: ");
            float c = float.Parse(Console.ReadLine());
            if (a >= 0 && a <= 500)
            {
                string hex = a.ToString("X");
                string binary = Convert.ToString(a , 2).PadLeft(10 , '0');
                Console.Write("{0,-10}|{1,10}|{2,10:0.00}|{3,-10:0.000}|\n", hex, binary, b, c);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID INPUT(integer must be <= 500)!!");
            }
        }
    }
