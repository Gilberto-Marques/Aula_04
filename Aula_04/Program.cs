// See https://aka.ms/new-console-template for more information
using Aula_04;
using Aula_04.Heranca;
using System;
using System.Text;


Console.WriteLine("Hello, World!");

/*Produto p1 = new Produto(1, 10.90M, "Cerveja");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Samba");
p1.setDescricao("Cerveja Samba");

Console.WriteLine(p1.getDescricao() + " " + p1.getId());
*/
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
gol.numeroAssentos = 5;

Bike caloi = new Bike();
caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;
caloi.tipo = "bicicleta";

gol.fabricante = "VW";
gol.cintoSeguranca = true;
gol.arCondicionado = false;
gol.marcaRadio = "Pioneer";
gol.tipo = "carro";

Carro Saveiro = new Carro();
Carro Palio = new Carro();
Carro Uno = new Carro();

Saveiro.fabricante = "VW";
Palio.fabricante = "Fiat";
Uno.fabricante = "Fiat";

Bike speed = new Bike();
speed.temMotor = false;
speed.numeroPortas = 0;
speed.numeroAssentos = 1;
speed.tipo = "bicicleta";

// Faça uma ação chamada ExibirDados e
// mostre as informações na tela pelo Console.Writeline

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
listaVeiculo.Add(caloi);
listaVeiculo.Add(gol);
listaVeiculo.Add(speed);


foreach (var item in listaVeiculo)
{
    Console.WriteLine(item.ExibirDados());
}
List<Produto> listaProduto2 = new List<Produto>();
Produto p1 = new Produto(1, 3.5M, "Cerveja Skol");
listaProduto2.Add(p1);
Produto p2 = new Produto(2, 6.5M, "Guaraná Poty");
listaProduto2.Add(p2);
Produto p3 = new Produto(3, 18.5M, "Carne Moída");
listaProduto2.Add(p3);
Produto p4 = new Produto(4, 12.5M, "Café Pelé");
listaProduto2.Add(p4);
Produto p5 = new Produto(5, 8.5M, "Pão de Forma");
listaProduto2.Add(p5);

//Crie uma classe vendas com uma lista de produtos comprada por um cliente
//Imprima na tela a lista de produtos , o Id da venda e a Data da venda.
Venda v1 = new Venda(001, "02/04/2023");

Console.WriteLine("Conclusão de venda:["+v1.getId()+ "] data: "+v1.getData());
foreach(var item in listaProduto2)
{
    Console.WriteLine(item.ExibirVenda());
}







