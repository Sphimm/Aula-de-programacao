using Exercicio_3;

Funcionario f1 = new Funcionario();
int opcao;
ContaBancaria c1 = new ContaBancaria();
Log log = new Log();

Console.WriteLine();
Console.WriteLine("Bem vindo");
Console.WriteLine("Criando conta");
Console.WriteLine();

do
{
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Consultar Saldo");
    Console.WriteLine("4 - Sair");
    Console.WriteLine();

    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            c1.Depositar(log, f1);
            break;
        case 2:
            c1.Sacar(log, f1);
            break;
        case 3:
            c1.ConsultarSaldo();
            break;
        case 4:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

} while (opcao != 4);