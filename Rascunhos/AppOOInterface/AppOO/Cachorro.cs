using System;
using System.Collections.Generic;
using System.Text;

namespace AppOO
{
    public class Cachorro : IAnimal
    {
        public void CalcularAltura()
        {
            Console.WriteLine("Altura: 1,10");
        }

        public void ExibiSom()
        {
            Console.WriteLine("Auuuuuuuuuuu");
        }

        public string VerificarRaca(object valor)
        {
            return (string)valor;
        }
    }
}
