// See https://aka.ms/new-console-template for more information
using Aula_04;
using Aula_04.Heranca;
using System;
using System.Text;

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
/*
Carro gol = new Carro();
gol.setTemMotor(true);
gol.setNumeroPortas(4);
gol.setNumeroAssento(5);

Bike caloi = new Bike();

caloi.setTemMotor(false);
caloi.setNumeroPortas(0);
caloi.setNumeroAssento(1);

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
speed.setTemMotor(true);
speed.setNumeroPortas(0);

Console.WriteLine(speed.ExibirDados());
Console.WriteLine(gol.ExibirDados());

List<Carro> listaCarros = new List<Carro>();
listaCarros.Add(gol);
listaCarros.Add(Palio);
listaCarros.Add(Uno);
listaCarros.Add(Saveiro);

//ira listar o primeiro adicionado na lista, sempre em ordem de inclusao
Console.WriteLine(listaCarros[0].fabricante);

listaCarros.Remove(Palio);

for (int i = 0; i < listaCarros.Count; i++ )
{
    Console.WriteLine(listaCarros[i].ExibirDados());
}

foreach (var item in listaCarros)
{
    Console.WriteLine(item.ExibirMarca());
}

*/
Console.WriteLine("___________________________________________________");
Console.WriteLine("Imprima na tela todos os clientes desse contexto");
Console.WriteLine("Dica crie uma lista pra eles");

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);
listaCliente.Add(c4);
listaCliente.Add(c5);

foreach (var item in listaCliente)
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("___________________________________________________");
Console.WriteLine("Crie uma lista com 560 produtos");
Console.WriteLine("Imprima na tela");
List<Produto> listaProduto = new List<Produto>();
for(int i = 1; i<=560; i++)
{
    Produto p = new Produto(1,1,"");
    p.setId(i);
    p.setValor(i);
    p.setDescricao(i+"");
    listaProduto.Add(p);
 
}
//Imprimindo todos os produtos incluidos na lista PRODUTO
Console.WriteLine("Dados dos Produtos:");
foreach (var item in listaProduto)
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("___________________________________________________");
Console.WriteLine("Crie uma lista que aceite qualquer tipo de veículo");
Console.WriteLine("Imprimir na tela");

List<Veiculo> listaVeiculo = new List<Veiculo>();
int condicao = 1;
Veiculo v = new Veiculo("", "", 0, 0, true);

while (condicao == 1)
{ 
    Console.WriteLine("Informe os dados do veículo: ");
}




