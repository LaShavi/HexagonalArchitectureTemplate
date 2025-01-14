using Domain.Entities;
using Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        #region Modelos Generales    
        public DbSet<ClienteEntity> Clientes { get; set; }
        #endregion

        #region DTOs 
        //public DbSet<ResponseAllTableOtherExample> ResponseAllTableOtherExample { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("dbContext"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Desactivamos llave primaria para DTOs de SPs.
            //modelBuilder.Entity<ResponseAllTableOtherExample>().HasNoKey();

            // Definimos info de tablas
            #region DTOs Generales            
            modelBuilder.Entity<ClienteEntity>(entity =>
            {
                entity.ToTable("Clientes", "dbo");
            });
            #endregion

            //OnModelCreatingPartial(modelBuilder);
        }
    }
}
