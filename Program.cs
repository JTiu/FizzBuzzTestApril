using System;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 16; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (i == 15)
                {
                    Console.WriteLine("\n\nThe");
                }
                if (i == 16)
                {
                    Console.WriteLine("End");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                        Console.WriteLine("?");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
