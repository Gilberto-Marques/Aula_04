// See https://aka.ms/new-console-template for more information
using Aula_04;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, 10.90M, "Cerveja");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
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


