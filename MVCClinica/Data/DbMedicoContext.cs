using MVCClinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCClinica.Data
{
    public partial class DbMedicoContext : DbContext
    {
        public DbMedicoContext()
            : base("name=Hospital")
        {
        }

        public DbSet<Medico> Medicos { get; set; }

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