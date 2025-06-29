bool condicao = true;
double totalAcumulado = 0;

while (condicao)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1 - Comprar produto");
    Console.WriteLine("2 - Ver total acumulado");
    Console.WriteLine("3 - Sair");

    Console.Write("Escolha uma opcao:");
    var menu = Console.ReadLine();
    switch (menu)
    {
        case "1":
            Console.WriteLine("\n-- Comprar produto --");
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Preco do produto: ");
            var preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            double subTotal = preco * quantidade;
            totalAcumulado += subTotal;

            Console.WriteLine($"Produto '{nome}' adicionado. Subtotal: R$ {subTotal:F2}");
            Console.WriteLine($"Total parcial: R$ {totalAcumulado:F2}");
            break;

        case "2":
            Console.WriteLine($"\nTotal Acumulad: R${totalAcumulado}");
            break;

        case "3":
            Console.WriteLine("\nObrigado pela compra!");
            condicao = false;
            break;

        default:
            Console.WriteLine("Opcao invalida, tente novamente!");
            break;

    }
}