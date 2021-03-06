using System;

int SecretNumber = new Random().Next(1, 10); 

void GuessNumber()
{
    bool isTrue = SkellyAsks("What's my number?");
    if (isTrue)
    {
        Console.WriteLine("");
        Console.WriteLine($@"
=====================================================================================================
        █▄░█ █ █▀▀ █▀▀ █
        █░▀█ █ █▄▄ ██▄ ▄");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine($@"
=====================================================================================================
        ▀█▀ █▀█ █▄█   ▄▀█ █▀▀ ▄▀█ █ █▄░█ ░ ░ ░
        ░█░ █▀▄ ░█░   █▀█ █▄█ █▀█ █ █░▀█ ▄ ▄ ▄
        
        (the number was {SecretNumber})");
    }
}

Console.WriteLine($@"

░██████╗░██╗░░░██╗███████╗░██████╗░██████╗██╗███╗░░██╗░██████╗░  ░██████╗░░█████╗░███╗░░░███╗███████╗
██╔════╝░██║░░░██║██╔════╝██╔════╝██╔════╝██║████╗░██║██╔════╝░  ██╔════╝░██╔══██╗████╗░████║██╔════╝
██║░░██╗░██║░░░██║█████╗░░╚█████╗░╚█████╗░██║██╔██╗██║██║░░██╗░  ██║░░██╗░███████║██╔████╔██║█████╗░░
██║░░╚██╗██║░░░██║██╔══╝░░░╚═══██╗░╚═══██╗██║██║╚████║██║░░╚██╗  ██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░
╚██████╔╝╚██████╔╝███████╗██████╔╝██████╔╝██║██║░╚███║╚██████╔╝  ╚██████╔╝██║░░██║██║░╚═╝░██║███████╗
░╚═════╝░░╚═════╝░╚══════╝╚═════╝░╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░  ░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝
=====================================================================================================");

GuessNumber();

bool SkellyAsks(string question)
{
    Console.Write($"{question} ");
    int answer = int.Parse(Console.ReadLine());

    if (answer == SecretNumber)
    {
        return true;
    }
    else
    {
        return false;
    }
}