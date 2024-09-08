using Day017;

GestaoFuncionarios gestao = new GestaoFuncionarios();

            gestao.AdicionarFuncionario("João", 3000, 30);
            gestao.AdicionarFuncionario("Maria", 4000, 28);
            gestao.AdicionarFuncionario("Pedro", 3500, 35);

            gestao.ListarFuncionarios();
            
            gestao.AtualizarFuncionario("Maria", 4500, 29);

            gestao.RemoverFuncionario("João");
            gestao.ListarFuncionarios();