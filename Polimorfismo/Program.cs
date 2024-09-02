using Polimorfismo;

Personagem h = new Humano();
Personagem o = new Orc();


h.VidaAtual();
Console.WriteLine();
o.VidaAtual();

Console.WriteLine();
h.ReceberDano(o);