using Main;
using System.ComponentModel.Design;

Interface_Inicial UI = new Interface_Inicial();
Jogo jogo = new Jogo();
int opcao;


opcao = UI.Menu();
Console.WriteLine();

jogo.Switch(opcao);

