using API.DTOs;
using AutoMapper;
using Core.Entities.Contribuyentes;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Contribuyente, ContribuyenteToReturnDto>()
                .ForMember(contriDto => contriDto.TipoContribuyente, option => option.MapFrom(contri => contri.TipoContribuyente.Descripcion)) ;

            CreateMap<ComprobanteFiscal, ComprobanteFiscalToReturnDto>()
                   .ForMember(comprobanteDto => comprobanteDto.RncCedula, option => option.MapFrom(compro => compro.Contribuyente.RncCedula)).ReverseMap();
                    
        
        }
    }
}
