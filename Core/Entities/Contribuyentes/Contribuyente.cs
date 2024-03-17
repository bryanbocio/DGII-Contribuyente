

namespace Core.Entities.Contribuyentes
{
    public class Contribuyente : BaseEntity
    {
        public string RncCedula { get; set; }
        public string Nombre { get; set; }
        public int TipoContribuyenteId { get; set; }
        public TipoContribuyente TipoContribuyente { get; set; }
        public bool IsActivo { get; set; }
        public virtual ICollection<ComprobanteFiscal> ComprobantesFiscales { get; set; } 


    }
}
