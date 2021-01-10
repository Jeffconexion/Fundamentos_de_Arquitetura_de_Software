using AppCaso1.Caso1;
using AppCaso1.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCaso1
{
    class Program
    {
        static void Main(string[] args)
        {

            PessoaFisica pessoaFisica = new PessoaFisica();

            pessoaFisica.Nome = "Carlos";
            pessoaFisica.DataNascimento = DateTime.Now;
            pessoaFisica.Cpf = "567547356";

            Console.WriteLine(" Pessoa Fisica ");
            Console.WriteLine("Nome="+ pessoaFisica.Nome);
            Console.WriteLine("Cpf=" + pessoaFisica.Cpf);

            PessoaFisica2 pessoaFisica2 = new PessoaFisica2();
            pessoaFisica2.Cpf = "111111111";

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Silva";

            pessoaFisica2.pessoa = pessoa;

            Console.WriteLine(" Pessoa Fisica 2 ");
            Console.WriteLine("Nome=" + pessoaFisica2.pessoa.Nome);
            Console.WriteLine("Cpf=" + pessoaFisica2.Cpf);

            Console.ReadKey();


        }
    }
}
