using Xunit;
using API.Controllers.ComprobanteController;
using Core.Entities.Interfaces;
using API.Controllers;
using Core.Entities.Contribuyentes;
using UnitTesting.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UnitTesting.ControllerTests
{
    public class ContribuyenteShouldNot
    {

        private readonly IMockupContribuyenteRepository _repository;

        public ContribuyenteShouldNot()
        {
            _repository = new MockupContribuyenteRepository();
        }

        [Fact]
        public async void Obtener_Todos_Los_Contribuyentes_Retorna_OK()
        {
            //Act
            var resultIsOK = await _repository.GetAllContribuyentes();

            //Assert
            Assert.IsType<List<Contribuyente>>(resultIsOK);

        }

        public async void Get_Cantidad_De_Contribuyentes_No_Es_Tres()
        {
            //Act
            var resultIsOK = await _repository.GetAllContribuyentes() as ObjectResult;
            var contribuyentes= Assert.IsType<List<Contribuyente>>(resultIsOK.Value);
            //Assert
            Assert.NotEqual(3,contribuyentes.Count);

        }
    }
}