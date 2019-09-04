using System;
using Portal.Infra.CrossCutting.Identity.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Portal.Domain.Entities;
using Portal.Infra.Data.Context;

namespace Portal.Infra.CrossCutting.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("ApplicationConnection", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Operadora> Operadoras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operadora>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Operadora>()
                .Property(e => e.Descricao)
                .IsUnicode(false);
        }
    }
}