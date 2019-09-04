using System.Data.Entity;
using Identity.Domain;
using Portal.Infra.Data.EntityConfig;

namespace Portal.Infra.Data.Context
{
    public class IdentityContext : DbContext
    {
        public IdentityContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}