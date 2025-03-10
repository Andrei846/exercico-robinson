using System;

class Program
{
    static void Main()
    {
        int[] D = new int[20];

        Console.WriteLine("Digite os 20 elementos do vetor:");
        for (int i = 0; i < 20; i++)
        {
            D[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Vetor compactado (elementos maiores que N):");
        foreach (int numero in D)
        {
            if (numero > N)
            {
                Console.Write(numero + " ");
            }
        }
        Console.WriteLine();
    }
}
