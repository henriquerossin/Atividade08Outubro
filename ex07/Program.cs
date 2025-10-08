/*
Exercício 07:
Sequência de Fibonacci
- Solicite um número N para quantidade de termos.
- Gere a sequência de Fibonacci com while ou for.
- Use if para impedir que N seja menor que 1.
*/

Console.WriteLine("Digite um número para saber a quantidade dos termos da sequência de Fibonacci");
int n = int.Parse(Console.ReadLine()!);

int numAnterior = 0;

if (n >= 1)
{
    for (int i = 0; i < n; i++)
    {
        int num = i;
        for (int j = 0; j < i; j++)
        {
            if (j == 0)
            {
                num = 1;
            }
            else
            {
                int temp = num;
                num += numAnterior;
                numAnterior = temp;
            }
        }
        Console.WriteLine(num);
        numAnterior = 0;
    }
}
else
{
    Console.WriteLine("Número inválido. Digite um número maior ou igual a 1.");
}
