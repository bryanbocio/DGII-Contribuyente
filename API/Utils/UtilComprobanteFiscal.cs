using API.DTOs;
using Core.Entities.Contribuyentes;

namespace API.Utils
{
    public  class UtilComprobanteFiscal
    {

        private UtilComprobanteFiscal()
        {
        }

        public static ComprobanteFiscalToReturnDto MapearComprobanteFiscalDto(ComprobanteFiscal comprobanteFiscal)
        {
            return new ComprobanteFiscalToReturnDto { Monto = comprobanteFiscal.Monto, Ncf = comprobanteFiscal.Ncf, RncCedula = comprobanteFiscal.Contribuyente.RncCedula, Itbis = comprobanteFiscal.GetItbis() };
        }
    }
}
