using System;

namespace Day004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para saber se é par ou ímpar: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " é Par");
            }
            else
            {
                Console.WriteLine(numero + " é Ímpar");
            }
        }
    }
}
