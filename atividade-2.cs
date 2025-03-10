Console.WriteLine("Digite sua altura em metros (ex: 1,75):");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite seu sexo (M para masculino, F para feminino):");
        char sexo = char.Parse(Console.ReadLine().ToUpper()); 

double pesoIdeal;
if (sexo == 'M')
{
pesoIdeal = (72.7 * altura) - 58;
}
else if (sexo == 'F')
{
pesoIdeal = (62.1 * altura) - 44.7;
}
else
{
Console.WriteLine("Sexo inválido. Use 'M' ou 'F'.");
            return; 
}

Console.WriteLine("Seu peso ideal é: " + pesoIdeal.ToString("F2") + " kg"); 
    
