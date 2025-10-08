/*
Exercício 4:
Números pares de 1 a N
- Peça um número N ao usuário.
- Com for, exiba todos os números pares de 1 até N
- Use um if dentro do laço para verificar se é par.
*/

Console.Write("Digite um número inteiro positivo N: ");
int N = int.Parse(Console.ReadLine()!);

for (int i = 0; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
