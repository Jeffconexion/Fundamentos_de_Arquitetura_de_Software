using AppOOImpleInterf.Repository;
using AppOOImpleInterf.UsandoAbstracaoPorInterface;
using AppOOImpleInterf.UsandoImplementacao;
using System;

namespace AppOOImpleInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== IMPLEMENTAÇÃO VS INTERFACE ==================");
            Console.WriteLine();
            Console.WriteLine("1 - Implementação.");
            Console.WriteLine("2 - UsoDeInterface Original.");
            Console.WriteLine("3 - UsoDeInterface Fake.");
            Console.WriteLine("Qual a sua escolha?.");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    UsoDeImplementacao exemploImplementacao = new UsoDeImplementacao();
                    exemploImplementacao.RodarProcesso();

                    break;
                case 2:
                    var exemploDeInterface = new UsoDeInterface(new Repositorio());
                    exemploDeInterface.RodarProcesso();

                    break;
                case 3:
                    var exempliDeInterfaceFake = new UsoDeInterface(new RepositorioFake());
                    exempliDeInterfaceFake.RodarProcesso();

                    break;
                default:
                    Console.WriteLine("Opção selecionada invalida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
