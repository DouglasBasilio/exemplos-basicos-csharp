using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 15");

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********

            //Escrevendo asteriscos com o BREAK

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            //Forma diferente de desenhar os asteriscos

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if ( coluna > linha )
                    {
                        break;
                    }
                    Console.Write( coluna+1 );
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
