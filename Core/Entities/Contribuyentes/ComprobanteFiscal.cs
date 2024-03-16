using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Contribuyentes
{
    public class ComprobanteFiscal : BaseEntity
    {
        public int ContribuyenteId  { get; set; }
        public Contribuyente Contribuyente  { get; set; }   
        public string Ncf { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Monto { get; set; }

        public decimal GetItbis()
        {
            return this.Monto * (decimal)0.18;
        }
        
    }
}
