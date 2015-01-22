using System;
class SumOfThreeNumbers
{
    static void Main(string[] args)
    {
        //Write a program that reads 3 real numbers from the console and prints their sum.
        Console.Write("Enter the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number:");
        int c = int.Parse(Console.ReadLine());
        int result = (a) + (b) + (c);
        Console.WriteLine(result);
    }
}
