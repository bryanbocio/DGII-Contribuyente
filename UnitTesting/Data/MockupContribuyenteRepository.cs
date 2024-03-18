using API.DTOs;
using Core.Entities.Contribuyentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Data
{
    public class MockupContribuyenteRepository : IMockupContribuyenteRepository
    {
        List<ContribuyenteToReturnDto> Contribuyentes { get; set; }


        public MockupContribuyenteRepository()
        {
            CargarDatosMockup();
        }

        public async Task<IEnumerable<ContribuyenteToReturnDto>> GetAllContribuyentes()
        {
            return Contribuyentes;
        }

        public async Task<IEnumerable<ContribuyenteToReturnDto>> GetContribuyenteById(string rncCedula)
        {
            return Contribuyentes.Where(c => c.RncCedula == rncCedula);
        }



        private void CargarDatosMockup()
        {
            Contribuyentes = new List<ContribuyenteToReturnDto>
            {
                new ContribuyenteToReturnDto
                {
                  Id = 1,
                  Nombre = "ISIDRO BOCIO",
                  TipoContribuyente = "PERSONA FISICA",
                  IsActivo = true,
                  RncCedula ="40222227290"
                },
                 new ContribuyenteToReturnDto
                {
                   Id = 2,
                   Nombre = "JOSE CONTRERAS",
                   TipoContribuyente="PERSONA JURIDICA",
                   IsActivo = true,
                   RncCedula ="40233337290"
                }
            };
        }


    }
}
