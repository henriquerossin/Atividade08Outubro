/*
Exercício 07:
Sequência de Fibonacci
- Solicite um número N para quantidade de termos.
- Gere a sequência de Fibonacci com while ou for.
- Use if para impedir que N seja menor que 1.
*/

int Termos, Numero1 = 0, Numero2 = 0, NumeroAtual = 1;

Console.WriteLine("Digite a quantidade de termos da sequência de Fibonacci: ");

Termos = int.Parse(Console.ReadLine());

if (Termos >= 1)
{
    for (int i = 0; i < Termos; i++)
    {
        Console.WriteLine(NumeroAtual);
        Numero1 = Numero2;
        Numero2 = NumeroAtual;
        NumeroAtual = Numero1 + Numero2;
    }
}
else
{
    Console.WriteLine("Digite um valor maior ou igual à 1: ");
}
