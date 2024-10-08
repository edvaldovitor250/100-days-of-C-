 SistemaBancario sistemaBancario = new SistemaBancario();

            sistemaBancario.CriarConta("Alice", 1000);
            sistemaBancario.CriarConta("Bob", 500);

            sistemaBancario.Depositar("Alice", 200);
            sistemaBancario.Sacar("Bob", 100);
            sistemaBancario.Transferir("Alice", "Bob", 300);

            sistemaBancario.ConsultarSaldo("Alice");
            sistemaBancario.ConsultarSaldo("Bob");

            sistemaBancario.ConsultarExtrato("Alice");
            sistemaBancario.ConsultarExtrato("Bob");

            Console.ReadLine();