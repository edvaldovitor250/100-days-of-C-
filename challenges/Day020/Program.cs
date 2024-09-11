using Day020;

GerenciamentoProduto gerenciamento = new GerenciamentoProduto();
            
            gerenciamento.AdicionarProduto("Celular", 1500);
            gerenciamento.AdicionarProduto("Notebook", 3000);
            gerenciamento.AdicionarProduto("Teclado", 200);
            
            Console.WriteLine("Produtos após adicionar:");
            gerenciamento.ListarProdutos();
            
            gerenciamento.AtualizarPreco("Teclado", 250);
            
            Console.WriteLine("Produtos após atualizar o preço:");
            gerenciamento.ListarProdutos();
            
            gerenciamento.RemoverProduto("Notebook");
            
            Console.WriteLine("Produtos após remover:");
            gerenciamento.ListarProdutos();