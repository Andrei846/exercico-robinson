using System;

public class ReajustePrecoSupermercado
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Digite a venda média mensal:");
        int vendaMensal = int.Parse(Console.ReadLine());

       
        Console.WriteLine("Digite o preço atual do produto:");
        double precoAtual = double.Parse(Console.ReadLine());

        
        double novoPreco = CalcularNovoPreco(vendaMensal, precoAtual);

        
        Console.WriteLine("O novo preço do produto é: R$ " + novoPreco.ToString("F2"));
    }

   
    public static double CalcularNovoPreco(int vendaMensal, double precoAtual)
    {
        
        if (vendaMensal < 500 && precoAtual < 30.00)
        {
            return precoAtual * 1.10;
        }
        
        else if (vendaMensal >= 500 && precoAtual >= 30.00)
        {
            return precoAtual * 0.80; 
        }
        
        else
        {
            return precoAtual; 
        }
    }
}