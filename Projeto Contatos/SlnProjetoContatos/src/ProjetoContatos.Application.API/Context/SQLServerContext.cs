using Microsoft.EntityFrameworkCore;
using ProjetoContatos.Application.API.Entities;

namespace ProjetoContatos.Application.API.Context
{
    public class SQLServerContext : DbContext
    {

        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed
            modelBuilder.Entity<Contact>()
                .HasData(
                new { Id = 1, Name = "Pedro Godri", Phone = "47999998888", Address = "Rua Hermann Tribess" },
                new { Id = 2, Name = "Ramon Lisboa", Phone = "47999997777", Address = "Rua Alberto Einstein" },
                new { Id = 3, Name = "Luiz Godri", Phone = "47999996666", Address = "Rua Julio Michel" }
                );
        }


        #region DbSets<Tables>
        public DbSet<Contact> Contacts { get; set; }
        #endregion
    }
}
