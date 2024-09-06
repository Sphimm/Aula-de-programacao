using Abstract;

Carro C = new Combustão();
Carro H = new Híbrido();
Carro E = new Elétrico();

C.Acelerar();
Console.WriteLine();
C.Frear();
Console.WriteLine();
C.Virar();
Console.WriteLine();

H.Acelerar();
Console.WriteLine();
H.Frear();
Console.WriteLine();
H.Virar();
Console.WriteLine();

E.Acelerar();
Console.WriteLine();
E.Frear();
Console.WriteLine();
E.Virar();
Console.WriteLine();
