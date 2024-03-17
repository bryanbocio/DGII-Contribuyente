using API.DTOs;
using API.Helpers;
using AutoMapper;
using Core.Data;
using Core.Entities.Contribuyentes;
using Core.Entities.Interfaces;
using Core.Specification.Contribuyentes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.ContribuyentesController
{
    public class ContribuyenteController : BaseApiController
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly DbContextDGII dbContextDGII;
        private readonly IMapper _mapper;

        public ContribuyenteController(IUnitOfWork unitOfWork, DbContextDGII db, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this.dbContextDGII = db;
            _mapper = mapper;
        }


        [HttpGet("/contribuyentes")]
        public async Task<ActionResult<Pagination<ContribuyenteToReturnDto>>> GetContribuyentes([FromQuery] ContribuyenteSpecificationParameters parameters)
        {
            var specification = new ContribuyenteWithTipoContribuyenteSpecification(parameters);
            var contribuyentes = await _unitOfWork.Repository<Contribuyente>().ListAsync(specification);
            var count = await _unitOfWork.Repository<Contribuyente>().CountAsync(specification);
            var data=_mapper.Map<IReadOnlyList<Contribuyente>, IList<ContribuyenteToReturnDto>>(contribuyentes);
            return Ok(new Pagination<ContribuyenteToReturnDto>(parameters.PageIndex, parameters.PageSize, count, data));


        }
    }
}
