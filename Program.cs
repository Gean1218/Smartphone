using System;
using DesafioPOO.Models;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Testando Nokia ===");
        Smartphone nokia = new Nokia("9999-1234", "Nokia Tijolão", "123456789012345", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine("=== Testando iPhone ===");
        Smartphone iphone = new Iphone("8888-4321", "iPhone 14 Pro", "987654321098765", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine();

        Console.WriteLine("Testes finalizados!");
    }
    
    }


