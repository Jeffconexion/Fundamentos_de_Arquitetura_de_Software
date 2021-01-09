using System;
using System.Collections.Generic;
using System.Text;

namespace AppOOPolimorfismo
{
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem) { }

        public CafeteiraEspressa()
            : base("Padrao", 220) { }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

        public override void Testar()
        {
        }

        public override void Ligar()
        {
            Console.WriteLine("ON");

        }

        public override void Desligar()
        {
            Console.WriteLine("OFF");

        }
    }
}
