using Pizzaria.Models;

Console.WriteLine("Bem vindo ao Projeto de Pizzaria");
Console.WriteLine("ESCOLHA UMA OPÇÃO:");
Console.WriteLine("1 - Adicionar Pizza");
Console.WriteLine("2 - Listar Pizzas \n");
Console.WriteLine("Digite sua opção");

int opcao = Console.ReadLine();

Pizza Pizza = new Pizza();


if (opcao == 1)
{
    Console.WriteLine("Digite o nome da Pizza: ");
    var nome = Console.ReadLine();
    Pizza.nome = nome;

    Console.WriteLine("Digite o sabor da Pizza separados por vírgula: ");
    var ingredientes = Console.ReadLine();
    Pizza.ingredientes = ingredientes;

    Console.WriteLine("Digite o preço da Pizza: ");
    var preco = Console.ReadLine();
    Pizza.preco = preco;

   

} else if (opcao == 2) {
    Pizza.MostrarPizza();

} else {
    Console.WriteLine("Você inseriu a opção errada");
}

