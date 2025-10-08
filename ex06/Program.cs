/*
Exercício 06:
Contar números pares e ímpares
- Solicite 10 números ao usuário (usando for).
- Para cada número, verifique se é par ou ímpar.
- Ao final, exiba a quantidade de pares e ímpares digitados.
*/

Console.WriteLine("Digite 10 números: ");
int countPares = 0;
int countImpares = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"{i + 1}° Número: ");
    int numero = int.Parse(Console.ReadLine()!);
    if (numero % 2 == 0)
    {
        countPares++;
    }
    else
    {
        countImpares++;
    }
}

Console.WriteLine($"Quantidade de números pares: {countPares}");
Console.WriteLine($"Quantidade de números ímpares: {countImpares}");
