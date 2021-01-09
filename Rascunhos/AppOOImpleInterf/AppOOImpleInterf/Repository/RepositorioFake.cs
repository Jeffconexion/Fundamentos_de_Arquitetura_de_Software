using AppOOImpleInterf.Contrato;
using System;

namespace AppOOImpleInterf.Repository
{
    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            Console.WriteLine("========> Repositorio Fake Testado.");
        }
    }
}
