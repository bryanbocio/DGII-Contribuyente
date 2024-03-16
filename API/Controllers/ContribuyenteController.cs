using Core.Data;
using Core.Entities.Contribuyentes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ContribuyenteController : Controller
    {

        private readonly DbContextDGII dbContext;
        public ContribuyenteController(DbContextDGII context)
        {
            this.dbContext = context;
        }


        [HttpGet("/contribuyentes")]
        public async Task<List<Contribuyente>> GetContribuyentes()
        {
           return await dbContext.Contribuyentes.Include(contri=> contri.TipoContribuyente).ToListAsync();
        }
    }
}
