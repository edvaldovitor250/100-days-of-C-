int[] matrix  = {3,2,5,1,2,4,5};

Console.WriteLine("Digite quantas vezes queres multiplicar: ");
int count = int.Parse(Console.ReadLine()); 
foreach (int ma in matrix)
{
    int mult = ma * count;
    Console.WriteLine(mult);
    
}