using Core.Entities.Contribuyentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification.Comprobantes
{
    public class ComprobanteWithContribuyenteSpecification : BaseSpecification<ComprobanteFiscal>
    {

        public ComprobanteWithContribuyenteSpecification(ComprobanteSpecificationParameters parameters) : base(comprobante =>

         (!parameters.ContribuyenteId.HasValue || comprobante.ContribuyenteId == parameters.ContribuyenteId)
        )
        {
            AddInclude(c => c.Contribuyente);
            AddOrderBy(product => product.Ncf);
            ApplyPaging(parameters.PageSize * (parameters.PageIndex - 1), parameters.PageSize);
        }
    }
}
