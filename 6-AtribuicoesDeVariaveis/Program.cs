using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 31;
            int idadeDouglas = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeDouglas);

            string parcela_1 = "10";
            string parcela_2 = "20";

            Console.WriteLine(parcela_1 + parcela_2);

            Console.ReadLine();
        }
    }
}
