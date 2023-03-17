// See https://aka.ms/new-console-template for more information
using Aula_04;
using Aula_04.Heranca;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, 10.90M, "Cerveja");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Samba");
p1.setDescricao("Cerveja Samba");

Console.WriteLine(p1.getDescricao() + " " + p1.getId());

Endereco endereco = new Endereco(
    "Rua Francisco Mateus",
    "385",
    "Paineiras 1",
    "14940-000",
    "Ibitinga",
    "SP"
);
Endereco endereco2 = new Endereco(
    "Rua Quebrada",
    "956",
    "América",
    "14948-088",
    "Ibitinga",
    "SP"
);

Cliente c1 = new Cliente(1, "Jorge", "912345678", endereco);
Cliente c2 = new Cliente(2, "Jose", "956781234", endereco);
Cliente c3 = new Cliente(3, "Joana", "987654321", endereco);
Cliente c4 = new Cliente(4, "Joao", "987651234", endereco);
Cliente c5 = new Cliente(5, "Joliete", "915784321", endereco);

Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());
c2.getEndereco().setNumero("159");

Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());
c2.setEndereco(endereco2);

Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero());

Console.WriteLine(c2.getEndereco().EnderecoCompleto());

Carro gol = new Carro();
gol.temMotor = true;
gol.numeroPortas = 4;
gol.numeroAssento = 5;

Bike caloi = new Bike();

caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssento = 1;

gol.fabricante = "VW";
gol.cintoSeguranca = true;
gol.arCondicionado = false;

Carro Saveiro = new Carro();
Carro Palio = new Carro();
Carro Uno = new Carro();

Saveiro.fabricante = "VW";
Palio.fabricante = "Fiat";
Uno.fabricante = "Fiat";

Bike speed = new Bike();
speed.temMotor = true;
speed.numeroPortas = 0;

Console.WriteLine(speed.ExibirDados());
Console.WriteLine(gol.ExibirDados());



