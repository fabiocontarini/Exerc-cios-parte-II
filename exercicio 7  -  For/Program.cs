double resultado;

Console.Write("Insira um número para que seja exibida sua tabuada ate 10: ");
double valor = double.Parse(Console.ReadLine());  

for (int i = 1; i <= 10; i++)
{
    resultado = valor * i;
    Console.WriteLine($"{valor} x {i} = {resultado}");
}

Console.WriteLine("\nPresione uma tecla para encerrar");
Console.ReadKey();  