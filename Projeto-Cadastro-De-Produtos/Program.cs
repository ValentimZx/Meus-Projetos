Console.WriteLine("Digite o nome do produto: \n");
var produto = Console.ReadLine();

Console.WriteLine("Digite o preco do produto: \n");
double preco = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quantidade do produto:\n ");
int quantidade = Convert.ToInt32(Console.ReadLine());

double total = preco * quantidade;
if (total > 100)
{
    double desconto = total * 0.10;
    double totalComDeconto = total - desconto;

    Console.WriteLine($"\nProduto: {produto}");
    Console.WriteLine($"Valor total sem desconto: R$ {total:F2}");
    Console.WriteLine($"Compra acima de R$100! Desconto de 10% aplicado.");
    Console.WriteLine($"Valor com desconto; R$ {totalComDeconto}");
}
else
{
    Console.WriteLine($"\nProduto: {produto}");
    Console.WriteLine($"Valor total da sua compra: R${total:F2}");
}