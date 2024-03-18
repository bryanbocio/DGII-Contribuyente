using Core.Data;
using Core.Entities.Contribuyentes;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DbContextSeedData
    {
        public static async Task SeedDataAsync(DbContextDGII dbContext, ILoggerFactory loggerFactory)
        {
            try
            {
                await SeedTipoContribuytente(dbContext);
                await SeedContribuyentes(dbContext);
                await SeedComprobanteFiscal(dbContext);

                if (dbContext.ChangeTracker.HasChanges()) await dbContext.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                var logger = loggerFactory.CreateLogger<DbContextDGII>();
                logger.LogError(exception.Message);
            }
        }

        private static async Task SeedTipoContribuytente(DbContextDGII dbContext)
        {
            if (!dbContext.TiposContribuyente.Any())
            {
                var tipoContribuyenteData = File.ReadAllText("../Infrastructure/Data/SeedData/TiposContribuyente.json");
                var tipoContribuyentes = JsonConvert.DeserializeObject<List<TipoContribuyente>>(tipoContribuyenteData);

                dbContext.TiposContribuyente.AddRange(tipoContribuyentes);
            }
        }

        private static async Task SeedContribuyentes(DbContextDGII dbContext)
        {
            if (!dbContext.Contribuyentes.Any())
            {
                IList<Contribuyente> contribuyente = new List<Contribuyente>{
                  new(){ Id = 1,
                         Nombre="PEDRO SANCHEZ",
                         IsActivo=true,
                         RncCedula="40233337290",
                         TipoContribuyenteId=1,
                   },
                   new(){ Id = 2,
                          Nombre="ALEXANDER PINEDA",
                          IsActivo=true,
                          RncCedula="40233337291",
                          TipoContribuyenteId=2,
                   }
               };

                dbContext.Contribuyentes.AddRange(contribuyente);
            }
        }

        private static async Task SeedComprobanteFiscal(DbContextDGII dbContext)
        {
            if (!dbContext.Contribuyentes.Any())
            {
                IList<ComprobanteFiscal> comprobantes = new List<ComprobanteFiscal>{
                    new() { Id=1, ContribuyenteId=1,Monto=2000, Ncf="B01123456789"},
                    new() { Id=2, ContribuyenteId=1,Monto=3000, Ncf="B01123456781"},
                    new() { Id=3, ContribuyenteId=2,Monto=4000, Ncf="B01123456782"},
                    new() { Id=4, ContribuyenteId=2,Monto=4000, Ncf="B01123456789"},
                    new() { Id=5, ContribuyenteId=1,Monto=4000, Ncf="B01123456784"}
                };
                dbContext.ComprobantesFiscales.AddRange(comprobantes);
            }
        }
    }
}
