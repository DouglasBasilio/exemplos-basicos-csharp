using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //O fatorial é sempre o produto de números consecutivos inteiros de 1 até o próprio número.
            //Ex: Fatorial de 4 = 4 x 3 x 2 x 1 = 24 ou fatorial de 4 = 4 x 3! = 24.

            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
