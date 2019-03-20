using CoreMvc.Models;
using Microsoft.EntityFrameworkCore;
using CoreMvc.Persistencia.Contexto.Mapeamento;

namespace CoreMvc.Persistencia.Contexto
{
    public class InstitutoContexto : DbContext
    {
        public virtual DbSet<Instituto> Instituto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfiguration(new InstitutoMap());

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
    }
}