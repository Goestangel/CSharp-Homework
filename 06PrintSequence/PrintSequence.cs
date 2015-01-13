using System;

namespace _06PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
                //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

                for (int i = 2; i <= 10;)
            {
                Console.WriteLine(i++);
                Console.WriteLine(-i++);
            }
        }
    }
}
