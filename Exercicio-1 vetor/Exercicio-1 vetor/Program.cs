string[] VetDiasdasemana = new string[]
{
    "Segunda-feira",
    "Terça-feira",
    "Quarta-feira",
    "Quinta-feira",
    "Sexta-feira",
    "Sábado",
    "Domingo",
};


string[] tarefas = new string[7];

for (int i = 0; i < tarefas.Length; i++) 
{
    Console.Write("\nInforme sua tarefa para " + VetDiasdasemana[i]+": ");

    tarefas[i] = Convert.ToString(Console.ReadLine());

}

Console.WriteLine($"\nA sua rotina da semana está assim:\nSegunda-feira: {tarefas[0]}\nTerça-feira: {tarefas[1]}\nQuarta-feira: {tarefas[2]}\nQuinta-feira: {tarefas[3]}\nSexta-feira: {tarefas[4]}\nSábado: {tarefas[5]}\nDomingo: {tarefas[6]}");

Console.ReadKey();  
