using System;
using System.Text;
    class PrintInfo
    {
        static void Main(string[] args)
        {
            /*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/
            Console.Write("Enter a company name:");
            var name = (Console.ReadLine());
            Console.Write("Enter a company address:");
            var address = (Console.ReadLine());
            Console.Write("Enter company phone number(begin from 359...):");
            var pNumber = (Console.ReadLine());
            Console.Write("Enter company fax number(if you dont have a fax write --> none):");
            var fNumber = (Console.ReadLine());
            if (fNumber == "none")
            {
                fNumber = "(nofax)";
            }
            Console.Write("Enter company website:");
            var webSite = (Console.ReadLine());
            Console.Write("Enter manager's first name:");
            var managerFirstName = (Console.ReadLine());
            Console.Write("Enter manager's last name:");
            var managerlastName = (Console.ReadLine());
            Console.Write("Enter manager's age:");
            var age = (Console.ReadLine());
            Console.Write("Enter manager's phone number(begin from 359...):");
            var phone = (Console.ReadLine());
            Console.WriteLine("{0}\nAddress: {1}\nTel.+{2}\nFax:{3}\nWeb Site: {4}\nManager: {5} {6}(age: {7},tel.+{8})", name , address , pNumber , fNumber ,
                webSite , managerFirstName , managerlastName , age , phone);
        }
    }

