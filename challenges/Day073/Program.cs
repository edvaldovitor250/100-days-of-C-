public class RecomendacaoMusica
{
        Dictionary<string, List<string>> tipoMusica = new Dictionary<string, List<string>>
        {
            {
                "Rock", new List<string> 
                { 
                    "Bohemian Rhapsody", 
                    "Stairway to Heaven", 
                    "Hotel California" 
                }
            },
            {
                "Pop", new List<string> 
                { 
                    "Shape of You", 
                    "Blinding Lights", 
                    "Uptown Funk" 
                }
            },
            {
                "Jazz", new List<string> 
                { 
                    "Take Five", 
                    "So What", 
                    "Autumn Leaves" 
                }
            },
            {
                "Classical", new List<string> 
                { 
                    "Symphony No. 5", 
                    "Canon in D", 
                    "The Four Seasons" 
                }
            }
        };
  public void PreferenciaMusical(string tipoMusical)
    {
        tipoMusical = tipoMusical.ToLower();
        
        if (tipoMusica.ContainsKey(tipoMusical))
        {
            Console.WriteLine($"As suas preferências são {tipoMusical}, recomendo estas músicas:");
            foreach (var musica in tipoMusica[tipoMusical])
            {
                Console.WriteLine(musica);
            }
        }
        else
        {
            Console.WriteLine("Tipo de música não encontrado.");
        }
    }
    
 public static void Main(string[] args)
    {
        RecomendacaoMusica recomendacao = new RecomendacaoMusica();

        Console.WriteLine("Digite seu tipo de música favorito (Rock, Pop, Jazz, Classical): ");
        string tipoMusica = Console.ReadLine();

        recomendacao.PreferenciaMusical(tipoMusica);
    }


}