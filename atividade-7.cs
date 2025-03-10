using System;

class Program
{
    static void Main()
    {
        int[] R = new int[5];
        int[] A = new int[10];
        int pontos = 0;

        Console.WriteLine("Digite os 5 números do gabarito da LOTO:");
        for (int i = 0; i < 5; i++)
        {
            R[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os 10 números da aposta:");
        for (int i = 0; i < 10; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        foreach (int numero in A)
        {
            if (Array.Exists(R, elemento => elemento == numero))
            {
                pontos++;
            }
        }

        Console.WriteLine($"O apostador fez {pontos} pontos.");
    }
}
