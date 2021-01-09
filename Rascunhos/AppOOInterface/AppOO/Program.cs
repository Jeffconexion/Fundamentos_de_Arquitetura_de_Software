using System;

namespace AppOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Cachorro lobo = new Cachorro();
            lobo.CalcularAltura();
            lobo.ExibiSom();

            Console.WriteLine("Raça ="+ lobo.VerificarRaca("worfDog"));



            Console.ReadKey();
        }
    }
}
