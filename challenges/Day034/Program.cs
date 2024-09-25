 SistemaPassagens sistema = new SistemaPassagens();

            sistema.ReservaPassagem("Voo SP - RJ", 500);
            sistema.ReservaPassagem("Voo Brasília - Salvador", 350);
            sistema.ReservaPassagem("Voo Recife - Fortaleza", 420);

            sistema.ListarVoos();

            sistema.RemoverReserva("Voo SP - RJ");

            sistema.ListarVoos();