using System;

namespace _09Ageafter10Years
{
    class Ageafter10Years
    {
        static void Main()
        {
            //Write a program to read your birthday from the console and 
            //print how old you are now and how old you will be after 10 years.

            Console.Write("Enter your age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be:{0}", Age + 10);
        }
    }
}
