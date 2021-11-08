using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCClinica.Models
{
    public partial class Hospital : DbContext
    {
        public Hospital()
            : base("name=Hospital")
        {
        }

        public virtual DbSet<Medico> Medico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medico>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Medico>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);
        }
    }
}
