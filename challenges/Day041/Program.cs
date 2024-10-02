ReservasCinema reservas = new ReservasCinema();

reservas.ListarAssentosDisponiveis();

reservas.ReservarAssento(10);
reservas.ReservarAssento(25);
reservas.ReservarAssento(150);

reservas.ReservarAssento(10);

reservas.ReservarAssento(200);

reservas.ListarAssentosDisponiveis();