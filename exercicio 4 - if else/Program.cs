int nota;
Console.Write("Informe a nota do aluno: ");
int.TryParse(Console.ReadLine(), out nota);

if (nota < 60)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("F!");
    Console.ResetColor();
}
if (nota > 59 && nota < 70)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("D!");
    Console.ResetColor();
}
if (nota >= 70 && nota < 80)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("C!");
    Console.ResetColor();
}
if (nota >= 80 && nota < 90)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("B!");
    Console.ResetColor();
}
if (nota >= 90 && nota <= 100)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("A!!");
    Console.ResetColor();
}

Console.WriteLine("\npressione uma tecla pra encerrar");
Console.ReadKey();