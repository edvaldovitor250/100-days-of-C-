void contadorDeVogais(string texto){
    int vogais = 0;
    string vogaisStr = "aeiouAEIOU";
    
    foreach(char c in texto){
        if(vogaisStr.Contains(c.ToString())){
            vogais++;
        }
    }
    
    Console.WriteLine($"A quantidade de vogais no texto é: {vogais}");
}

contadorDeVogais("vitor");