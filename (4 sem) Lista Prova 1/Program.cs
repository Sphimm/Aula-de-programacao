using Ex_UM;

Interface i = new Interface();

do
{
    
    i.Inicio();

    switch (i.opcao)
    {
        case 1:
            i.CriarConta();
            break;

        case 2:
            i.Depositar();
            break;

        case 3:
            i.Sacar();
            break;

        default:
            Console.WriteLine("Opção inválida!");
            Console.WriteLine();
            break;
    }

} while (i.opcao != 4);