using Fatorial;
using Recursividade;

Palindromos palindromos = new Palindromos();

palindromos.Calcular("osso");

Fibonacci fibonacci = new Fibonacci();

foreach(int f in fibonacci.Sequencia(12))
{
    Console.Write($"{f} ");
}