﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo => 10s -> 10 segundos");
    Console.WriteLine("M = Minuto => 10m-> 10 minutos");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));

    Console.WriteLine(time);

}

Menu();

static void Start(int time)
{
    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;

        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("StopWatch ended!");
    Thread.Sleep(25000);
}

//Start(6);