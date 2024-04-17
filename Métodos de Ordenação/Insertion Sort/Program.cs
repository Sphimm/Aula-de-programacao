int[] vetor;
int numOrdem, troca;

vetor = new int[] { 5, 3, 2, 4, 7, 1, 0, 6, 9, 8 };

/*
int entrada;
Console.WriteLine("Insira 10 números inteiros para serem ordenados:");
Console.WriteLine();

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write("Digite o {0}º número: ", i + 1);
    entrada = int.Parse(Console.ReadLine());
    vetor[i] = entrada;
}
*/

for (int num = 1; num < vetor.Length; num++) // Percorre o vetor a partir do Indice 1 ou 2º numero
{
    troca = vetor[num]; // Armazena o valor atual do vetor em troca
    numOrdem = num - 1; // Armazena o indice anterior do vetor em numOrdem

    while (numOrdem >= 0 && vetor[numOrdem] > troca) // Enquanto o indice anterior for maior ou igual a 0 |EEE| o valor no indice anterior for maior que o valor de troca
    {
        vetor[numOrdem + 1] = vetor[numOrdem]; // O valor no indice anterior é movido para a direita
        numOrdem--; // O indice anterior perde 1        
    }

    vetor[numOrdem + 1] = troca; // O valor de troca é inserido no indice anterior
}

foreach (int num in vetor)
{
    Console.Write(vetor[num] + " ");
}
Console.WriteLine();
