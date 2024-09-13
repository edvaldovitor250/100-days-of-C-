
 static void GeradorDado(int numero){

 Random rand = new Random();
int rando =  rand.Next(numero, 7);
 Console.WriteLine(rando);
 }

 GeradorDado(6);