using AppOOImpleInterf.Contrato;

namespace AppOOImpleInterf.UsandoAbstracaoPorInterface
{
    public class UsoDeInterface
    {
        private readonly IRepositorio _repositorio;

        public UsoDeInterface(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void RodarProcesso()
        {
            _repositorio.Adicionar();
        }

    }
}
