using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Domain.Entities
{
    public partial class Contexto : DbContext
    {
        public Contexto()
           : base("name=Contexto")
        {
        }

        public virtual DbSet<Operadora> Operadora { get; set; }


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
