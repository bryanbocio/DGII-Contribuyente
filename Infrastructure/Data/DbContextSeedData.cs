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
                //await SeedComprobanteFiscal(dbContext);

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
               Contribuyente contribuyente= new Contribuyente{
                   Id = 1,
                   Nombre="Pedro",
                   IsActivo=true,
                   RncCedula="40233337290",
                   TipoContribuyenteId=1,
               };

                dbContext.Contribuyentes.AddRange(contribuyente);
            }
        }

        private static async Task SeedComprobanteFiscal(DbContextDGII dbContext)
        {
            if (!dbContext.Contribuyentes.Any())
            {
                var comprobantesData = File.ReadAllText("../Infrastructure/Data/SeedData/Comprobantes.json");
                var comprobantes = JsonConvert.DeserializeObject<List<ComprobanteFiscal>>(comprobantesData);
                dbContext.ComprobantesFiscales.AddRange(comprobantes);
            }
        }
    }
}
