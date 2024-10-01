Console.Write("Digite um número inteiro: ");

if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
{
    long fatorial = 1;
    for (int i = 1; i <= numero; i++)
    {
        fatorial *= i;
    }

    Console.WriteLine($"O fatorial do número: {numero} é {fatorial}");
}    
    Console.WriteLine("Por favor, digite uma tecla para encerrar...");
    Console.ReadKey();