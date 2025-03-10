using System;

public class MatrizHachurada
{
    public static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];

       
        Console.WriteLine("Digite os elementos da matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        Console.WriteLine("\nSomas das áreas hachuradas:");

        
        int somaA = matriz[0, 0] + matriz[0, 1] + matriz[1, 0] + matriz[1, 1];
        Console.WriteLine($"a) Canto Superior Esquerdo: {somaA}");

      
        int somaB = matriz[2, 2] + matriz[2, 3] + matriz[3, 2] + matriz[3, 3];
        Console.WriteLine($"b) Canto Inferior Direito: {somaB}");

      
        int somaC = matriz[1, 0] + matriz[2, 0] + matriz[2, 1] + matriz[3, 0] + matriz[3, 1] + matriz[3, 2];
        Console.WriteLine($"c) Diagonal Principal Inferior: {somaC}");

        
        int somaD = matriz[0, 2] + matriz[0, 3] + matriz[1, 2] + matriz[1, 3] + matriz[2, 3];
        Console.WriteLine($"d) Diagonal Secundária Superior: {somaD}");
    }
}