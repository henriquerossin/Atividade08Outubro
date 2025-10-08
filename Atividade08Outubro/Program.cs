/* 
Exercício 01:
Tabuada com verificação de entrada
- Solicite ao usuário um número entre 1 e 10.
- Se o número estiver fora do intervalo, peça novamente (use while).
- Imprima a tabuada desse número usando for.
*/

Console.WriteLine("Digite um número entre 1 e 10 para fazer a tabuada");
int num = int.Parse(Console.ReadLine()!);

while (num < 1 || num > 10)
{
    Console.WriteLine("Número inválido. Digite um número entre 1 e 10:");
    num = int.Parse(Console.ReadLine()!);
}

for (int i = 1; i<= 10; i++)
{
    int result = num * i;
    Console.WriteLine($"{num} * {i} = {result} ");
}

