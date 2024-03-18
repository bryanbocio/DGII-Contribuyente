using API.DTOs;
using Core.Entities.Contribuyentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Data
{
    public interface IMockupContribuyenteRepository
    {
        Task<IEnumerable<ContribuyenteToReturnDto>> GetAllContribuyentes();
        Task<IEnumerable<ContribuyenteToReturnDto>> GetContribuyenteById(string rncCedula);   
    }
}
