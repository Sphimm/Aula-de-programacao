/* Console.WriteLine("Insira 10 números para somar:");

Console.WriteLine();

int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Insira o número {i + 1}");
    int.TryParse(Console.ReadLine(), out numeros[i]);

    Console.WriteLine();
}

int soma = 0;

for (int num = 0; num < numeros.Length; num++)
{
    soma += numeros[num];
}

Console.WriteLine(soma);
*/

/* Console.WriteLine("Insira 20 números para exibir de trás para frente:");

Console.WriteLine();

int[] numeros = new int[20];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Insira o número {i + 1}");
    int.TryParse(Console.ReadLine(), out numeros[i]);

    Console.WriteLine();
}

for (int num = numeros.Length - 1; num >= 0; num--)
{
    Console.WriteLine(numeros[num]);
}
*/

/* Console.WriteLine("Insira 20 números para verificação de pares:");

Console.WriteLine();

int[] numeros = new int[20];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Insira o número {i + 1}");
    int.TryParse(Console.ReadLine(), out numeros[i]);

    Console.WriteLine();
}

int quantidade = 0;

for (int num = 0; num < numeros.Length; num++)
{
    if ((numeros[num] % 2) == 0)
    {
        quantidade++;
    }
}

Console.WriteLine(quantidade);
*/

/* Console.WriteLine("Insira 10 medidas de comprimento e largura para medição de área:");

Console.WriteLine();

int comodos = 10;

int[] comprimento = new int[comodos];
int[] largura = new int[comodos];
int[] area = new int[comodos];

for (int i = 0; i < comodos; i++)
{
    Console.WriteLine($"Insira a medida de comprimento {i + 1} do cômodo:");
    int.TryParse(Console.ReadLine(), out comprimento[i]);

    Console.WriteLine();

    Console.WriteLine($"Insira a medida de largura {i + 1} do cômodo:");
    int.TryParse(Console.ReadLine(), out largura[i]);

    area[i] = comprimento[i] * largura[i];

    Console.WriteLine();
}

for (int p = 0; p < comodos; p++)
{
    Console.WriteLine($"A área do cômodo {p + 1} é: {area[p]}M²");

    Console.WriteLine();
}
*/

Console.WriteLine("Insira 10 nomes e 2 notas desses Estudantes:");

Console.WriteLine();

int alunos = 3;
bool resultado = false;
string final = "";

int[] nota1 = new int[alunos];
int[] nota2 = new int[alunos];
string?[] nomes = new string[alunos];
float[] medias = new float[alunos]; 

for (int i = 0; i < alunos; i++)
{
    Console.WriteLine($"Insira o nome do Estudante n°{i + 1}:");
    nomes[i] = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine($"Informe a primeira nota do Estudante n°{i + 1}:");
    int.TryParse(Console.ReadLine(), out nota1[i]);

    Console.WriteLine();

    Console.WriteLine($"Informe a segunda nota do Estudante n°{i + 1}:");
    int.TryParse(Console.ReadLine(), out nota2[i]);

    medias[i] = (nota1[i] + nota2[i]) / 2;
    resultado = medias[i] >= 6;

    if (resultado)
    {
        //aprovado
        final = "APROVADO";
    }
    else
    {
        //reprovado
        final = "REPROVADO";
    }

    Console.WriteLine();
}

for (int i = 0;i < alunos; i++)
{
    Console.WriteLine($"O Estudante {i + 1} Nome: {nomes[i]}, teve média: {medias[i]} e portanto foi: {final}");
}