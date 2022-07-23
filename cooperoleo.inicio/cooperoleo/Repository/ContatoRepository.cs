using cooperoleo.Contexto;
using cooperoleo.Models;

namespace cooperoleo.Repository
{
    public class ContatoRepository
    {
        public CooperContext contexto { get; set; }

        public ContatoRepository(CooperContext ctx)
        {
            contexto = ctx;
        }

        public List<ContatoModel> FindAll()
        {
            var listaContatos = contexto.Contatos.ToList();

            return listaContatos;
        }
    }
}
