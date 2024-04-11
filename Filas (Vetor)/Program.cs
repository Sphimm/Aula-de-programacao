using Filas__Vetor_;

Vetor fila = new Vetor();
Interface inter = new Interface();
int opcao = 0;

do
{
    inter.Divisao_Longa();
    inter.Inicio();
    inter.Divisao_Longa();

    opcao = inter.Insira_Aqui();

    switch (opcao)
    {
        case 1:
            fila.Criar();
            break;

        case 2:
            fila.Adicionar();
            break;

        case 3:
            fila.Remover();
            break;

        case 4:
            fila.Spy();
            break;

        case 5:
            fila.View();
            break;

        case 6:
            inter.Fim();
            break;

        default:
            inter.Erro();        
            break;
    }

} while (opcao != 6);




