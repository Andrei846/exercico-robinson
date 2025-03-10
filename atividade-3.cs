
Console.WriteLine("Digite um número inteiro de 1 a 7:");
int numeroDia = int.Parse(Console.ReadLine());

string diaSemana;

switch (numeroDia)
{
case 1:
diaSemana = "Domingo";
break;
case 2:
diaSemana = "Segunda-feira";
break;
case 3:
diaSemana = "Terça-feira";
break;
case 4:
diaSemana = "Quarta-feira";
break;
case 5:
diaSemana = "Quinta-feira";
break;
case 6:
diaSemana = "Sexta-feira";
break;
case 7:
diaSemana = "Sábado";
break;
default:
diaSemana = "Número inválido. Digite um número de 1 a 7.";
break;
} 

Console.WriteLine("O dia da semana correspondente é: " + diaSemana);
