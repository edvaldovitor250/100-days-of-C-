using System;
using System.Drawing;

class ImageManipulationApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao manipulador de imagens!");
        string inputFilePath = "";
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Carregar imagem");
            Console.WriteLine("2. Aplicar filtro de escala de cinza");
            Console.WriteLine("3. Espelhar horizontalmente");
            Console.WriteLine("4. Salvar imagem");
            Console.WriteLine("5. Sair");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Digite o caminho completo da imagem para carregar: ");
                    inputFilePath = Console.ReadLine();
                    if (System.IO.File.Exists(inputFilePath))
                    {
                        Console.WriteLine("Imagem carregada com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Arquivo não encontrado.");
                    }
                    break;

                case "2":
                    if (CheckImageLoaded(inputFilePath))
                    {
                        ApplyGrayscaleFilter(inputFilePath);
                        Console.WriteLine("Filtro de escala de cinza aplicado.");
                    }
                    break;

                case "3":
                    if (CheckImageLoaded(inputFilePath))
                    {
                        MirrorImageHorizontally(inputFilePath);
                        Console.WriteLine("Imagem espelhada horizontalmente.");
                    }
                    break;

                case "4":
                    if (CheckImageLoaded(inputFilePath))
                    {
                        Console.Write("Digite o caminho e nome do arquivo para salvar a imagem modificada: ");
                        string savePath = Console.ReadLine();
                        SaveImage(inputFilePath, savePath);
                        Console.WriteLine("Imagem salva com sucesso.");
                    }
                    break;

                case "5":
                    keepRunning = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        Console.WriteLine("Encerrando o programa. Até logo!");
    }

    static bool CheckImageLoaded(string inputFilePath)
    {
        if (string.IsNullOrEmpty(inputFilePath) || !System.IO.File.Exists(inputFilePath))
        {
            Console.WriteLine("Nenhuma imagem carregada. Por favor, carregue uma imagem primeiro.");
            return false;
        }
        return true;
    }

    static void ApplyGrayscaleFilter(string inputFilePath)
    {
        Bitmap bitmap = new Bitmap(inputFilePath);

        for (int y = 0; y < bitmap.Height; y++)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                Color originalColor = bitmap.GetPixel(x, y);
                int grayScale = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                Color grayColor = Color.FromArgb(grayScale, grayScale, grayScale);
                bitmap.SetPixel(x, y, grayColor);
            }
        }

        bitmap.Save(inputFilePath);
        bitmap.Dispose();
    }

    static void MirrorImageHorizontally(string inputFilePath)
    {
        Bitmap bitmap = new Bitmap(inputFilePath);
        bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
        bitmap.Save(inputFilePath);
        bitmap.Dispose();
    }

    static void SaveImage(string inputFilePath, string savePath)
    {
        Bitmap bitmap = new Bitmap(inputFilePath);
        bitmap.Save(savePath);
        bitmap.Dispose();
    }
}
