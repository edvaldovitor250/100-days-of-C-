using Day015;

FilaBanco filaBanco = new FilaBanco();

            filaBanco.entrarFila("Cliente 1");
            filaBanco.entrarFila("Cliente 2");
            filaBanco.entrarFila("Cliente 3");

            Console.WriteLine("Fila de clientes:");
            filaBanco.listarFila();

            filaBanco.sairFila();

            Console.WriteLine("\nFila após a saída de um cliente:");
            filaBanco.listarFila();