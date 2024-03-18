namespace Core.Entities.Contribuyentes
{
    public class ComprobanteFiscal : BaseEntity
    {
        public Contribuyente Contribuyente  { get; set; } 
        public int ContribuyenteId { get; set; } 
        public string Ncf { get; set; }
        public decimal Monto { get; set; }
        public decimal GetItbis()
        {
            return this.Monto * (decimal)0.18;
        }
        
    }
}
