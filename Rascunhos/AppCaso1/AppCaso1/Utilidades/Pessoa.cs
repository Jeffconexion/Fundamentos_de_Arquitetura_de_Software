using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCaso1.Utilidades
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public DateTime DataNascimento { set; get; }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }

    }
}
