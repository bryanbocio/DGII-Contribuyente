using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification.Comprobantes
{
    public class ComprobanteSpecificationParameters
    {
        private const int MaxPageSize = 50;
        public int PageIndex { get; set; } = 1;

        private int _pagSize = 6;

        public int PageSize
        {
            get => _pagSize;
            set => _pagSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        public int? ContribuyenteId { get; set; }
        public string? Sort { get; set; }
       
    }
}
