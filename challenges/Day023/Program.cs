   using Day023;
   
   GestaoCliente gestaoCliente = new GestaoCliente();

            gestaoCliente.AddNomeCliente("João", 25);
            gestaoCliente.AddNomeCliente("Maria", 30);

            Console.WriteLine("Clientes após adicionar:");
            gestaoCliente.ListarClientes();

            Console.WriteLine("\nAtualizando a idade de Maria...");
            gestaoCliente.atualizar();  

            Console.WriteLine("\nClientes após atualização:");
            gestaoCliente.ListarClientes();

            Console.WriteLine("\nRemovendo João...");
            gestaoCliente.RemoverNomeCliente("João");

            Console.WriteLine("\nClientes após remoção:");
            gestaoCliente.ListarClientes();