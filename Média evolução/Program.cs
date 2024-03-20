/* int nota1 = 6;
int nota2 = 3;

float media = (nota1 + nota2) / 2;

Console.WriteLine("Média:" + media); 
*/

/* Console.WriteLine("Informe a primeira nota:");
string strNota1 = Console.ReadLine();
float nota1 = float.Parse(strNota1);
Console.WriteLine();

Console.WriteLine("Informe a segunda nota:");
string strNota2 = Console.ReadLine();
float nota2 = float.Parse(strNota2);
Console.WriteLine();

float media = (nota1 + nota2) / 2;

Console.WriteLine("Média: " + media);
Console.WriteLine(); */

/* Console.WriteLine("Informe a primeira nota:");
string? strNota1 = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Informe a segunda nota:");
string? strNota2 = Console.ReadLine();

Console.WriteLine();

float Nota1;
float Nota2;


if (!float.TryParse(strNota1, out Nota1))
{
    Console.WriteLine("Nota 1 recebeu um caractere inválido");
    Environment.Exit(-1);
}
 else if (!(Nota1 >= 0 && Nota1 <= 10))
{
    Console.WriteLine("Nota 1 deve ser entre 0 e 10");
    Environment.Exit(-1);
}

if (!float.TryParse(strNota2, out Nota2))
{
    Console.WriteLine("Nota 2 recebeu um caractere inválido");
    Environment.Exit(-1);
}
else if (!(Nota2 >= 0 && Nota2 <= 10))
{
    Console.WriteLine("Nota 2 deve ser entre 0 e 10");
    Environment.Exit(-1);
}

float media = (Nota1 + Nota2) / 2;
Console.WriteLine("Média: " + media);

Console.WriteLine();

bool resultado = media >= 6;

if (resultado)
{ Console.WriteLine("APROVADO"); }
else
{ Console.WriteLine("REPROVADO"); }
*/

/* int contagem = 1;

for (int Alunos = 0; Alunos < 5; Alunos++)
{

    Console.WriteLine($"Insira o nome do Estudante n°{contagem}:");
    string? nome = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine($"Informe a primeira nota do aluno n°{contagem}:");
    string? strNota1 = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine($"Informe a segunda nota do aluno n°{contagem}:");
    string? strNota2 = Console.ReadLine();

    Console.WriteLine();

    float Nota1;
    float Nota2;

    if (!(float.TryParse(strNota1, out Nota1) && (Nota1 >= 0 && Nota1 <= 10)))
    {
        Console.WriteLine("Nota 1 recebeu um caractere inválido, ou não está entre 0 e 10");
        Environment.Exit(-1);
    }

    if (!(float.TryParse(strNota2, out Nota2) && (Nota2 >= 0 && Nota2 <= 10)))
    {
        Console.WriteLine("Nota 1 recebeu um caractere inválido, ou não está entre 0 e 10");
        Environment.Exit(-1);
    }

    float media = (Nota1 + Nota2) / 2;
    bool resultado = media >= 6;

    if (resultado)
    { Console.WriteLine($"Aluno: {nome} teve média {media} : APROVADO"); }
    else
    { Console.WriteLine($"Aluno: {nome} teve média {media} : REPROVADO"); }

    Console.WriteLine();
    contagem++;
}
*/

/* string? continuar = "SIM";
int contagem = 1;

while (continuar.Equals("SIM"))
{
    float Nota1;
    float Nota2;

    Console.WriteLine($"Insira o nome do Estudante n°{contagem}:");
    string? nome = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine($"Informe a primeira nota do aluno n°{contagem}:");
    string? strNota1 = Console.ReadLine();

    Console.WriteLine();

    while (!(float.TryParse(strNota1, out Nota1) && (Nota1 >= 0f && Nota1 <= 10f)))
    {

        Console.WriteLine("Nota 1 recebeu um caractere inválido, ou não está entre 0 e 10");
        Console.WriteLine("Digite novamente:");

        Console.WriteLine();

        Console.WriteLine($"Informe a primeira nota do aluno n°{contagem}:");
        strNota1 = Console.ReadLine();

        Console.WriteLine();

    }

    Console.WriteLine($"Informe a segunda nota do aluno n°{contagem}:");
    string? strNota2 = Console.ReadLine();

    Console.WriteLine();

    while (!(float.TryParse(strNota2, out Nota2) && (Nota2 >= 0 && Nota2 <= 10)))
    {

        Console.WriteLine("Nota 1 recebeu um caractere inválido, ou não está entre 0 e 10");
        Console.WriteLine("Digite novamente:");

        Console.WriteLine();

        Console.WriteLine($"Informe a primeira nota do aluno n°{contagem}:");
        strNota2 = Console.ReadLine();

        Console.WriteLine();

    }

    float media = (Nota1 + Nota2) / 2;
    bool resultado = media >= 6;

    if (resultado)
    { Console.WriteLine($"Aluno: {nome} teve média {media} : APROVADO"); }
    else
    { Console.WriteLine($"Aluno: {nome} teve média {media} : REPROVADO"); }

    Console.WriteLine();

    contagem++;
    continuar = "";

    while (!(continuar.Equals("SIM") || continuar.Equals("NAO")))
    {
        Console.WriteLine("Digite SIM ou NAO para continuar com mais notas:");
        continuar = Console.ReadLine().ToUpper();
    }

    Console.WriteLine();

}
*/