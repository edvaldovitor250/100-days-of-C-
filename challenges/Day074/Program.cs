using System;
using System.Collections.Generic;

public class GerenciarMidia
{
    List<string> audios = new List<string>();
    List<string> videos = new List<string>();

    public void AdicionarAudio(string audio)
    {
        audios.Add(audio);
    }

    public void AdicionarVideo(string video)
    {
        videos.Add(video);
    }

    public void ListarAudios()
    {
        foreach (var item in audios)
        {
            Console.WriteLine("{0}", item);   
        }
    }

    public void ListarVideos()
    {
        foreach (var item in videos)
        {
            Console.WriteLine("{0}", item);   
        }
    }

    public void ReproduzirMusica(string audio)
    {
        Console.WriteLine("Reproduzindo áudio: {0}", audio);
    }

    public void ReproduzirVideo(string video)
    {
        Console.WriteLine("Reproduzindo vídeo: {0}", video);
    }

    public static void Main(string[] args)
    {
        GerenciarMidia midia = new GerenciarMidia();

        midia.AdicionarAudio("Audio1.mp3");
        midia.AdicionarAudio("Audio2.mp3");
        midia.AdicionarVideo("Video1.mp4");
        midia.AdicionarVideo("Video2.mp4");

        Console.WriteLine("Lista de Áudios:");
        midia.ListarAudios();

        Console.WriteLine("\nLista de Vídeos:");
        midia.ListarVideos();

        Console.WriteLine("\nReprodução de Mídia:");
        midia.ReproduzirMusica("Audio1.mp3");
        midia.ReproduzirVideo("Video1.mp4");
    }
}
