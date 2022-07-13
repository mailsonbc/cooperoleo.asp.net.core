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
    }
}
