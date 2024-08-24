using System;

namespace Day002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Seu número: " + numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Não é um número.");
            }
        }
    }
}
