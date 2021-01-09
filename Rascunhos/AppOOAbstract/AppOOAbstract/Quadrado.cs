using System;
using System.Collections.Generic;
using System.Text;

namespace AppOOAbstract
{
    public class Quadrado : FormaGeometrica
    {
        public int Lado { get; set; }


        public override void CalcularArea()
        {
            this.Area = Lado * Lado;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * Lado;
        }
    }
}
