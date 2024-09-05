using Day014;

GerenciamentoAluno gerenciamento = new GerenciamentoAluno();

            gerenciamento.adicionarDados("João", "Matemática");
            gerenciamento.adicionarDados("Maria", "Português");

            gerenciamento.remover("João", 0);

            gerenciamento.atualizarAluno("Carlos", 0);

            Console.WriteLine("\nLista final de alunos e matérias:");
            gerenciamento.adicionarDados("Lucas", "Ciências"); 