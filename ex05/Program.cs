/*
Exercício 05:
Menu interativo (Switch + Loop)
- Apresente um menu com opções (1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Sair).
- Use while para repetir até o usuário escolher sair.
- Dentro do loop, leia dois números e faça a operação escolhida
*/

using System.Runtime.Serialization;

Console.WriteLine("Menu de operações: ");
Console.WriteLine("1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Sair");
int opcao = 0;

while (opcao != 4)
{
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Soma");
            Console.WriteLine("Digite um número: ");
            float num1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite outro número: ");
            float num2 = float.Parse(Console.ReadLine()!);
            float soma = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {soma}");
            break;
        case 2:
            Console.WriteLine("Subtração");
            Console.WriteLine("Digite um número: ");
            num1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite outro número: ");
            num2 = float.Parse(Console.ReadLine()!);
            float subtracao = num1 - num2;
            Console.WriteLine($"O resultado da subtração é: {subtracao}");
            break;
        case 3:
            Console.WriteLine("Multiplicação");
            Console.WriteLine("Digite um número: ");
            num1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite outro número: ");
            num2 = float.Parse(Console.ReadLine()!);
            float multiplicacao = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
            break;
        case 4:
            Console.WriteLine("Encerrando programa...");
            break;
    }
}
