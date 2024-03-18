using Core.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Core.Entities.Contribuyentes;
using API.DTOs;
using Core.Specification.Comprobantes;
using API.Utils;
using API.Helpers;

namespace API.Controllers.ComprobanteController
{
    public class ComprobanteController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public ComprobanteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("/comprobante-fiscal")]
        public async Task<ActionResult<Pagination<ComprobanteFiscalToReturnDto>>> buscar([FromQuery] ComprobanteSpecificationParameters parameters)
        {
            var comprobantes = await _unitOfWork.Repository<ComprobanteFiscal>().ListAsync(new ComprobanteWithContribuyenteSpecification(parameters));
            var lstComprobantesFiscalDto = new List<ComprobanteFiscalToReturnDto>();
            var count= await _unitOfWork.Repository<ComprobanteFiscal>().CountAsync(new ComprobanteWithContribuyenteSpecification(parameters));
            foreach(var item in comprobantes)
            {
                lstComprobantesFiscalDto.Add(UtilComprobanteFiscal.MapearComprobanteFiscalDto(item));
            }
            return Ok(new Pagination<ComprobanteFiscalToReturnDto>(parameters.PageIndex, parameters.PageSize, count, lstComprobantesFiscalDto));
        }
    }
}
