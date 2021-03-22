using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();

            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
