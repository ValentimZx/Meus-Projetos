bool condicao = true;
decimal saldo = 1000;
decimal depositar;

while (condicao)
{
    Console.WriteLine("==== Bem vindo ao banco Console ===");

    Console.Write("\nDigite seu nome: ");
    var nome = Console.ReadLine();

    Console.WriteLine($"\nBem vindo {nome}! Escolha uma opcao: \t");

    Console.WriteLine("\n1 - Ver Saldo");
    Console.WriteLine("\n2 - Depositar");
    Console.WriteLine("\n3 - Sacar");
    Console.WriteLine("\n4 - Sair");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Seu saldo atual e {saldo}");
            break;
        case 2:
            Console.WriteLine($"Informe o valor do deposito: ");
            depositar = Convert.ToDecimal(Console.ReadLine());

            Console.Write("COnfirma o valor do deposito S/N");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                saldo += depositar;
                Console.WriteLine("Deposito concluido com sucesso!");
            }

            else
                Console.WriteLine("Deposito nao autorizado!");
            Console.WriteLine($"Seu saldo atual e {saldo + depositar}:");
            break;

        case 3:
            Console.WriteLine("Digite o valor do saque: ");
            var sacar = Convert.ToInt32(Console.ReadLine());
            if (sacar > 1000)
            {
                Console.WriteLine("O valor de saque e maior que o saldo disponivel!");
                break;
            }
            Console.Write("Voce autoriza o saque: S/N");
            var saque = Console.ReadLine();
            if (saque == "S")
                Console.WriteLine("Saque feito com sucesso!");
            else
                Console.WriteLine("Saque nao autorizado!");

            Console.WriteLine($"Seu saldo atual e {saldo - sacar}");
            break;

        case 4:
            Console.WriteLine("Voce deseja sair: S/N");
            string sair = Console.ReadLine().ToUpper();
            if (sair == "S")
                Console.WriteLine("Saindo...");
            condicao = false;
            break;
            

            
        

    }

}