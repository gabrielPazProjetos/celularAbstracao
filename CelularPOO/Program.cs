using System;
using CelularPOO.Models;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone nokia = new Nokia("11999999999", "Nokia 3310", "123456789", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            Smartphone iphone = new Iphone("11988888888", "iPhone 14", "987654321", 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
