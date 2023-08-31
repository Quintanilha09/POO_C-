using Pizzaria.Models;

Console.WriteLine("Bem vindo ao Projeto de Pizzaria");
Console.WriteLine("ESCOLHA UMA OPÇÃO:");
Console.WriteLine("1 - Adicionar Pizza");
Console.WriteLine("2 - Listar Pizzas \n");
Console.WriteLine("Digite sua opção");

int opcao = int.Parse(Console.ReadLine());

Pizza Pizza = new Pizza();
List<Pizza> pizzas = new List<Pizza>();

while (opcao == 1) {
    Console.WriteLine("Digite o nome da Pizza: ");
    string nome = Console.ReadLine();
    Pizza.nome = nome;

    Console.WriteLine("Adicione os ingredientes da pizza separados por vírgula: ");
    string ingredientes = Console.ReadLine();
    Pizza.ingredientes = ingredientes.Split(',');

    Console.WriteLine("Digite o preço da Pizza: ");
    float preco = float.Parse(Console.ReadLine());
    Pizza.preco = preco;

    pizzas.Add(Pizza);

    Console.WriteLine("ESCOLHA UMA OPÇÃO:");
    Console.WriteLine("1 - Adicionar Pizza");
    Console.WriteLine("2 - Listar Pizzas \n");
    Console.WriteLine("Digite sua opção");
    opcao = int.Parse(Console.ReadLine());

}

Console.WriteLine(pizzas.MostrarPizza());




