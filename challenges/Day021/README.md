# Day 21

## Desafio:

Implemente um programa C# que valide um endereço de e-mail usando expressões regulares.

**Resultado:**

```cshap

using System.Text.RegularExpressions;


Console.Write("Informe seu E-mail: ");
var email = Console.ReadLine();

    Regex regex = new Regex(@"^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)?$", RegexOptions.IgnoreCase);

var verification = regex.Match(email);

if (verification.Success)
{
   Console.WriteLine("E-mail válido." + verification);
} 
 else
 {
     Console.WriteLine("E-mail inválido." + verification);

 }