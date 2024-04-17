int[] vetor;
int entrada;
int troca;

vetor = new int[] { 5, 3, 2, 4, 7, 1, 0, 6, 9, 8 };

/*
Console.WriteLine("Insira 10 números inteiros para serem ordenados:");
Console.WriteLine();

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write("Digite o {0}º número: ", i + 1);
    entrada = int.Parse(Console.ReadLine());
    vetor[i] = entrada;
}
*/

for (int num_Esq = 0; num_Esq < vetor.Length - 1; num_Esq++) // Percorre o vetor todo
{
    for (int num_Dir = num_Esq + 1; num_Dir < vetor.Length; num_Dir++) // Percorre o vetor novamente, mas a partir do número seguinte de 'num_Maior'
    {
        if (vetor[num_Esq] > vetor[num_Dir]) // Se o número à esquerda for maior que o número à direita
        {
            troca = vetor[num_Esq];
            vetor[num_Esq] = vetor[num_Dir];
            vetor[num_Dir] = troca;
        }
    }
}

foreach (int num in vetor)
{
    Console.Write(vetor[num] + " ");    
}

Console.WriteLine();


