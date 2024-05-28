using Main;


Inicializacoes Ini = new Inicializacoes();

Jogo jogo = Ini.GetJogo();
Jogadas jogadas = Ini.GetJogadas();
Interface_Inicial UI = Ini.GetUI();


Ini.opcao = UI.Menu();
Console.WriteLine();

switch (Ini.opcao)
{
    case 1:
        jogo.IniciarJogo();
        break;
    case 2:
        Console.WriteLine("Exibir Resumo");
        break;
    case 3:
        Console.WriteLine("Sair");
        break;
}
