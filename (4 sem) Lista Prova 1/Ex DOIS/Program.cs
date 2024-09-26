using Ex_DOIS;

Fila<Carro> filaCarro = new Fila<Carro>();
Fila<Moto> filaMoto = new Fila<Moto>();

Carro carro1 = new Carro();
Carro carro2 = new Carro();
Moto moto1 = new Moto();
Moto moto2 = new Moto();

filaCarro.Inserir(carro1);
filaCarro.Inserir(carro2);
filaMoto.Inserir(moto1);
filaMoto.Inserir(moto2);

filaCarro.Listar();
filaMoto.Listar();

