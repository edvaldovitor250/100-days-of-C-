AgendaContatos agenda = new AgendaContatos();

            agenda.AdicionarContato("João", 123456);
            agenda.AdicionarContato("Maria", 987654);
            agenda.AdicionarContato("Pedro", 555555);

            Console.WriteLine("\n--- Contatos Atuais ---");
            agenda.ExibirContatos();

            Console.WriteLine("\n--- Atualizando Contato de João para João Silva ---");
            agenda.AtualizarContato("João", "João Silva", 123456, 654321);

            Console.WriteLine("\n--- Contatos Após Atualização ---");
            agenda.ExibirContatos();

            Console.WriteLine("\n--- Removendo Contato Maria ---");
            agenda.RemoverContato("Maria", 987654);

            Console.WriteLine("\n--- Contatos Após Remoção ---");
            agenda.ExibirContatos();