using Core.Data;
using Core.Entities.Contribuyentes;
using Core.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ContribuyenteController : BaseApiController
    {

        private readonly IUnitOfWork _unitOfWork;

        public ContribuyenteController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }


        [HttpGet("/contribuyentes")]
        public async Task<ActionResult<Contribuyente>> GetContribuyentes()
        {
           return Ok(await _unitOfWork.Repository<Contribuyente>().ListAllAsync());
        }
    }
}
