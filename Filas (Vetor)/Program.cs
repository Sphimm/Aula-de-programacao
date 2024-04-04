using Filas__Vetor_;

Vetor fila = new Vetor();
Interface UI = new Interface();
bool verf = true;
string? item;
int quant;
string quant_S;
int opcao;
string opcao_S;

while (verf)
{
    UI.Divisao_Longa();
    UI.Inicio();
    UI.Divisao_Longa();

    UI.Insira_Aqui();
    opcao_S = Console.ReadLine();
    Console.WriteLine();

    if (opcao == 1)
    {
        Console.WriteLine("Escreva a quantidade de lugares na fila:");        
        Console.WriteLine();
        UI.Insira_Aqui();
        quant_S = Console.ReadLine();
        quant = UI.Verificar(quant_S);
        fila.Criar(quant);
    } //Criar Fila

    else if (opcao == 2)
    {
        Console.WriteLine("Escreva o item a ser adicionado:");
        Console.WriteLine();
        UI.Insira_Aqui();
        item = Console.ReadLine();
        fila.Adicionar(item);
    } //Adicionar Item

    else if (opcao == 3)
    {
        fila.Remover();
    } //Excluir Item

    else if (opcao == 4)
    {
        fila.Spy();
    } //Ver Item no Topo

    else if (opcao == 5)
    {
        fila.View();
    } //Ver Todos os Itens

    else
    {
        verf = false;
        for (int i = 0; i < 100; i++)
        {
            Console.Write("=");
        }
    } //Encerrar
}