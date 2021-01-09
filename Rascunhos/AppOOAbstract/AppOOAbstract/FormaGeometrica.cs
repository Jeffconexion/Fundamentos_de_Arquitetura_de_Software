using System;
using System.Collections.Generic;
using System.Text;

namespace AppOOAbstract
{
    public abstract class FormaGeometrica
    {
        public string Cor { set; get; }
        public double Area { set; get; }
        public double Perimetro { set; get; }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        public string Descricao()
        {
            return "Sou a classe abstrata Forma.";
        }
    }
}
