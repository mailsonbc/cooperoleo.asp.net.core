using cooperoleo.Contexto;
using cooperoleo.Models;

namespace cooperoleo.Repository
{
    public class CondominoRepository
    {
        public CooperContext contexto { get; set; }

        public CondominoRepository(CooperContext ctx)
        {
            contexto = ctx;
        }

        public List<CondominioModel> FindAll()
        {
            var listaCondominios = contexto.Condominios.ToList();

            return (listaCondominios);
        }
    }
}
