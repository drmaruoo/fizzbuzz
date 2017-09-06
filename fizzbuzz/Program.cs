using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input max value that will be fizzbuzzed: ");
            int max = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("");
                if ((i + 1) % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if ((i + 1) % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                if ((i + 1) % 3 != 0 && (i + 1) % 5 != 0)
                {
                    Console.Write(i + 1);
                }

            }
            Console.ReadKey();
        }
    }
}
