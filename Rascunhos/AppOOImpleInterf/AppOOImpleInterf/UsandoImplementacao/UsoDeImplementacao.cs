using AppOOImpleInterf.Repository;

namespace AppOOImpleInterf.UsandoImplementacao
{
    public class UsoDeImplementacao
    {      
        Repositorio repositorio = new Repositorio();

        /*Adicionar alguma funcionalidade nova
         * a nova alteração irá gerar erros,
         * código novo que precisa ser implementado na chamada.
         */

        //private string nome;
        //public UsoDeImplementacao(string nome)
        //{
        //     this.nome = nome;
        //}

        public void RodarProcesso()
        {
            repositorio.Adicionar();
        }

    }
}
