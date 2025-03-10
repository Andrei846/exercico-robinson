
double S = 1;
for (int i = 3, j = 2; i <= 99; i += 2, j++)
{
S += (double)i / j;
}
Console.WriteLine($"O valor de S é: {S:F2}");
 