int escolha;

do
{
    Console.Clear();
    Console.WriteLine("Menu de Opções:");
    Console.WriteLine("1. Exibir uma mensagem");
    Console.WriteLine("2. Fazer uma soma");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha uma dessas opções: ");
    escolha = int.Parse(Console.ReadLine());

    if (escolha == 1)
    {
        Console.WriteLine("Hello world!");
    }
    else if (escolha == 2)
    {
        try
        {
            Console.Write("Digite um número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = numero1 + numero2;
            Console.WriteLine($"\nO resultado da soma é: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nERRO: Por favor, digite números válidos!");
        }
    }
    else if (escolha != 3)
    {
        Console.WriteLine("\nOpção inválida. Tente novamente.");
    }

    if (escolha != 3)
    {
        Console.WriteLine($"Você digitou: {escolha}");
        Console.WriteLine("Pressione uma tecla para continuar...");
        Console.ReadKey();
    }

} while (escolha != 3);

Console.WriteLine($"Programa encerrado, até mais ;) !");
Console.ReadKey();
