using cooperoleo.Contexto;
using cooperoleo.Models;

namespace cooperoleo.Repository
{
    public class ConteinerRepository
    {
        public CooperContext contexto { get; set; }

        public ConteinerRepository(CooperContext ctx)
        {
            contexto = ctx;
        }

        public List<ConteinerModel> FindAll()
        {
            var listaConteiner = contexto.Conteiners.ToList();
            return listaConteiner;
        }
    }
}
