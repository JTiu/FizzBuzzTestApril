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
                if (i == 16)
                {
                    Console.WriteLine("\n\nThe End");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    for (int k = 1; k <= 12; k++)
                    {
                        string str = "";
                        if (k % 3 == 0)
                        {
                            str += "Ziff";
                        }
                        if (k % 5 == 0)
                        {
                            str += "Zubb";
                        }
                        if (k % 7 == 0)
                        {
                            str += "Zubb";
                        }

                        if (str.Length == 0)
                        {
                            str = k.ToString();
                        }
                        Console.WriteLine(str);

                    }
                }
                else
                {
                    Console.WriteLine(i);
                }

                

                
            }
        }
    }
}
