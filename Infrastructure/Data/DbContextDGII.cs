using Core.Entities.Contribuyentes;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Core.Data
{
    public class DbContextDGII : DbContext
    {

        public DbContextDGII(DbContextOptions<DbContextDGII> options) : base(options)
        {

        }

        public DbSet<TipoContribuyente> TiposContribuyente { get; set; }
        public DbSet<Contribuyente> Contribuyentes { get; set; }
        public DbSet<ComprobanteFiscal> ComprobantesFiscales{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType == typeof(decimal));
                    foreach (var property in properties)
                    {
                        modelBuilder.Entity(entityType.Name).Property(property.Name).HasConversion<double>();
                    }
                }
            }
        }
    }
}
