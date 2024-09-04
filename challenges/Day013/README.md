# Day 13

## Desafio:

Escreva um programa C# que verifique se uma string é um palíndromo.

**Resultado:**


```cshap

  Console.WriteLine("Digite uma string para verificar se é um palíndromo:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"\"{input}\" é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"\"{input}\" não é um palíndromo.");
        }

         static bool IsPalindrome(string str)
    {
        string cleanedStr = str.Replace(" ", "").ToLower();

        char[] charArray = cleanedStr.ToCharArray();

        Array.Reverse(charArray);

        string reversedStr = new string(charArray);

        return cleanedStr == reversedStr;
    }