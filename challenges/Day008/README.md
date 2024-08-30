# Day 8

## Desafio:

	Crie uma classe em C# para representar uma calculadora básica com operações de soma, subtração, multiplicação e divisão.

**Resultado:**


```cshap


Console.WriteLine("Escolha a operação: ");
string op = Console.ReadLine();

Console.WriteLine("Escolha um numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escolha escolha o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

switch (op)
{
    case "+":
    {
      int  soma = num1 + num2;
        Console.WriteLine(soma);
          break;
    }
    case "-":
    {
       int sub = num1 + num2;
        Console.WriteLine(sub);
          break;
    }
     case "*":
    {
      int  mult = num1 * num2;
        Console.WriteLine(mult);
          break;
    }
     case "/":
    {
       int div = num1 / num2;
        Console.WriteLine(div);
          break;
    }
    
    default:
    {
        Console.WriteLine("Sua operação está errada, escolha uma válida: + - / *");
        break;
    }
    }

