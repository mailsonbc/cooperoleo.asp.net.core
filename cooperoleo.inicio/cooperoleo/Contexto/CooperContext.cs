using cooperoleo.Models;
using Microsoft.EntityFrameworkCore;

namespace cooperoleo.Contexto
{
    public class CooperContext : DbContext
    {
        public CooperContext()
        {

        }

        public CooperContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CondominioModel> Condominios { get; set; }

        public DbSet<ContatoModel> Contatos { get; set; }

        public DbSet<ConteinerModel> Conteiners { get; set; }
    }
}
