using System.Data.Entity;
using Portal.Domain.Entities;
using Portal.Infra.Data.EntityConfig;

namespace Portal.Infra.Data.Context
{
    public class IdentityContext : DbContext
    {
        public IdentityContext()
            : base("IdentityConnection")
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