using Core.Entities.Contribuyentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification.Contribuyentes
{
    public class ContribuyenteWithTipoContribuyenteSpecification: BaseSpecification<Contribuyente>
    {

        public ContribuyenteWithTipoContribuyenteSpecification(ContribuyenteSpecificationParameters parameters): base(contribuyente =>

        (string.IsNullOrEmpty(parameters.Search) || contribuyente.Nombre.ToLower().Contains(parameters.Search))
            &&
         (!parameters.TipoContribuyenteId.HasValue || contribuyente.TipoContribuyenteId == parameters.TipoContribuyenteId)

        )
        {
            AddInclude(c=> c.TipoContribuyente);
            AddOrderBy(product => product.Nombre);
            ApplyPaging(parameters.PageSize * (parameters.PageIndex - 1), parameters.PageSize);
        }

        public ContribuyenteWithTipoContribuyenteSpecification(int id) : base(c => c.Id == id)
        {
            AddInclude(c => c.TipoContribuyente);
        }
    }
}
