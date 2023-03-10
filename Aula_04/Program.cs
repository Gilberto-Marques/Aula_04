// See https://aka.ms/new-console-template for more information
using Aula_04;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, 10.90M, "Cerveja");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Samba");

Console.WriteLine(p1.getDescricao() + " " + p1.getId());