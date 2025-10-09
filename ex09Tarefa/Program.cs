/*
Peça um número N para o usuário. O número será fatorado. 
*/

Console.Write("Digite um número inteiro positivo para ser fatorado: ");

int N = int.Parse(Console.ReadLine()!);

long fatorial = 1;

for (int i = N; i > 1; i--)
{
    fatorial *= i;
}

Console.WriteLine($"O fatorial de {N} é: {fatorial}");
