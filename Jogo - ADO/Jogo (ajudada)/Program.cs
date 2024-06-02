using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var game = new Game();
        game.Start();
    }
}

class Game
{
    private Player player;
    private Computer computer;
    private int scoreToWin = 3;

    public void Start()
    {
        Linha();
        
        Console.WriteLine("Bem-vindo ao jogo Pedra, Papel e Tesoura!");
        Console.WriteLine();
        Console.Write("Digite seu nome: ");
        string playerName = Console.ReadLine();
        Console.WriteLine();
        player = new Player(playerName);
        computer = new Computer();

        while (true)
        {
            Console.WriteLine("\n[1] Iniciar jogo\n[2] Exibir resumo\n[3] Sair");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    PlayGame();
                    break;
                case "2":
                    ShowSummary();
                    break;
                case "3":
                    ExitGame();
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.WriteLine();
                    break;
            }
        }
    }

    private void PlayGame()
    {
        Linha();
        
        while (player.Score < scoreToWin && computer.Score < scoreToWin)
        {
            Console.WriteLine("\n[1] Pedra\n[2] Papel\n[3] Tesoura");
            Console.WriteLine();
            Console.Write("Escolha uma jogada: ");
            string move = Console.ReadLine();
            Console.WriteLine();

            var playerMove = GetMoveFromInput(move);
            var computerMove = computer.GetMove();

            Console.WriteLine($"{player.Name} jogou {playerMove}");
            Console.WriteLine();
            Console.WriteLine($"Computador jogou {computerMove}");
            Console.WriteLine();

            if (playerMove == computerMove)
            {
                Console.WriteLine("Empate!");
            }
            else if ((playerMove == "Pedra" && computerMove == "Tesoura") ||
                     (playerMove == "Papel" && computerMove == "Pedra") ||
                     (playerMove == "Tesoura" && computerMove == "Papel"))
            {
                Console.WriteLine($"{player.Name} ganhou!");
                Console.WriteLine();
                player.Score++;
            }
            else
            {
                Console.WriteLine("Computador ganhou!");
                Console.WriteLine();
                computer.Score++;
            }

            player.Moves.Add(playerMove);
            computer.Moves.Add(computerMove);
        }

        Console.WriteLine(player.Score == scoreToWin ? $"{player.Name} venceu o jogo!" : "Computador venceu o jogo!");
        Console.WriteLine();
    }

    private void ShowSummary()
    {
        Linha();
        
        Console.WriteLine($"\nNome do jogador: {player.Name}");
        Console.WriteLine();
        Console.WriteLine("Histórico das jogadas da última partida:");
        for (int i = 0; i < player.Moves.Count; i++)
        {
            Console.WriteLine($"Jogada {i + 1}: {player.Moves[i]} vs {computer.Moves[i]}");
            Console.WriteLine();
        }
        Console.WriteLine($"Total de vitórias: {player.Score}");
    }

    private void ExitGame()
    {
        Linha();

        Console.WriteLine("Você deseja salvar o jogo antes de sair? [S/N]");
        string save = Console.ReadLine().ToUpper();
        if (save == "S")
        {
            // Salvar o jogo aqui
            Console.WriteLine("Jogo salvo com sucesso!");
            Console.WriteLine();
        }
        Console.WriteLine("Saindo do jogo...");
    }

    private string GetMoveFromInput(string input)
    {
        switch (input)
        {
            case "1":
                return "Pedra";
            case "2":
                return "Papel";
            case "3":
                return "Tesoura";
            default:
                return "Inválido";
        }
    }

    private void Linha()
    { 
        for (int i = 0; i < 50; i++)
        {
            Console.Write("=");
        }
        Console.WriteLine();
    }
}

class Player
{
    public string Name { get; set; }
    public int Score { get; set; }
    public List<string> Moves { get; set; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
        Moves = new List<string>();
    }
}

class Computer
{
    private Random random;
    public int Score { get; set; }
    public List<string> Moves { get; set; }

    public Computer()
    {
        random = new Random();
        Score = 0;
        Moves = new List<string>();
    }

    public string GetMove()
    {
        int move = random.Next(1, 4);
        switch (move)
        {
            case 1:
                return "Pedra";
            case 2:
                return "Papel";
            case 3:
                return "Tesoura";
            default:
                return "Inválido";
        }
    }
}
