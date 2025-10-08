/*
Exercício 03:
Contagem regressiva
- Solicite um número inteiro positivo.
- Se for negativo ou zero, peça novamente (com do...while).
- Faça uma contagem regressiva até 0 usando for.
*/

int num;

do
{
    Console.WriteLine("Digite um número inteiro, positivo e maior que 0: ");
    num = int.Parse(Console.ReadLine()!);
} while (num <= 0);

for (int i = num -1; i >= 0; i--)
{
    Console.WriteLine(i);
}
