/*
Exercício 02:
Somatório de números positivos
- Permita que o usuário digite números até que insira um número negativo.
- Some somente os números positivos informados.
- Ao final, exiba o total.
*/

int num;
int soma = 0; 

do
{
    Console.WriteLine("Digite um número");
    num = int.Parse(Console.ReadLine());
    soma += num;
} while (num >= 0);

Console.WriteLine($"A soma dos números positivos é {soma}");
