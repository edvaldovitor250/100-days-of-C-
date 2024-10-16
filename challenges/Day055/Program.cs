using System;
using System.Collections.Generic;
using System.Threading;

class Chat
{
    private static List<string> messages = new List<string>(); 

    public void SendMessage(string user, string message)
    {
        lock (messages)
        {
            messages.Add($"{user}: {message}");
        }
    }

    public void DisplayMessages()
    {
        lock (messages)
        {
            Console.Clear();
            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}

class Program
{
    static Chat chat = new Chat();
    static string user;

    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        user = Console.ReadLine();

        Thread thread = new Thread(ListenForMessages); 
        thread.Start();

        while (true)
        {
            string message = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(message))
            {
                chat.SendMessage(user, message); 
            }
        }
    }

    static void ListenForMessages()
    {
        while (true)
        {
            chat.DisplayMessages(); 
            Thread.Sleep(1000);
        }
    }
}
