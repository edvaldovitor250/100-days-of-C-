using System;

namespace Day005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero para saber seu Fatorial: ");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = 1;
            

            for (int i = numero; i > 1; i--)
            {
                fatorial *= i; 
                Console.Write(i + (i > 2 ? " x " : " = "));
            }

            Console.WriteLine(fatorial); 
        }
    }
}
