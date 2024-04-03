using Filas__Vetor_;

Vetor fila = new Vetor();
string? item;

Console.WriteLine("Adicione um item na fila:");
item = Console.ReadLine();
fila.Adicionar(item);

Console.WriteLine("Adicione um item na fila:");
item = Console.ReadLine();
fila.Adicionar(item);

fila.Spy();

fila.Remover();

fila.Spy();