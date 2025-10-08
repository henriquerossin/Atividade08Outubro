/*
Exercício 08:
Jogo de adivinhação
- Gere um número aleatório de 1 a 50.
- Use do...while para permitir tentativas até o usuário acertar.
- Informe se o número digitado é maior ou menor que o número secreto.
*/

Random random = new Random();

int NumeroSecreto = random.Next(1, 51);

Console.WriteLine("Tente adivinhar o número secreto!");
Console.WriteLine("Digite um número entre 1 e 50: ");

int Tentativa = int.Parse(Console.ReadLine()!);

do
{
    if (Tentativa < NumeroSecreto)
    {
        Console.WriteLine("O número é maior! Tente novamente: ");
    }
    else if (Tentativa > NumeroSecreto)
    {
        Console.WriteLine("O número é menor! Tente novamente: ");
    }
    Tentativa = int.Parse(Console.ReadLine()!);
} while (Tentativa != NumeroSecreto);

Console.WriteLine($"Parabéns! Você acertou o número secreto! O número era {NumeroSecreto}");
