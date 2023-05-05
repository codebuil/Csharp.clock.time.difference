using System;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.Write("write time start: ");
        DateTime inicio = DateTime.Parse(Console.ReadLine());

        Console.Write("write time end : ");
        DateTime fim = DateTime.Parse(Console.ReadLine());

        TimeSpan duracao = fim - inicio;
        double horas = duracao.TotalHours;

        Console.WriteLine("time difference: " + horas.ToString("F2") + " hours");
    }
}
