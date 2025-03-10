Console.WriteLine("Digite o número de horas trabalhadas no mês:");
double horasTrabalhadasMes = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o salário por hora:");
double salarioPorHora = double.Parse(Console.ReadLine());

      
double horasNormais = 4 * 40;

double salarioTotal;

if (horasTrabalhadasMes <= horasNormais)
{
           
salarioTotal = horasTrabalhadasMes * salarioPorHora;
}
else
{
          
double horasExtras = horasTrabalhadasMes - horasNormais;
     
double valorHoraExtra = salarioPorHora * 1.5;
           
salarioTotal = (horasNormais * salarioPorHora) + (horasExtras * valorHoraExtra);
}

Console.WriteLine("O salário total do funcionário é: R$ " + salarioTotal.ToString("F2"));
