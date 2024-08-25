
using System;

namespace Day003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine("A soma é: " + soma);
        }
    }
}

