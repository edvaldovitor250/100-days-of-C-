
using System;

namespace Day006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero para saber se é Primo: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = numero; i < numero; i++){
                if (i == 1)
                {
                    Console.WriteLine(numero + " é um número Primo");
                }
                
            }

        }
    }
}

