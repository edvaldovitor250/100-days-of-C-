
            GerenciarBiblioteca biblioteca = new GerenciarBiblioteca();

            biblioteca.EmprestimoLivro("O Senhor dos Anéis", new DateTime(2024, 10, 13));
            biblioteca.EmprestimoLivro("1984", new DateTime(2024, 10, 12));

            biblioteca.DevolucaoLivro("O Senhor dos Anéis");

            biblioteca.ReservarLivro("O Hobbit", new DateTime(2024, 10, 20));

            biblioteca.ListarLivros();
