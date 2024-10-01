
int numero = 7;
int palpite;

do
{
    Console.Write("\nTente adivinhar o numero secreto: ");
    palpite = int.Parse(Console.ReadLine());

    if (palpite != numero)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você errou, tente novamente!");
        Console.ResetColor();
    };
  

} while ( numero != palpite);


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PARABÉNS, VOCÊ ACERTOU O NÚMERO SECRETO");
Console.ResetColor();

Console.WriteLine("\nPressione uma tecla para encerrar");
Console.ReadKey();
