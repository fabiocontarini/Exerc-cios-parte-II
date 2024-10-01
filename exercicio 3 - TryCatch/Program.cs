
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
    Console.WriteLine("\nERRO: Por favor digite numeros válidos");
}

Console.ReadKey();  