
Console.WriteLine("Informe um número de 1 a 12 (de acordo com os meses do ano): ");
int numerodomes = int.Parse(Console.ReadLine());

switch (numerodomes)
{
    case 12: 
    case 1:  
    case 2:  
        Console.WriteLine("Essa estação é o: Verão");
        break;
    case 3:  
    case 4:  
    case 5:  
        Console.WriteLine("Essa estação é o: Outono");
        break;
    case 6:  
    case 7:  
    case 8: 
        Console.WriteLine("Essa estação é o: Inverno");
        break;
    case 9:  
    case 10:
    case 11: 
        Console.WriteLine("Essa etação é a: Primavera");
        break;
    default:
        Console.WriteLine("Esse mês é inválido! Por favor, escolha um número entre 1 e 12(meses do ano).");
        break;
}
