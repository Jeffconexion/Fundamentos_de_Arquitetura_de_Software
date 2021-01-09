using System;

namespace AppOOPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Eletrodomestico cafeteriaX = new CafeteiraEspressa();

            cafeteriaX.Ligar();
            
            Console.ReadKey();
        }
    }
}
