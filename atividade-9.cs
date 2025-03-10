using System;

public class SaltosOrnamentais
{
    public static void Main(string[] args)
    {
        double[] notas = new double[6];
        double maiorNota = double.MinValue;
        double menorNota = double.MaxValue;
        double somaNotas = 0;

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Digite a nota do {i + 1}º juiz: ");
            notas[i] = double.Parse(Console.ReadLine());

            if (notas[i] > maiorNota)
            {
                maiorNota = notas[i];
            }

            if (notas[i] < menorNota)
            {
                menorNota = notas[i];
            }
        }

        for (int i = 0; i < 6; i++)
        {
            if (notas[i] != maiorNota && notas[i] != menorNota)
            {
                somaNotas += notas[i];
            }
        }

        Console.WriteLine($"A nota final do atleta é: {somaNotas}");
    }
}