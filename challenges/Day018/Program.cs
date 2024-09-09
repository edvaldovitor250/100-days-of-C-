static double CalculoPi(double p, double d, double c)
{
    double pi = 4 * (p * d) / c;
    Console.WriteLine(pi); 
    return pi;             
}

double resultado = CalculoPi(3, 3, 3);
Console.WriteLine("Resultado: " + resultado);
