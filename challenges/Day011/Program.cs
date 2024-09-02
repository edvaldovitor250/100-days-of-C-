using Day011;

 GestaoEstoque g2 = new GestaoEstoque();

            g2.AdicionarEstoque("Laptop", 3500);
            g2.AdicionarEstoque("Smartphone", 2000);
            g2.AdicionarEstoque("Tablet", 1500);

            g2.ListarEstoque();

            g2.AtualizarProduto();

            g2.ListarEstoque();

            g2.RemoverPedido();

            g2.ListarEstoque();