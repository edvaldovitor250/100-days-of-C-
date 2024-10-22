public class RecomendacaoFilmes{

    string[] filmes = { "O Poderoso Chefão",
            "Star Wars",
            "O Senhor dos Anéis",
            "Matrix",
            "Pulp Fiction",
            "Gladiador",
            "Inception",
            "O Lobo de Wall Street",
            "Interestelar",
            "Coringa"};
    double[] pontuacoes = {3,4,2,6,5,3,5,2,10};

    public string ObterRecomendacao(double pontuacao)
    {
        int index = Array.IndexOf(pontuacoes, pontuacao);
        if (index != -1) 
        {
            return filmes[index];
        }
        else
        {
            return "Nenhum filme encontrado com essa pontuação.";
        }
    }

public static void Main(string[] args)
{
    RecomendacaoFilmes recomendacao = new RecomendacaoFilmes();
    double pontuacao = 3;
    Console.WriteLine("Recomendado: " + recomendacao.ObterRecomendacao(pontuacao));
}
    

}